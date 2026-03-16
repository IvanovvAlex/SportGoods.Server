using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using SportGoods.Server.API.Configuration;
using SportGoods.Server.API.Middlewares;
using SportGoods.Server.API.ServiceExtensions;
using SportGoods.Server.Common.Options;
using SportGoods.Server.Data;
using SportGoods.Server.Data.Helpers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(JwtOptions.SectionName));
builder.Services.Configure<ClientAppOptions>(builder.Configuration.GetSection(ClientAppOptions.SectionName));
builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection(EmailOptions.SectionName));
builder.Services.Configure<CorsOptions>(builder.Configuration.GetSection(CorsOptions.SectionName));
builder.Services.Configure<PaymentOptions>(builder.Configuration.GetSection(PaymentOptions.SectionName));
builder.Services.Configure<DevelopmentOptions>(builder.Configuration.GetSection(DevelopmentOptions.SectionName));
builder.Services.Configure<InventoryOptions>(builder.Configuration.GetSection(InventoryOptions.SectionName));

JwtOptions jwtOptions = builder.Configuration
    .GetSection(JwtOptions.SectionName)
    .Get<JwtOptions>() ?? throw new InvalidOperationException("JWT configuration is missing.");

CorsOptions corsOptions = builder.Configuration
    .GetSection(CorsOptions.SectionName)
    .Get<CorsOptions>() ?? new CorsOptions();

builder.Services.AddMemoryCache();
builder.Services.AddOpenApi();
builder.Services.AddCustomServices();
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

ResolvedDatabaseConnection resolvedDatabaseConnection;

try
{
    resolvedDatabaseConnection = DatabaseConnectionStringResolver.Resolve(builder.Configuration, builder.Environment);
}
catch (InvalidOperationException ex)
{
    Console.Error.WriteLine($"Database configuration error: {ex.Message}");
    throw;
}

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseNpgsql(resolvedDatabaseConnection.ConnectionString));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = jwtOptions.Issuer,
            ValidateAudience = true,
            ValidAudience = jwtOptions.Audience,
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Secret)),
            ValidateIssuerSigningKey = true
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ConfiguredOrigins", policy =>
    {
        if (corsOptions.AllowedOrigins.Length == 0)
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            return;
        }

        policy.WithOrigins(corsOptions.AllowedOrigins)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

WebApplication app = builder.Build();

app.Logger.LogInformation(
    "PostgreSQL connection resolved from configuration key {DatabaseConnectionSource}.",
    resolvedDatabaseConnection.SourceKey);

app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseCors("ConfiguredOrigins");

app.MapOpenApi();
app.MapScalarApiReference(options =>
{
    options.WithTheme(ScalarTheme.Moon)
        .WithDefaultHttpClient(ScalarTarget.Shell, ScalarClient.Curl);
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (IServiceScope scope = app.Services.CreateScope())
{
    try
    {
        ApplicationDbContext db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        IOptions<DevelopmentOptions> developmentOptionsAccessor = scope.ServiceProvider.GetRequiredService<IOptions<DevelopmentOptions>>();
        DevelopmentOptions developmentOptions = developmentOptionsAccessor.Value;

        if (app.Environment.IsDevelopment() && developmentOptions.ResetDatabaseOnStart)
        {
            await DatabaseUtils.TruncateAllTablesSafeAsync(db);
        }

        app.Logger.LogInformation("Applying Entity Framework Core migrations.");
        await db.Database.MigrateAsync();
    }
    catch (Exception ex)
    {
        app.Logger.LogCritical(
            ex,
            "Database startup failed while applying migrations using configuration key {DatabaseConnectionSource}.",
            resolvedDatabaseConnection.SourceKey);
        throw;
    }
}

await DbInitializer.SeedAsync(app.Services);

app.Run();

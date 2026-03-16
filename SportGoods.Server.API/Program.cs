using System.Text;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using SportGoods.Server.Data;
using Scalar.AspNetCore;
using SportGoods.Server.API.Middlewares;
using SportGoods.Server.API.ServiceExtensions;
using SportGoods.Server.Data.Helpers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

Env.Load();

builder.Services.AddOpenApi();
builder.Services.AddCustomServices();
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder.Services
    .AddDbContext<ApplicationDbContext>(
        options =>
            options.UseNpgsql(Environment.GetEnvironmentVariable("DB_CONNECTION")!)
    );

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            ValidIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER"),
            ValidateAudience = true,
            ValidAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_TOKEN_SECRET")!)),
            ValidateIssuerSigningKey = true
        };
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
    options.AddPolicy("AllowReactFrontend", policy =>
    {
        policy
            .WithOrigins("https://sportgoods-client.onrender.com")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

string port = Environment.GetEnvironmentVariable("PORT") ?? "5000";

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(int.Parse(port));
});

WebApplication app = builder.Build();

app.UseMiddleware<ExceptionHandlerMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseCors("AllowAll");
    app.MapOpenApi();
    app.MapScalarApiReference(
        options =>
        {
            options
                .WithTheme(ScalarTheme.Moon)
                .WithDefaultHttpClient(ScalarTarget.Shell, ScalarClient.Curl);
            
        }
    );
}

if (app.Environment.IsProduction())
{
    app.UseCors("AllowReactFrontend");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (IServiceScope scope = app.Services.CreateScope())
{
    ApplicationDbContext db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    if (Environment.GetEnvironmentVariable("DROP_DB_ON_RUN") == "1")
    {
        await DatabaseUtils.TruncateAllTablesSafeAsync(db); 
    }
    await db.Database.MigrateAsync();
}

await DbInitializer.SeedAsync(app.Services);

app.Run();

using System;
using Microsoft.Extensions.Options;
using SportGoods.Server.Common.Options;
using SportGoods.Server.Domain.Authentication;
using Xunit;

namespace SportGoods.Server.Tests.Unit.Configuration;

public class JwtSecurityConfigurationTests
{
    [Fact]
    public void ValidateOrThrow_ShouldThrowClearError_WhenSecretIsTooShortForHs512()
    {
        JwtOptions jwtOptions = new()
        {
            Issuer = "SportGoods.Tests",
            Audience = "SportGoods.Tests.Client",
            Secret = "ThisSecretIsTooShortForHs512Signing",
            AccessTokenExpiryMinutes = 60,
            RefreshTokenExpiryDays = 30
        };

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(
            () => JwtSecurityConfiguration.ValidateOrThrow(jwtOptions));

        Assert.Contains("Jwt:Secret", exception.Message);
        Assert.Contains("longer than 64 bytes", exception.Message);
        Assert.Contains(JwtSecurityConfiguration.SigningAlgorithm, exception.Message);
    }

    [Fact]
    public void JwtOptionsValidator_ShouldReturnFailure_WhenSecretIsTooShortForHs512()
    {
        JwtOptionsValidator validator = new();
        JwtOptions jwtOptions = new()
        {
            Issuer = "SportGoods.Tests",
            Audience = "SportGoods.Tests.Client",
            Secret = "ThisSecretIsTooShortForHs512Signing",
            AccessTokenExpiryMinutes = 60,
            RefreshTokenExpiryDays = 30
        };

        ValidateOptionsResult result = validator.Validate(null, jwtOptions);

        Assert.False(result.Succeeded);
        Assert.NotNull(result.Failures);
        Assert.Contains(result.Failures!, failure => failure.Contains("Jwt:Secret"));
    }
}

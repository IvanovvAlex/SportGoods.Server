using Microsoft.Extensions.Options;
using SportGoods.Server.Common.Options;

namespace SportGoods.Server.Domain.Authentication;

public sealed class JwtOptionsValidator : IValidateOptions<JwtOptions>
{
    public ValidateOptionsResult Validate(string? name, JwtOptions options)
    {
        IReadOnlyCollection<string> validationErrors = JwtSecurityConfiguration.Validate(options);
        if (validationErrors.Count == 0)
        {
            return ValidateOptionsResult.Success;
        }

        return ValidateOptionsResult.Fail(validationErrors);
    }
}

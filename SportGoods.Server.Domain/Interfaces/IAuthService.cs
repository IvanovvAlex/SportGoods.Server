using SportGoods.Server.Common.Requests.Auth;
using SportGoods.Server.Common.Responses.Auth;

namespace SportGoods.Server.Domain.Interfaces;

public interface IAuthService
{
    Task<RegisterUserResponse?> RegisterAsync(RegisterUserRequest request);
    Task<TokenResponse?> LoginAsync(LoginUserRequest request);
    Task<TokenResponse?> RefreshTokensAsync(RefreshTokenRequest request);
    Task<string?> GetCurrentUserRole();
    Task<string?> GetCurrentUserEmail();
    Task<string?> GetCurrentUserId();
    Task<bool> LogoutAsync();

}

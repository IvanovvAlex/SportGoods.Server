using SportGoods.Server.Common.Requests.Users;
using SportGoods.Server.Common.Responses.Users;

namespace SportGoods.Server.Domain.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserResponse>?> GetAsync();
    Task<UserResponse?> GetByIdAsync(Guid id);
    Task<UserResponse?> UpdateAsync(UpdateUserRequest request);
    Task<bool> DeleteAsync(Guid id);
    Task<bool> PromoteToAdminAsync(RoleChangeRequest request);
    Task<bool> DemoteToRegisteredCustomerAsync(RoleChangeRequest request); 
}

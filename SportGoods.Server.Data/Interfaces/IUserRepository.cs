using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> IsEmailAlreadyUsed(string email);
    }
}

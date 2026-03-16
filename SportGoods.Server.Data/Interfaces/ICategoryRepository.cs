using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Interfaces;

public interface ICategoryRepository : IRepository<Category>
{
    Task<bool> IsNameAlreadyUsed(string name);
}

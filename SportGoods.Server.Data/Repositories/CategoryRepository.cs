using SportGoods.Server.Data.Entities;
using SportGoods.Server.Data.Interfaces;

namespace SportGoods.Server.Data.Repositories;

public class CategoryRepository(ApplicationDbContext context) : Repository<Category>(context), ICategoryRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<bool> IsNameAlreadyUsed(string name)
    {
        return _context.Users.Any(u => u.Email == name && u.IsDeleted == false);   
    }
}

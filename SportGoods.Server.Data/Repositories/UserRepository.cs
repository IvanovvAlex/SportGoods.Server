using Microsoft.EntityFrameworkCore;
using SportGoods.Server.Data.Entities;
using SportGoods.Server.Data.Interfaces;

namespace SportGoods.Server.Data.Repositories
{
    public class UserRepository(ApplicationDbContext context) : Repository<User>(context), IUserRepository
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<bool> IsEmailAlreadyUsed(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email && u.IsDeleted == false);
        }
    }
}

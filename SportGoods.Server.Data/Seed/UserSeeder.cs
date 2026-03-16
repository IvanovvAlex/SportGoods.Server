using Microsoft.AspNetCore.Identity;
using SportGoods.Server.Core.StaticClasses;
using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Seed
{
    public static class UserSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (db.Users.Any())
            {
                return;
            }

            PasswordHasher<User> hasher = new();

            List<User> users = [];

            User admin = new()
            {
                Email = "admin@sportgoods.com",
                PasswordHash = "temporaryPasswordHash",
                Names = "Admin",
                Phone = "0872123199",
                Role = Roles.Admin,
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Admin123!");
            users.Add(admin);

            for (int i = 1; i <= 9; i++)
            {
                User customer = new()
                {
                    Email = $"customer{i}@sportgoods.com",
                    PasswordHash = "temporaryPasswordHash",
                    Names = "Customer",
                    Phone = $"087212312{i}",
                    Role = Roles.RegisteredCustomer
                };
                customer.PasswordHash = hasher.HashPassword(customer, $"Customer{i}123!");
                users.Add(customer);
            }

            await db.Users.AddRangeAsync(users);
            await db.SaveChangesAsync();
        }
    }
}

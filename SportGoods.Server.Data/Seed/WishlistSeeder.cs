using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Seed
{
    public static class WishlistSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (db.WishlistItems.Any())
            {
                return;
            }

            List<User> users = db.Users.Take(5).ToList();
            List<Product> products = db.Products.Skip(5).Take(5).ToList();

            foreach (User user in users)
            {
                foreach (Product product in products)
                {
                    db.WishlistItems.Add(new()
                    {
                        Id = Guid.NewGuid(),
                        UserId = user.Id,
                        ProductId = product.Id
                    });
                }
            }

            await db.SaveChangesAsync();
        }
    }
}
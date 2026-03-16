using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Seed
{
    public static class ReviewSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (db.Reviews.Any())
            {
                return;
            }

            List<User> users = db.Users.Take(5).ToList();
            List<Product> products = db.Products.Take(5).ToList();

            foreach (User user in users)
            {
                foreach (Product product in products)
                {
                    db.Reviews.Add(new()
                    {
                        Id = Guid.NewGuid(),
                        UserId = user.Id,
                        ProductId = product.Id,
                        Content = $"Много добър продукт {product.Title}",
                        Rating = 0
                    });
                }
            }

            await db.SaveChangesAsync();
        }
    }
}

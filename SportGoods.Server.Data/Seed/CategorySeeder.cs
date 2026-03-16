using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Seed
{
    public static class CategorySeeder
    {
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (db.Categories.Any())
            {
                return;
            }
            
            Category[] categories =
            [
                new() { Id = Guid.NewGuid(), Name = "Фитнес", ImageUri = "https://api.interactive-img.com/interactiveimage/67171ba1c4f8e.jpg"},
                new() { Id = Guid.NewGuid(), Name = "Тенис", ImageUri = "https://images.unsplash.com/photo-1595435934249-5df7ed86e1c0?q=80&w=800" },
                new() { Id = Guid.NewGuid(), Name = "Футбол", ImageUri = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55?q=80&w=800" },
                new() { Id = Guid.NewGuid(), Name = "Баскетбол", ImageUri = "https://images.unsplash.com/photo-1546519638-68e109498ffc?q=80&w=800" },
                new() { Id = Guid.NewGuid(), Name = "Колоездене", ImageUri = "https://image-cdn.essentiallysports.com/wp-content/uploads/2021-07-15T142945Z_720664159_UP1EH7F149JI4_RTRMADP_3_CYCLING-FRANCE-800x546.jpg" },
                new() { Id = Guid.NewGuid(), Name = "Бокс", ImageUri = "https://pride.shop/images/thumbs/0013562_rukavice.jpeg" },
            ];

            db.Categories.AddRange(categories);
            await db.SaveChangesAsync();
        }
    }
}

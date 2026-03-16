using SportGoods.Server.Data.Entities;
using SportGoods.Server.Data.Interfaces;

namespace SportGoods.Server.Data.Repositories;

public class ImageRepository(ApplicationDbContext context) : Repository<Image>(context), IImageRepository
{
    
}

using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Interfaces;

public interface IReviewRepository : IRepository<Review>
{
    Task<IEnumerable<Review>> GetReviews(Guid productId);
}

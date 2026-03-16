using SportGoods.Server.Common.Requests.Review;
using SportGoods.Server.Common.Responses.Review;
using SportGoods.Server.Core.Pages;

namespace SportGoods.Server.Domain.Interfaces;

public interface IReviewService
{
    Task<ReviewResponse?> UpdateAsync(UpdateReviewRequest request);
    Task<ReviewResponse?> CreateAsync(CreateReviewRequest request);
    Task<bool> DeleteAsync(Guid id);
    Task<Paginated<ReviewResponse>> SearchReviewsAsync(SearchReviewsRequest request);
}

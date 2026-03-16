using SportGoods.Server.Common.Responses.Order;
using SportGoods.Server.Common.Responses.Review;
using SportGoods.Server.Common.Responses.Users;

namespace SportGoods.Server.Common.Responses.Gdpr;

public class GdprExportResponse
{
    public DateTime RequestedAtUtc { get; set; }

    public UserResponse? User { get; set; }

    public ICollection<OrderResponse> Orders { get; set; } = new List<OrderResponse>();

    public ICollection<Guid> WishlistProductIds { get; set; } = new List<Guid>();

    public ICollection<ReviewResponse> Reviews { get; set; } = new List<ReviewResponse>();
}

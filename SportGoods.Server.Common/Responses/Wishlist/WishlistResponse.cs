using SportGoods.Server.Common.Responses.Product;

namespace SportGoods.Server.Common.Responses.Wishlist;

public class WishlistResponse
{
    public ICollection<ProductsResponse> Products { get; set; } = new List<ProductsResponse>();
}

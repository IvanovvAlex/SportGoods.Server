using SportGoods.Server.Common.Responses.Wishlist;

namespace SportGoods.Server.Domain.Interfaces;

public interface IWishlistService
{
    Task<WishlistResponse> GetByJWT();
    Task<bool> AddProductToWishlistAsync(Guid productId);
    Task<bool> RemoveProductFromWishlistAsync(Guid productId);
}

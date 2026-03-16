using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportGoods.Server.API.Helpers;
using SportGoods.Server.Common.Requests.Wishlist;
using SportGoods.Server.Domain.Interfaces;

namespace SportGoods.Server.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class WishlistController(IWishlistService wishlistService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return await ControllerProcessor.ProcessAsync(() => wishlistService.GetByJWT(), this);
    }
    
    [HttpPost("add-product")]
    public async Task<IActionResult> AddProductToWhishlistAsync([FromBody] AddToWishlistRequest request)
    {
        return await ControllerProcessor.ProcessAsync<object>(
            async () => await wishlistService.AddProductToWishlistAsync(request.ProductId), this);    
    }
    
    [HttpDelete("remove-product")]
    public async Task<IActionResult> RemoveProductFromWhishlistAsync([FromBody] RemoveFromWishlistRequest request)
    {
        return await ControllerProcessor.ProcessAsync<object>(
            async () => await wishlistService.RemoveProductFromWishlistAsync(request.ProductId), this); 
    }
}

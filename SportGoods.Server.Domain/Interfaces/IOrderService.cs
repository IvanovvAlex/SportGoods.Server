using SportGoods.Server.Common.Requests.Order;
using SportGoods.Server.Common.Requests.OrderItem;
using SportGoods.Server.Common.Responses.Order;
using SportGoods.Server.Core.Pages;

namespace SportGoods.Server.Domain.Interfaces;

public interface IOrderService
{
    Task<OrderResponse> GetAsync();
    Task<OrderResponse> AddProductAsync(AddOrderItemRequest product);
    Task<OrderResponse> RemoveProductAsync(RemoveOrderItemRequest product);
    Task<bool> SendCurrentAsync(SendOrderRequest request);
    Task<bool> ChangeStatusAsync(ChangeOrderStatusRequest request);
    Task<Paginated<OrderResponse>> SearchOrdersAsync(SearchOrderRequest request);
}
 

using SportGoods.Server.Common.Responses.OrderItem;
using SportGoods.Server.Core.Enums;

namespace SportGoods.Server.Common.Responses.Order;

public class OrderResponse
{
    public required Guid Id { get; set; }
    public required decimal OrderTotalPrice { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime CreatedOn { get; set; }
    public ICollection<OrderItemResponse> Items { get; set; } = new List<OrderItemResponse>();
}

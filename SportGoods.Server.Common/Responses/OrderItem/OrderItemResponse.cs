namespace SportGoods.Server.Common.Responses.OrderItem;

public class OrderItemResponse
{
    public required Guid ProductId { get; set; }
    public required decimal SinglePrice { get; set; }
    public required decimal TotalPrice { get; set; }
    public required int Quantity { get; set; }
    
    public required string Title { get; set; }
    public required string PrimaryImageUri { get; set; }

}

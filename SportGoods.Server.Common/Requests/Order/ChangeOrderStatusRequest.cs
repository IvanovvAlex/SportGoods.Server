using System.ComponentModel.DataAnnotations;
using SportGoods.Server.Core.Enums;

namespace SportGoods.Server.Common.Requests.Order;

public class ChangeOrderStatusRequest
{
    [Required]
    public required Guid OrderId { get; set; }
    
    [Required]
    public required OrderStatus OrderStatus { get; set; }
}

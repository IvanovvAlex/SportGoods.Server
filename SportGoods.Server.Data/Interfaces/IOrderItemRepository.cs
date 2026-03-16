using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Interfaces;

public interface IOrderItemRepository : IRepository<OrderItem>
{
    Task<bool> AddRange(ICollection<OrderItem> orderItems);
}

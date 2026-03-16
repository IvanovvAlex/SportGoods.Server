using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Domain.Interfaces;

public interface IEmailNotificationService
{
    Task SendPasswordResetAsync(User user, string resetLink);

    Task SendOrderConfirmationAsync(User user, Order order, string paymentMethod, string deliveryMethod);

    Task SendOrderStatusChangedAsync(User user, Order order);
}

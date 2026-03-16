namespace SportGoods.Server.Common.Options;

public class EmailOptions
{
    public const string SectionName = "Email";

    public string DeliveryMode { get; set; } = "Console";

    public string SenderEmail { get; set; } = "noreply@sportgoods.local";

    public string SenderName { get; set; } = "SportGoods";

    public int PasswordResetTokenExpiryMinutes { get; set; } = 30;
}

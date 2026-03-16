using System.ComponentModel.DataAnnotations;

namespace SportGoods.Server.Common.Requests.Auth;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
}

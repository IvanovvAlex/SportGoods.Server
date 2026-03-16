using System.ComponentModel.DataAnnotations;

namespace SportGoods.Server.Common.Requests.Image;

public class CreateImageRequest
{
    [Required]
    public required string Uri { get; set; }
}

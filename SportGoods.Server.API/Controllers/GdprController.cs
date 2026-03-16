using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportGoods.Server.Common.Responses.Gdpr;
using SportGoods.Server.Domain.Interfaces;

namespace SportGoods.Server.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class GdprController(IGdprService gdprService) : ControllerBase
{
    [HttpGet("export")]
    public async Task<ActionResult<GdprExportResponse>> ExportData()
    {
        GdprExportResponse response = await gdprService.ExportCurrentUserDataAsync();
        return Ok(response);
    }

    [HttpDelete("delete-account")]
    public async Task<ActionResult<GdprDeleteResponse>> DeleteAccount()
    {
        GdprDeleteResponse response = await gdprService.DeleteCurrentUserDataAsync();
        return Ok(response);
    }
}

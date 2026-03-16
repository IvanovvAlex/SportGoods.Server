using SportGoods.Server.Common.Responses.Gdpr;

namespace SportGoods.Server.Domain.Interfaces;

public interface IGdprService
{
    Task<GdprExportResponse> ExportCurrentUserDataAsync();

    Task<GdprDeleteResponse> DeleteCurrentUserDataAsync();
}

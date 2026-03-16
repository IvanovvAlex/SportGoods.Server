using SportGoods.Server.Common.Requests.Product;
using SportGoods.Server.Common.Responses.Product;
using SportGoods.Server.Core.Pages;

namespace SportGoods.Server.Domain.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductResponse>?> GetAsync();
    Task<IEnumerable<ProductResponse>?> GetBestSellersAsync(int numOfBestSellers);
    Task<ProductResponse?> GetByIdAsync(Guid id);
    Task<ProductResponse?> UpdateAsync(UpdateProductRequest request);
    Task<ProductResponse?> CreateAsync(CreateProductRequest request);
    Task<bool> DeleteAsync(Guid id);
    Task<Paginated<ProductsResponse>> SearchProductsAsync(SearchProductsRequest request);

}

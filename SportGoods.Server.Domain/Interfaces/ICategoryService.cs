using SportGoods.Server.Common.Requests.Category;
using SportGoods.Server.Common.Responses.Category;

namespace SportGoods.Server.Domain.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryResponse>?> GetAsync();
    Task<CategoryResponse?> GetByIdAsync(Guid id);
    Task<CategoryResponse?> UpdateAsync(UpdateCategoryRequest request);
    Task<CategoryResponse?> CreateAsync(CreateCategoryRequest request);
    Task<bool> DeleteAsync(Guid id);
}

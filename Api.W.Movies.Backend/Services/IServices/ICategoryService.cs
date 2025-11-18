using Api.W.Movies.Backend.DAL.Entities;
using Api.W.Movies.Backend.DAL.Entities.Dtos;

namespace Api.W.Movies.Backend.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoryAsync();

        Task<CategoryDto> GetCategoryAsync(int id);

        Task<CategoryDto> GetCategoryAsync(string name);

        Task<bool> CategotyExistsByIdAsync(int id);

        Task<bool> GetCategoyExistsByNameAsync(string name);

        Task<bool> CreateCategoryAsync(Category category);

        Task<bool> UpdateCategoryAsync(Category category);

        Task<bool> DeleteCategoryAsync(int id);
    }
}
using Api.W.Movies.Backend.DAL.Entities;

namespace Api.W.Movies.Backend.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoryAsync();

        Task<Category> GetCategoryAsync(int id);

        Task<Category> GetCategoryAsync(string name);

        Task<bool> CategotyExistsByIdAsync(int id);

        Task<bool> GetCategoyExistsByNameAsync(string name);

        Task<bool> CreateCategoryAsync(Category category);

        Task<bool> UpdateCategoryAsync(Category category);

        Task<bool> DeleteCategoryAsync(int id);
    }
}
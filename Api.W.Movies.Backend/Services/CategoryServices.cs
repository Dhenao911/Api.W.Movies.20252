using Api.W.Movies.Backend.DAL.Entities;
using Api.W.Movies.Backend.DAL.Entities.Dtos;
using Api.W.Movies.Backend.Repository.IRepository;
using Api.W.Movies.Backend.Services.IServices;
using AutoMapper;

namespace Api.W.Movies.Backend.Services
{
    public class CategoryServices : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryServices(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<bool> CategotyExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoryAsync()
        {
            var categories = await _categoryRepository.GetCategoryAsync();
            var categoriesDto = _mapper.Map<ICollection<CategoryDto>>(categories);

            return categoriesDto;
        }

        public Task<CategoryDto> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetCategoyExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
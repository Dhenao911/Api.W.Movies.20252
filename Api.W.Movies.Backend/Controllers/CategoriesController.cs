using Api.W.Movies.Backend.DAL.Entities.Dtos;
using Api.W.Movies.Backend.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.W.Movies.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]

        public async Task<ActionResult<ICollection<CategoryDto>>>GetCategoryAsync()
        {
            var categories = await _categoryService.GetCategoryAsync();

            return Ok(categories);
        }
    }
}

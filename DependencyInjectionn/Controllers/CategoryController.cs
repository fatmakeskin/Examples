using DependencyInjectionn.Data_DataAccess.Entities;
using DependencyInjectionn.Data_DataAccess.Repositoies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DependencyInjectionn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository categoryRepository { get; set; }
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> categories = categoryRepository.GetCategories();

            return Ok(categories);
        }
    }
}

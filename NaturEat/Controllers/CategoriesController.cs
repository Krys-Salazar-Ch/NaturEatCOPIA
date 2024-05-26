using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.C_Categories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_PruebaEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ISvCategories _svCategories;
        public CategoriesController(ISvCategories svCategories)
        {
            _svCategories = svCategories;
        }
        [HttpGet]
        public IEnumerable<Categories> Get()
        {
            return _svCategories.GetAllCategories();
        }


        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] Categories categories)
        {
            _svCategories.Add_Categories(new Categories
            {
                Name = categories.Name
            });
        }


    }
}

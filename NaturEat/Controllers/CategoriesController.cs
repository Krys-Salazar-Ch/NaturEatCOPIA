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
        private ISvCategories svCategories;
        public CategoriesController(ISvCategories svCategories)
        {
            this.svCategories = svCategories;
        }
        [HttpGet]
        public IEnumerable<Categories> Get()
        {
            return svCategories.GetAllCategories();
        }


        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] Categories categories)
        {
            svCategories.Add_Categories(categories);

        }

    }
}
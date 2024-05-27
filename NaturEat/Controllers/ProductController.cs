using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.C_Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaturEat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ISvProduct svProduct;

        public ProductController(ISvProduct svProduct)
        {
            this.svProduct = svProduct;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return svProduct.Print_List();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return svProduct.Get_ById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            svProduct.Add_Product(product);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            svProduct.Update_Poduct(id, new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoriesId = product.CategoriesId
            });
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            svProduct.Delete_Product(id);
        }
    }
}

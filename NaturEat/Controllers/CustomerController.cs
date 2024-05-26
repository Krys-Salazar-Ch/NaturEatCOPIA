using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.C_Customer;
using Services.C_Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaturEat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private ISvCustomer svCustomer;

        public CustomerController(ISvCustomer svCustomer)
        {
            this.svCustomer = svCustomer;
        }
        // GET: api/<CustomerController1>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return svCustomer.GetAllCustomers();
        }

        // POST api/<CustomerController1>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            svCustomer.Add_Customer(customer);
        }
    }
}
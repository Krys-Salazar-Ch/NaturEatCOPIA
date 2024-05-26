using Microsoft.AspNetCore.Mvc;
using Entities;
using Services.C_Customer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaturEat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ISvCustomer _svCustomer;
        public CustomerController(ISvCustomer svCustomer)
        {
            _svCustomer = svCustomer;
        }


        // POST api/<CustomerController1>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _svCustomer.Add_Customer(new Customer
            {
                Name = customer.Name,
                eMail = customer.eMail,
                Phone_Number = customer.Phone_Number
            });
        }

        // PUT api/<CustomerController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            _svCustomer.Update_Customer(id, new Customer
            {
                Name = customer.Name,
                eMail = customer.eMail,
                Phone_Number = customer.Phone_Number
            });
        }

    }
}
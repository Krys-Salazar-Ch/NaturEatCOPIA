using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.C_Order_Confirmation;
using Services.C_Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaturEat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private ISvOrder svOrder;
        public OrderController(ISvOrder svOrder)
        {
            this.svOrder = svOrder;
        }

        // GET: api/<OrderController1>
        [HttpGet]
        public IEnumerable<Order_Confirmation> Get()
        {
            return svOrder.GetAllOrder_Confirmation();
        }

        // GET api/<OrderController1>/5
        [HttpGet("{id}")]
        public Order_Confirmation Get(int id)
        {
            return svOrder.Get_ById(id);
        }

        // POST api/<OrderController1>
        [HttpPost]
        public void Post([FromBody] Order_Confirmation order_Confirmation)
        {
            svOrder.Add_Order(order_Confirmation);
        }

        // PUT api/<OrderController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

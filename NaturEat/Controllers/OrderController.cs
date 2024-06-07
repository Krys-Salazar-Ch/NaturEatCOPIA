using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.C_Order_Confirmation;
using Services.C_SendEmail;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private ISvOrder _svOrder;
    private ISvSendEmail _svSendEmail;

    public OrderController(ISvOrder svOrder, ISvSendEmail svSendEmail)
    {
        _svOrder = svOrder;
        _svSendEmail = svSendEmail;

    }

    [HttpGet]
    public IEnumerable<Order_Confirmation> Get()
    {
        return _svOrder.GetAllOrder_Confirmation();
    }

    [HttpGet("{id}")]
    public Order_Confirmation Get(int id)
    {

        return _svOrder.Get_ById(id);
    }

    [HttpGet("email/{id}")]
    public ActionResult<Order_Confirmation> GetEmailById(int id)
    {
        var order = _svOrder.Get_ById(id);
        if (order == null)
        {
            return NotFound();
        }
        // Enviar correo electrónico
        _svSendEmail.SendEmail(order);

        return order;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Order_Confirmation order)
    {
        var order_Confirmation = order.OrderDetails;
        var createdOrder = _svOrder.Add_Order(order);
        return CreatedAtAction(nameof(Get), new { id = createdOrder.Id }, createdOrder);
    }
}

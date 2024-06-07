

namespace Entities
{
    public class Order_Confirmation
    {
        public int Id { get; set; }

        public string Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double IVA { get; set; }
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        public Order_Confirmation()
        {
            OrderDetails = new List<OrderDetails>();
        }
    }

}

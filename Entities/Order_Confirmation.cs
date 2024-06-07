

namespace Entities
{
    public class Order_Confirmation
    {
        public int Id { get; set; }

        public string Date { get; set; }
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double IVA { get; set; }
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }

}

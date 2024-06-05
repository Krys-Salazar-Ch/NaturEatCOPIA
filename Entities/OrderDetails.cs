namespace Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderConfirmationId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public Order_Confirmation? Order_Confirmation { get; set; }
    }

}

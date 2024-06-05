using Entities;

namespace Services.C_Order_Confirmation
{
    public interface ISvOrder
    {
        public Order_Confirmation Add_Order(Order_Confirmation order_Confirmation);
        public List<Order_Confirmation> GetAllOrder_Confirmation();
        public Order_Confirmation Get_ById(int id);
    }
}

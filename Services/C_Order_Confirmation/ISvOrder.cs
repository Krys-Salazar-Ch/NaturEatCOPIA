using Entities;

namespace Services.C_Order_Confirmation
{
    public interface ISvOrder
    {
        public Order_Confirmation Add_Order();

        public float Calculate_Total();

        public Order_Confirmation Send_Email();

        public Order_Confirmation Update_Confirmation();

        List<Order_Confirmation> Order_Confirmation();
    }
}

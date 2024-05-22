using Entities;

namespace Services.C_Order_Confirmation
{
    public interface ISvOrder
    {
        public void Add_Order();

        public float Calculate_Total();

        public void Send_Email();

        public Order_Confirmation Update_Confirmation();

        List<Order_Confirmation> Order_Confirmation();
    }
}

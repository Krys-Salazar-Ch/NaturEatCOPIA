using Entities;

namespace Services.C_Order_Confirmation
{
    public interface ISvOrder
    {
        public Order_Confirmation Add_Order(Order_Confirmation order_Confirmation);

        public float Calculate_Total();

        public Order_Confirmation Send_Email();

        public Order_Confirmation Update_Confirmation(Order_Confirmation order_Confirmation); //SE ENCARGA DE ELIMINAR PRODUCTOS SI ES NECESARIO.

        List<Order_Confirmation> Order_Confirmation();
    }
}

using Entities;

namespace Services.C_SendEmail
{
    public interface ISvSendEmail
    {
        public void SendEmail(Order_Confirmation order_Confirmation);
    }
}

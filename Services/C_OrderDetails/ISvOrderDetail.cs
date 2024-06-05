using Entities;

namespace Services.OrderDetail
{
    public interface ISvOrderDetail
    {
        List<OrderDetails> GetOrderDetails();
        void AddOrderDetail(OrderDetails orderDetail);
        OrderDetails GetOrderDetailById(int id);
        void UpdateOrderDetail(OrderDetails orderDetail);
        void DeleteOrderDetail(int id);
    }

}

using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyBbContext;

namespace Services.OrderDetail
{
    public class SvOrderDetail : ISvOrderDetail
    {
        private MyContext _myDbContext;

        public SvOrderDetail()
        {
            _myDbContext = new MyContext();
        }

        public void AddOrderDetail(OrderDetails Detail)
        {
            _myDbContext.DetailOrder.Add(Detail);
            _myDbContext.SaveChanges();

            return;
        }

        public List<OrderDetails> GetOrderDetails()
        {
            return _myDbContext.DetailOrder.ToList();
        }

        public OrderDetails GetOrderDetailById(int id)
        {
            return _myDbContext.DetailOrder.Include(x => x.Order_Confirmation).Include(x => x.ProductId).SingleOrDefault(x => x.Id == id);

        }

        public void UpdateOrderDetail(OrderDetails orderDetail)
        {
            _myDbContext.Entry(orderDetail).State = EntityState.Modified;
            _myDbContext.SaveChanges();
        }

        public void DeleteOrderDetail(int id)
        {
            var orderDetail = _myDbContext.DetailOrder.Find(id);
            if (orderDetail != null)
            {
                _myDbContext.DetailOrder.Remove(orderDetail);
                _myDbContext.SaveChanges();
            }
        }
    }

}

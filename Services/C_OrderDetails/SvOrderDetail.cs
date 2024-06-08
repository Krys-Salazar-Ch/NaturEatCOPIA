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
        }

    }

}

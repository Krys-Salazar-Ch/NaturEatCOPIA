using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services.C_Categories;
using Services.MyBbContext;

namespace Services.C_Order_Confirmation
{
    public class SvOrder_Confirmation : ISvOrder
    {
        private MyContext _myDbContext;
        public SvOrder_Confirmation()
        {
            _myDbContext = new MyContext();
        }

        public Order_Confirmation Add_Order(Order_Confirmation order_Confirmation)
        {
            _myDbContext.Orders_confirmations.Add(order_Confirmation);
            _myDbContext.SaveChanges();

            return order_Confirmation;
        }

        public List<Order_Confirmation> GetAllOrder_Confirmation()
        {
            return _myDbContext.Orders_confirmations.Include(x=>x.Customers).ToList();
        }

        public Order_Confirmation Get_ById(int id)
        {
            return _myDbContext.Orders_confirmations.Include(x=>x.Customers).SingleOrDefault(x => x.Id == id);
        }
    }
}

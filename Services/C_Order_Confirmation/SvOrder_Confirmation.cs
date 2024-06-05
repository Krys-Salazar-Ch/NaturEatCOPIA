using Entities;
using Microsoft.EntityFrameworkCore;
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
            order_Confirmation.Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            double iva = 0.10;
            double subTotal = 0;

            foreach (var orderDetail in order_Confirmation.OrderDetails)
            {
                var product = _myDbContext.Products.SingleOrDefault(p => p.Id == orderDetail.ProductId);

                if (product != null)
                {
                    subTotal += product.Price * orderDetail.Quantity;
                }
            }

            order_Confirmation.SubTotal = subTotal;
            order_Confirmation.IVA = subTotal * iva;
            order_Confirmation.Total = subTotal + (subTotal * iva);

            _myDbContext.Orders_confirmations.Add(order_Confirmation);
            _myDbContext.SaveChanges();

            return order_Confirmation;
        }

        public List<Order_Confirmation> GetAllOrder_Confirmation()
        {

            return _myDbContext.Orders_confirmations.Include(x => x.Customer).
                Include(x => x.OrderDetails).ThenInclude(x => x.Product).ToList();
        }

        public Order_Confirmation Get_ById(int id)
        {

            return _myDbContext.Orders_confirmations.Include(x => x.Customer).
                Include(x => x.OrderDetails).ThenInclude(x => x.Product).SingleOrDefault(x => x.Id == id);
        }

    }
}
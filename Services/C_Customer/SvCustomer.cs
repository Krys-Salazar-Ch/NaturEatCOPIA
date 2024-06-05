using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyBbContext;

namespace Services.C_Customer
{
    public class SvCustomer : ISvCustomer
    {
        private MyContext _myDbContext = default!;
        public SvCustomer()
        {
            _myDbContext = new MyContext();
        }

        public Customer Add_Customer(Customer customer)
        {
            _myDbContext.Customers.Add(customer);
            _myDbContext.SaveChanges();

            return customer;
        }

        public List<Customer> GetAllCustomers()
        {
            return _myDbContext.Customers.Include(x => x.Order_Confirmation).ThenInclude(x => x.OrderDetails).ThenInclude(x => x.Product).ToList();
        }


    }
}
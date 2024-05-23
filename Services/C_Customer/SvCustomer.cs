using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
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
            _myDbContext.customers.Add(customer);
            _myDbContext.SaveChanges();

            return customer;
        }

        public Customer Update_Customer(int id, Customer newCustomer)
        {
            Customer updateCustomer = _myDbContext.customers.Find(id);

            if (updateCustomer is not null)
            {
                updateCustomer.Name = newCustomer.Name;
                updateCustomer.eMail = newCustomer.eMail;
                updateCustomer.Phone_Number= newCustomer.Phone_Number;

                _myDbContext.customers.Update(updateCustomer);
                _myDbContext.SaveChanges();
            }

            return updateCustomer;
        }
    }
}

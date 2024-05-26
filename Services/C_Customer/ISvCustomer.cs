using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.C_Customer
{
    public interface ISvCustomer
    {
        public Customer Add_Customer(Customer customer);
        public Customer Update_Customer(int id, Customer customer);
    }
}

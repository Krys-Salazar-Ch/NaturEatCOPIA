using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string eMail { get; set; }
        public int Phone_Number { get; set; }
        public List<Order_Confirmation>? Order_Confirmation { get; set; }
    }
}

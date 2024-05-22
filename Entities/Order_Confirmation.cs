using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order_Confirmation
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public Customer Customer { get; set; }

        List<Product> products { get; set; }
    }
}

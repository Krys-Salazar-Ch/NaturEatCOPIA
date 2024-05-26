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
        public string? Date { get; set; }

        public double Total { get; set; }

        public double SubTotal { get; set; }

        public int CustomerId { get; set; }
        public int CategoriesId { get; set; }

        public List<Product>? Products { get; set; }

        public Customer? Customers { get; set; }
        public Categories? Categories { get; set; }
    }
}

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

        public Customer? CustomerId { get; set; }
        public Categories? CategoriesId { get; set; }

        List<Product>? products { get; set; }
    }
}

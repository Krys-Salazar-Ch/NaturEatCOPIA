using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }
        public Order_Confirmation? Order_Confirmation { get; set; }
    }
}

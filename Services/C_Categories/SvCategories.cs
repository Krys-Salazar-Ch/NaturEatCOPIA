using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyBbContext;
namespace Services.C_Categories
{
    public class SvCategories : ISvCategories
    {
        private MyContext _myDbContext = default!;
        public SvCategories()
        {
            _myDbContext = new MyContext();
        }

        public Categories Add_Categories(Categories categories)
        {
            _myDbContext.categories.Add(categories);
            _myDbContext.SaveChanges();

            return categories;
        }
        public List<Categories> GetAllCategories()
        {
            return _myDbContext.categories.Include(x => x.Products).ToList(); //quita el bucle
        }

    }  
}
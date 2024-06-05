using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyBbContext;
namespace Services.C_Categories
{
    public class SvCategories : ISvCategories
    {
        private MyContext _myDbContext;
        public SvCategories()
        {
            _myDbContext = new MyContext();
        }

        public Categories Add_Categories(Categories categories)
        {
            _myDbContext.Category.Add(categories);
            _myDbContext.SaveChanges();

            return categories;
        }
        public List<Categories> GetAllCategories()
        {
            return _myDbContext.Category.Include(x => x.Products).ToList();
        }

    }
}
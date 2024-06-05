using Entities;

namespace Services.C_Categories
{
    public interface ISvCategories
    {
        public Categories Add_Categories(Categories categories);

        public List<Categories> GetAllCategories();
    }
}
using Entities;

namespace Services.C_Product
{
    public interface ISvProduct
    {
        public List<Product> GetAllProducts();
        public Product Add_Product(Product product);
        public Product Update_Poduct(int id, Product product);
        public Product Get_ById(int id);
        public void Delete_Product(int id);
    }
}

using Entities;
using Services.MyBbContext;

namespace Services.C_Product
{
    public class SvProduct : ISvProduct
    {

        private MyContext _myDbContext;

        public SvProduct()
        {
            _myDbContext = new MyContext();
        }

        public Product Add_Product(Product product)
        {
            _myDbContext.Products.Add(product);
            _myDbContext.SaveChanges();

            return product;
        }

        public void Delete_Product(int id)
        {
            Product deletProduct = _myDbContext.Products.Find(id);

            if (deletProduct is not null)
            {
                _myDbContext.Products.Remove(deletProduct);
                _myDbContext.SaveChanges();
            }
        }

        public Product Get_ById(int id)
        {
            return _myDbContext.Products.SingleOrDefault(x => x.Id == id);
        }

        public List<Product> GetAllProducts()
        {
            return _myDbContext.Products.ToList();
        }

        public Product Update_Poduct(int id, Product product)
        {
            Product updateProduct = _myDbContext.Products.Find(id);

            if (updateProduct is not null)
            {
                updateProduct.Name = product.Name;
                updateProduct.Price = product.Price;
                updateProduct.Description = product.Description;

                _myDbContext.Products.Update(updateProduct);
                _myDbContext.SaveChanges();
            }

            return updateProduct;
        }
    }
}
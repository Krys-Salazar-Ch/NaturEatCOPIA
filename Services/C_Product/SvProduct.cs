using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services.MyBbContext;

namespace Services.C_Product
{
    public class SvProduct : ISvProduct
    {

        private MyContext _myDbContext = default!;

        public SvProduct()
        {
            _myDbContext = new MyContext();
        }


        //Add Product
        public Product Add_Product(Product product)
        {
            _myDbContext.products.Add(product);
            _myDbContext.SaveChanges();

            return product;
        }

        //Delete Product
        public void Delete_Product(int id)
        {
            Product ProductFound = _myDbContext.products.Where(Product => Product.Id == id).First();
            _myDbContext.products.Remove(ProductFound);
            _myDbContext.SaveChanges();
        }

        //Get By Id
        public Product Get_ById(int id)
        {
            return _myDbContext.products.Where(Product => Product.Id == id).First();
        }

        //Print List
        public List<Product> Print_List()
        {
            return _myDbContext.products.ToList();
        }

        //Update Product 
        public Product Update_Poduct(int id, Product product)
        {
            Product updateProduct = _myDbContext.products.Find();

            if (updateProduct is not null)
            {
                Product ProductFound = _myDbContext.products.Where(Product => Product.Id == id).First();
                ProductFound.Name = product.Name;
                ProductFound.Price = product.Price;
                ProductFound.Description = product.Description;

                _myDbContext.products.Update(ProductFound);
                _myDbContext.SaveChanges();
            }

            return updateProduct;
        }
    }
}

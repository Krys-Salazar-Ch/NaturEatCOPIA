using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
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


        //Add Product
        public Product Add_Product(Product product)
        {
            _myDbContext.Products.Add(product);
            _myDbContext.SaveChanges();

            return product;
        }

        //Delete Product
        public void Delete_Product(int id)
        {
            Product deletProduct = _myDbContext.Products.Find(id);

            if (deletProduct is not null)
            {
                _myDbContext.Products.Remove(deletProduct);
                _myDbContext.SaveChanges();
            }
        }

        //Get By Id
        public Product Get_ById(int id)
        {
            return _myDbContext.Products.Include(x => x.Categories).SingleOrDefault(x => x.Id == id);
        }

        //Print List
        public List<Product> Print_List()
        {
            return _myDbContext.Products.Include(x => x.Categories).ToList();
        }

        //Update Product 
        public Product Update_Poduct(int id, Product product)
        {
            Product updateProduct = _myDbContext.Products.Find(id);

            if (updateProduct is not null)
            {
                // Product ProductFound = _myDbContext.Products.Where(Product => Product.Id == id).First();
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

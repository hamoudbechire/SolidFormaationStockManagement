using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class ProductServiceImp : IProductService
    {
        public void AddProduct(Product product)
        {
            Product.ListProduct.Add(product);
            Console.WriteLine("Product Added");
        }

        public void DeleteProduct(int productId)
        {
            var item = GetProductById(productId);
            Product.ListProduct.Remove(item);
            Console.WriteLine("Product removed");
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return Product.ListProduct.Where(p => p.Category.Id == categoryId).ToList();
        }

        public Product GetProductById(int id)
        {
            return Product.ListProduct.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Product> GetProductList()
        {
            return Product.ListProduct;
        }

        public void ModifyProduct(Product product)
        {
            var item = GetProductById(product.Id);
            var index = Product.ListProduct.IndexOf(item);
            Product.ListProduct[index] = product;
            Console.WriteLine("Product Updated " + Category.ListCategory.Count);
        }
    }
}

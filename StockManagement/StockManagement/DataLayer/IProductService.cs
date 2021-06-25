
using System.Collections.Generic;

namespace StockManagement
{
  public  interface IProductService
    {

        void AddProduct(Product product);
        void ModifyProduct(Product product);
        void DeleteProduct(int productId);
        List<Product> GetProductList();                 
        List<Product> GetProductByCategory(int categoryId);
        Product GetProductById(int categoryId);
    }
}

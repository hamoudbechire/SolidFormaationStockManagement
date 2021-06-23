
using System.Collections.Generic;

namespace StockManagement
{
  public  interface IProductService
    {

         bool AddProduct(Product product);
        bool ModifyProduct(Product product);
        bool DeleteProduct(int productId);
        IEnumerable<Product> GetProductList();
        IEnumerable<Product> GetProductByCategory(int categoryId);
    }
}

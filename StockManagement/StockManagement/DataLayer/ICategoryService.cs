using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public   interface ICategory
    {

          void AddCategory(Category category);
          void ModifyCategory(Category category);
          void DeleteCategory(int categoryId);
          List<Category> GetCategoryList();
          Category GetCategoryById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface ICategory
    {

        bool AddCategory(Category category);
        bool ModifyCategory(Category category);
        bool DeleteCategory(int categoryId);
        bool GetCategoryList(int categoryId);
    }
}

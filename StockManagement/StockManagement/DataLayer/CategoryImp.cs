using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManagement
{
    public class CategoryImp : ICategory
    {
        public void AddCategory(Category category)
        {
            Category.ListCategory.Add(category);
            Console.WriteLine("Category Added");

        }

        public void DeleteCategory(int categoryId)
        {
            var item = GetCategoryById(categoryId);
            Category.ListCategory.Remove(item);
            Console.WriteLine("Category removed");
        }

        public Category GetCategoryById(int id)
        {
            return Category.ListCategory.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Category> GetCategoryList()
        {
            return Category.ListCategory;
        }

        public void ModifyCategory(Category category)
        {
            var item = GetCategoryById(category.Id);
            var index = Category.ListCategory.IndexOf(item);
            Category.ListCategory[index] = category;
            Console.WriteLine("Category Updated " + Category.ListCategory.Count);

        }
    }
}

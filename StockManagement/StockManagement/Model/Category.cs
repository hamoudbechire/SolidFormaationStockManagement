using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class Category
    {
        public int Id { get; set; }
        public string Lib_Cat { get; set; }
        public static List<Category> ListCategory=new List<Category>();
        public Category(int id ,string libCat)
        {
            this.Id = id;
            this.Lib_Cat = libCat;
        }
        
    }
}

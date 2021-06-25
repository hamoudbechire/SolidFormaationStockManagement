using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
  public  class Product
    {
        public static List<Product> ListProduct = new List<Product>();
        public int Id { get;  }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Product(int id, string name, string description, DateTime date, int quantity,Category category)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Date = date;
            this.Quantity = quantity;
            this.Category = category;
        }
    }
}

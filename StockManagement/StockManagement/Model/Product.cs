using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
  public  class Product
    {
        public int Id { get;  }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
   public  class Order
    {

        public int Id { get; }
        public int Date_Cmd { get; set; }
        public double Quantity { get; set; }
        public OrderStatus Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
 public   class OutcomingLine
    {

        public double OutcomingQte { get; set; }

        public double BuyPrice { get; set; }
        public int ProductId { get; set; }
        public int OutQuantity { get; set; }
        public Product Product { get; set; }
        public int IncomingId { get; set; }
        public Incoming Incoming { get; set; }
    }
}

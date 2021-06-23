using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
   public class IncomingLine
    {
        public double IncomingQte { get; set; }
        public int EnterQuantity { get; set; }

        public double SalesPrice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int IncomingId { get; set; }
        public Incoming Incoming { get; set; }
    }
}

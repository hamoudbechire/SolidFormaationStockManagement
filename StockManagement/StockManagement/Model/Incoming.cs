using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
  public  class Incoming 
    {
        public int Id { get; }
        public int IncomingDate { get; }

        public IEnumerable<IncomingLine> incomingLines { get; set; }
    }
}

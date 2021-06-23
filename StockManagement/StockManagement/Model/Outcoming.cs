using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
  public  class Outcoming 
    {

        public int Id { get; }
        public int OutcomingDate { get; set; }
        public IEnumerable<OutcomingLine> outcomingLines { get; set; }
    }
}

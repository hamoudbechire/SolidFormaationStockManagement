using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
  public  class Incoming 
    {
        public static List<Incoming> ListIncoming = new List<Incoming>();
        public int Id { get; }
        public DateTime IncomingDate { get; }

        //public IEnumerable<IncomingLine> incomingLines { get; set; }
        public Incoming(int id,DateTime incomingDate)
        {
            this.Id = id;
            this.IncomingDate = incomingDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
  public  class Outcoming 
    {
        public static List<Outcoming> ListOutcoming = new List<Outcoming>();
        public int Id { get; }
        public DateTime OutcomingDate { get; set; }
        //public IEnumerable<OutcomingLine> outcomingLines { get; set; }
        public Outcoming(int id, DateTime outcomingDate)
        {
            this.Id = id;
            this.OutcomingDate = outcomingDate;
        }
    }
}

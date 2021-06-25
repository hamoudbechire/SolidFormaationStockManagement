using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class OutcomingServiceImp : IOutcomingService
    {
        public void AddOutcoming(Outcoming outcoming)
        {
            Outcoming.ListOutcoming.Add(outcoming);
            Console.WriteLine("Outcoming Added");
        }

        public List<Outcoming> GetOutcomingList()
        {
            return Outcoming.ListOutcoming;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class IncomingServiceImp : IIncomingService
    {
        public void AddIncoming(Incoming incoming)
        {
            Incoming.ListIncoming.Add(incoming);
            Console.WriteLine("Incoming Added");
        }

        public List<Incoming> GetIncomingList()
        {
            return Incoming.ListIncoming;
        }
    }
}

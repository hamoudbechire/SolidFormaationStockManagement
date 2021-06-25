using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface IIncomingService
    {

        void AddIncoming(Incoming incoming);
        List<Incoming> GetIncomingList();
        
    }
}

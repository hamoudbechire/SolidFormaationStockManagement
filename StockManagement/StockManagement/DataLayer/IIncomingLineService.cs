using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface IIncomingLineService
    {
        void AddIIncomingLine(IncomingLine incomingLine);
        List<IncomingLine> GetIncomingLineList();
        List<IncomingLine> GetIncomingLineByProduct(Product product);
        List<IncomingLine> GetIncomingLineByIncoming(Incoming incoming);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface IOutcomingLineService
    {
        void AddOutcomingLine(OutcomingLine outcomingLine);
        List<OutcomingLine> GetOutcomingLineList();
        List<OutcomingLine> GetOutcomingLineByProduct(Product product);
        List<OutcomingLine> GetOutcomingLineByOutcoming(Outcoming outcoming);
    }
}

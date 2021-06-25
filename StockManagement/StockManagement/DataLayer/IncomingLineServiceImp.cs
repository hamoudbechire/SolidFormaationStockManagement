using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class IncomingLineServiceImp : IIncomingLineService
    {
        private IProductService productService=new ProductServiceImp();
        public void AddIIncomingLine(IncomingLine incomingLine)
        {
            IncomingLine.ListIncomingLine.Add(incomingLine);
            Incoming.ListIncoming.Add(incomingLine.Incoming);
            incomingLine.Product.Quantity += incomingLine.IncomingQuantity;
            productService.ModifyProduct(incomingLine.Product);
            Console.WriteLine("IncomingLine Added");
        }
        public List<IncomingLine> GetIncomingLineByIncoming(Incoming incoming)
        {
            return IncomingLine.ListIncomingLine.Where(i => i.Incoming.Id == incoming.Id).ToList();

        }
         
        public List<IncomingLine> GetIncomingLineByProduct(Product product)
        {
            return IncomingLine.ListIncomingLine.Where(i => i.Product.Id == product.Id).ToList();
        }

        public List<IncomingLine> GetIncomingLineList()
        {
            return IncomingLine.ListIncomingLine;
        }
    }
}

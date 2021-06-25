using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class OutcomingLineServiceImp :IOutcomingLineService
    {
        private IProductService productService=new ProductServiceImp();
        public void AddOutcomingLine(OutcomingLine outcomingLine)
        {
            if (outcomingLine.OutcomingQte<outcomingLine.Product.Quantity)
            {
                OutcomingLine.ListOutcomingLine.Add(outcomingLine);
                Outcoming.ListOutcoming.Add(outcomingLine.Outcoming);
                outcomingLine.Product.Quantity -= outcomingLine.OutcomingQte;
                productService.ModifyProduct(outcomingLine.Product);
                Console.WriteLine("OutcomingLine Added");
            }
            else
            {
                Console.WriteLine("Quantity not found");
            }
            
        }
        public List<OutcomingLine> GetOutcomingLineByOutcoming(Outcoming outcoming)
        {
            return OutcomingLine.ListOutcomingLine.Where(i => i.Outcoming.Id == outcoming.Id).ToList(); ;
        }

        public List<OutcomingLine> GetOutcomingLineByProduct(Product product)
        {
            return OutcomingLine.ListOutcomingLine.Where(i => i.Product.Id == product.Id).ToList();
        }

        public List<OutcomingLine> GetOutcomingLineList()
        {
            return OutcomingLine.ListOutcomingLine;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
   public class IncomingLine
    {
        public static int AutoIncremantew =0;
        public static List<IncomingLine> ListIncomingLine = new List<IncomingLine>();
        public int Id { get; set; }
        public int IncomingQuantity { get; set; }
        public double SalesPrice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int IncomingId { get; set; }
        public Incoming Incoming { get; set; }
        public IncomingLine(int quantity,double salesPrice,Product product,Incoming incoming)
        {
            AutoIncremantew++;
            this.Id = AutoIncremantew;
            this.IncomingQuantity = quantity;
            this.SalesPrice = salesPrice;
            this.Product = product;
            this.Incoming = incoming;
        }
    }
}

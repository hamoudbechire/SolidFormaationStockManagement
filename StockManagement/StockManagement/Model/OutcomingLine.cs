using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
 public   class OutcomingLine
    {
        public static int AutoIncremante = 0;
        public static List<OutcomingLine> ListOutcomingLine = new List<OutcomingLine>();
        public int Id { get; set; }
        public int OutcomingQte { get; set; }
        public double BuyPrice { get; set; }
        public int ProductId { get; set; }
        public int OutQuantity { get; set; }
        public Product Product { get; set; }
        public int OutcomingId { get; set; }
        public Outcoming Outcoming { get; set; }

        public OutcomingLine(int quantity, double salesPrice, Product product, Outcoming outcoming)
        {
            AutoIncremante++;
            this.Id = AutoIncremante;
            this.OutcomingQte = quantity;
            this.BuyPrice = salesPrice;
            this.Product = product;
            this.Outcoming = outcoming;
        }
    }
}

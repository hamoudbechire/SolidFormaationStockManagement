using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface IInvoiceService
    {

        Invoice EstablishInvoice(Invoice invoice);
        void ShowInvoice(Invoice invoice);
        void SendInvoice(Invoice invoice);
    }
}

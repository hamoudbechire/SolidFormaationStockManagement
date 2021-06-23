using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface IOrderService
    {
        Order PassOrder(Order order);
        bool ModifyOrderStatus(Order order);
        IEnumerable<Order> GetOrderList();
    }
}

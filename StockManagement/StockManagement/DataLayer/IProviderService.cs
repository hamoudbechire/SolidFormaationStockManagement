using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    interface IProvider
    {
         bool AddProvider(Provider provider);
         bool ModifyProvider(Provider provider);
         bool DeleteProvider(int providerId);
         IEnumerable<Provider> GetProviderList();
        Provider GetProvicerById(int providerId);
    }
}

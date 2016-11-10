using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStore
{
    class Program
    {
        static void Main(string[] args)
        {
            NEITStoreOrdersService.NEITStoreOrdersServiceClient proxy = new NEITStoreOrdersService.NEITStoreOrdersServiceClient();

            NEITStoreOrdersService.Information returnAccount = new NEITStoreOrdersService.Information();
            returnAccount = proxy.getBankInformation("12345");

            float returnRate = proxy.returnAmountEarned(100, float.Parse(".05"));
            Console.ReadLine();
        }
    }
}

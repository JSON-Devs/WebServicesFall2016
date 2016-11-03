using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersRef.OrdersClient proxy = new OrdersRef.OrdersClient();

            OrdersRef.OrderBillingInfo returnBillingInfo = new OrdersRef.OrderBillingInfo();
            returnBillingInfo = proxy.GetBillingAddressForAnOrder(1);
            OrdersRef.OrderItems[] returnOrder = proxy.GetItemListForOrder(1);

            Console.WriteLine("Billing Information for Order 1");
            Console.WriteLine("Name = " + returnBillingInfo.Name);
            Console.WriteLine("Address = " + returnBillingInfo.Address);
            Console.WriteLine("City = " + returnBillingInfo.City);
            Console.WriteLine("State = " + returnBillingInfo.State);
            Console.WriteLine("ZipCode = " + returnBillingInfo.ZipCode);
            Console.WriteLine("Number of Orders = " + proxy.GetNumberOfOrders());
            Console.WriteLine("Total COst for Order 1 = " + proxy.GetTotalCostForAnOrder(1));
            Console.WriteLine("Total Number of orders with part 'JETSWEATER' = " + proxy.HowManyOrderedForAPartNo("JETSWEATER"));
            Console.WriteLine("Items in order 1 (Qty, Part, Description)");
            Console.WriteLine(returnOrder[0].Quantity + " " + returnOrder[0].PartNo + " " + returnOrder[0].Description);
            Console.WriteLine(returnOrder[1].Quantity + " " + returnOrder[1].PartNo + " " + returnOrder[1].Description);
            Console.WriteLine(returnOrder[2].Quantity + " " + returnOrder[2].PartNo + " " + returnOrder[2].Description);

            Console.WriteLine("Enter CR To Exit");
            Console.ReadLine();

        }
    }
}

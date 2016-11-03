using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrdersService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NEITStoreOrdersService : INEITStoreOrdersService
    {
        Order INEITStoreOrdersService.GetOrder(int OrderID)
        {
            Order myOrder = new Order();
                Item item1 = new Item();
                CustomerOptions customerOptions1 = new CustomerOptions();
                    customerOptions1.Color = "green";
                    customerOptions1.Size = "S";
                item1.Options = customerOptions1;
                item1.Cost = "7.00";
                item1.Name = "T-Shirt";
                item1.Sku = "T001";
                Item item2 = new Item();
                item2.Options = new CustomerOptions();
                item2.Cost = "17.00";
                item2.Name = "Pants";
                item2.Sku = "P002";
            Item[] itemsArray = new Item[2];
            itemsArray[0] = item1;
            itemsArray[1] = item2;
            myOrder.Items = itemsArray;
            myOrder.OrderID = "1";
            myOrder.ShopperAddress = "101 Main Street";
            myOrder.ShopperName = "Sam Spade";

            return myOrder;
        }

        double INEITStoreOrdersService.ReturnDoubeOrderID(int OrderID)
        {
            return OrderID * 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrdersService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INEITStoreOrdersService
    {

        [OperationContract]
        double ReturnDoubeOrderID(int OrderID);

        [OperationContract]
        Order GetOrder(int OrderID);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Order
    {
        Item[] items;
        string orderID, shopperAddress, shopperName;

        [DataMember]
        public Item[] Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        [DataMember]
        public string OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }

        [DataMember]
        public string ShopperAddress
        {
            get
            {
                return shopperAddress;
            }

            set
            {
                shopperAddress = value;
            }
        }

        [DataMember]
        public string ShopperName
        {
            get
            {
                return shopperName;
            }

            set
            {
                shopperName = value;
            }
        }
        

    }

    public class Item
    {
        CustomerOptions options;
        string cost, name, sku;

        public CustomerOptions Options
        {
            get
            {
                return options;
            }

            set
            {
                options = value;
            }
        }

        public string Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Sku
        {
            get
            {
                return sku;
            }

            set
            {
                sku = value;
            }
        }
    }

    public class CustomerOptions
    {
        string color, size;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrders
    {

        [OperationContract]
        int GetNumberOfOrders();

        [OperationContract]
        double GetTotalCostForAnOrder(int OrderID);

        [OperationContract]
        List<OrderItems> GetItemListForOrder(int OrderID);

        [OperationContract]
        int HowManyOrderedForAPartNo(String sPartNo);

        [OperationContract]
        OrderBillingInfo GetBillingAddressForAnOrder(int OrderID);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class OrderItems
    {
        string partNo, description, size, color;
        double unitPrice, totalCost;
        int quantity;

        [DataMember]
        public string PartNo
        {
            get
            {
                return partNo;
            }

            set
            {
                partNo = value;
            }
        }

        [DataMember]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [DataMember]
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

        [DataMember]
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

        [DataMember]
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        [DataMember]
        public double TotalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                totalCost = value;
            }
        }

        [DataMember]
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
       
    }

    [DataContract]
    public class OrderBillingInfo
    {
        string name, address, city, state, zipCode;

        [DataMember]
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        [DataMember]
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        [DataMember]
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

        [DataMember]
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        [DataMember]
        public string ZipCode
        {
            get
            {
                return zipCode;
            }

            set
            {
                zipCode = value;
            }
        }
    }
}

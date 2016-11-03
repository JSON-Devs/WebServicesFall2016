using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.XPath;

namespace Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Orders : IOrders
    {

        OrderBillingInfo IOrders.GetBillingAddressForAnOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            //XPathNodeIterator myNode;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            OrderBillingInfo billInfo = new OrderBillingInfo();
            billInfo.Name = nav.SelectSingleNode("//Order[@id=\"" + OrderID + "\"]//BillingInformation/Name").Value;
            billInfo.Address = nav.SelectSingleNode("//Order[@id=\"" + OrderID + "\"]//BillingInformation/Address").Value;
            billInfo.City = nav.SelectSingleNode("//Order[@id=\"" + OrderID + "\"]//BillingInformation/City").Value;
            billInfo.State = nav.SelectSingleNode("//Order[@id=\"" + OrderID + "\"]//BillingInformation/State").Value;
            billInfo.ZipCode = nav.SelectSingleNode("//Order[@id=\"" + OrderID + "\"]//BillingInformation/ZipCode").Value;
            return billInfo;
        }

        List<OrderItems> IOrders.GetItemListForOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator myNode;
            List<OrderItems> myOrderList = new List<OrderItems>();

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            myNode = nav.Select("//Order[@id=\"" + OrderID + "\"]//Items/Item");

            while (myNode.MoveNext())
            {
                OrderItems myOrder = new OrderItems();
                myOrder.PartNo = myNode.Current.SelectSingleNode("PartNo").Value;
                myOrder.Description = myNode.Current.SelectSingleNode("Description").Value;
                myOrder.UnitPrice = Convert.ToDouble(myNode.Current.SelectSingleNode("UnitPrice").Value);
                myOrder.Quantity = Convert.ToInt32(myNode.Current.SelectSingleNode("Quantity").Value);
                myOrder.TotalCost = Convert.ToDouble(myNode.Current.SelectSingleNode("TotalCost").Value);

                if (myNode.Current.SelectSingleNode("CustomerOptions").Value.Equals(""))
                {
                    myOrder.Size = null;
                    myOrder.Color = null;
                }
                else
                {
                    myOrder.Size = myNode.Current.SelectSingleNode("//CustomerOptions/Size").Value;
                    myOrder.Color = myNode.Current.SelectSingleNode("//CustomerOptions/Color").Value;
                }

                myOrderList.Add(myOrder);
            }

            return myOrderList;
        }

        int IOrders.GetNumberOfOrders()
        {
            XPathNavigator nav;
            XPathDocument docNav;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            int noOfOrders = Convert.ToInt32(nav.Evaluate("count(//Order)"));
            return noOfOrders;
        }

        double IOrders.GetTotalCostForAnOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            double totalCost = Convert.ToDouble(nav.Evaluate("sum(//Order[@id=\""+ OrderID +"\"]//TotalCost)"));
            return totalCost;
        }

        int IOrders.HowManyOrderedForAPartNo(string sPartNo)
        {
            XPathNavigator nav;
            XPathDocument docNav;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            int noOrderedForPart = Convert.ToInt32(nav.Evaluate("count(//Item[PartNo=\"" + sPartNo + "\"])"));
            return noOrderedForPart;
            
        }
    }
}

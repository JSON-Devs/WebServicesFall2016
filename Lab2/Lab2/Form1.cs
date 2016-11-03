using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeIter = nav.Select("//BillingInformation/*");
            while (NodeIter.MoveNext())
            {
                rtBilling.Text += NodeIter.Current.Value + Environment.NewLine;
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeIter = nav.Select("//ShippingInformation/*");
            while (NodeIter.MoveNext())
            {
                rtShipping.Text += NodeIter.Current.Value + Environment.NewLine;
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;


            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeIter = nav.Select("//Items/Item/*");
            while (NodeIter.MoveNext())
            {
                if (NodeIter.Current.Value.Equals("")) {
                    rtItem.Text += "No Customer Options Present";
                }
                else
                {
                    rtItem.Text += NodeIter.Current.Value + Environment.NewLine;
                }
            }

            // Use the Evaluate method to return the evaluated expression.
            lblItems.Text = "Number of Items: " + nav.Evaluate("count(//Items/Item)").ToString();
            lblCost.Text = "Total Cost: " + nav.Evaluate("sum(//Items/Item/TotalCost)").ToString();
        }

    }
}

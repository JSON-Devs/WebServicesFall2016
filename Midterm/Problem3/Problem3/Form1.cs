using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Problem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeItems, NodeDesc;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\catalog.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeItems = nav.Select("//catalog/product/catalog_item[price < 40]");
            while (NodeItems.MoveNext())
            {
                rtItems.Text += NodeItems.Current.SelectSingleNode("price").Value + " - " + NodeItems.Current.SelectSingleNode("@gender").Value + Environment.NewLine;
            }

            NodeDesc = nav.Select("//catalog_item[size[@description='Small']]");
            while (NodeDesc.MoveNext())
            {
                rtDesc.Text += NodeDesc.Current.SelectSingleNode("item_number").Value + Environment.NewLine;
            }
        }
    }
}

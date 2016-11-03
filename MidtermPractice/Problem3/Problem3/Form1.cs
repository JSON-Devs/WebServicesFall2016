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
            XPathNodeIterator NodeName, NodeCal, NodeFood;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\Nutrition.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodeName = nav.Select("//food[fiber > 2]/name");
            NodeCal = nav.Select("//food[fiber > 2]/calories/@total");
            while (NodeName.MoveNext() && NodeCal.MoveNext())
            {
                rtCal.Text += NodeName.Current.Value + " - Calories: "+ NodeCal.Current.Value + Environment.NewLine;
            }

            NodeFood = nav.Select("//food[@type=\"meat\"]/name");
            while (NodeFood.MoveNext())
            {
                rtMeat.Text += NodeFood.Current.Value + Environment.NewLine;
            }
        }
    }
}

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
using System.Net;

namespace Problem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodeName, nodeWeight;
            rtPlayers.Text = "";

            //Create Request
            String playerURL = "http://54.84.69.209/midtermFootballService/Footballservice.asmx/GetFootballTeam";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(playerURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            nodeName = nav.Select("//Player[weight > 250]/name");
            nodeWeight = nav.Select("//Player[weight > 250]/weight");

            while (nodeName.MoveNext() && nodeWeight.MoveNext())
            {
                rtPlayers.Text += nodeName.Current.Value + " - " + nodeWeight.Current.Value + Environment.NewLine;

            }
        }
    }
}

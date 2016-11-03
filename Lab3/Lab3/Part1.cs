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

namespace Lab3
{
    public partial class Part1 : Form
    {
        public Part1()
        {
            InitializeComponent();
        }

        private void btnGetForcast_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodeTitle, nodeFor;

            //Create Request
            String WeatherURL = "http://api.wunderground.com/api/03276aecf1b257d9/forecast/q/MA/Boston.xml";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            nodeTitle = nav.Select("//title");
            nodeFor = nav.Select("//fcttext");

            while (nodeTitle.MoveNext() && nodeFor.MoveNext()) {
                rtForecast.Text += nodeTitle.Current.Value + Environment.NewLine + nodeFor.Current.Value + Environment.NewLine + Environment.NewLine;

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodeName, nodeZip;
            rtInfo.Text = "";
            String zipCode = txtZip.Text.ToString();

            //Create Request
            String WeatherURL = "http://api.geonames.org/postalCodeSearch?postalcode=" + zipCode + "&maxRows=10&username=jlgagnon1";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            nodeName = nav.Select("//name");
            nodeZip = nav.Select("//postalcode");

            while (nodeName.MoveNext() && nodeZip.MoveNext())
            {
                rtInfo.Text += nodeZip.Current.Value + "-" + nodeName.Current.Value + Environment.NewLine;

            }
        }

        private void btnNearby_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodeName, nodeZip;
            rtInfo.Text = "";
            String zipCode = txtZip.Text.ToString();

            //Create Request
            String WeatherURL = "http://api.geonames.org/findNearbyPostalCodes?postalcode=" + zipCode + "&radius=10&username=jlgagnon1";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            nodeName = nav.Select("//name");
            nodeZip = nav.Select("//postalcode");

            while (nodeName.MoveNext() && nodeZip.MoveNext())
            {
                rtInfo.Text += nodeZip.Current.Value + "-" + nodeName.Current.Value + Environment.NewLine;

            }
        }
    }
}

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
using System.IO;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            // make life easy for now, put this file in the debug directory
            string sStartupPath = Application.StartupPath + "\\Contacts.xml";
            if (File.Exists(sStartupPath))
            {
                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load(sStartupPath);
                XmlElement elm = xmlDoc.DocumentElement;
                XmlNodeList contacts = elm.ChildNodes;

                Console.WriteLine(contacts[0].Name + " - " +contacts[0].FirstChild.InnerText);
                Console.WriteLine(contacts[1].Name + " - " + contacts[1].FirstChild.InnerText);

                for (int iCount = 2; iCount < contacts.Count; iCount++)
                {
                    Console.WriteLine(contacts[iCount].Name);
                    Console.WriteLine("Sex - " + contacts[iCount].Attributes["sex"].Value);
                    XmlNodeList contactProp = contacts[iCount].ChildNodes;

                    for (int jCount = 0; jCount < contactProp.Count; jCount++)
                    {
                        Console.WriteLine(contactProp[jCount].Name + " - " + contactProp[jCount].InnerText);
                    }
                }
            }
            else
                Console.Write("File does not exist");
        }
    }
}

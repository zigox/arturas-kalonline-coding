using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kml;
using System.Xml;

namespace KalMarkupLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            KmlDocument kdoc = new KmlDocument();
            kdoc.LoadFromFile("Test.kml");

            KmlNodeCollection nodeCollection = kdoc.SelectNodes("item");
            int i = 0;
            int errors = 0;
            DateTime start = DateTime.Now;
            foreach (KmlNode knode in nodeCollection)
            {
                i++;
                try
                {
                    textBox1.AppendText(knode.SelectSingleNode("Index").Values[1] + "\r\n");
                    //textBox1.AppendText(knode.Values[1] + "\n");
                    //textBox1.AppendText(knode.ToString() + "\r\n");
                    // MessageBox.Show(knode.ToString());
                }
                catch (Exception)
                {
                    errors++;
                }
            }
           // textBox1.Text = kdoc.ToString();
            DateTime end = DateTime.Now;
            TimeSpan span = end - start;
            MessageBox.Show("Read and re-generated " + i + " items with " + errors + " errors in " + span.TotalSeconds + " seconds.");
            //MessageBox.Show(kdoc.RootNode.ToString());
        }
    }
}

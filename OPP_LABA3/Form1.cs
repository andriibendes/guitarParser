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
using System.Xml.Xsl;

namespace OPP_LABA3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        string path = "GuitarDataBase.xml";
        List<Guitar> final = new List<Guitar>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Guitar guitar = OurGuitar();
            if(Linq.Checked)
            {
                IStrategy CurrentStrategy = new Linq(path);
                final = CurrentStrategy.Algorithm(guitar, path);
                Output(final);
            }
            if (Dom.Checked)
            {
                IStrategy CurrentStrategy = new Dom(path);
                final = CurrentStrategy.Algorithm(guitar, path);
                Output(final);
            }
            if (Sax.Checked)
            {
                IStrategy CurrentStrategy = new Sax(path);
                final = CurrentStrategy.Algorithm(guitar, path);
                Output(final);
            }

        }
        private Guitar OurGuitar()
        {
            string[] info = new string[6];
            if (Type.Checked) info[0] = Convert.ToString(TypeBox.Text);
            if (Brand.Checked) info[1] = Convert.ToString(BrandBox.Text);
            if (Body.Checked) info[2] = Convert.ToString(BodyBox.Text);
            if (Material.Checked) info[3] = Convert.ToString(MaterialBox.Text);
            if (Country.Checked) info[4] = Convert.ToString(CountryBox.Text);
            Guitar IdealGuitar = new Guitar(info);
            return IdealGuitar;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Type.Checked = false;
            Brand.Checked = false;
            Body.Checked = false;
            Material.Checked = false;
            Country.Checked = false;

            TypeBox.Text = null;
            BrandBox.Text = null;
            BodyBox.Text = null;
            MaterialBox.Text = null;
            CountryBox.Text = null;

            Linq.Checked = false;
            Dom.Checked = false;
            Sax.Checked = false;
        }
        private void Output(List<Guitar> final)
        {
            int i = 1;
            Console.WriteLine("Alg+");
            foreach(Guitar g in final)
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                richTextBox1.AppendText("Name: " + g.Name + "\n");
                richTextBox1.AppendText("Type: " + g.Type + "\n");
                richTextBox1.AppendText("Brand: " + g.Brand + "\n");
                richTextBox1.AppendText("Body: " + g.Body + "\n");
                richTextBox1.AppendText("Material: " + g.Material + "\n");
                richTextBox1.AppendText("Country: " + g.Country + "\n");
                richTextBox1.AppendText("--------------------------------\n");
            }
        }
       /* public void GetAllGuitars()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("GuitarDataBase.xml");
            XmlNodeList list = doc.SelectNodes("//GuitarDataBase");
            foreach(XmlNode node in list)
            {
                string type = node.Attributes.GetNamedItem("TYPE").Value;
                if (!TypeBox.Items.Contains(type))
                    TypeBox.Items.Add(type);
                string brand = node.Attributes.GetNamedItem("BRAND").Value;
                if (!BrandBox.Items.Contains(brand))
                    BrandBox.Items.Add(brand);
                string body = node.Attributes.GetNamedItem("BODY").Value;
                if (!BodyBox.Items.Contains(body))
                    BodyBox.Items.Add(body);
                string material = node.Attributes.GetNamedItem("MATERIAL").Value;
                if (!MaterialBox.Items.Contains(material))
                    MaterialBox.Items.Add(type);
                string country = node.Attributes.GetNamedItem("COUNTRY").Value;
                if (!CountryBox.Items.Contains(country))
                    CountryBox.Items.Add(country);

                TypeBox.Items.Add(node.Attributes.GetNamedItem("TYPE").Value);
                BrandBox.Items.Add(node.Attributes.GetNamedItem("BRAND").Value);
                BodyBox.Items.Add(node.Attributes.GetNamedItem("BODY").Value);
                MaterialBox.Items.Add(node.Attributes.GetNamedItem("MATERIAL").Value);
                CountryBox.Items.Add(node.Attributes.GetNamedItem("COUNTRY").Value);
            }
        }*/

        private void Html_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(@"D:\CB\OPP_LABA3\OPP_LABA3\XSL.xslt");
            string input = @"D:\CB\OPP_LABA3\OPP_LABA3\GuitarDataBase.xml";
            string output = @"D:\CB\OPP_LABA3\OPP_LABA3\information.html";
            xsl.Transform(input, output);
            System.Diagnostics.Process.Start(@"D:\CB\OPP_LABA3\OPP_LABA3\information.html");
        }
    }
}

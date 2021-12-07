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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double d_alis, d_satis, e_alis, e_satis;

        protected void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / double.Parse(label4.Text));
            textBox3.Text = Convert.ToString(double.Parse(textBox1.Text) / double.Parse(label6.Text));
        }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            dovizcek();  
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void dovizcek()
        {
            XmlTextReader oku = new XmlTextReader("https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument belge = new XmlDocument();
            belge.Load(oku);

            XmlNode dolar = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='US DOLLAR']");
            XmlNode euro = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EURO']");

            d_alis = double.Parse(dolar.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            d_satis = double.Parse(dolar.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));
            e_alis = double.Parse(euro.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            e_satis = double.Parse(euro.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));

            label3.Text = d_alis.ToString();
            label4.Text = d_satis.ToString();
            label5.Text = e_alis.ToString();
            label6.Text = e_satis.ToString();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader oku = new XmlTextReader("https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument belge = new XmlDocument();
            belge.Load(oku);

            XmlNode dolar = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='US DOLLAR']");
            XmlNode euro = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EURO']");

            d_alis = double.Parse(dolar.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            d_satis = double.Parse(dolar.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));
            e_alis = double.Parse(euro.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            e_satis = double.Parse(euro.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));

            label3.Text = d_alis.ToString();
            label4.Text = d_satis.ToString();
            label5.Text = e_alis.ToString();
            label6.Text = e_satis.ToString();

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace k191373_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Category> list = new List<Category>();
            list.Add(new Category(0, " "));
            list.Add(new Category(1, "AUTOMOBILE ASSEMBLER"));
            list.Add(new Category(2, "AUTOMOBILE PARTS & ACCESSORIES"));
            list.Add(new Category(3, "CABLE & ELECTRICAL GOODS"));
            list.Add(new Category(4, "CEMENT"));            

            list.Add(new Category(5, "CHEMICAL"));
            list.Add(new Category(6, "CLOSE - END MUTUAL FUND"));
            list.Add(new Category(7, "COMMERCIAL BANKS"));
            list.Add(new Category(8, "ENGINEERING"));

            list.Add(new Category(9, "EXCHANGE TRADED FUNDS"));
            list.Add(new Category(10, "FERTILIZER"));
            list.Add(new Category(11, "FOOD & PERSONAL CARE PRODUCTS"));
            list.Add(new Category(12, "FUTURE CONTRACTS"));

            list.Add(new Category(13, "GLASS & CERAMICS"));
            list.Add(new Category(14, "INSURANCE"));
            list.Add(new Category(15, "INV. BANKS  INV. COS.  SECURITIES COS"));
            list.Add(new Category(16, "JUTE"));

            list.Add(new Category(17, "LEASING COMPANIES"));
            list.Add(new Category(18, "LEATHER & TANNERIES"));
            list.Add(new Category(19, "MISCELLANEOUS"));
            list.Add(new Category(20, "MODARABAS"));

            list.Add(new Category(21, "OIL & GAS EXPLORATION COMPANIES"));
            list.Add(new Category(22, "OIL & GAS MARKETING COMPANIES"));
            list.Add(new Category(23, "PAPER & BOARD"));
            list.Add(new Category(24, "PHARMACEUTICALS"));

            list.Add(new Category(25, "POWER GENERATION & DISTRIBUTION"));
            list.Add(new Category(26,"PROPERTY"));
            list.Add(new Category(27, "REAL ESTATE INVESTMENT TRUST"));
            list.Add(new Category(28, "REFINERY"));

            list.Add(new Category(29, "SUGAR & ALLIED INDUSTRIES"));
            list.Add(new Category(30, "SYNTHETIC & RAYON"));
            list.Add(new Category(31, "TECHNOLOGY & COMMUNICATION"));            
            list.Add(new Category(32, "TEXTILE COMPOSITE"));

            list.Add(new Category(33, "TEXTILE SPINNING"));
            list.Add(new Category(34, "TEXTILE WEAVING"));
            list.Add(new Category(35, "TEXTILE WEAVING"));
            list.Add(new Category(36, "TRANSPORT"));
            list.Add(new Category(37, "VANASPATI & ALLIED INDUSTRIES"));
            list.Add(new Category(38, "WOOLLEN"));

            comboBox1.DataSource = list;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   label2.Text = e.dis
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category c = new Category(Convert.ToInt32(comboBox1.SelectedValue));
        
             XmlDocument xmlDoc = new XmlDocument();
             xmlDoc.Load("C:\\Users\\kk\\source\\repos\\k191373_Q2\\bin\\Debug\\"+ c.Name +"\\"+c.Name+".xml");

             XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("Scripts");
             string script = "", price = "";


            listView1.Items.Clear();
            foreach (XmlNode node in nodeList)
            {
                script = node.SelectSingleNode("script").InnerText;
                price = node.SelectSingleNode("Price").InnerText;

                ListViewItem lvi = new ListViewItem();
                lvi.Text = script;
                lvi.SubItems.Add(price);
                listView1.Items.Add(lvi);                
            }
        }
    }
}

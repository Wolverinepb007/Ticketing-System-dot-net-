using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace booking
{
    public partial class PriceDetails : Form
    {
        XmlSerializer xmlSerializer;
        List<SetPrice> ticketPrices;
        public PriceDetails()
        {
            InitializeComponent();
            ticketPrices = new List<SetPrice>();
            xmlSerializer = new XmlSerializer(typeof(List<SetPrice>));
            abc();
            dataGridView1.DataSource = ticketPrices;
        }
        private void abc()
        {
            FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/setprice.xml", FileMode.Open, FileAccess.Read);
            try
            {
                var v = xmlSerializer.Deserialize(fileStream);

                ticketPrices = (List<SetPrice>)v;

                fileStream.Close();
            }
            catch (Exception e)
            {
                fileStream.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            a.Show();
            this.Hide();
        }
    }
}

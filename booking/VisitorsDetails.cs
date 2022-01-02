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
    public partial class VisitorsDetails : Form
    {
        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails;
        public VisitorsDetails()
        {
            InitializeComponent();
            vistorDetails = new List<VistorDetails>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            abc();
            if (vistorDetails.Count > 0)
            {
                dataGridView1.DataSource = vistorDetails;
            }
            else
            {
                dataGridView1.DataSource = vistorDetails;
                Console.WriteLine("No visitor Entered Till date");
            }
        }
        private void abc()
        {
            FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/vistordetails.xml", FileMode.Open, FileAccess.Read);
            try
            {
                var v = xmlSerializer2.Deserialize(fileStream);

                vistorDetails = (List<VistorDetails>)v;

                Console.WriteLine(vistorDetails);
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

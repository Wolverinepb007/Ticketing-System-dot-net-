﻿using System;
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
    public partial class Report : Form
    {
        XmlSerializer xmlSerializer;
        List<VistorDetails> vistorDetails;

        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails2;

        String currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public Report()
        {
            InitializeComponent();
            xmlSerializer = new XmlSerializer(typeof(List<VistorDetails>));
            vistorDetails = new List<VistorDetails>();

            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            vistorDetails2 = new List<VistorDetails>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/vistordetails.xml", FileMode.Open, FileAccess.Read);

                try
                {
                    var vistor = xmlSerializer.Deserialize(fileStream);

                    vistorDetails = (List<VistorDetails>)vistor;

                    DataTable dt = new DataTable();

                    int child = vistorDetails.Where(a => a.date.ToString("yyyy-MM-dd") == currentDate && (a.age >= 5 && a.age <= 12)).Count();
                    int adult = vistorDetails.Where(a => a.date.ToString("yyyy-MM-dd") == currentDate && (a.age >= 13 && a.age <= 60)).Count();
                    int group5 = vistorDetails.Where(a => a.date.ToString("yyyy-MM-dd") == currentDate && a.group == 5).Count();
                    int group10 = vistorDetails.Where(a => a.date.ToString("yyyy-MM-dd") == currentDate && a.group == 10).Count();
                    int group15 = vistorDetails.Where(a => a.date.ToString("yyyy-MM-dd") == currentDate && a.group == 15).Count();
                    int group20 = vistorDetails.Where(a => a.date.ToString("yyyy-MM-dd") == currentDate && a.group == 20).Count();

                    dt.Columns.Add("Name");
                    dt.Columns.Add("Count");

                    dt.Rows.Add("Child", child);
                    dt.Rows.Add("Adult", adult);
                    dt.Rows.Add("Group of 5", group5);
                    dt.Rows.Add("Group of 10", group10);
                    dt.Rows.Add("Group of 15", group15);
                    dt.Rows.Add("Group of 20", group20);

                    dataGridView1.DataSource = dt;

                    textBox1.Text = (child + adult + (group5 * 5) + (group10 * 10) + (group15 * 15) + (group20 * 20)).ToString();

                    fileStream.Close();
                }
                catch (Exception e2)
                {
                    fileStream.Close();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/vistordetails.xml", FileMode.Open, FileAccess.Read);

                try
                {
                    var vistor2 = xmlSerializer2.Deserialize(fileStream);

                    vistorDetails2 = (List<VistorDetails>)vistor2;

                    DataTable dt = new DataTable();

                    dt.Columns.Add("Day");
                    dt.Columns.Add("Total Visitor");
                    dt.Columns.Add("Total Earning");

                    int indate = ((int)DateTime.Parse(currentDate).DayOfWeek);
                    String fDate = (DateTime.Parse(currentDate).AddDays(-indate)).ToString("yyyy-MM-dd");
                    String LDate = (DateTime.Parse(currentDate).AddDays(7 - (-indate))).ToString("yyyy-MM-dd");

                    dt.Rows.Add("Sunday", calender(fDate), totalPrice(fDate));
                    dt.Rows.Add("Monday", calender(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Tuesday", calender(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Wednesday", calender(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Thursday", calender(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Friday", calender(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Saturday", calender(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")));

                    dataGridView2.DataSource = dt;

                    fileStream.Close();
                }
                catch (Exception e1)
                {
                    fileStream.Close();
                }
            }
        }

        public int calender(String cal)
        {

            int child = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && (a.age >= 5 && a.age <= 12)).Count();
            int adult = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && (a.age >= 13 && a.age <= 60)).Count();
            int group5 = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 5).Count() * 5;
            int group10 = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 10).Count() * 10;
            int group15 = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 15).Count() * 15;
            int group20 = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 20).Count() * 20;

            int sum = child + adult + group5 + group10 + group15 + group20;
            return sum;
        }

        public int totalPrice(String cal)
        {

            int totalprice = vistorDetails2.Where(a => a.date.ToString("yyyy-MM-dd") == cal).Select(a => a.TotalPrice).Sum();

            return totalprice;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
                vistorDetails2 = new List<VistorDetails>();

                FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/vistordetails.xml", FileMode.Open, FileAccess.Read);

                try
                {
                    var vistor2 = xmlSerializer2.Deserialize(fileStream);

                    vistorDetails2 = (List<VistorDetails>)vistor2;

                    DataTable dt = new DataTable();

                    dt.Columns.Add("Day");
                    dt.Columns.Add("Total Visitor");
                    dt.Columns.Add("Total Earning");

                    int indate = ((int)DateTime.Parse(currentDate).DayOfWeek);
                    String fDate = (DateTime.Parse(currentDate).AddDays(-indate)).ToString("yyyy-MM-dd");
                    String LDate = (DateTime.Parse(currentDate).AddDays((7 - indate))).ToString("yyyy-MM-dd");

                    dt.Rows.Add("Sunday", calender(fDate), totalPrice(fDate));
                    dt.Rows.Add("Monday", calender(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Tuesday", calender(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Wednesday", calender(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Thursday", calender(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Friday", calender(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Saturday", calender(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")));

                    /*dataGridView2.DataSource = dt;*/

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = dt.Rows.Count - 1; j > i; j--)
                        {
                            if (Convert.ToInt32(dt.Rows[j]["Total Visitor"]) < Convert.ToInt32(dt.Rows[j - 1]["Total Visitor"]))
                            {
                                var temp = dt.Rows[j]["Total Earning"];
                                var visit = dt.Rows[j]["Total Visitor"];
                                var name = dt.Rows[j]["Day"];
                                dt.Rows[j]["Total Earning"] = dt.Rows[j - 1]["Total Earning"];
                                dt.Rows[j - 1]["Total Earning"] = temp;
                                dt.Rows[j]["Total Visitor"] = dt.Rows[j - 1]["Total Visitor"];
                                dt.Rows[j - 1]["Total Visitor"] = visit;
                                dt.Rows[j]["Day"] = dt.Rows[j - 1]["Day"];
                                dt.Rows[j - 1]["Day"] = name;

                            }
                        }
                    }

                    dataGridView2.DataSource = dt;

                    fileStream.Close();
                }
                catch (Exception e3)
                {
                    fileStream.Close();
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WeeklyChart chart = new WeeklyChart();
            chart.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
                vistorDetails2 = new List<VistorDetails>();

                FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/vistordetails.xml", FileMode.Open, FileAccess.Read);

                try
                {
                    var vistor2 = xmlSerializer2.Deserialize(fileStream);

                    vistorDetails2 = (List<VistorDetails>)vistor2;

                    DataTable dt = new DataTable();

                    dt.Columns.Add("Day");
                    dt.Columns.Add("Total Visitor");
                    dt.Columns.Add("Total Earning");

                    int indate = ((int)DateTime.Parse(currentDate).DayOfWeek);
                    String fDate = (DateTime.Parse(currentDate).AddDays(-indate)).ToString("yyyy-MM-dd");
                    String LDate = (DateTime.Parse(currentDate).AddDays((7 - indate))).ToString("yyyy-MM-dd");

                    dt.Rows.Add("Sunday", calender(fDate), totalPrice(fDate));
                    dt.Rows.Add("Monday", calender(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Tuesday", calender(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Wednesday", calender(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Thursday", calender(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")));
                    dt.Rows.Add("Friday", calender(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")));
                dt.Rows.Add("Saturday", calender(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")));

                for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = dt.Rows.Count - 1; j > i; j--)
                        {
                            if (Convert.ToInt32(dt.Rows[j]["Total Earning"]) < Convert.ToInt32(dt.Rows[j - 1]["Total Earning"]))
                            {
                                var temp = dt.Rows[j]["Total Earning"];
                                var visit = dt.Rows[j]["Total Visitor"];
                                var name = dt.Rows[j]["Day"];
                                dt.Rows[j]["Total Earning"] = dt.Rows[j - 1]["Total Earning"];
                                dt.Rows[j - 1]["Total Earning"] = temp;
                                dt.Rows[j]["Total Visitor"] = dt.Rows[j - 1]["Total Visitor"];
                                dt.Rows[j - 1]["Total Visitor"] = visit;
                                dt.Rows[j]["Day"] = dt.Rows[j - 1]["Day"];
                                dt.Rows[j - 1]["Day"] = name;

                            }
                        }
                    }

                    dataGridView2.DataSource = dt;

                    fileStream.Close();
                }
                catch (Exception e4)
                {
                    fileStream.Close();
                }

            
        }

		private void Report_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

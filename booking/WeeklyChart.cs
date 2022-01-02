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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace booking
{
    public partial class WeeklyChart : Form
    {
        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails2;

        String currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public WeeklyChart()
        {
            InitializeComponent();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            vistorDetails2 = new List<VistorDetails>();
            weeklyChart(currentDate);
        }

        private void weeklyChart(String date)
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
                String LDate = (DateTime.Parse(currentDate).AddDays((7 - indate))).ToString("yyyy-MM-dd");

                dt.Rows.Add("Sunday", calender(fDate), totalPrice(fDate));
                dt.Rows.Add("Monday", calender(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")));
                dt.Rows.Add("Tuesday", calender(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")));
                dt.Rows.Add("Wednesday", calender(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")));
                dt.Rows.Add("Thursday", calender(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")));
                dt.Rows.Add("Friday", calender(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")));
                dt.Rows.Add("Saturday", calender(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(6).ToString("yyyy-MM-dd")));

                chart1.Series["Series1"].LegendText = "Visitors";
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"].XValueMember = "Day";
                chart1.Series["Series1"].YValueMembers = "Total Visitor";
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart1.DataSource = dt;

                chart2.Series["Series1"].LegendText = "Price";
                chart2.Series["Series1"].ChartType = SeriesChartType.Column;
                chart2.Series["Series1"].IsValueShownAsLabel = true;
                chart2.Series["Series1"].XValueMember = "Day";
                chart2.Series["Series1"].YValueMembers = "Total Earning";
                chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart2.DataSource = dt;

                fileStream.Close();
            }
            catch (Exception e)
            {
                fileStream.Close();
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


        private void WeeklyChart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            a.Show();
            this.Hide();
        }
    }
}

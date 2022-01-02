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
    public partial class EmployeeForm : Form
    {
        XmlSerializer xmlSerializer;
        List<SetPrice> priceDatas;

        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails;

        int count = 0;
        public EmployeeForm()
        {
            InitializeComponent();
            xmlSerializer = new XmlSerializer(typeof(List<SetPrice>));
            priceDatas = new List<SetPrice>();

            vistorDetails = new List<VistorDetails>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            abc();
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

            
                TimeSpan start = TimeSpan.Parse("10:00"); //10am o'clock
                TimeSpan end = TimeSpan.Parse("18:00");  //6pm o'clock
                TimeSpan now = DateTime.Now.TimeOfDay;

                if ((now > start) && (now < end))
                {
                    FileStream fileStream2 = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/vistordetails.xml", FileMode.OpenOrCreate, FileAccess.Write);

                    VistorDetails v = new VistorDetails();

                    v.id = Int32.Parse(textBox1.Text);
                    v.name = textBox2.Text;
                    v.contact = textBox3.Text;
                    v.date = DateTime.Parse(textBox4.Text, System.Globalization.CultureInfo.CurrentCulture);
                    /*v.date = Convert.ToDateTime(textBox4.Text);*/
                    String todayDay = textBox5.Text;

                    switch (todayDay)
                    {
                        case "Sunday":
                            v.day = DayOfWeek.Sunday;
                            break;
                        case "Monday":
                            v.day = DayOfWeek.Monday;
                            break;
                        case "Tuesday":
                            v.day = DayOfWeek.Monday;
                            break;
                        case "Wednesday":
                            v.day = DayOfWeek.Monday;
                            break;
                        case "Thursday":
                            v.day = DayOfWeek.Monday;
                            break;
                        case "Friday":
                            v.day = DayOfWeek.Monday;
                            break;
                        default:
                            v.day = DayOfWeek.Saturday;
                            break;
                    }

                    v.CheckInTime = DateTime.Parse(textBox6.Text, System.Globalization.CultureInfo.CurrentCulture);

                    Random r = new Random();

                    if ((!radioButton1.Checked && !radioButton2.Checked) && (comboBox1.SelectedItem == null))
                    {
                        MessageBox.Show("Please select either Age or Group", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            v.age = r.Next(5, 11);
                        }
                        else if (radioButton2.Checked)
                        {
                            v.age = r.Next(12, 60);
                        }
                        else
                        {
                            v.age = 0;
                        }

                        if (comboBox1.SelectedItem == null)
                        {
                            v.group = 0;
                        }
                        else
                        {
                            v.group = Int32.Parse(comboBox1.Text);
                        }
                    }

                    if (comboBox2.SelectedItem == null)
                    {
                        MessageBox.Show("Please select duration hours", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (comboBox2.Text == "1" || comboBox2.Text == "2" || comboBox2.Text == "3" || comboBox2.Text == "4")
                        {
                            v.Duration = Int32.Parse(comboBox2.Text);
                        }
                        else
                        {
                            v.Duration = 8;
                        }
                    }

                    v.CheckoutTime = DateTime.Parse(textBox7.Text, System.Globalization.CultureInfo.CurrentCulture);

                    v.TotalPrice = Int32.Parse(textBox8.Text);


                    vistorDetails.Add(v);
                    xmlSerializer2.Serialize(fileStream2, vistorDetails);
                    fileStream2.Close();

                    Console.WriteLine(v.id);
                    Console.WriteLine(v.name);
                    Console.WriteLine(v.contact);
                    Console.WriteLine(v.date);
                    Console.WriteLine(v.day);
                    Console.WriteLine(v.CheckInTime);
                    Console.WriteLine(v.age);
                    Console.WriteLine(v.group);
                    Console.WriteLine(v.Duration);
                    Console.WriteLine(v.CheckoutTime);
                    Console.WriteLine(v.TotalPrice);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";

                    comboBox1.SelectedIndex = -1;
                    comboBox1.Text = "Group of";

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    comboBox2.SelectedIndex = -1;
                    comboBox2.Text = "Hours";

                    comboBox1.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    comboBox2.Enabled = false;

                    count += 1;
                    textBox1.Text = count.ToString();

                    /*Random rnd = new Random();
                    int num = rnd.Next(1, 1000);
                    textBox1.Text = num.ToString();*/
                }
                else
                {
                    Console.WriteLine("Recreation centre is closed, It's opening time is 10am to 6pm");
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Group of";
            comboBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "Hours";
            comboBox2.Enabled = false;
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

          
                foreach (VistorDetails vis in vistorDetails)
                {
                    count += 1;
                }

                count += 1;
                timer1.Start();
                /*textBox1.Text = num.ToString();*/
                textBox1.Text = (count).ToString();
                textBox4.Text = DateTime.Now.ToString("yyyy-MM-dd");
                textBox5.Text = DateTime.Today.DayOfWeek.ToString();
                textBox6.Text = DateTime.Now.ToLongTimeString();
                comboBox2.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
                textBox6.Text = DateTime.Now.ToLongTimeString();

                DateTime date = DateTime.Parse(textBox6.Text, System.Globalization.CultureInfo.CurrentCulture);

                if (comboBox2.Text == "1")
                {
                    textBox7.Text = date.AddHours(1).ToLongTimeString();
                }

                if (comboBox2.Text == "2")
                {
                    textBox7.Text = date.AddHours(2).ToLongTimeString();
                }

                if (comboBox2.Text == "3")
                {
                    textBox7.Text = date.AddHours(3).ToLongTimeString();
                }

                if (comboBox2.Text == "4")
                {
                    textBox7.Text = date.AddHours(4).ToLongTimeString();
                }

                if (comboBox2.Text == "Whole Day")
                {
                    textBox7.Text = AbsoluteEnd(date).ToLongTimeString();
                }

                timer1.Start();
        }
        public static DateTime AbsoluteStart(DateTime dateTime)
        {
            return dateTime.Date;
        }
        public static DateTime AbsoluteEnd(DateTime dateTime)
        {
            return AbsoluteStart(dateTime).AddDays(1).AddTicks(-1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                timer1.Start();

                FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/setprice.xml", FileMode.Open, FileAccess.Read);

                var priceData = xmlSerializer.Deserialize(fileStream);

                priceDatas = (List<SetPrice>)priceData;

                DateTime date = DateTime.Parse(textBox6.Text, System.Globalization.CultureInfo.CurrentCulture);


                /*One Hours*/
                if (comboBox2.Text == "1")
                {
                    textBox7.Text = date.AddHours(1).ToLongTimeString();

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 5 && price.age <= 12)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        Console.WriteLine(price.age);

                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(price.age);
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        if (radioButton2.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 13 && price.age <= 60)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        return;
                    }

                    if (comboBox1.SelectedIndex >= 0)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Console.WriteLine("hour of 1");
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 5)
                                {
                                    Console.WriteLine("group of 5");
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 10)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 2)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 15)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 3)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 20)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.oneHour.ToString();
                                        }
                                    }

                                }
                            }
                        }



                    }
                }


                /*Two Hours*/
                if (comboBox2.Text == "2")
                {
                    textBox7.Text = date.AddHours(2).ToLongTimeString();

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 5 && price.age <= 12)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        Console.WriteLine(price.age);

                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(price.age);
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        if (radioButton2.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 13 && price.age <= 60)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        return;
                    }

                    if (comboBox1.SelectedIndex >= 0)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 5)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 10)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 2)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 15)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 3)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 20)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.twoHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }

                /*Three Hours*/
                if (comboBox2.Text == "3")
                {
                    textBox7.Text = date.AddHours(3).ToLongTimeString();

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 5 && price.age <= 12)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        Console.WriteLine(price.age);

                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(price.age);
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        if (radioButton2.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 13 && price.age <= 60)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        return;
                    }

                    if (comboBox1.SelectedIndex >= 0)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 5)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 10)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 2)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 15)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 3)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 20)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.threeHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }

                /*four Hours*/
                if (comboBox2.Text == "4")
                {
                    textBox7.Text = date.AddHours(4).ToLongTimeString();

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 5 && price.age <= 12)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        Console.WriteLine(price.age);

                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(price.age);
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        if (radioButton2.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 13 && price.age <= 60)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        return;
                    }

                    if (comboBox1.SelectedIndex >= 0)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 5)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 10)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 2)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 15)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 3)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 20)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.fourHour.ToString();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }

                /*whole day*/
                if (comboBox2.Text == "Whole Day")
                {
                    textBox7.Text = AbsoluteEnd(date).ToLongTimeString();

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 5 && price.age <= 12)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(price.age);
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        if (radioButton2.Checked)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.age >= 13 && price.age <= 60)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }

                                }
                            }
                        }
                        return;
                    }

                    if (comboBox1.SelectedIndex >= 0)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 5)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 10)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 2)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 15)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }

                                }
                            }
                        }

                        if (comboBox1.SelectedIndex == 3)
                        {
                            foreach (SetPrice price in priceDatas)
                            {
                                if (price.group == 20)
                                {
                                    if (textBox5.Text.Equals("Saturday"))
                                    {
                                        if (price.dayType == "Holiday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }
                                    else
                                    {
                                        if (price.dayType == "Weekday")
                                        {
                                            textBox8.Text = price.wholeday.ToString();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            comboBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblEmployeeTitle_Click(object sender, EventArgs e)
		{

		}
	}
}

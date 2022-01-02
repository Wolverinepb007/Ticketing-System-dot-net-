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
    public partial class AdminForm : Form
    {
        XmlSerializer xmlSerializer;
        List<SetPrice> priceData;
        public AdminForm()
        {
            InitializeComponent();
            priceData = new List<SetPrice>();
            xmlSerializer = new XmlSerializer(typeof(List<SetPrice>));
        }

        private void btnSetTicketPrice_Click(object sender, EventArgs e)
        {

           
                FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/setprice.xml", FileMode.OpenOrCreate, FileAccess.Write);
                SetPrice setPrice = new SetPrice();
                Random random = new Random();

                if (comboBox1.SelectedIndex == 0)
                {

                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        setPrice.dayType = comboBox1.SelectedItem.ToString();

                        if (radioButton1.Checked)
                        {
                            if (priceData.Count > 0)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Weekday" && (t.age >= 5 && t.age <= 12))
                                    {
                                        Console.WriteLine("Already Exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            setPrice.age = random.Next(5, 11);
                        }
                        else
                        {
                            if (priceData.Count > 0)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Weekday" && (t.age >= 13 && t.age <= 60))
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            setPrice.age = random.Next(12, 60);
                        }

                        setPrice.group = 0;

                        setPrice.oneHour = Int32.Parse(txtboxTicketPrice.Text);
                        setPrice.twoHour = Int32.Parse(textBox1.Text);
                        setPrice.threeHour = Int32.Parse(textBox3.Text);
                        setPrice.fourHour = Int32.Parse(textBox2.Text);
                        setPrice.wholeday = Int32.Parse(txtboxWholeDay.Text);

                        Console.WriteLine("Radio button weekday");
                        Console.WriteLine(setPrice.dayType);
                    }

                    if (cmbboxGroup.SelectedIndex >= 0)
                    {
                        if (priceData.Count > 0)
                        {
                            if (cmbboxGroup.SelectedIndex == 0)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Weekday" && t.group == 5)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }


                            if (cmbboxGroup.SelectedIndex == 1)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Weekday" && t.group == 10)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            if (cmbboxGroup.SelectedIndex == 2)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Weekday" && t.group == 15)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            if (cmbboxGroup.SelectedIndex == 3)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Weekday" && t.group == 20)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }
                        }

                        setPrice.dayType = comboBox1.SelectedItem.ToString();

                        setPrice.age = 0;

                        setPrice.group = Int32.Parse(cmbboxGroup.SelectedItem.ToString());

                        setPrice.oneHour = Int32.Parse(txtboxTicketPrice.Text);
                        setPrice.twoHour = Int32.Parse(textBox1.Text);
                        setPrice.threeHour = Int32.Parse(textBox3.Text);
                        setPrice.fourHour = Int32.Parse(textBox2.Text);
                        setPrice.wholeday = Int32.Parse(txtboxWholeDay.Text);

                        Console.WriteLine("combobox weekday");
                        Console.WriteLine(setPrice.dayType);

                    }

                }
                else
                {
                    if (radioButton1.Checked || radioButton2.Checked)
                    {
                        setPrice.dayType = comboBox1.SelectedItem.ToString();

                        if (radioButton1.Checked)
                        {
                            if (priceData.Count > 0)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Holiday" && (t.age >= 5 && t.age <= 12))
                                    {
                                        Console.WriteLine("Already Exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            setPrice.age = random.Next(5, 11);
                        }
                        else
                        {
                            if (priceData.Count > 0)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Holiday" && (t.age >= 13 && t.age <= 60))
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            setPrice.age = random.Next(12, 60);
                        }

                        setPrice.group = 0;

                        setPrice.oneHour = Int32.Parse(txtboxTicketPrice.Text);
                        setPrice.twoHour = Int32.Parse(textBox1.Text);
                        setPrice.threeHour = Int32.Parse(textBox3.Text);
                        setPrice.fourHour = Int32.Parse(textBox2.Text);
                        setPrice.wholeday = Int32.Parse(txtboxWholeDay.Text);

                        Console.WriteLine("Radio button holiday");
                        Console.WriteLine(setPrice.dayType);

                    }

                    if (cmbboxGroup.SelectedIndex >= 0)
                    {
                        if (priceData.Count > 0)
                        {
                            if (cmbboxGroup.SelectedIndex == 0)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Holiday" && t.group == 5)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }


                            if (cmbboxGroup.SelectedIndex == 1)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Holiday" && t.group == 10)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            if (cmbboxGroup.SelectedIndex == 2)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Holiday" && t.group == 15)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                            if (cmbboxGroup.SelectedIndex == 3)
                            {
                                foreach (SetPrice t in priceData)
                                {
                                    if (t.dayType == "Holiday" && t.group == 20)
                                    {
                                        Console.WriteLine("already exist");
                                        fileStream.Close();
                                        return;
                                    }
                                }
                            }

                        }

                        setPrice.dayType = comboBox1.SelectedItem.ToString();

                        setPrice.age = 0;

                        setPrice.group = Int32.Parse(cmbboxGroup.SelectedItem.ToString());

                        setPrice.oneHour = Int32.Parse(txtboxTicketPrice.Text);
                        setPrice.twoHour = Int32.Parse(textBox1.Text);
                        setPrice.threeHour = Int32.Parse(textBox3.Text);
                        setPrice.fourHour = Int32.Parse(textBox2.Text);
                        setPrice.wholeday = Int32.Parse(txtboxWholeDay.Text);

                        Console.WriteLine("combobox holiday");
                        Console.WriteLine(setPrice.dayType);

                    }

                }


                priceData.Add(setPrice);
                xmlSerializer.Serialize(fileStream, priceData);
                fileStream.Close();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbboxGroup.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbboxGroup.Enabled = false;
        }

        private void cmbboxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cmbboxGroup.SelectedIndex = -1;
            cmbboxGroup.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            comboBox1.SelectedIndex = -1;
            txtboxTicketPrice.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            txtboxWholeDay.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PriceDetails pd = new PriceDetails();
            pd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisitorsDetails vd = new VisitorsDetails();
            this.Hide();
            vd.Show();
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();
        }

		private void AdminForm_Load(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

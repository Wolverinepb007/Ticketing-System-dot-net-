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
    public partial class LoginForm : Form
    {
        XmlSerializer xmlSerializer;
        List<Login> loginDetails;
        public LoginForm()
        {
            InitializeComponent();
            loginDetails = new List<Login>();
            xmlSerializer = new XmlSerializer(typeof(List<Login>));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/login.xml", FileMode.Open, FileAccess.Read);
            loginDetails = (List<Login>)xmlSerializer.Deserialize(fileStream);

            foreach (var item in loginDetails)
            {
                if (item.Email == textBox1.Text && item.Password == textBox2.Text && item.Role == "admin")
                {

                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();

                }
                else if (item.Email == textBox1.Text && item.Password == textBox2.Text && item.Role == "employee")
                {
                    this.Hide();
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                }
                //else
                //{
                //    MessageBox.Show("invalid login credentials!!");

                //}
            }
        }

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}
	}
}

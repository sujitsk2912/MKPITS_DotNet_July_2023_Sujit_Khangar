using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_selection_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Password = textBox2.Text;
            string Gender = null;
            string Courses = null;
            string City = comboBox1.Text;

            StringBuilder sb = new StringBuilder();

            if(radioButton1.Checked )
            {
                Gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                Gender = "Female";
            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }

            if(checkBox1.Checked)
            {
                Courses = "Java";
            }
            else if(checkBox2.Checked)
            {
                Courses = "DotNet";
            }
            else if(checkBox3.Checked)
            {
                Courses = "PHP";
            }
            else
            {
                MessageBox.Show("Please Select Courses");
            }

            sb.AppendLine("Username: " + Name);
            sb.AppendLine("Password: " +  Password);
            sb.AppendLine("Gender: " +  Gender);
            sb.AppendLine("Courses: " +  Courses);
            sb.AppendLine("City: " + City);

            label6.Text = sb.ToString();
        }
    }
}

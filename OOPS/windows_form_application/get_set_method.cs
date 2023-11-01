using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_set_method_of_person_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal class Person
        {
           public string Name { get; set; } 
           public int Age { get; set; }
           public string Address { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            p.Name = textBox1.Text;
            p.Age = Convert.ToInt32(textBox2.Text);
            p.Address = textBox3.Text;

            StringBuilder sb = new StringBuilder();

            sb.Append("Name: " + p.Name + "\n");
            sb.Append("Age: " + p.Age + "\n");
            sb.Append("Address: " + p.Address + "\n");

            label4.Text = sb.ToString();
        }
    }
}

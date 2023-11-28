using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_class_using_windows_form_in_dictonary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Employee> emp = new Dictionary<int, Employee>();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee E = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
            emp.Add(E.empid, E);
            clear();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<int, Employee> kvp in emp)
            {
                sb.AppendLine("Employee ID: " + kvp.Key + "  Employee Name: " + kvp.Value.empname);
            }

            label3.Text = sb.ToString();
        }
    }
}



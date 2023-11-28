using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_class_using_arraylist
{
    public partial class Form1 : Form
    {
        internal class Employee
        {
            public int empid;
            public string name;
            public int salary;
            public string designation;

            public Employee(int empid, string name, int salary, string designation)
            {
                this.empid = empid;
                this.name = name;
                this.salary = salary;
                this.designation = designation;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        Employee emp;

        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            emp = new Employee(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
            ar.Add(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Employee emp in ar)
            {
                sb.Append("Employee ID: " + emp.empid + "\n");
                sb.Append("Name: " + emp.name + "\n");
                sb.Append("Salary: " + emp.salary + "\n");
                sb.Append("Designation: " + emp.designation + "\n");
                sb.AppendLine();
            }

            label5.Text = sb.ToString();
        }
    }
}

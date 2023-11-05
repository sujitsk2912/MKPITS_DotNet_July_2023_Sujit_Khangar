using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal class Employee
        {
            int EmployeeId;
            string Name;
            string Age;
            int Salary;

            public Employee(int EmployeeId, string Name, string Age, int Salary)
            {
                this.EmployeeId = EmployeeId;
                this.Name = Name;
                this.Age = Age;
                this.Salary = Salary;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string age = textBox3.Text; 
            int salary = Convert.ToInt32(textBox4.Text);

            Employee employee = new Employee(empid,name,age,salary);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Employee ID: " +  empid);
            sb.AppendLine("Employee Name: " +  name);
            sb.AppendLine("Age: " +  age);
            sb.AppendLine("Salary: " +  salary);

            label5.Text = sb.ToString();

        }
    }
}

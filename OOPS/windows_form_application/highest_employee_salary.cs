using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_highest_salary
{
    public partial class Form1 : Form
    {
        internal class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public int Salary { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        Employee[] emp = new Employee[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( cnt < 3 )
            {
                emp[cnt].EmployeeId = Convert.ToInt32(textBox1.Text);
                emp[cnt].EmployeeName = textBox2.Text;
                emp[cnt].Salary = Convert.ToInt32(textBox3.Text);
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 3 Employees are Submited, Now Show Employee Details...");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           StringBuilder sb = new StringBuilder();

            sb.Append("\n-------- EMPLOYEE DETAILS -------\n");
            for( int i = 0; i < 3; i++ )
            {
                sb.Append("---------------------------------------------\n");
                sb.Append("Employee ID: " + emp[i].EmployeeId + "\n");
                sb.Append("Employee Name: " + emp[i].EmployeeName + "\n");
                sb.Append("Salary: " + emp[i].Salary + "\n");
                sb.Append("---------------------------------------------\n");
            }

           label4.Text = sb.ToString();

            // high salary details

            int high = emp[0].Salary;
            int rem = 0;

            for( int i = 1; i < 3; i++ )
            {
                    if(high < emp[i].Salary)
                    {
                        high = emp[i].Salary;
                        rem = i;
                    }
            }

            StringBuilder sb2 = new StringBuilder();

            sb2.Append("\n----- HIGH SALARY DETAILS -----\n");
            sb2.Append("Employee ID: " + emp[rem].EmployeeId + "\n");
            sb2.Append("Employee Name: " + emp[rem].EmployeeName + "\n");
            sb2.Append("Salary: " + emp[rem].Salary);

            label5.Text = sb2.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_and_bonus_of_employee
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
            float Salary = Convert.ToSingle(textBox2.Text);
            string designation = comboBox1.Text;

            float BonusSal = 0.0f;
            float TotalSal = 0.0f;

            StringBuilder sb = new StringBuilder();

            switch(designation)
            {
                case "Manager":
                    BonusSal = Salary + (BonusSal= 4000.00f);
                    break;

                case "Clerk":
                    BonusSal = Salary + (BonusSal = 3000.00f);
                    break;

                case "Peon":
                    BonusSal = Salary + (BonusSal = 2000.00f);
                    break;
            }

             if (checkBox1.Checked && checkBox2.Checked)
            {
                sb.AppendLine("Employee Name: " + Name);
                sb.AppendLine("Designation: " + designation);
                sb.AppendLine("Bonus + Salary: " + BonusSal);
                sb.AppendLine("Salary: " + Salary);
            }
            else if ( checkBox1.Checked )
            {
                sb.AppendLine("Employee Name: " + Name);
                sb.AppendLine("Designation: " + designation);
                sb.AppendLine("Bonus + Salary: " + BonusSal);
            }
            else if (checkBox2.Checked)
            {
                sb.AppendLine("Employee Name: " + Name);
                sb.AppendLine("Designation: " + designation);
                sb.AppendLine("Salary: " + Salary);
            }
            else
            {
                MessageBox.Show("Please Select Any One Textbox");
            }

            label3.Text = sb.ToString();
        }
    }
}

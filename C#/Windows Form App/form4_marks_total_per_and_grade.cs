using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, p, c;
            int total = 0;
            float per = 0;
            string grade = null;

            m = Convert.ToInt32(textBox1.Text);
            p = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            total = m + p + c;
            per = ( total / 300.0f) * 100.0f;

            label4.Text = "Total: " + total;
            label5.Text = "Percentage: " + per;

            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 65 && per < 75)
            {
                grade = "First";
            }
            else if (per >= 45 && per < 65)
            {
                grade = "Second";
            }
            else
            {
                grade = "Fail";
            }

            label6.Text = "Grade: " + grade;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

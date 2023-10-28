using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marks_of_3_sub_and__calculate_total_and_percent
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        int[] marks = new int[3];
        int total = 0;
        float per;
        int cnt = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < marks.Length; i++)
            {
                total = total + marks[i];
            }
            label2.Text = "Total Marks: " + total;
            per = (total / 300.0f) * 100.0f;
            label3.Text = "Percentage: " + per;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (cnt < 3)
            {
                if(cnt == 0)
                {
                    label1.Text = "Chemistry Marks: ";
                }
                else if( cnt == 1)
                {
                    label1.Text = "Physics Marks: ";
                }
                else
                {
                    label1.Text = "";
                }

                marks[cnt] = Convert.ToInt32(textBox1.Text);
                cnt++;
                textBox1.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have entered 3 subject marks now click on result button");

                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

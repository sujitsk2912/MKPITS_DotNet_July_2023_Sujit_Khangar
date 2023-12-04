using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accept_no_and_strore_in_arry_and_sum_of_it
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int res = 0;
        int i = 0;
        int[] arry = new int[5];


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (i < 5)
            {
                arry[i] = Convert.ToInt32(textBox1.Text);
                res = res + arry[i];
                i++;

                textBox1.Clear();
                textBox1.Focus();
                

                if (i == 5)
                {
                    label2.Text = "Sum of " + i + " numbers is : " + res;
                }
                
            }   

            else
            {
               MessageBox.Show ("Five numbers are Entered Alredy");
            }

        }
    }
}

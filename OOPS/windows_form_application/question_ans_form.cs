using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_Answer_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q1 = null;
            string q2 = null;
            string q3 = null;

            int score = 0;

                if (opt1.Checked)
                {
                opt1.Text = "Lion";
                score++;
                }

                 if (radioButton3.Checked)
                {
                radioButton3.Text = "Delhi";
                score++;
                }

                 if (radioButton7.Checked)
                {
                radioButton7.Text = "Mumbai";
                score++;
                }
               
            MessageBox.Show("Total Score is : " + score);
        }
    }
}

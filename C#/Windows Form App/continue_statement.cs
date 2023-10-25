using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace continue_statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int num, counter = 0;
            num = Convert.ToInt32(textBox1.Text);

            while(true)
            {
                sb.AppendLine(counter.ToString());
                richTextBox1.Text = sb.ToString();
                counter++;

                if (counter < num)
                {
                    continue;
                }
                else
                {
                    break;
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

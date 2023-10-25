using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_break_statement
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
            int num, counter = 1;

            num = Convert.ToInt32(textBox1.Text);

            for( counter = 1; counter <= 10 ; counter++ ) 
            {
                sb.AppendLine(counter.ToString());

                if( counter == num ) 
                {
                    break;
                }
            }
            label2.Text = sb.ToString();
        }
    }
}

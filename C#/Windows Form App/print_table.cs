using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace print_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); // StringBuilder use to modify a string without creating a new object.
            int num, counter = 1, res = 1;

            num = Convert.ToInt32(textBox1.Text);

            for ( counter = 1; counter <= 10 ; counter++ ) 
            {
                res = num * counter;
                sb.AppendLine (num + " * " + counter + " = " + res); // AppendLine Appends a copy of the specified string followed by
                                                                     // the default line terminator to the end of the current StringBuilder object.
            }
            
            label2.Text = sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMI_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int principal, time;
            float rate, EMI;

            principal = Convert.ToInt32(textBox1.Text);
            rate = Convert.ToSingle(textBox2.Text);
            time = Convert.ToInt32(textBox3.Text);

            rate = rate / (12 * 100); /*one month interest*/
            time = time * 12; /*one month period*/

            EMI = (float)((principal * rate * Math.Pow(1 + rate, time)) / (Math.Pow(1 + rate, time) - 1));

            label4.Text = " Monthly EMI: " + EMI + ".Rs";
        }
    }
}

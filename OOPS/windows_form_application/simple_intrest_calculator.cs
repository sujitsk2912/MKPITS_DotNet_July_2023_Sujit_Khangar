using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_Intrest_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal class SimpleIntrest
        {
            public int Amount;
            public int Years;
            public float ROI;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SimpleIntrest SI = new SimpleIntrest();

            int amount = Convert.ToInt32(textBox1.Text);
            int year = Convert.ToInt32(textBox2.Text);
            float rate = Convert.ToSingle(textBox3.Text);

            float intrest = amount * rate * year / 100;

            float Total = intrest + amount;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Total Amount: " + Total + " Rs");

            label4.Text = sb.ToString();
        }
    }
}

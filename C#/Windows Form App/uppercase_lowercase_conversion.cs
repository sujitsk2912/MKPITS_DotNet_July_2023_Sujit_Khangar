using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppercase_conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence, upper;

            sentence = textBox1.Text;

            upper = sentence.ToUpper();

            label2.Text = "Converted Sentence: " + upper;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sentence, lower;

            sentence = textBox1.Text;

            lower = sentence.ToLower();

            label2.Text = "Converted Sentence: " + lower;
        }
    }
}

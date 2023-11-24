using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortlng_keys_using_windows_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SortedList sl = new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            sl.Add(Convert.ToInt32(textBox1.Text), textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection key = sl.Keys;

            StringBuilder sb = new StringBuilder();

            foreach (object s  in key )
            {
                sb.Append("Product ID: " + s + "\n");
            }

            label3.Text = sb.ToString();

            ICollection value = sl.Values;

            StringBuilder sb2 = new StringBuilder();

            foreach (object s in key)
            {
                sb2.Append("Product Name: " + sl[s] + "\n");
            }

            label4.Text = sb2.ToString();
        }
    }
}

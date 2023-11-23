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

namespace remove_in_arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button2_Click(object sender, EventArgs e)
        {
            Name = textBox2.Text;
            ar.Add(Name);
            textBox2.Clear();
            textBox2.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ar.Remove(textBox2.Text);

            StringBuilder sb = new StringBuilder();

            foreach(object obj in ar)
            {
                sb.Append("Name: " + obj + "\n");
            }

            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (object obj in ar)
            {
                sb.Append("Name: " + obj + "\n");
            }

            label3.Text = sb.ToString();
            textBox2.Clear();
            textBox2.Focus();
        }
    }
}

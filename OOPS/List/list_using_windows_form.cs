using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> li = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.Add(textBox1.Text);
            clear();

        }

        public void display()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in li)
            {
                sb.AppendLine("Name: " + s);
            }

            label2.Text = sb.ToString();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            li.Remove(textBox1.Text);
            clear();
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            li.Sort();
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(li.Contains(textBox1.Text))
            {
                MessageBox.Show(textBox1.Text + " is fount in list");
            }
            else
            {
                    MessageBox.Show(textBox1.Text + " is not found in list");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            li.Insert(1, textBox1.Text);
            clear();
            display();
        }
    }
}

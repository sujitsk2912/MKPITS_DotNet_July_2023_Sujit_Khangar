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

namespace Queqe_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Queue q = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            q.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;

            StringBuilder sb = new StringBuilder();

            foreach(string str in q)
            {
                sb.AppendLine("Name: " + str);
                sb.AppendLine();
            }

            richTextBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            q.Dequeue();

            StringBuilder sb = new StringBuilder();

            foreach (string str in q)
            {
                sb.AppendLine("Name: " + str);
                sb.AppendLine();
            }

            richTextBox1.Text = sb.ToString();
        }
    }
}

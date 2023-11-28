using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue_coll_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> Q = new Queue<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Q.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Q.Dequeue();

            StringBuilder sb = new StringBuilder();

            foreach (string s in Q)
            {
                sb.AppendLine("Name: " + s);
            }

            label2.Text = sb.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(string s in Q)
            {
                sb.AppendLine("Name: " + s);
            }

            label2.Text = sb.ToString();
        }
    }
}

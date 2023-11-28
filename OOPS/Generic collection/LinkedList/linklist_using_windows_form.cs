using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkedlist_using_windows_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<string> li = new LinkedList<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.AddLast(textBox1.Text);
            clear();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox1.Focus();
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

        private void button2_Click(object sender, EventArgs e)
        {
            li.AddFirst(textBox1.Text);
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedListNode<string> node = li.Find(textBox1.Text);
            li.AddBefore(node, textBox2.Text);
            clear();
            display();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Enabled = true;
            textBox2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            display();
            clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkedListNode<string> node2 = li.Find(textBox1.Text);
            li.AddAfter(node2, textBox2.Text);
            clear();
            display();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_generic_coll_wiindows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<int> s = new Stack<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            s.Push(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int i in s)
            {
                sb.AppendLine("ID: " +  i);
            }

            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.Pop();

            StringBuilder sb = new StringBuilder();
            foreach (int i in s)
            {
                sb.AppendLine("ID: " + i);
            }

            label2.Text = sb.ToString();

        }
    }
}

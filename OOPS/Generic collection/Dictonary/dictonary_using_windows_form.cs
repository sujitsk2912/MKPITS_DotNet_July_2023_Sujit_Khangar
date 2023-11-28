using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictonary_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> li = new Dictionary<int, string>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            li.Add(Convert.ToInt32(textBox1.Text),textBox2.Text);
            clear();

            //------------ key ---------------

            List<int> key = new List<int>(li.Keys);

            StringBuilder sb = new StringBuilder();

            foreach (int k in key)
            {
                sb.AppendLine("Key: " + k);
            }

            label3.Text = sb.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //------------ values ---------------

            List<string> val = new List<string>(li.Values);

            StringBuilder sb = new StringBuilder();

            foreach (string k in val)
            {
                sb.AppendLine("Values: " + k);
            }

            label3.Text = sb.ToString();
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<int, string> k in li)
            {
                sb.AppendLine("Key: " + k.Key + "    Value: " + k.Value);
            }

            label3.Text = sb.ToString();
        }
    }
}

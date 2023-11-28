using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace sorting_in_ArryList
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
            ar.Sort();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
      
            foreach (object obj in ar)
            {
                sb.Append("Name: " + obj + "\n");
                
            }

            label3.Text = sb.ToString();
        }
    }
}

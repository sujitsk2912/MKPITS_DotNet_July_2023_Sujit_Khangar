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

namespace product_class_using_arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product P;
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            P = new Product(Convert.ToInt32(textBox1.Text),textBox2.Text, Convert.ToInt32(textBox3.Text));
            ar.Add(P);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Product p in ar)
            {
                sb.Append("Product ID: " + p.pid + "\n");
                sb.Append("Product Name: " + p.name + "\n");
                sb.Append("Price: " + p.price + "\n");
                sb.AppendLine();
            }

            label5.Text = sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bank;

namespace bank_class_library_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account act = null;
        string res = null;

        private void button1_Click(object sender, EventArgs e)
        {
            act.acctno = Convert.ToInt32(textBox1.Text);
            res = act.deposite(act.acctno, Convert.ToInt32(textBox2.Text));
            label4.Text = res;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Savings")
            {
                act = new Saving();
            }
            else if (comboBox1.Text == "Current")
            {
                act = new Current();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.acctno = Convert.ToInt32(textBox1.Text);
            res = act.withdrawl(act.acctno, Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

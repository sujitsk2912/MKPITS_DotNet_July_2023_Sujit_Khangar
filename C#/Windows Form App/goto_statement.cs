using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goto_statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text);

            if (num % 2 == 0) // condition

            goto Even; // when condition is false then executes this condition like (else)
                 label2.Text = "Result: it is a Odd Number";
            goto End;

            Even: // when the condition is true then executes Even like (if)
                  // this is the Even condition....
            label2.Text = "Result: it is a Even Number";
            End:
                 label3.Text = "Bye";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_using_list__collection_in_windows_form
{
    public partial class Form1 : Form
    {
        internal class Attendance
        {
            public int Roll { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }

            public string atte { get; set; }


            public Attendance(int Roll, string Name, string Date, string atte)
            {
                this.Roll = Roll;
                this.Name = Name;
                this.Date = Date;
                this.atte = atte;

            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        int count_p = 0;
        int count_a = 0;

        Dictionary<int, Attendance> att = new Dictionary<int, Attendance>();
        Attendance A;
        private void button2_Click(object sender, EventArgs e)
        {

            A = new Attendance(Convert.ToInt32(textBox1.Text), textBox2.Text, dateTimePicker1.Text,radioButton1.Text);
            att.Add(Convert.ToInt32(textBox1.Text), A);

            if (radioButton1.Checked == true)
            {
                A.atte = "present";
                count_p++;
            }
            else
            {
                A.atte = "Absent";
                count_a++;
            }

            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<int, Attendance> at in att)
            {
                sb.AppendLine("Roll No: " + at.Key);
                sb.AppendLine("Name: " + at.Value.Name);
                sb.AppendLine("Date: " + at.Value.Date);
                sb.AppendLine("Attendance: " + at.Value.atte);
                sb.AppendLine();
            }

            richTextBox1.Text = sb.ToString();

            MessageBox.Show("Present students is :" + count_p + "\n" + "Absent students is :" + count_a);
        }
    }
}

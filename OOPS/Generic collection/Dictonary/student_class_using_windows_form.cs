using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_class_using_dictionary_in_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Student> stud = new Dictionary<int, Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            stud.Add(s.ID, s);
            clear();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<int, Student> kvp in stud)
            {
                sb.AppendLine("ID: " + kvp.Key + "   Name: " + kvp.Value.Name);
            }

            label3.Text = sb.ToString();
        }
    }
}

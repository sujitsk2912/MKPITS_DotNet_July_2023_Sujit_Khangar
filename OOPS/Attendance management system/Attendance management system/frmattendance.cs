using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmattendance : Form
    {
        public frmattendance()
        {
            InitializeComponent();
        }

        private void StudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void frmattendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sujitdbDataSet._student_data__8A_' table. You can move, or remove it, as needed.
            this.student_data__8A_TableAdapter.Fill(this.sujitdbDataSet._student_data__8A_);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }
    }
}

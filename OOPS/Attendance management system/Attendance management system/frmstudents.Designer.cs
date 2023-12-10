namespace Attendance_management_system
{
    partial class frmstudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmstudents
            // 
            this.ClientSize = new System.Drawing.Size(1730, 655);
            this.Name = "frmstudents";
            this.Load += new System.EventHandler(this.frmstudents_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtfirstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox txtstudentid;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnadd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btndelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnupdate;
        private System.Windows.Forms.ComboBox txtclass;
        private System.Windows.Forms.ComboBox txtsection;
        private System.Windows.Forms.Panel StudentPanel;
        private Bunifu.UI.WinForms.BunifuTextBox txtlastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentsRecordDataGridView;
        private sujitdbDataSet sujitdbDataSet;
        private System.Windows.Forms.BindingSource studentData8ABindingSource;
        private sujitdbDataSetTableAdapters.student_data__8A_TableAdapter student_data__8A_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private sujitdbDataSet sujitdbDataSet1;
        private System.Windows.Forms.BindingSource studentData8ABindingSource1;
        private sujitdbDataSetTableAdapters.student_data__8A_TableAdapter student_data__8A_TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
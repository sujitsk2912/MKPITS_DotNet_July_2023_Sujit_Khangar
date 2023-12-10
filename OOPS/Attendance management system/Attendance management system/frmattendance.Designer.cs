namespace Attendance_management_system
{
    partial class frmattendance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmattendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendancepanel = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.ComboBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtsubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtsection = new System.Windows.Forms.ComboBox();
            this.txtclass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuButton7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rOLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESENT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ABSENT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentData8ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sujitdbDataSet = new Attendance_management_system.sujitdbDataSet();
            this.student_data__8A_TableAdapter = new Attendance_management_system.sujitdbDataSetTableAdapters.student_data__8A_TableAdapter();
            this.attendancepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // attendancepanel
            // 
            this.attendancepanel.BackColor = System.Drawing.Color.GhostWhite;
            this.attendancepanel.Controls.Add(this.txtname);
            this.attendancepanel.Controls.Add(this.bunifuButton1);
            this.attendancepanel.Controls.Add(this.txtsubject);
            this.attendancepanel.Controls.Add(this.label4);
            this.attendancepanel.Controls.Add(this.label3);
            this.attendancepanel.Controls.Add(this.txtdate);
            this.attendancepanel.Controls.Add(this.txtsection);
            this.attendancepanel.Controls.Add(this.txtclass);
            this.attendancepanel.Controls.Add(this.label1);
            this.attendancepanel.Controls.Add(this.label7);
            this.attendancepanel.Controls.Add(this.label8);
            this.attendancepanel.Controls.Add(this.bunifuButton7);
            this.attendancepanel.Controls.Add(this.bunifuButton6);
            this.attendancepanel.Controls.Add(this.bunifuButton5);
            this.attendancepanel.Controls.Add(this.panel3);
            this.attendancepanel.Controls.Add(this.dataGridView1);
            this.attendancepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancepanel.Location = new System.Drawing.Point(0, 0);
            this.attendancepanel.MaximumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.MinimumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.Name = "attendancepanel";
            this.attendancepanel.Size = new System.Drawing.Size(1226, 664);
            this.attendancepanel.TabIndex = 7;
            this.attendancepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentPanel_Paint);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.GhostWhite;
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.FormattingEnabled = true;
            this.txtname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtname.Items.AddRange(new object[] {
            "Lucky Tambe",
            "Sujit Khangar",
            "Chetan Raut"});
            this.txtname.Location = new System.Drawing.Point(216, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(260, 31);
            this.txtname.TabIndex = 23;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.ForestGreen;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Submit";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 5;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 30;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton1.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(572, 600);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(135, 39);
            this.bunifuButton1.TabIndex = 22;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // txtsubject
            // 
            this.txtsubject.BackColor = System.Drawing.Color.GhostWhite;
            this.txtsubject.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.FormattingEnabled = true;
            this.txtsubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtsubject.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English"});
            this.txtsubject.Location = new System.Drawing.Point(216, 136);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(260, 31);
            this.txtsubject.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(127, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Subject: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(873, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date: ";
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(939, 74);
            this.txtdate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdate.Size = new System.Drawing.Size(141, 30);
            this.txtdate.TabIndex = 18;
            this.txtdate.Value = new System.DateTime(2023, 12, 7, 11, 59, 42, 0);
            // 
            // txtsection
            // 
            this.txtsection.BackColor = System.Drawing.Color.GhostWhite;
            this.txtsection.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsection.FormattingEnabled = true;
            this.txtsection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtsection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.txtsection.Location = new System.Drawing.Point(767, 74);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(72, 31);
            this.txtsection.TabIndex = 16;
            // 
            // txtclass
            // 
            this.txtclass.BackColor = System.Drawing.Color.GhostWhite;
            this.txtclass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclass.FormattingEnabled = true;
            this.txtclass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtclass.Items.AddRange(new object[] {
            "5th",
            "6th",
            "7th",
            "8th",
            "9th",
            "10th",
            "11th",
            "12th"});
            this.txtclass.Location = new System.Drawing.Point(572, 74);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(89, 31);
            this.txtclass.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(685, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Section: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(511, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Class: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Faculty Name: ";
            // 
            // bunifuButton7
            // 
            this.bunifuButton7.AllowAnimations = true;
            this.bunifuButton7.AllowMouseEffects = true;
            this.bunifuButton7.AllowToggling = false;
            this.bunifuButton7.AnimationSpeed = 200;
            this.bunifuButton7.AutoGenerateColors = false;
            this.bunifuButton7.AutoRoundBorders = false;
            this.bunifuButton7.AutoSizeLeftIcon = true;
            this.bunifuButton7.AutoSizeRightIcon = true;
            this.bunifuButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton7.BackgroundImage")));
            this.bunifuButton7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton7.ButtonText = "Edit";
            this.bunifuButton7.ButtonTextMarginLeft = 0;
            this.bunifuButton7.ColorContrastOnClick = 45;
            this.bunifuButton7.ColorContrastOnHover = 45;
            this.bunifuButton7.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton7.CustomizableEdges = borderEdges2;
            this.bunifuButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton7.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton7.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton7.ForeColor = System.Drawing.Color.White;
            this.bunifuButton7.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton7.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton7.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton7.IconMarginLeft = 11;
            this.bunifuButton7.IconPadding = 10;
            this.bunifuButton7.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton7.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton7.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton7.IconSize = 25;
            this.bunifuButton7.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.IdleBorderRadius = 1;
            this.bunifuButton7.IdleBorderThickness = 1;
            this.bunifuButton7.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.edit_solid_24;
            this.bunifuButton7.IdleIconRightImage = null;
            this.bunifuButton7.IndicateFocus = false;
            this.bunifuButton7.Location = new System.Drawing.Point(814, 163);
            this.bunifuButton7.Name = "bunifuButton7";
            this.bunifuButton7.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.OnDisabledState.BorderRadius = 1;
            this.bunifuButton7.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton7.OnDisabledState.BorderThickness = 1;
            this.bunifuButton7.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton7.OnDisabledState.IconLeftImage = null;
            this.bunifuButton7.OnDisabledState.IconRightImage = null;
            this.bunifuButton7.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton7.onHoverState.BorderRadius = 1;
            this.bunifuButton7.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton7.onHoverState.BorderThickness = 1;
            this.bunifuButton7.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton7.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton7.onHoverState.IconLeftImage = null;
            this.bunifuButton7.onHoverState.IconRightImage = null;
            this.bunifuButton7.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.OnIdleState.BorderRadius = 1;
            this.bunifuButton7.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton7.OnIdleState.BorderThickness = 1;
            this.bunifuButton7.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton7.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.edit_solid_24;
            this.bunifuButton7.OnIdleState.IconRightImage = null;
            this.bunifuButton7.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.OnPressedState.BorderRadius = 1;
            this.bunifuButton7.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton7.OnPressedState.BorderThickness = 1;
            this.bunifuButton7.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton7.OnPressedState.IconLeftImage = null;
            this.bunifuButton7.OnPressedState.IconRightImage = null;
            this.bunifuButton7.Size = new System.Drawing.Size(119, 39);
            this.bunifuButton7.TabIndex = 8;
            this.bunifuButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton7.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton7.TextMarginLeft = 0;
            this.bunifuButton7.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bunifuButton7.UseDefaultRadiusAndThickness = true;
            this.bunifuButton7.Click += new System.EventHandler(this.bunifuButton7_Click);
            // 
            // bunifuButton6
            // 
            this.bunifuButton6.AllowAnimations = true;
            this.bunifuButton6.AllowMouseEffects = true;
            this.bunifuButton6.AllowToggling = false;
            this.bunifuButton6.AnimationSpeed = 200;
            this.bunifuButton6.AutoGenerateColors = false;
            this.bunifuButton6.AutoRoundBorders = false;
            this.bunifuButton6.AutoSizeLeftIcon = true;
            this.bunifuButton6.AutoSizeRightIcon = true;
            this.bunifuButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton6.BackColor1 = System.Drawing.Color.Red;
            this.bunifuButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton6.BackgroundImage")));
            this.bunifuButton6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton6.ButtonText = "Delete";
            this.bunifuButton6.ButtonTextMarginLeft = 0;
            this.bunifuButton6.ColorContrastOnClick = 45;
            this.bunifuButton6.ColorContrastOnHover = 45;
            this.bunifuButton6.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton6.CustomizableEdges = borderEdges3;
            this.bunifuButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton6.DisabledFillColor = System.Drawing.Color.Red;
            this.bunifuButton6.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton6.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton6.ForeColor = System.Drawing.Color.White;
            this.bunifuButton6.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton6.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton6.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton6.IconMarginLeft = 11;
            this.bunifuButton6.IconPadding = 10;
            this.bunifuButton6.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton6.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton6.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton6.IconSize = 25;
            this.bunifuButton6.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton6.IdleBorderRadius = 1;
            this.bunifuButton6.IdleBorderThickness = 1;
            this.bunifuButton6.IdleFillColor = System.Drawing.Color.Red;
            this.bunifuButton6.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.bin;
            this.bunifuButton6.IdleIconRightImage = null;
            this.bunifuButton6.IndicateFocus = false;
            this.bunifuButton6.Location = new System.Drawing.Point(961, 163);
            this.bunifuButton6.Name = "bunifuButton6";
            this.bunifuButton6.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton6.OnDisabledState.BorderRadius = 1;
            this.bunifuButton6.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton6.OnDisabledState.BorderThickness = 1;
            this.bunifuButton6.OnDisabledState.FillColor = System.Drawing.Color.Red;
            this.bunifuButton6.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton6.OnDisabledState.IconLeftImage = null;
            this.bunifuButton6.OnDisabledState.IconRightImage = null;
            this.bunifuButton6.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton6.onHoverState.BorderRadius = 1;
            this.bunifuButton6.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton6.onHoverState.BorderThickness = 1;
            this.bunifuButton6.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton6.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton6.onHoverState.IconLeftImage = null;
            this.bunifuButton6.onHoverState.IconRightImage = null;
            this.bunifuButton6.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton6.OnIdleState.BorderRadius = 1;
            this.bunifuButton6.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton6.OnIdleState.BorderThickness = 1;
            this.bunifuButton6.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.bunifuButton6.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton6.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.bin;
            this.bunifuButton6.OnIdleState.IconRightImage = null;
            this.bunifuButton6.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton6.OnPressedState.BorderRadius = 1;
            this.bunifuButton6.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton6.OnPressedState.BorderThickness = 1;
            this.bunifuButton6.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.bunifuButton6.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton6.OnPressedState.IconLeftImage = null;
            this.bunifuButton6.OnPressedState.IconRightImage = null;
            this.bunifuButton6.Size = new System.Drawing.Size(119, 39);
            this.bunifuButton6.TabIndex = 7;
            this.bunifuButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton6.TextMarginLeft = 0;
            this.bunifuButton6.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bunifuButton6.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton5
            // 
            this.bunifuButton5.AllowAnimations = true;
            this.bunifuButton5.AllowMouseEffects = true;
            this.bunifuButton5.AllowToggling = false;
            this.bunifuButton5.AnimationSpeed = 200;
            this.bunifuButton5.AutoGenerateColors = false;
            this.bunifuButton5.AutoRoundBorders = false;
            this.bunifuButton5.AutoSizeLeftIcon = true;
            this.bunifuButton5.AutoSizeRightIcon = true;
            this.bunifuButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.BackColor1 = System.Drawing.Color.ForestGreen;
            this.bunifuButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton5.BackgroundImage")));
            this.bunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.ButtonText = "Enter";
            this.bunifuButton5.ButtonTextMarginLeft = 0;
            this.bunifuButton5.ColorContrastOnClick = 45;
            this.bunifuButton5.ColorContrastOnHover = 45;
            this.bunifuButton5.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton5.CustomizableEdges = borderEdges4;
            this.bunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton5.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.DisabledFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton5.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton5.IconMarginLeft = 11;
            this.bunifuButton5.IconPadding = 10;
            this.bunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton5.IconSize = 25;
            this.bunifuButton5.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.IdleBorderRadius = 1;
            this.bunifuButton5.IdleBorderThickness = 1;
            this.bunifuButton5.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton5.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.add_user;
            this.bunifuButton5.IdleIconRightImage = null;
            this.bunifuButton5.IndicateFocus = false;
            this.bunifuButton5.Location = new System.Drawing.Point(572, 142);
            this.bunifuButton5.Name = "bunifuButton5";
            this.bunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.OnDisabledState.BorderRadius = 1;
            this.bunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnDisabledState.BorderThickness = 1;
            this.bunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnDisabledState.IconLeftImage = null;
            this.bunifuButton5.OnDisabledState.IconRightImage = null;
            this.bunifuButton5.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton5.onHoverState.BorderRadius = 1;
            this.bunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.onHoverState.BorderThickness = 1;
            this.bunifuButton5.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton5.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.onHoverState.IconLeftImage = null;
            this.bunifuButton5.onHoverState.IconRightImage = null;
            this.bunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.OnIdleState.BorderRadius = 1;
            this.bunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnIdleState.BorderThickness = 1;
            this.bunifuButton5.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.add_user;
            this.bunifuButton5.OnIdleState.IconRightImage = null;
            this.bunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.OnPressedState.BorderRadius = 1;
            this.bunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnPressedState.BorderThickness = 1;
            this.bunifuButton5.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.bunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnPressedState.IconLeftImage = null;
            this.bunifuButton5.OnPressedState.IconRightImage = null;
            this.bunifuButton5.Size = new System.Drawing.Size(119, 39);
            this.bunifuButton5.TabIndex = 6;
            this.bunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton5.TextMarginLeft = 0;
            this.bunifuButton5.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bunifuButton5.UseDefaultRadiusAndThickness = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1226, 39);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attendance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOLLNODataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.PRESENT,
            this.ABSENT,
            this.EDIT,
            this.DELETE});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.studentData8ABindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(83, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rOLLNODataGridViewTextBoxColumn
            // 
            this.rOLLNODataGridViewTextBoxColumn.DataPropertyName = "ROLL NO";
            this.rOLLNODataGridViewTextBoxColumn.HeaderText = "ROLL NO";
            this.rOLLNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOLLNODataGridViewTextBoxColumn.Name = "rOLLNODataGridViewTextBoxColumn";
            this.rOLLNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            this.fIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PRESENT
            // 
            this.PRESENT.HeaderText = "PRESENT";
            this.PRESENT.MinimumWidth = 6;
            this.PRESENT.Name = "PRESENT";
            this.PRESENT.ReadOnly = true;
            // 
            // ABSENT
            // 
            this.ABSENT.HeaderText = "ABSENT";
            this.ABSENT.MinimumWidth = 6;
            this.ABSENT.Name = "ABSENT";
            this.ABSENT.ReadOnly = true;
            // 
            // EDIT
            // 
            this.EDIT.DataPropertyName = "ROLL NO";
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            // 
            // DELETE
            // 
            this.DELETE.DataPropertyName = "ROLL NO";
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            // 
            // studentData8ABindingSource
            // 
            this.studentData8ABindingSource.DataMember = "student data (8A)";
            this.studentData8ABindingSource.DataSource = this.sujitdbDataSet;
            // 
            // sujitdbDataSet
            // 
            this.sujitdbDataSet.DataSetName = "sujitdbDataSet";
            this.sujitdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_data__8A_TableAdapter
            // 
            this.student_data__8A_TableAdapter.ClearBeforeFill = true;
            // 
            // frmattendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1226, 664);
            this.Controls.Add(this.attendancepanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1226, 664);
            this.MinimumSize = new System.Drawing.Size(1226, 664);
            this.Name = "frmattendance";
            this.Text = "frmattendance";
            this.Load += new System.EventHandler(this.frmattendance_Load);
            this.attendancepanel.ResumeLayout(false);
            this.attendancepanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancepanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtsection;
        private System.Windows.Forms.ComboBox txtclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtsubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.ComboBox txtname;
        private sujitdbDataSet sujitdbDataSet;
        private System.Windows.Forms.BindingSource studentData8ABindingSource;
        private sujitdbDataSetTableAdapters.student_data__8A_TableAdapter student_data__8A_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PRESENT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ABSENT;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}
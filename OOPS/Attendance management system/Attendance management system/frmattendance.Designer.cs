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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentData8ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sujitdbDataSet = new Attendance_management_system.sujitdbDataSet();
            this.student_data__8A_TableAdapter = new Attendance_management_system.sujitdbDataSetTableAdapters.student_data__8A_TableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.attendancepanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbatch = new System.Windows.Forms.ComboBox();
            this.txtfacultyname = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnenter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AttendanceRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.HeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderLate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentData8ABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sujitdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.attendancepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // attendancepanel
            // 
            this.attendancepanel.BackColor = System.Drawing.Color.GhostWhite;
            this.attendancepanel.Controls.Add(this.label5);
            this.attendancepanel.Controls.Add(this.txtbatch);
            this.attendancepanel.Controls.Add(this.txtfacultyname);
            this.attendancepanel.Controls.Add(this.btnsubmit);
            this.attendancepanel.Controls.Add(this.label3);
            this.attendancepanel.Controls.Add(this.txtdate);
            this.attendancepanel.Controls.Add(this.label8);
            this.attendancepanel.Controls.Add(this.btnenter);
            this.attendancepanel.Controls.Add(this.panel3);
            this.attendancepanel.Controls.Add(this.AttendanceRecordDataGridView);
            this.attendancepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancepanel.Location = new System.Drawing.Point(0, 0);
            this.attendancepanel.MaximumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.MinimumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.Name = "attendancepanel";
            this.attendancepanel.Size = new System.Drawing.Size(1226, 664);
            this.attendancepanel.TabIndex = 7;
            this.attendancepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.attendancepanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(566, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Batch: ";
            // 
            // txtbatch
            // 
            this.txtbatch.BackColor = System.Drawing.Color.GhostWhite;
            this.txtbatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbatch.FormattingEnabled = true;
            this.txtbatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtbatch.Items.AddRange(new object[] {
            "Java",
            "DotNet"});
            this.txtbatch.Location = new System.Drawing.Point(641, 82);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(144, 31);
            this.txtbatch.TabIndex = 25;
            this.txtbatch.Text = "Java";
            // 
            // txtfacultyname
            // 
            this.txtfacultyname.BackColor = System.Drawing.Color.GhostWhite;
            this.txtfacultyname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacultyname.FormattingEnabled = true;
            this.txtfacultyname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtfacultyname.Location = new System.Drawing.Point(327, 82);
            this.txtfacultyname.Name = "txtfacultyname";
            this.txtfacultyname.Size = new System.Drawing.Size(195, 31);
            this.txtfacultyname.TabIndex = 23;
            // 
            // btnsubmit
            // 
            this.btnsubmit.AllowAnimations = true;
            this.btnsubmit.AllowMouseEffects = true;
            this.btnsubmit.AllowToggling = false;
            this.btnsubmit.AnimationSpeed = 200;
            this.btnsubmit.AutoGenerateColors = false;
            this.btnsubmit.AutoRoundBorders = false;
            this.btnsubmit.AutoSizeLeftIcon = true;
            this.btnsubmit.AutoSizeRightIcon = true;
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsubmit.BackgroundImage")));
            this.btnsubmit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsubmit.ButtonText = "Submit";
            this.btnsubmit.ButtonTextMarginLeft = 0;
            this.btnsubmit.ColorContrastOnClick = 45;
            this.btnsubmit.ColorContrastOnHover = 45;
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnsubmit.CustomizableEdges = borderEdges1;
            this.btnsubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsubmit.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnsubmit.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnsubmit.DisabledForecolor = System.Drawing.Color.Black;
            this.btnsubmit.Enabled = false;
            this.btnsubmit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnsubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnsubmit.IconLeftPadding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnsubmit.IconMarginLeft = 11;
            this.btnsubmit.IconPadding = 5;
            this.btnsubmit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnsubmit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnsubmit.IconSize = 30;
            this.btnsubmit.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnsubmit.IdleBorderRadius = 1;
            this.btnsubmit.IdleBorderThickness = 1;
            this.btnsubmit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnsubmit.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.btnsubmit.IdleIconRightImage = null;
            this.btnsubmit.IndicateFocus = false;
            this.btnsubmit.Location = new System.Drawing.Point(546, 603);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsubmit.OnDisabledState.BorderRadius = 1;
            this.btnsubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsubmit.OnDisabledState.BorderThickness = 1;
            this.btnsubmit.OnDisabledState.FillColor = System.Drawing.Color.LightGray;
            this.btnsubmit.OnDisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnsubmit.OnDisabledState.IconLeftImage = null;
            this.btnsubmit.OnDisabledState.IconRightImage = null;
            this.btnsubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsubmit.onHoverState.BorderRadius = 1;
            this.btnsubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsubmit.onHoverState.BorderThickness = 1;
            this.btnsubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.onHoverState.IconLeftImage = null;
            this.btnsubmit.onHoverState.IconRightImage = null;
            this.btnsubmit.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsubmit.OnIdleState.BorderRadius = 1;
            this.btnsubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsubmit.OnIdleState.BorderThickness = 1;
            this.btnsubmit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnsubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.btnsubmit.OnIdleState.IconRightImage = null;
            this.btnsubmit.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsubmit.OnPressedState.BorderRadius = 1;
            this.btnsubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsubmit.OnPressedState.BorderThickness = 1;
            this.btnsubmit.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnsubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.OnPressedState.IconLeftImage = null;
            this.btnsubmit.OnPressedState.IconRightImage = null;
            this.btnsubmit.Size = new System.Drawing.Size(181, 39);
            this.btnsubmit.TabIndex = 22;
            this.btnsubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsubmit.TextMarginLeft = 0;
            this.btnsubmit.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsubmit.UseDefaultRadiusAndThickness = true;
            this.btnsubmit.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(855, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date: ";
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(921, 82);
            this.txtdate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(137, 30);
            this.txtdate.TabIndex = 18;
            this.txtdate.Value = new System.DateTime(2023, 12, 15, 0, 53, 1, 0);
            this.txtdate.ValueChanged += new System.EventHandler(this.txtdate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Faculty Name: ";
            // 
            // btnenter
            // 
            this.btnenter.AllowAnimations = true;
            this.btnenter.AllowMouseEffects = true;
            this.btnenter.AllowToggling = false;
            this.btnenter.AnimationSpeed = 200;
            this.btnenter.AutoGenerateColors = false;
            this.btnenter.AutoRoundBorders = false;
            this.btnenter.AutoSizeLeftIcon = true;
            this.btnenter.AutoSizeRightIcon = true;
            this.btnenter.BackColor = System.Drawing.Color.Transparent;
            this.btnenter.BackColor1 = System.Drawing.Color.ForestGreen;
            this.btnenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnenter.BackgroundImage")));
            this.btnenter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.ButtonText = "Enter";
            this.btnenter.ButtonTextMarginLeft = 0;
            this.btnenter.ColorContrastOnClick = 45;
            this.btnenter.ColorContrastOnHover = 45;
            this.btnenter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnenter.CustomizableEdges = borderEdges2;
            this.btnenter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnenter.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnenter.DisabledFillColor = System.Drawing.Color.ForestGreen;
            this.btnenter.DisabledForecolor = System.Drawing.Color.White;
            this.btnenter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnenter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnenter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnenter.IconMarginLeft = 11;
            this.btnenter.IconPadding = 10;
            this.btnenter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnenter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnenter.IconSize = 25;
            this.btnenter.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnenter.IdleBorderRadius = 1;
            this.btnenter.IdleBorderThickness = 1;
            this.btnenter.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.btnenter.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.add_user;
            this.btnenter.IdleIconRightImage = null;
            this.btnenter.IndicateFocus = false;
            this.btnenter.Location = new System.Drawing.Point(558, 153);
            this.btnenter.Name = "btnenter";
            this.btnenter.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnenter.OnDisabledState.BorderRadius = 1;
            this.btnenter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.OnDisabledState.BorderThickness = 1;
            this.btnenter.OnDisabledState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnenter.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnenter.OnDisabledState.IconLeftImage = null;
            this.btnenter.OnDisabledState.IconRightImage = null;
            this.btnenter.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnenter.onHoverState.BorderRadius = 1;
            this.btnenter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.onHoverState.BorderThickness = 1;
            this.btnenter.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnenter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnenter.onHoverState.IconLeftImage = null;
            this.btnenter.onHoverState.IconRightImage = null;
            this.btnenter.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnenter.OnIdleState.BorderRadius = 1;
            this.btnenter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.OnIdleState.BorderThickness = 1;
            this.btnenter.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnenter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnenter.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.add_user;
            this.btnenter.OnIdleState.IconRightImage = null;
            this.btnenter.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnenter.OnPressedState.BorderRadius = 1;
            this.btnenter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.OnPressedState.BorderThickness = 1;
            this.btnenter.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnenter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnenter.OnPressedState.IconLeftImage = null;
            this.btnenter.OnPressedState.IconRightImage = null;
            this.btnenter.Size = new System.Drawing.Size(157, 39);
            this.btnenter.TabIndex = 6;
            this.btnenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnenter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenter.TextMarginLeft = 0;
            this.btnenter.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnenter.UseDefaultRadiusAndThickness = true;
            this.btnenter.Click += new System.EventHandler(this.bunifuButton5_Click);
            // 
            // AttendanceRecordDataGridView
            // 
            this.AttendanceRecordDataGridView.AllowUserToAddRows = false;
            this.AttendanceRecordDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AttendanceRecordDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendanceRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceRecordDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AttendanceRecordDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttendanceRecordDataGridView.ColumnHeadersHeight = 40;
            this.AttendanceRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderID,
            this.HeaderName,
            this.HeaderBatch,
            this.HeaderPresent,
            this.HeaderAbsent,
            this.HeaderLate});
            this.AttendanceRecordDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceRecordDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.AttendanceRecordDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.AttendanceRecordDataGridView.Location = new System.Drawing.Point(83, 223);
            this.AttendanceRecordDataGridView.Name = "AttendanceRecordDataGridView";
            this.AttendanceRecordDataGridView.ReadOnly = true;
            this.AttendanceRecordDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.AttendanceRecordDataGridView.RowHeadersWidth = 50;
            this.AttendanceRecordDataGridView.RowTemplate.Height = 24;
            this.AttendanceRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceRecordDataGridView.Size = new System.Drawing.Size(1065, 356);
            this.AttendanceRecordDataGridView.TabIndex = 1;
            this.AttendanceRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceRecordDataGridView_CellClick);
            this.AttendanceRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.AttendanceRecordDataGridView.Click += new System.EventHandler(this.AttendanceRecordDataGridView_Click);
            // 
            // HeaderID
            // 
            this.HeaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderID.DataPropertyName = "STUDENT ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderID.DefaultCellStyle = dataGridViewCellStyle3;
            this.HeaderID.HeaderText = "STUDENT ID";
            this.HeaderID.MinimumWidth = 6;
            this.HeaderID.Name = "HeaderID";
            this.HeaderID.ReadOnly = true;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderName.DataPropertyName = "FULLNAME";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderName.DefaultCellStyle = dataGridViewCellStyle4;
            this.HeaderName.HeaderText = "NAME";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.ReadOnly = true;
            // 
            // HeaderBatch
            // 
            this.HeaderBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderBatch.DataPropertyName = "COURSE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderBatch.DefaultCellStyle = dataGridViewCellStyle5;
            this.HeaderBatch.HeaderText = "BATCH";
            this.HeaderBatch.MinimumWidth = 6;
            this.HeaderBatch.Name = "HeaderBatch";
            this.HeaderBatch.ReadOnly = true;
            // 
            // HeaderPresent
            // 
            this.HeaderPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderPresent.HeaderText = "PRESENT";
            this.HeaderPresent.MinimumWidth = 6;
            this.HeaderPresent.Name = "HeaderPresent";
            this.HeaderPresent.ReadOnly = true;
            // 
            // HeaderAbsent
            // 
            this.HeaderAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderAbsent.HeaderText = "ABSENT";
            this.HeaderAbsent.MinimumWidth = 6;
            this.HeaderAbsent.Name = "HeaderAbsent";
            this.HeaderAbsent.ReadOnly = true;
            // 
            // HeaderLate
            // 
            this.HeaderLate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderLate.HeaderText = "LATE";
            this.HeaderLate.MinimumWidth = 6;
            this.HeaderLate.Name = "HeaderLate";
            this.HeaderLate.ReadOnly = true;
            this.HeaderLate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // studentData8ABindingSource1
            // 
            this.studentData8ABindingSource1.DataMember = "student data (8A)";
            this.studentData8ABindingSource1.DataSource = this.sujitdbDataSet;
            // 
            // sujitdbDataSetBindingSource
            // 
            this.sujitdbDataSetBindingSource.DataSource = this.sujitdbDataSet;
            this.sujitdbDataSetBindingSource.Position = 0;
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
            this.Activated += new System.EventHandler(this.frmattendance_Activated);
            this.Load += new System.EventHandler(this.frmattendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.attendancepanel.ResumeLayout(false);
            this.attendancepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private sujitdbDataSet sujitdbDataSet;
        private System.Windows.Forms.BindingSource studentData8ABindingSource;
        private sujitdbDataSetTableAdapters.student_data__8A_TableAdapter student_data__8A_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel attendancepanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtbatch;
        private System.Windows.Forms.ComboBox txtfacultyname;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnsubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnenter;
        private System.Windows.Forms.DataGridView AttendanceRecordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderBatch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderAbsent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderLate;
        private System.Windows.Forms.BindingSource sujitdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentData8ABindingSource1;
    }
}
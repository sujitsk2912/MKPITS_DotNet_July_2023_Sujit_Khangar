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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmattendance));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.attendancepanel = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AttendanceRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.HeaderStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderLate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentData8ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sujitdbDataSet = new Attendance_management_system.sujitdbDataSet();
            this.student_data__8A_TableAdapter = new Attendance_management_system.sujitdbDataSetTableAdapters.student_data__8A_TableAdapter();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcourse = new System.Windows.Forms.ComboBox();
            this.txtfacultyid = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attendancepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // attendancepanel
            // 
            this.attendancepanel.BackColor = System.Drawing.Color.GhostWhite;
            this.attendancepanel.Controls.Add(this.txtfacultyid);
            this.attendancepanel.Controls.Add(this.label1);
            this.attendancepanel.Controls.Add(this.label5);
            this.attendancepanel.Controls.Add(this.txtcourse);
            this.attendancepanel.Controls.Add(this.txtname);
            this.attendancepanel.Controls.Add(this.bunifuButton1);
            this.attendancepanel.Controls.Add(this.label3);
            this.attendancepanel.Controls.Add(this.txtdate);
            this.attendancepanel.Controls.Add(this.label8);
            this.attendancepanel.Controls.Add(this.bunifuButton5);
            this.attendancepanel.Controls.Add(this.panel3);
            this.attendancepanel.Controls.Add(this.AttendanceRecordDataGridView);
            this.attendancepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancepanel.Location = new System.Drawing.Point(0, 0);
            this.attendancepanel.MaximumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.MinimumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.Name = "attendancepanel";
            this.attendancepanel.Size = new System.Drawing.Size(1226, 664);
            this.attendancepanel.TabIndex = 7;
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
            this.txtname.Location = new System.Drawing.Point(350, 76);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(260, 31);
            this.txtname.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(669, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date: ";
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(735, 137);
            this.txtdate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(132, 30);
            this.txtdate.TabIndex = 18;
            this.txtdate.Value = new System.DateTime(2023, 12, 15, 0, 53, 1, 0);
            this.txtdate.ValueChanged += new System.EventHandler(this.txtdate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Faculty Name: ";
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
            // AttendanceRecordDataGridView
            // 
            this.AttendanceRecordDataGridView.AllowUserToAddRows = false;
            this.AttendanceRecordDataGridView.AllowUserToDeleteRows = false;
            this.AttendanceRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceRecordDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AttendanceRecordDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AttendanceRecordDataGridView.ColumnHeadersHeight = 40;
            this.AttendanceRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderStudentID,
            this.HeaderName,
            this.HeaderClass,
            this.HeaderSection,
            this.HeaderPresent,
            this.HeaderAbsent,
            this.HeaderLate});
            this.AttendanceRecordDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceRecordDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.AttendanceRecordDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.AttendanceRecordDataGridView.Location = new System.Drawing.Point(83, 262);
            this.AttendanceRecordDataGridView.Name = "AttendanceRecordDataGridView";
            this.AttendanceRecordDataGridView.ReadOnly = true;
            this.AttendanceRecordDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.AttendanceRecordDataGridView.RowHeadersWidth = 50;
            this.AttendanceRecordDataGridView.RowTemplate.Height = 24;
            this.AttendanceRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceRecordDataGridView.Size = new System.Drawing.Size(1065, 334);
            this.AttendanceRecordDataGridView.TabIndex = 0;
            this.AttendanceRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceRecordDataGridView_CellClick);
            this.AttendanceRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HeaderStudentID
            // 
            this.HeaderStudentID.DataPropertyName = "STUDENT ID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderStudentID.DefaultCellStyle = dataGridViewCellStyle9;
            this.HeaderStudentID.HeaderText = "STUDENT ID";
            this.HeaderStudentID.MinimumWidth = 6;
            this.HeaderStudentID.Name = "HeaderStudentID";
            this.HeaderStudentID.ReadOnly = true;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderName.DataPropertyName = "NAME";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderName.DefaultCellStyle = dataGridViewCellStyle10;
            this.HeaderName.HeaderText = "NAME";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.ReadOnly = true;
            // 
            // HeaderClass
            // 
            this.HeaderClass.DataPropertyName = "CLASS";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderClass.DefaultCellStyle = dataGridViewCellStyle11;
            this.HeaderClass.HeaderText = "CLASS";
            this.HeaderClass.MinimumWidth = 6;
            this.HeaderClass.Name = "HeaderClass";
            this.HeaderClass.ReadOnly = true;
            // 
            // HeaderSection
            // 
            this.HeaderSection.DataPropertyName = "SECTION";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderSection.DefaultCellStyle = dataGridViewCellStyle12;
            this.HeaderSection.HeaderText = "SECTION";
            this.HeaderSection.MinimumWidth = 6;
            this.HeaderSection.Name = "HeaderSection";
            this.HeaderSection.ReadOnly = true;
            // 
            // HeaderPresent
            // 
            this.HeaderPresent.HeaderText = "PRESENT";
            this.HeaderPresent.MinimumWidth = 6;
            this.HeaderPresent.Name = "HeaderPresent";
            this.HeaderPresent.ReadOnly = true;
            // 
            // HeaderAbsent
            // 
            this.HeaderAbsent.HeaderText = "ABSENT";
            this.HeaderAbsent.MinimumWidth = 6;
            this.HeaderAbsent.Name = "HeaderAbsent";
            this.HeaderAbsent.ReadOnly = true;
            // 
            // HeaderLate
            // 
            this.HeaderLate.HeaderText = "LATE";
            this.HeaderLate.MinimumWidth = 6;
            this.HeaderLate.Name = "HeaderLate";
            this.HeaderLate.ReadOnly = true;
            this.HeaderLate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Submit";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
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
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(545, 613);
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
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
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
            this.bunifuButton1.Size = new System.Drawing.Size(181, 39);
            this.bunifuButton1.TabIndex = 22;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
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
            this.bunifuButton5.Location = new System.Drawing.Point(544, 208);
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
            this.bunifuButton5.Size = new System.Drawing.Size(157, 39);
            this.bunifuButton5.TabIndex = 6;
            this.bunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton5.TextMarginLeft = 0;
            this.bunifuButton5.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bunifuButton5.UseDefaultRadiusAndThickness = true;
            this.bunifuButton5.Click += new System.EventHandler(this.bunifuButton5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(660, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Batch: ";
            // 
            // txtcourse
            // 
            this.txtcourse.BackColor = System.Drawing.Color.GhostWhite;
            this.txtcourse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.FormattingEnabled = true;
            this.txtcourse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtcourse.Items.AddRange(new object[] {
            "Java",
            "DotNet"});
            this.txtcourse.Location = new System.Drawing.Point(735, 76);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(218, 31);
            this.txtcourse.TabIndex = 25;
            // 
            // txtfacultyid
            // 
            this.txtfacultyid.AcceptsReturn = false;
            this.txtfacultyid.AcceptsTab = false;
            this.txtfacultyid.AnimationSpeed = 200;
            this.txtfacultyid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtfacultyid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtfacultyid.BackColor = System.Drawing.Color.Transparent;
            this.txtfacultyid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtfacultyid.BackgroundImage")));
            this.txtfacultyid.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtfacultyid.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtfacultyid.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtfacultyid.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtfacultyid.BorderRadius = 1;
            this.txtfacultyid.BorderThickness = 1;
            this.txtfacultyid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtfacultyid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfacultyid.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtfacultyid.DefaultText = "";
            this.txtfacultyid.FillColor = System.Drawing.Color.GhostWhite;
            this.txtfacultyid.HideSelection = true;
            this.txtfacultyid.IconLeft = null;
            this.txtfacultyid.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfacultyid.IconPadding = 10;
            this.txtfacultyid.IconRight = null;
            this.txtfacultyid.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfacultyid.Lines = new string[0];
            this.txtfacultyid.Location = new System.Drawing.Point(350, 124);
            this.txtfacultyid.MaxLength = 32767;
            this.txtfacultyid.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtfacultyid.Modified = false;
            this.txtfacultyid.Multiline = false;
            this.txtfacultyid.Name = "txtfacultyid";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtfacultyid.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtfacultyid.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtfacultyid.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.GhostWhite;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtfacultyid.OnIdleState = stateProperties8;
            this.txtfacultyid.Padding = new System.Windows.Forms.Padding(3);
            this.txtfacultyid.PasswordChar = '\0';
            this.txtfacultyid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtfacultyid.PlaceholderText = "";
            this.txtfacultyid.ReadOnly = false;
            this.txtfacultyid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfacultyid.SelectedText = "";
            this.txtfacultyid.SelectionLength = 0;
            this.txtfacultyid.SelectionStart = 0;
            this.txtfacultyid.ShortcutsEnabled = true;
            this.txtfacultyid.Size = new System.Drawing.Size(260, 43);
            this.txtfacultyid.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtfacultyid.TabIndex = 27;
            this.txtfacultyid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfacultyid.TextMarginBottom = 0;
            this.txtfacultyid.TextMarginLeft = 3;
            this.txtfacultyid.TextMarginTop = 0;
            this.txtfacultyid.TextPlaceholder = "";
            this.txtfacultyid.UseSystemPasswordChar = false;
            this.txtfacultyid.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(236, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Faculty ID: ";
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
            this.attendancepanel.ResumeLayout(false);
            this.attendancepanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData8ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sujitdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancepanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton5;
        private System.Windows.Forms.DataGridView AttendanceRecordDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.ComboBox txtname;
        private sujitdbDataSet sujitdbDataSet;
        private System.Windows.Forms.BindingSource studentData8ABindingSource;
        private sujitdbDataSetTableAdapters.student_data__8A_TableAdapter student_data__8A_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderSection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderAbsent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderLate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtcourse;
        private Bunifu.UI.WinForms.BunifuTextBox txtfacultyid;
        private System.Windows.Forms.Label label1;
    }
}
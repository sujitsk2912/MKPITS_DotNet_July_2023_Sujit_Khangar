namespace Attendance_management_system
{
    partial class blank2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blank2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderLate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbatch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.attendancepanel = new System.Windows.Forms.Panel();
            this.AttendanceRecordDataGridView1 = new System.Windows.Forms.DataGridView();
            this.HeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnupdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btndelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnedit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnsearchrecord = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3.SuspendLayout();
            this.attendancepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderDate
            // 
            this.HeaderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderDate.DataPropertyName = "DATE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.HeaderDate.HeaderText = "DATE";
            this.HeaderDate.MinimumWidth = 6;
            this.HeaderDate.Name = "HeaderDate";
            this.HeaderDate.ReadOnly = true;
            // 
            // HeaderLate
            // 
            this.HeaderLate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderLate.DataPropertyName = "LATE";
            this.HeaderLate.HeaderText = "LATE";
            this.HeaderLate.MinimumWidth = 6;
            this.HeaderLate.Name = "HeaderLate";
            this.HeaderLate.ReadOnly = true;
            // 
            // HeaderAbsent
            // 
            this.HeaderAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderAbsent.DataPropertyName = "ABSENT";
            this.HeaderAbsent.HeaderText = "ABSENT";
            this.HeaderAbsent.MinimumWidth = 6;
            this.HeaderAbsent.Name = "HeaderAbsent";
            this.HeaderAbsent.ReadOnly = true;
            // 
            // HeaderPresent
            // 
            this.HeaderPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderPresent.DataPropertyName = "PRESENT";
            this.HeaderPresent.HeaderText = "PRESENT";
            this.HeaderPresent.MinimumWidth = 6;
            this.HeaderPresent.Name = "HeaderPresent";
            this.HeaderPresent.ReadOnly = true;
            this.HeaderPresent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HeaderBatch
            // 
            this.HeaderBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderBatch.DataPropertyName = "BATCH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderBatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.HeaderBatch.HeaderText = "BATCH";
            this.HeaderBatch.MinimumWidth = 6;
            this.HeaderBatch.Name = "HeaderBatch";
            this.HeaderBatch.ReadOnly = true;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderName.DataPropertyName = "NAME";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderName.DefaultCellStyle = dataGridViewCellStyle3;
            this.HeaderName.HeaderText = "NAME";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attendance Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(365, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Batch: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.txtbatch.Location = new System.Drawing.Point(437, 60);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(144, 31);
            this.txtbatch.TabIndex = 25;
            this.txtbatch.Text = "Java";
            this.txtbatch.SelectedIndexChanged += new System.EventHandler(this.txtbatch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(674, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(740, 60);
            this.txtdate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(129, 22);
            this.txtdate.TabIndex = 18;
            this.txtdate.Value = new System.DateTime(2023, 12, 15, 0, 53, 1, 0);
            this.txtdate.ValueChanged += new System.EventHandler(this.txtdate_ValueChanged);
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
            // attendancepanel
            // 
            this.attendancepanel.BackColor = System.Drawing.Color.GhostWhite;
            this.attendancepanel.Controls.Add(this.btnupdate);
            this.attendancepanel.Controls.Add(this.btndelete);
            this.attendancepanel.Controls.Add(this.btnedit);
            this.attendancepanel.Controls.Add(this.label5);
            this.attendancepanel.Controls.Add(this.txtbatch);
            this.attendancepanel.Controls.Add(this.label3);
            this.attendancepanel.Controls.Add(this.txtdate);
            this.attendancepanel.Controls.Add(this.btnsearchrecord);
            this.attendancepanel.Controls.Add(this.panel3);
            this.attendancepanel.Controls.Add(this.AttendanceRecordDataGridView1);
            this.attendancepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancepanel.Location = new System.Drawing.Point(0, 0);
            this.attendancepanel.MaximumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.MinimumSize = new System.Drawing.Size(1226, 664);
            this.attendancepanel.Name = "attendancepanel";
            this.attendancepanel.Size = new System.Drawing.Size(1226, 664);
            this.attendancepanel.TabIndex = 9;
            // 
            // AttendanceRecordDataGridView1
            // 
            this.AttendanceRecordDataGridView1.AllowUserToAddRows = false;
            this.AttendanceRecordDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AttendanceRecordDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AttendanceRecordDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceRecordDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AttendanceRecordDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AttendanceRecordDataGridView1.ColumnHeadersHeight = 40;
            this.AttendanceRecordDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderID,
            this.HeaderName,
            this.HeaderBatch,
            this.HeaderPresent,
            this.HeaderAbsent,
            this.HeaderLate,
            this.HeaderDate});
            this.AttendanceRecordDataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceRecordDataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.AttendanceRecordDataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.AttendanceRecordDataGridView1.Location = new System.Drawing.Point(85, 176);
            this.AttendanceRecordDataGridView1.Name = "AttendanceRecordDataGridView1";
            this.AttendanceRecordDataGridView1.ReadOnly = true;
            this.AttendanceRecordDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AttendanceRecordDataGridView1.RowHeadersWidth = 50;
            this.AttendanceRecordDataGridView1.RowTemplate.Height = 24;
            this.AttendanceRecordDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceRecordDataGridView1.Size = new System.Drawing.Size(1057, 421);
            this.AttendanceRecordDataGridView1.TabIndex = 0;
            this.AttendanceRecordDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceRecordDataGridView1_CellContentClick);
            // 
            // HeaderID
            // 
            this.HeaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderID.DataPropertyName = "STUDENT ID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderID.DefaultCellStyle = dataGridViewCellStyle6;
            this.HeaderID.HeaderText = "STUDENT ID";
            this.HeaderID.MinimumWidth = 6;
            this.HeaderID.Name = "HeaderID";
            this.HeaderID.ReadOnly = true;
            // 
            // btnupdate
            // 
            this.btnupdate.AllowAnimations = true;
            this.btnupdate.AllowMouseEffects = true;
            this.btnupdate.AllowToggling = false;
            this.btnupdate.AnimationSpeed = 200;
            this.btnupdate.AutoGenerateColors = false;
            this.btnupdate.AutoRoundBorders = false;
            this.btnupdate.AutoSizeLeftIcon = true;
            this.btnupdate.AutoSizeRightIcon = true;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnupdate.ButtonText = "Update";
            this.btnupdate.ButtonTextMarginLeft = 0;
            this.btnupdate.ColorContrastOnClick = 45;
            this.btnupdate.ColorContrastOnHover = 45;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnupdate.CustomizableEdges = borderEdges1;
            this.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnupdate.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnupdate.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.DisabledForecolor = System.Drawing.Color.White;
            this.btnupdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnupdate.IconMarginLeft = 11;
            this.btnupdate.IconPadding = 10;
            this.btnupdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnupdate.IconSize = 25;
            this.btnupdate.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnupdate.IdleBorderRadius = 1;
            this.btnupdate.IdleBorderThickness = 1;
            this.btnupdate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.btnupdate.IdleIconRightImage = null;
            this.btnupdate.IndicateFocus = false;
            this.btnupdate.Location = new System.Drawing.Point(567, 613);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnupdate.OnDisabledState.BorderRadius = 1;
            this.btnupdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnupdate.OnDisabledState.BorderThickness = 1;
            this.btnupdate.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnupdate.OnDisabledState.IconLeftImage = null;
            this.btnupdate.OnDisabledState.IconRightImage = null;
            this.btnupdate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnupdate.onHoverState.BorderRadius = 1;
            this.btnupdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnupdate.onHoverState.BorderThickness = 1;
            this.btnupdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnupdate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnupdate.onHoverState.IconLeftImage = null;
            this.btnupdate.onHoverState.IconRightImage = null;
            this.btnupdate.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnupdate.OnIdleState.BorderRadius = 1;
            this.btnupdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnupdate.OnIdleState.BorderThickness = 1;
            this.btnupdate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnupdate.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.apply;
            this.btnupdate.OnIdleState.IconRightImage = null;
            this.btnupdate.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnupdate.OnPressedState.BorderRadius = 1;
            this.btnupdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnupdate.OnPressedState.BorderThickness = 1;
            this.btnupdate.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnupdate.OnPressedState.IconLeftImage = null;
            this.btnupdate.OnPressedState.IconRightImage = null;
            this.btnupdate.Size = new System.Drawing.Size(133, 39);
            this.btnupdate.TabIndex = 32;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnupdate.TextMarginLeft = 0;
            this.btnupdate.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnupdate.UseDefaultRadiusAndThickness = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.AllowAnimations = true;
            this.btndelete.AllowMouseEffects = true;
            this.btndelete.AllowToggling = false;
            this.btndelete.AnimationSpeed = 200;
            this.btndelete.AutoGenerateColors = false;
            this.btndelete.AutoRoundBorders = false;
            this.btndelete.AutoSizeLeftIcon = true;
            this.btndelete.AutoSizeRightIcon = true;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BackColor1 = System.Drawing.Color.Red;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.ButtonTextMarginLeft = 0;
            this.btndelete.ColorContrastOnClick = 45;
            this.btndelete.ColorContrastOnHover = 45;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btndelete.CustomizableEdges = borderEdges2;
            this.btndelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btndelete.DisabledFillColor = System.Drawing.Color.Red;
            this.btndelete.DisabledForecolor = System.Drawing.Color.White;
            this.btndelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btndelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btndelete.IconMarginLeft = 11;
            this.btndelete.IconPadding = 10;
            this.btndelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btndelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btndelete.IconSize = 25;
            this.btndelete.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btndelete.IdleBorderRadius = 1;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleFillColor = System.Drawing.Color.Red;
            this.btndelete.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.bin;
            this.btndelete.IdleIconRightImage = null;
            this.btndelete.IndicateFocus = false;
            this.btndelete.Location = new System.Drawing.Point(736, 613);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btndelete.OnDisabledState.BorderRadius = 1;
            this.btndelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndelete.OnDisabledState.BorderThickness = 1;
            this.btndelete.OnDisabledState.FillColor = System.Drawing.Color.Red;
            this.btndelete.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btndelete.OnDisabledState.IconLeftImage = null;
            this.btndelete.OnDisabledState.IconRightImage = null;
            this.btndelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btndelete.onHoverState.BorderRadius = 1;
            this.btndelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndelete.onHoverState.BorderThickness = 1;
            this.btndelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btndelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btndelete.onHoverState.IconLeftImage = null;
            this.btndelete.onHoverState.IconRightImage = null;
            this.btndelete.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btndelete.OnIdleState.BorderRadius = 1;
            this.btndelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndelete.OnIdleState.BorderThickness = 1;
            this.btndelete.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btndelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btndelete.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.bin;
            this.btndelete.OnIdleState.IconRightImage = null;
            this.btndelete.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btndelete.OnPressedState.BorderRadius = 1;
            this.btndelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btndelete.OnPressedState.BorderThickness = 1;
            this.btndelete.OnPressedState.FillColor = System.Drawing.Color.Red;
            this.btndelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btndelete.OnPressedState.IconLeftImage = null;
            this.btndelete.OnPressedState.IconRightImage = null;
            this.btndelete.Size = new System.Drawing.Size(119, 39);
            this.btndelete.TabIndex = 31;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndelete.TextMarginLeft = 0;
            this.btndelete.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btndelete.UseDefaultRadiusAndThickness = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.AllowAnimations = true;
            this.btnedit.AllowMouseEffects = true;
            this.btnedit.AllowToggling = false;
            this.btnedit.AnimationSpeed = 200;
            this.btnedit.AutoGenerateColors = false;
            this.btnedit.AutoRoundBorders = false;
            this.btnedit.AutoSizeLeftIcon = true;
            this.btnedit.AutoSizeRightIcon = true;
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.BackColor1 = System.Drawing.Color.ForestGreen;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnedit.ButtonText = "Edit";
            this.btnedit.ButtonTextMarginLeft = 0;
            this.btnedit.ColorContrastOnClick = 45;
            this.btnedit.ColorContrastOnHover = 45;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnedit.CustomizableEdges = borderEdges3;
            this.btnedit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnedit.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnedit.DisabledFillColor = System.Drawing.Color.ForestGreen;
            this.btnedit.DisabledForecolor = System.Drawing.Color.White;
            this.btnedit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnedit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnedit.IconMarginLeft = 11;
            this.btnedit.IconPadding = 10;
            this.btnedit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnedit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnedit.IconSize = 25;
            this.btnedit.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnedit.IdleBorderRadius = 1;
            this.btnedit.IdleBorderThickness = 1;
            this.btnedit.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.btnedit.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.edit_solid_24;
            this.btnedit.IdleIconRightImage = null;
            this.btnedit.IndicateFocus = false;
            this.btnedit.Location = new System.Drawing.Point(412, 613);
            this.btnedit.Name = "btnedit";
            this.btnedit.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnedit.OnDisabledState.BorderRadius = 1;
            this.btnedit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnedit.OnDisabledState.BorderThickness = 1;
            this.btnedit.OnDisabledState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnedit.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnedit.OnDisabledState.IconLeftImage = null;
            this.btnedit.OnDisabledState.IconRightImage = null;
            this.btnedit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnedit.onHoverState.BorderRadius = 1;
            this.btnedit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnedit.onHoverState.BorderThickness = 1;
            this.btnedit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnedit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnedit.onHoverState.IconLeftImage = null;
            this.btnedit.onHoverState.IconRightImage = null;
            this.btnedit.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnedit.OnIdleState.BorderRadius = 1;
            this.btnedit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnedit.OnIdleState.BorderThickness = 1;
            this.btnedit.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnedit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnedit.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.edit_solid_24;
            this.btnedit.OnIdleState.IconRightImage = null;
            this.btnedit.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnedit.OnPressedState.BorderRadius = 1;
            this.btnedit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnedit.OnPressedState.BorderThickness = 1;
            this.btnedit.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnedit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnedit.OnPressedState.IconLeftImage = null;
            this.btnedit.OnPressedState.IconRightImage = null;
            this.btnedit.Size = new System.Drawing.Size(119, 39);
            this.btnedit.TabIndex = 30;
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnedit.TextMarginLeft = 0;
            this.btnedit.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnedit.UseDefaultRadiusAndThickness = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsearchrecord
            // 
            this.btnsearchrecord.AllowAnimations = true;
            this.btnsearchrecord.AllowMouseEffects = true;
            this.btnsearchrecord.AllowToggling = false;
            this.btnsearchrecord.AnimationSpeed = 200;
            this.btnsearchrecord.AutoGenerateColors = false;
            this.btnsearchrecord.AutoRoundBorders = false;
            this.btnsearchrecord.AutoSizeLeftIcon = true;
            this.btnsearchrecord.AutoSizeRightIcon = true;
            this.btnsearchrecord.BackColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.BackColor1 = System.Drawing.Color.ForestGreen;
            this.btnsearchrecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearchrecord.BackgroundImage")));
            this.btnsearchrecord.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.ButtonText = "Search Record";
            this.btnsearchrecord.ButtonTextMarginLeft = 0;
            this.btnsearchrecord.ColorContrastOnClick = 45;
            this.btnsearchrecord.ColorContrastOnHover = 45;
            this.btnsearchrecord.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnsearchrecord.CustomizableEdges = borderEdges4;
            this.btnsearchrecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsearchrecord.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.DisabledFillColor = System.Drawing.Color.ForestGreen;
            this.btnsearchrecord.DisabledForecolor = System.Drawing.Color.White;
            this.btnsearchrecord.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnsearchrecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchrecord.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearchrecord.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnsearchrecord.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnsearchrecord.IconMarginLeft = 11;
            this.btnsearchrecord.IconPadding = 10;
            this.btnsearchrecord.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearchrecord.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnsearchrecord.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnsearchrecord.IconSize = 25;
            this.btnsearchrecord.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.IdleBorderRadius = 1;
            this.btnsearchrecord.IdleBorderThickness = 1;
            this.btnsearchrecord.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.btnsearchrecord.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.search_alt_2_regular_24;
            this.btnsearchrecord.IdleIconRightImage = null;
            this.btnsearchrecord.IndicateFocus = false;
            this.btnsearchrecord.Location = new System.Drawing.Point(525, 115);
            this.btnsearchrecord.Name = "btnsearchrecord";
            this.btnsearchrecord.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.OnDisabledState.BorderRadius = 1;
            this.btnsearchrecord.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.OnDisabledState.BorderThickness = 1;
            this.btnsearchrecord.OnDisabledState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnsearchrecord.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.OnDisabledState.IconLeftImage = null;
            this.btnsearchrecord.OnDisabledState.IconRightImage = null;
            this.btnsearchrecord.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsearchrecord.onHoverState.BorderRadius = 1;
            this.btnsearchrecord.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.onHoverState.BorderThickness = 1;
            this.btnsearchrecord.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsearchrecord.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.onHoverState.IconLeftImage = null;
            this.btnsearchrecord.onHoverState.IconRightImage = null;
            this.btnsearchrecord.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.OnIdleState.BorderRadius = 1;
            this.btnsearchrecord.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.OnIdleState.BorderThickness = 1;
            this.btnsearchrecord.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnsearchrecord.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.search_alt_2_regular_24;
            this.btnsearchrecord.OnIdleState.IconRightImage = null;
            this.btnsearchrecord.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.OnPressedState.BorderRadius = 1;
            this.btnsearchrecord.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.OnPressedState.BorderThickness = 1;
            this.btnsearchrecord.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnsearchrecord.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.OnPressedState.IconLeftImage = null;
            this.btnsearchrecord.OnPressedState.IconRightImage = null;
            this.btnsearchrecord.Size = new System.Drawing.Size(195, 39);
            this.btnsearchrecord.TabIndex = 6;
            this.btnsearchrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchrecord.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsearchrecord.TextMarginLeft = 0;
            this.btnsearchrecord.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsearchrecord.UseDefaultRadiusAndThickness = true;
            this.btnsearchrecord.Click += new System.EventHandler(this.btnsearchrecord_Click);
            // 
            // blank2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 809);
            this.Controls.Add(this.attendancepanel);
            this.Name = "blank2";
            this.Text = "blank2";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.attendancepanel.ResumeLayout(false);
            this.attendancepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnupdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btndelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnsearchrecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderLate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderAbsent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderBatch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtbatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel attendancepanel;
        private System.Windows.Forms.DataGridView AttendanceRecordDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderID;
    }
}
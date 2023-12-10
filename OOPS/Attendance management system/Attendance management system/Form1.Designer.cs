namespace Attendance_management_system
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties37 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties38 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties39 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties40 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signuplink = new System.Windows.Forms.LinkLabel();
            this.errormsg = new System.Windows.Forms.Label();
            this.erroricon = new System.Windows.Forms.PictureBox();
            this.btnlogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtpassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtusername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Managment System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "New here ? ";
            // 
            // signuplink
            // 
            this.signuplink.AutoSize = true;
            this.signuplink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuplink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signuplink.Location = new System.Drawing.Point(257, 316);
            this.signuplink.Name = "signuplink";
            this.signuplink.Size = new System.Drawing.Size(82, 28);
            this.signuplink.TabIndex = 8;
            this.signuplink.TabStop = true;
            this.signuplink.Text = "Sign up";
            this.signuplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signuplink_LinkClicked);
            // 
            // errormsg
            // 
            this.errormsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errormsg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormsg.ForeColor = System.Drawing.Color.Red;
            this.errormsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errormsg.Location = new System.Drawing.Point(67, 199);
            this.errormsg.Name = "errormsg";
            this.errormsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errormsg.Size = new System.Drawing.Size(282, 27);
            this.errormsg.TabIndex = 7;
            this.errormsg.Text = "Invalid username or password !";
            this.errormsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errormsg.Visible = false;
            // 
            // erroricon
            // 
            this.erroricon.Image = global::Attendance_management_system.Properties.Resources.warning__1_;
            this.erroricon.Location = new System.Drawing.Point(72, 201);
            this.erroricon.Name = "erroricon";
            this.erroricon.Size = new System.Drawing.Size(26, 24);
            this.erroricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erroricon.TabIndex = 10;
            this.erroricon.TabStop = false;
            this.erroricon.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.AllowAnimations = true;
            this.btnlogin.AllowMouseEffects = true;
            this.btnlogin.AllowToggling = false;
            this.btnlogin.AnimationSpeed = 200;
            this.btnlogin.AutoGenerateColors = false;
            this.btnlogin.AutoRoundBorders = false;
            this.btnlogin.AutoSizeLeftIcon = true;
            this.btnlogin.AutoSizeRightIcon = true;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BackColor1 = System.Drawing.Color.DarkMagenta;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.ButtonTextMarginLeft = 0;
            this.btnlogin.ColorContrastOnClick = 45;
            this.btnlogin.ColorContrastOnHover = 45;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnlogin.CustomizableEdges = borderEdges5;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlogin.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.DisabledFillColor = System.Drawing.Color.DarkMagenta;
            this.btnlogin.DisabledForecolor = System.Drawing.Color.White;
            this.btnlogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnlogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnlogin.IconMarginLeft = 11;
            this.btnlogin.IconPadding = 10;
            this.btnlogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnlogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnlogin.IconSize = 25;
            this.btnlogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogin.IdleBorderRadius = 1;
            this.btnlogin.IdleBorderThickness = 1;
            this.btnlogin.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.btnlogin.IdleIconLeftImage = null;
            this.btnlogin.IdleIconRightImage = null;
            this.btnlogin.IndicateFocus = false;
            this.btnlogin.Location = new System.Drawing.Point(284, 366);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.OnDisabledState.BorderRadius = 1;
            this.btnlogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlogin.OnDisabledState.BorderThickness = 1;
            this.btnlogin.OnDisabledState.FillColor = System.Drawing.Color.DarkMagenta;
            this.btnlogin.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnlogin.OnDisabledState.IconLeftImage = null;
            this.btnlogin.OnDisabledState.IconRightImage = null;
            this.btnlogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnlogin.onHoverState.BorderRadius = 1;
            this.btnlogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlogin.onHoverState.BorderThickness = 1;
            this.btnlogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnlogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnlogin.onHoverState.IconLeftImage = null;
            this.btnlogin.onHoverState.IconRightImage = null;
            this.btnlogin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogin.OnIdleState.BorderRadius = 1;
            this.btnlogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlogin.OnIdleState.BorderThickness = 1;
            this.btnlogin.OnIdleState.FillColor = System.Drawing.Color.DarkMagenta;
            this.btnlogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnlogin.OnIdleState.IconLeftImage = null;
            this.btnlogin.OnIdleState.IconRightImage = null;
            this.btnlogin.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.OnPressedState.BorderRadius = 1;
            this.btnlogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlogin.OnPressedState.BorderThickness = 1;
            this.btnlogin.OnPressedState.FillColor = System.Drawing.Color.DarkMagenta;
            this.btnlogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnlogin.OnPressedState.IconLeftImage = null;
            this.btnlogin.OnPressedState.IconRightImage = null;
            this.btnlogin.Size = new System.Drawing.Size(388, 49);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnlogin.TextMarginLeft = 0;
            this.btnlogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnlogin.UseDefaultRadiusAndThickness = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.AcceptsReturn = false;
            this.txtpassword.AcceptsTab = false;
            this.txtpassword.AnimationSpeed = 200;
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpassword.BackgroundImage")));
            this.txtpassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtpassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtpassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtpassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtpassword.BorderRadius = 1;
            this.txtpassword.BorderThickness = 1;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtpassword.DefaultText = "";
            this.txtpassword.FillColor = System.Drawing.Color.White;
            this.txtpassword.HideSelection = true;
            this.txtpassword.IconLeft = null;
            this.txtpassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.IconPadding = 10;
            this.txtpassword.IconRight = null;
            this.txtpassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(65, 151);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpassword.Modified = false;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            stateProperties33.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpassword.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtpassword.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpassword.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.Color.White;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpassword.OnIdleState = stateProperties36;
            this.txtpassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.ReadOnly = false;
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(388, 44);
            this.txtpassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtpassword.TabIndex = 4;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.TextMarginBottom = 0;
            this.txtpassword.TextMarginLeft = 3;
            this.txtpassword.TextMarginTop = 0;
            this.txtpassword.TextPlaceholder = "";
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.WordWrap = true;
            // 
            // txtusername
            // 
            this.txtusername.AcceptsReturn = false;
            this.txtusername.AcceptsTab = false;
            this.txtusername.AnimationSpeed = 200;
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtusername.BackgroundImage")));
            this.txtusername.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtusername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtusername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtusername.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtusername.BorderRadius = 1;
            this.txtusername.BorderThickness = 1;
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.DefaultText = "";
            this.txtusername.FillColor = System.Drawing.Color.White;
            this.txtusername.HideSelection = true;
            this.txtusername.IconLeft = null;
            this.txtusername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.IconPadding = 10;
            this.txtusername.IconRight = null;
            this.txtusername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(65, 55);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtusername.Modified = false;
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            stateProperties37.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties37.FillColor = System.Drawing.Color.Empty;
            stateProperties37.ForeColor = System.Drawing.Color.Empty;
            stateProperties37.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtusername.OnActiveState = stateProperties37;
            stateProperties38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties38.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtusername.OnDisabledState = stateProperties38;
            stateProperties39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties39.FillColor = System.Drawing.Color.Empty;
            stateProperties39.ForeColor = System.Drawing.Color.Empty;
            stateProperties39.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtusername.OnHoverState = stateProperties39;
            stateProperties40.BorderColor = System.Drawing.Color.Silver;
            stateProperties40.FillColor = System.Drawing.Color.White;
            stateProperties40.ForeColor = System.Drawing.Color.Empty;
            stateProperties40.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtusername.OnIdleState = stateProperties40;
            this.txtusername.Padding = new System.Windows.Forms.Padding(3);
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtusername.PlaceholderText = "";
            this.txtusername.ReadOnly = false;
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(388, 44);
            this.txtusername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtusername.TabIndex = 3;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.TextMarginBottom = 0;
            this.txtusername.TextMarginLeft = 3;
            this.txtusername.TextMarginTop = 0;
            this.txtusername.TextPlaceholder = "";
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.WordWrap = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.signuplink);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.erroricon);
            this.panel1.Controls.Add(this.errormsg);
            this.panel1.Location = new System.Drawing.Point(218, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 392);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(954, 551);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(972, 598);
            this.MinimumSize = new System.Drawing.Size(972, 598);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtusername;
        private Bunifu.UI.WinForms.BunifuTextBox txtpassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel signuplink;
        private System.Windows.Forms.Label errormsg;
        private System.Windows.Forms.PictureBox erroricon;
        private System.Windows.Forms.Panel panel1;
    }
}


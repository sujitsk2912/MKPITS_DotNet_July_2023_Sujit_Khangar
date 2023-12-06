namespace SideBar_Layout
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.imgmen = new System.Windows.Forms.PictureBox();
            this.btnmenu = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btncreateact = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnadmin = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnsetting = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnabout = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidebartransition = new System.Windows.Forms.Timer(this.components);
            this.frmloadpanel = new System.Windows.Forms.Panel();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgmen)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.SystemColors.Control;
            this.headerpanel.Controls.Add(this.panel3);
            this.headerpanel.Controls.Add(this.label2);
            this.headerpanel.Controls.Add(this.imgmen);
            this.headerpanel.Controls.Add(this.btnmenu);
            this.headerpanel.Controls.Add(this.label1);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1186, 53);
            this.headerpanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 310);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(1007, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "USERNAME";
            // 
            // imgmen
            // 
            this.imgmen.BackColor = System.Drawing.Color.AliceBlue;
            this.imgmen.Image = global::SideBar_Layout.Properties.Resources.man;
            this.imgmen.Location = new System.Drawing.Point(1104, 7);
            this.imgmen.Name = "imgmen";
            this.imgmen.Size = new System.Drawing.Size(45, 39);
            this.imgmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgmen.TabIndex = 4;
            this.imgmen.TabStop = false;
            // 
            // btnmenu
            // 
            this.btnmenu.ActiveImage = null;
            this.btnmenu.AllowAnimations = true;
            this.btnmenu.AllowBuffering = false;
            this.btnmenu.AllowToggling = false;
            this.btnmenu.AllowZooming = false;
            this.btnmenu.AllowZoomingOnFocus = false;
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmenu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnmenu.ErrorImage")));
            this.btnmenu.FadeWhenInactive = false;
            this.btnmenu.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageActive = null;
            this.btnmenu.ImageLocation = null;
            this.btnmenu.ImageMargin = 0;
            this.btnmenu.ImageSize = new System.Drawing.Size(33, 34);
            this.btnmenu.ImageZoomSize = new System.Drawing.Size(33, 34);
            this.btnmenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnmenu.InitialImage")));
            this.btnmenu.Location = new System.Drawing.Point(24, 12);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Rotation = 0;
            this.btnmenu.ShowActiveImage = true;
            this.btnmenu.ShowCursorChanges = true;
            this.btnmenu.ShowImageBorders = false;
            this.btnmenu.ShowSizeMarkers = false;
            this.btnmenu.Size = new System.Drawing.Size(33, 34);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.ToolTipText = "";
            this.btnmenu.WaitOnLoad = false;
            this.btnmenu.Zoom = 0;
            this.btnmenu.ZoomSpeed = 10;
            this.btnmenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUJIT DASHBOARD | MODERN SIDEBAR";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 53);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(229, 534);
            this.sidebar.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.btncreateact);
            this.panel4.Location = new System.Drawing.Point(0, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 70);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SideBar_Layout.Properties.Resources.log_in_solid_24;
            this.pictureBox5.Location = new System.Drawing.Point(26, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btncreateact
            // 
            this.btncreateact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.btncreateact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateact.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncreateact.Location = new System.Drawing.Point(-46, -30);
            this.btncreateact.Name = "btncreateact";
            this.btncreateact.Size = new System.Drawing.Size(330, 119);
            this.btncreateact.TabIndex = 7;
            this.btncreateact.Text = "Signup";
            this.btncreateact.UseVisualStyleBackColor = false;
            this.btncreateact.Click += new System.EventHandler(this.btncreateact_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnadmin);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 70);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SideBar_Layout.Properties.Resources.user_solid_24__2_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnadmin.Location = new System.Drawing.Point(-45, -10);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(330, 119);
            this.btnadmin.TabIndex = 6;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Controls.Add(this.btnlogin);
            this.panel8.Location = new System.Drawing.Point(2, 213);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 70);
            this.panel8.TabIndex = 5;
            this.panel8.MouseHover += new System.EventHandler(this.btnadmin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SideBar_Layout.Properties.Resources.log_out_solid_24;
            this.pictureBox4.Location = new System.Drawing.Point(24, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlogin.Location = new System.Drawing.Point(-50, -23);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(330, 119);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnsetting);
            this.panel2.Location = new System.Drawing.Point(2, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 70);
            this.panel2.TabIndex = 5;
            this.panel2.MouseHover += new System.EventHandler(this.btnadmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SideBar_Layout.Properties.Resources.cog_solid_24;
            this.pictureBox2.Location = new System.Drawing.Point(24, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.btnsetting.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsetting.Location = new System.Drawing.Point(-41, -15);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(330, 119);
            this.btnsetting.TabIndex = 5;
            this.btnsetting.Text = "Settings";
            this.btnsetting.UseVisualStyleBackColor = false;
            this.btnsetting.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.btnabout);
            this.panel7.Location = new System.Drawing.Point(2, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 70);
            this.panel7.TabIndex = 5;
            this.panel7.MouseHover += new System.EventHandler(this.btnadmin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SideBar_Layout.Properties.Resources.info_circle_regular_24;
            this.pictureBox3.Location = new System.Drawing.Point(24, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.btnabout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnabout.Location = new System.Drawing.Point(-47, -2);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(330, 119);
            this.btnabout.TabIndex = 4;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.imgmen;
            // 
            // sidebartransition
            // 
            this.sidebartransition.Interval = 10;
            this.sidebartransition.Tick += new System.EventHandler(this.sidebartransition_Tick);
            // 
            // frmloadpanel
            // 
            this.frmloadpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmloadpanel.Location = new System.Drawing.Point(229, 53);
            this.frmloadpanel.Name = "frmloadpanel";
            this.frmloadpanel.Size = new System.Drawing.Size(957, 534);
            this.frmloadpanel.TabIndex = 2;
            this.frmloadpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.frmadminpanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1186, 587);
            this.Controls.Add(this.frmloadpanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.headerpanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgmen)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton btnmenu;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox imgmen;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer sidebartransition;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btncreateact;
        private System.Windows.Forms.Panel frmloadpanel;
    }
}
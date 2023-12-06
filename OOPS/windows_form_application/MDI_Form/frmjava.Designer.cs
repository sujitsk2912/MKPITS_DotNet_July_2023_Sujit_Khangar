namespace MDI_form
{
    partial class frmadmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmission));
            this.signup_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.courseslist = new System.Windows.Forms.ComboBox();
            this.addresslb = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.courselb = new System.Windows.Forms.Label();
            this.DOB_calender = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.DOBlb = new System.Windows.Forms.Label();
            this.btnfemale = new System.Windows.Forms.RadioButton();
            this.btnmale = new System.Windows.Forms.RadioButton();
            this.genderlb = new System.Windows.Forms.Label();
            this.phonelb = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.emaillb = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.namelb = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.java_add = new System.Windows.Forms.Label();
            this.signup_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.Color.Lavender;
            this.signup_panel.Controls.Add(this.label1);
            this.signup_panel.Controls.Add(this.txtfees);
            this.signup_panel.Controls.Add(this.courseslist);
            this.signup_panel.Controls.Add(this.addresslb);
            this.signup_panel.Controls.Add(this.txtaddress);
            this.signup_panel.Controls.Add(this.courselb);
            this.signup_panel.Controls.Add(this.DOB_calender);
            this.signup_panel.Controls.Add(this.DOBlb);
            this.signup_panel.Controls.Add(this.btnfemale);
            this.signup_panel.Controls.Add(this.btnmale);
            this.signup_panel.Controls.Add(this.genderlb);
            this.signup_panel.Controls.Add(this.phonelb);
            this.signup_panel.Controls.Add(this.txtphone);
            this.signup_panel.Controls.Add(this.btnsubmit);
            this.signup_panel.Controls.Add(this.emaillb);
            this.signup_panel.Controls.Add(this.txtmail);
            this.signup_panel.Controls.Add(this.namelb);
            this.signup_panel.Controls.Add(this.txtuser);
            this.signup_panel.Controls.Add(this.java_add);
            this.signup_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup_panel.Location = new System.Drawing.Point(0, 0);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(1045, 603);
            this.signup_panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fees : ";
            // 
            // txtfees
            // 
            this.txtfees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfees.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfees.Location = new System.Drawing.Point(334, 388);
            this.txtfees.Multiline = true;
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(496, 41);
            this.txtfees.TabIndex = 20;
            // 
            // courseslist
            // 
            this.courseslist.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseslist.FormattingEnabled = true;
            this.courseslist.Items.AddRange(new object[] {
            "Angular",
            "DotNet",
            "Java",
            "Nodejs",
            "PHP",
            "Python",
            "React"});
            this.courseslist.Location = new System.Drawing.Point(334, 341);
            this.courseslist.Name = "courseslist";
            this.courseslist.Size = new System.Drawing.Size(149, 33);
            this.courseslist.TabIndex = 19;
            this.courseslist.Text = "DotNet";
            // 
            // addresslb
            // 
            this.addresslb.AutoSize = true;
            this.addresslb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslb.Location = new System.Drawing.Point(230, 462);
            this.addresslb.Name = "addresslb";
            this.addresslb.Size = new System.Drawing.Size(88, 25);
            this.addresslb.TabIndex = 18;
            this.addresslb.Text = "Address: ";
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(334, 446);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(496, 41);
            this.txtaddress.TabIndex = 17;
            // 
            // courselb
            // 
            this.courselb.AutoSize = true;
            this.courselb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselb.Location = new System.Drawing.Point(240, 347);
            this.courselb.Name = "courselb";
            this.courselb.Size = new System.Drawing.Size(79, 25);
            this.courselb.TabIndex = 16;
            this.courselb.Text = "Course: ";
            // 
            // DOB_calender
            // 
            this.DOB_calender.BackColor = System.Drawing.Color.Transparent;
            this.DOB_calender.BorderRadius = 0;
            this.DOB_calender.Color = System.Drawing.Color.Snow;
            this.DOB_calender.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.DOB_calender.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DOB_calender.DisabledColor = System.Drawing.Color.Gray;
            this.DOB_calender.DisplayWeekNumbers = false;
            this.DOB_calender.DPHeight = 0;
            this.DOB_calender.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DOB_calender.FillDatePicker = true;
            this.DOB_calender.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_calender.ForeColor = System.Drawing.Color.Black;
            this.DOB_calender.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB_calender.Icon = ((System.Drawing.Image)(resources.GetObject("DOB_calender.Icon")));
            this.DOB_calender.IconColor = System.Drawing.SystemColors.Highlight;
            this.DOB_calender.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DOB_calender.LeftTextMargin = 5;
            this.DOB_calender.Location = new System.Drawing.Point(334, 292);
            this.DOB_calender.MinimumSize = new System.Drawing.Size(4, 32);
            this.DOB_calender.Name = "DOB_calender";
            this.DOB_calender.Size = new System.Drawing.Size(149, 32);
            this.DOB_calender.TabIndex = 15;
            this.DOB_calender.Value = new System.DateTime(2023, 12, 6, 16, 6, 0, 0);
            // 
            // DOBlb
            // 
            this.DOBlb.AutoSize = true;
            this.DOBlb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlb.Location = new System.Drawing.Point(135, 299);
            this.DOBlb.Name = "DOBlb";
            this.DOBlb.Size = new System.Drawing.Size(174, 25);
            this.DOBlb.TabIndex = 14;
            this.DOBlb.Text = "Date of Admission: ";
            // 
            // btnfemale
            // 
            this.btnfemale.AutoSize = true;
            this.btnfemale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfemale.Location = new System.Drawing.Point(439, 244);
            this.btnfemale.Name = "btnfemale";
            this.btnfemale.Size = new System.Drawing.Size(86, 27);
            this.btnfemale.TabIndex = 13;
            this.btnfemale.TabStop = true;
            this.btnfemale.Text = "Female";
            this.btnfemale.UseVisualStyleBackColor = true;
            // 
            // btnmale
            // 
            this.btnmale.AutoSize = true;
            this.btnmale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmale.Location = new System.Drawing.Point(334, 244);
            this.btnmale.Name = "btnmale";
            this.btnmale.Size = new System.Drawing.Size(69, 27);
            this.btnmale.TabIndex = 12;
            this.btnmale.TabStop = true;
            this.btnmale.Text = "Male";
            this.btnmale.UseVisualStyleBackColor = true;
            // 
            // genderlb
            // 
            this.genderlb.AutoSize = true;
            this.genderlb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlb.Location = new System.Drawing.Point(235, 244);
            this.genderlb.Name = "genderlb";
            this.genderlb.Size = new System.Drawing.Size(84, 25);
            this.genderlb.TabIndex = 11;
            this.genderlb.Text = "Gender: ";
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelb.Location = new System.Drawing.Point(244, 196);
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(74, 25);
            this.phonelb.TabIndex = 10;
            this.phonelb.Text = "Phone: ";
            // 
            // txtphone
            // 
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(334, 180);
            this.txtphone.MaxLength = 10;
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(496, 41);
            this.txtphone.TabIndex = 9;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.Location = new System.Drawing.Point(467, 512);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(176, 53);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillb.Location = new System.Drawing.Point(255, 140);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(65, 25);
            this.emaillb.TabIndex = 4;
            this.emaillb.Text = "Email: ";
            // 
            // txtmail
            // 
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(334, 124);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(496, 41);
            this.txtmail.TabIndex = 3;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(211, 83);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(105, 25);
            this.namelb.TabIndex = 2;
            this.namelb.Text = "Full Name: ";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(334, 67);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(496, 41);
            this.txtuser.TabIndex = 1;
            // 
            // java_add
            // 
            this.java_add.AutoSize = true;
            this.java_add.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.java_add.Location = new System.Drawing.Point(435, 8);
            this.java_add.Name = "java_add";
            this.java_add.Size = new System.Drawing.Size(231, 38);
            this.java_add.TabIndex = 0;
            this.java_add.Text = "Admission Form";
            // 
            // frmadmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 603);
            this.Controls.Add(this.signup_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadmission";
            this.Text = "frmjava";
            this.Load += new System.EventHandler(this.frmjava_Load);
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signup_panel;
        private System.Windows.Forms.Label phonelb;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label emaillb;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label java_add;
        private System.Windows.Forms.Label genderlb;
        private Bunifu.UI.WinForms.BunifuDatePicker DOB_calender;
        private System.Windows.Forms.Label DOBlb;
        private System.Windows.Forms.RadioButton btnfemale;
        private System.Windows.Forms.RadioButton btnmale;
        private System.Windows.Forms.Label addresslb;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label courselb;
        private System.Windows.Forms.ComboBox courseslist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfees;
    }
}
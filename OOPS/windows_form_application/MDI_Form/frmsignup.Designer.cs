namespace MDI_form
{
    partial class frmsignup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtconfpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.signup_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(390, 162);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(395, 41);
            this.txtuser.TabIndex = 1;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username: ";
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(390, 218);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(395, 41);
            this.txtpass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(422, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(452, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(270, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Agree Terms and Conditions";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(492, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Click Here to ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(621, 485);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtconfpass
            // 
            this.txtconfpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconfpass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfpass.Location = new System.Drawing.Point(390, 274);
            this.txtconfpass.Multiline = true;
            this.txtconfpass.Name = "txtconfpass";
            this.txtconfpass.Size = new System.Drawing.Size(395, 41);
            this.txtconfpass.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm Password:";
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signup_panel.Controls.Add(this.label5);
            this.signup_panel.Controls.Add(this.txtconfpass);
            this.signup_panel.Controls.Add(this.linkLabel1);
            this.signup_panel.Controls.Add(this.label4);
            this.signup_panel.Controls.Add(this.checkBox1);
            this.signup_panel.Controls.Add(this.button1);
            this.signup_panel.Controls.Add(this.label3);
            this.signup_panel.Controls.Add(this.txtpass);
            this.signup_panel.Controls.Add(this.label2);
            this.signup_panel.Controls.Add(this.txtuser);
            this.signup_panel.Controls.Add(this.label1);
            this.signup_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup_panel.Location = new System.Drawing.Point(0, 0);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(1067, 636);
            this.signup_panel.TabIndex = 3;
            // 
            // frmsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 636);
            this.Controls.Add(this.signup_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsignup";
            this.Load += new System.EventHandler(this.frmsignup_Load);
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtconfpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel signup_panel;
    }
}
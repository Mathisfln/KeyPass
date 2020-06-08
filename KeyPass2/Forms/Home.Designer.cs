namespace KeyPass2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.password_List = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordBtn = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settings_control = new KeyPass2.settings();
            this.addPassword_control = new KeyPass2.password_add();
            this.listPassword_control = new KeyPass2.password_list();
            this.editPassword_control = new KeyPass2.password_edit();
            this.panel1.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.editPassword_control);
            this.panel1.Controls.Add(this.settings_control);
            this.panel1.Controls.Add(this.addPassword_control);
            this.panel1.Controls.Add(this.listPassword_control);
            this.panel1.Controls.Add(this.left_panel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 556);
            this.panel1.TabIndex = 0;
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.left_panel.Controls.Add(this.settingsBtn);
            this.left_panel.Controls.Add(this.panelPassword);
            this.left_panel.Controls.Add(this.button1);
            this.left_panel.Controls.Add(this.passwordBtn);
            this.left_panel.Controls.Add(this.username_label);
            this.left_panel.Controls.Add(this.label1);
            this.left_panel.Controls.Add(this.pictureBox1);
            this.left_panel.ForeColor = System.Drawing.Color.White;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(322, 556);
            this.left_panel.TabIndex = 1;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(0, 450);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsBtn.Size = new System.Drawing.Size(322, 41);
            this.settingsBtn.TabIndex = 107;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panelPassword.Controls.Add(this.button7);
            this.panelPassword.Controls.Add(this.button3);
            this.panelPassword.Controls.Add(this.button2);
            this.panelPassword.Controls.Add(this.password_List);
            this.panelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F);
            this.panelPassword.Location = new System.Drawing.Point(0, 273);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(322, 167);
            this.panelPassword.TabIndex = 106;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(3, 127);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(319, 37);
            this.button7.TabIndex = 3;
            this.button7.Text = "Delete";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(4, 86);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(318, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(3, 43);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(319, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // password_List
            // 
            this.password_List.FlatAppearance.BorderSize = 0;
            this.password_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_List.ForeColor = System.Drawing.SystemColors.Control;
            this.password_List.Location = new System.Drawing.Point(4, 3);
            this.password_List.Margin = new System.Windows.Forms.Padding(0);
            this.password_List.Name = "password_List";
            this.password_List.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.password_List.Size = new System.Drawing.Size(318, 37);
            this.password_List.TabIndex = 0;
            this.password_List.Text = "List";
            this.password_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.password_List.UseVisualStyleBackColor = false;
            this.password_List.Click += new System.EventHandler(this.password_List_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(322, 41);
            this.button1.TabIndex = 105;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordBtn
            // 
            this.passwordBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.passwordBtn.FlatAppearance.BorderSize = 0;
            this.passwordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F);
            this.passwordBtn.ForeColor = System.Drawing.Color.White;
            this.passwordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordBtn.Location = new System.Drawing.Point(0, 235);
            this.passwordBtn.Margin = new System.Windows.Forms.Padding(0);
            this.passwordBtn.Name = "passwordBtn";
            this.passwordBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passwordBtn.Size = new System.Drawing.Size(322, 41);
            this.passwordBtn.TabIndex = 104;
            this.passwordBtn.Text = "Manage Passwords";
            this.passwordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordBtn.UseVisualStyleBackColor = false;
            this.passwordBtn.Click += new System.EventHandler(this.passwordBtn_Click);
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(158, 182);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(0, 20);
            this.username_label.TabIndex = 2;
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(14, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome home,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyPass.Properties.Resources.password__2_;
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // settings_control
            // 
            this.settings_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.settings_control.Location = new System.Drawing.Point(340, 12);
            this.settings_control.Name = "settings_control";
            this.settings_control.Size = new System.Drawing.Size(715, 528);
            this.settings_control.TabIndex = 2;
            // 
            // addPassword_control
            // 
            this.addPassword_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.addPassword_control.Location = new System.Drawing.Point(337, 12);
            this.addPassword_control.Name = "addPassword_control";
            this.addPassword_control.Size = new System.Drawing.Size(718, 530);
            this.addPassword_control.TabIndex = 0;
            // 
            // listPassword_control
            // 
            this.listPassword_control.Location = new System.Drawing.Point(337, 12);
            this.listPassword_control.Name = "listPassword_control";
            this.listPassword_control.Size = new System.Drawing.Size(718, 530);
            this.listPassword_control.TabIndex = 0;
            // 
            // editPassword_control
            // 
            this.editPassword_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.editPassword_control.Location = new System.Drawing.Point(340, 12);
            this.editPassword_control.Name = "editPassword_control";
            this.editPassword_control.Size = new System.Drawing.Size(712, 528);
            this.editPassword_control.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyPass";
            this.panel1.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button passwordBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button password_List;
        public password_list listPassword_control;
        public password_add addPassword_control;
        private System.Windows.Forms.Button settingsBtn;
        private settings settings_control;
        private password_edit editPassword_control;
    }
}
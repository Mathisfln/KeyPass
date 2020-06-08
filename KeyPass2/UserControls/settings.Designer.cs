namespace KeyPass2
{
    partial class settings
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsUsername = new System.Windows.Forms.TextBox();
            this.settingsMail = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteAccountBtn = new System.Windows.Forms.Label();
            this.settingsPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change Mail Adress";
            // 
            // settingsUsername
            // 
            this.settingsUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.settingsUsername.Location = new System.Drawing.Point(74, 67);
            this.settingsUsername.Name = "settingsUsername";
            this.settingsUsername.Size = new System.Drawing.Size(381, 37);
            this.settingsUsername.TabIndex = 2;
            // 
            // settingsMail
            // 
            this.settingsMail.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.settingsMail.Location = new System.Drawing.Point(74, 165);
            this.settingsMail.Name = "settingsMail";
            this.settingsMail.Size = new System.Drawing.Size(381, 37);
            this.settingsMail.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(522, 431);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 53);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Confirm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.AutoSize = true;
            this.deleteAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteAccountBtn.Location = new System.Drawing.Point(71, 451);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(136, 17);
            this.deleteAccountBtn.TabIndex = 14;
            this.deleteAccountBtn.Text = "Delete your Account";
            this.deleteAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click);
            // 
            // settingsPassword
            // 
            this.settingsPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.settingsPassword.Location = new System.Drawing.Point(74, 260);
            this.settingsPassword.Name = "settingsPassword";
            this.settingsPassword.PasswordChar = '*';
            this.settingsPassword.Size = new System.Drawing.Size(381, 37);
            this.settingsPassword.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password";
            // 
            // settingsPasswordConfirm
            // 
            this.settingsPasswordConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.settingsPasswordConfirm.Location = new System.Drawing.Point(74, 352);
            this.settingsPasswordConfirm.Name = "settingsPasswordConfirm";
            this.settingsPasswordConfirm.PasswordChar = '*';
            this.settingsPasswordConfirm.Size = new System.Drawing.Size(381, 37);
            this.settingsPasswordConfirm.TabIndex = 18;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.settingsPasswordConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.settingsPassword);
            this.Controls.Add(this.deleteAccountBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.settingsMail);
            this.Controls.Add(this.settingsUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(723, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label deleteAccountBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox settingsUsername;
        public System.Windows.Forms.TextBox settingsMail;
        public System.Windows.Forms.TextBox settingsPassword;
        public System.Windows.Forms.TextBox settingsPasswordConfirm;
    }
}

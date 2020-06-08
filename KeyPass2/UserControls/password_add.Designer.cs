namespace KeyPass2
{
    partial class password_add
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
            this.addName = new System.Windows.Forms.TextBox();
            this.addPassword = new System.Windows.Forms.TextBox();
            this.addType = new System.Windows.Forms.TextBox();
            this.addDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addName
            // 
            this.addName.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.addName.ForeColor = System.Drawing.Color.LightGray;
            this.addName.Location = new System.Drawing.Point(92, 124);
            this.addName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(289, 42);
            this.addName.TabIndex = 6;
            this.addName.Text = "Name";
            this.addName.Enter += new System.EventHandler(this.addName_Enter);
            this.addName.Leave += new System.EventHandler(this.addName_Leave);
            // 
            // addPassword
            // 
            this.addPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.addPassword.ForeColor = System.Drawing.Color.LightGray;
            this.addPassword.Location = new System.Drawing.Point(92, 199);
            this.addPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPassword.Name = "addPassword";
            this.addPassword.Size = new System.Drawing.Size(393, 42);
            this.addPassword.TabIndex = 7;
            this.addPassword.Text = "Password";
            this.addPassword.Enter += new System.EventHandler(this.addPassword_Enter);
            this.addPassword.Leave += new System.EventHandler(this.addPassword_Leave);
            // 
            // addType
            // 
            this.addType.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.addType.ForeColor = System.Drawing.Color.LightGray;
            this.addType.Location = new System.Drawing.Point(92, 274);
            this.addType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(393, 42);
            this.addType.TabIndex = 8;
            this.addType.Text = "Type";
            this.addType.Enter += new System.EventHandler(this.addType_Enter);
            this.addType.Leave += new System.EventHandler(this.addType_Leave);
            // 
            // addDescription
            // 
            this.addDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.addDescription.ForeColor = System.Drawing.Color.LightGray;
            this.addDescription.Location = new System.Drawing.Point(92, 351);
            this.addDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDescription.Name = "addDescription";
            this.addDescription.Size = new System.Drawing.Size(526, 42);
            this.addDescription.TabIndex = 9;
            this.addDescription.Text = "Description";
            this.addDescription.Enter += new System.EventHandler(this.addDescription_Enter);
            this.addDescription.Leave += new System.EventHandler(this.addDescription_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add new password";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(526, 433);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 53);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Confirm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // password_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDescription);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.addPassword);
            this.Controls.Add(this.addName);
            this.Name = "password_add";
            this.Size = new System.Drawing.Size(718, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.TextBox addPassword;
        private System.Windows.Forms.TextBox addType;
        private System.Windows.Forms.TextBox addDescription;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button addBtn;
    }
}

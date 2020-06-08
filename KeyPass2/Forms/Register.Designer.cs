namespace KeyPass2
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goToSignIn = new System.Windows.Forms.Label();
            this.registerPasswordConfirm = new System.Windows.Forms.TextBox();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerMail = new System.Windows.Forms.TextBox();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyPassText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.goToSignIn);
            this.panel1.Controls.Add(this.registerPasswordConfirm);
            this.panel1.Controls.Add(this.registerPassword);
            this.panel1.Controls.Add(this.registerMail);
            this.panel1.Controls.Add(this.registerUsername);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 556);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyPass.Properties.Resources.password__2_;
            this.pictureBox1.Location = new System.Drawing.Point(704, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // goToSignIn
            // 
            this.goToSignIn.AutoSize = true;
            this.goToSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.goToSignIn.Location = new System.Drawing.Point(100, 457);
            this.goToSignIn.Name = "goToSignIn";
            this.goToSignIn.Size = new System.Drawing.Size(231, 17);
            this.goToSignIn.TabIndex = 13;
            this.goToSignIn.Text = "Already have an account ? Sign in !";
            this.goToSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goToSignIn.Click += new System.EventHandler(this.goToSignIn_Click);
            this.goToSignIn.Enter += new System.EventHandler(this.goToSignIn_Enter);
            this.goToSignIn.Leave += new System.EventHandler(this.goToSignIn_Leave);
            this.goToSignIn.MouseEnter += new System.EventHandler(this.goToSignIn_MouseEnter);
            this.goToSignIn.MouseLeave += new System.EventHandler(this.goToSignIn_MouseLeave);
            // 
            // registerPasswordConfirm
            // 
            this.registerPasswordConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.registerPasswordConfirm.ForeColor = System.Drawing.Color.LightGray;
            this.registerPasswordConfirm.Location = new System.Drawing.Point(159, 385);
            this.registerPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPasswordConfirm.Name = "registerPasswordConfirm";
            this.registerPasswordConfirm.Size = new System.Drawing.Size(393, 42);
            this.registerPasswordConfirm.TabIndex = 8;
            this.registerPasswordConfirm.Text = "Confirm Password";
            this.registerPasswordConfirm.Enter += new System.EventHandler(this.registerPasswordConfirm_Enter);
            this.registerPasswordConfirm.Leave += new System.EventHandler(this.registerPasswordConfirm_Leave);
            // 
            // registerPassword
            // 
            this.registerPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.registerPassword.ForeColor = System.Drawing.Color.LightGray;
            this.registerPassword.Location = new System.Drawing.Point(159, 319);
            this.registerPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(393, 42);
            this.registerPassword.TabIndex = 7;
            this.registerPassword.Text = "Password";
            this.registerPassword.Enter += new System.EventHandler(this.registerPassword_Enter);
            this.registerPassword.Leave += new System.EventHandler(this.registerPassword_Leave);
            // 
            // registerMail
            // 
            this.registerMail.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.registerMail.ForeColor = System.Drawing.Color.LightGray;
            this.registerMail.Location = new System.Drawing.Point(159, 250);
            this.registerMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerMail.Name = "registerMail";
            this.registerMail.Size = new System.Drawing.Size(393, 42);
            this.registerMail.TabIndex = 6;
            this.registerMail.Text = "Mail";
            this.registerMail.Enter += new System.EventHandler(this.registerMail_Enter);
            this.registerMail.Leave += new System.EventHandler(this.registerMail_Leave);
            // 
            // registerUsername
            // 
            this.registerUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.registerUsername.ForeColor = System.Drawing.Color.LightGray;
            this.registerUsername.Location = new System.Drawing.Point(159, 181);
            this.registerUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(289, 42);
            this.registerUsername.TabIndex = 5;
            this.registerUsername.Text = "Username";
            this.registerUsername.Enter += new System.EventHandler(this.registerUsername_Enter);
            this.registerUsername.Leave += new System.EventHandler(this.registerUsername_Leave);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.registerBtn.Location = new System.Drawing.Point(491, 457);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(123, 53);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.keyPassText);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 110);
            this.panel2.TabIndex = 0;
            // 
            // keyPassText
            // 
            this.keyPassText.AutoSize = true;
            this.keyPassText.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyPassText.ForeColor = System.Drawing.SystemColors.Control;
            this.keyPassText.Location = new System.Drawing.Point(371, 28);
            this.keyPassText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keyPassText.Name = "keyPassText";
            this.keyPassText.Size = new System.Drawing.Size(379, 49);
            this.keyPassText.TabIndex = 0;
            this.keyPassText.Text = "Create your account";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label keyPassText;
        private System.Windows.Forms.TextBox registerPasswordConfirm;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerMail;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label goToSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
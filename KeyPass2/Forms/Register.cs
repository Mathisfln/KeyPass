using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyPass2
{
    public partial class Register : Form
    {
        Model1 model = new Model1();

        public Register()
        {
            InitializeComponent();
        }

        private void registerUsername_Enter(object sender, EventArgs e)
        {
            String username = registerUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                registerUsername.Text = "";
                registerUsername.ForeColor = Color.Black;
            }
        }

        private void registerUsername_Leave(object sender, EventArgs e)
        {
            String username = registerUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                registerUsername.Text = "Username";
                registerUsername.ForeColor = Color.LightGray;
            }
        }

        private void registerMail_Enter(object sender, EventArgs e)
        {
            String mail = registerMail.Text;
            if (mail.ToLower().Trim().Equals("mail"))
            {
                registerMail.Text = "";
                registerMail.ForeColor = Color.Black;
            }
        }
        private void registerMail_Leave(object sender, EventArgs e)
        {
            String mail = registerMail.Text;
            if (mail.ToLower().Trim().Equals("mail") || mail.Trim().Equals(""))
            {
                registerMail.Text = "Mail";
                registerMail.ForeColor = Color.LightGray;
            }
        }

        private void registerPassword_Enter(object sender, EventArgs e)
        {
            String password = registerPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                registerPassword.Text = "";
                registerPassword.UseSystemPasswordChar = true;
                registerPassword.ForeColor = Color.Black;
            }
        }

        private void registerPassword_Leave(object sender, EventArgs e)
        {
            String password = registerPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                registerPassword.Text = "Password";
                registerPassword.UseSystemPasswordChar = false;
                registerPassword.ForeColor = Color.LightGray;
            }
        }

        private void registerPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String confirmPassword = registerPasswordConfirm.Text;
            if (confirmPassword.ToLower().Trim().Equals("confirm password"))
            {
                registerPasswordConfirm.Text = "";
                registerPasswordConfirm.UseSystemPasswordChar = true;
                registerPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void registerPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String confirmPassword = registerPasswordConfirm.Text;
            if (confirmPassword.ToLower().Trim().Equals("confirm password") || confirmPassword.Trim().Equals(""))
            {
                registerPasswordConfirm.Text = "Confirm Password";
                registerPasswordConfirm.UseSystemPasswordChar = false;
                registerPasswordConfirm.ForeColor = Color.LightGray;
            }
        }

        private void goToSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        private void goToSignIn_Enter(object sender, EventArgs e)
        {
            goToSignIn.ForeColor = Color.Yellow;
        }

        private void goToSignIn_Leave(object sender, EventArgs e)
        {
            goToSignIn.ForeColor = Color.White;
        }

        private void goToSignIn_MouseEnter(object sender, EventArgs e)
        {
            goToSignIn.ForeColor = Color.GreenYellow;

        }

        private void goToSignIn_MouseLeave(object sender, EventArgs e)
        {
            goToSignIn.ForeColor = Color.White;
        }





        private void registerBtn_Click(object sender, EventArgs e)
        {

            if (!checkValues())
            {
                // On vérifie que les deuxs passwords sont les mêmes
                if (registerPassword.Text.Equals(registerPasswordConfirm.Text))
                {
                    // On vérifie si l'user à bien rentré toutes les informations
                    user nUser = new user { mail = registerMail.Text, username = registerUsername.Text, password = registerPassword.Text };

                    model.user.Add(nUser);

                    if (model.SaveChanges() > 0)
                    {
                        this.Hide();
                        Login loginform = new Login();
                        loginform.Show();
                        MessageBox.Show("Your account has been successfully created");
                    }
                    else
                    {
                        MessageBox.Show("Error ! Unable to create an account");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public Boolean checkValues()
        {
            String mail = registerMail.Text;
            String username = registerUsername.Text;
            String password = registerPassword.Text;
            String confirmPassword = registerPasswordConfirm.Text;

            if (mail.Equals("Mail") || username.Equals("Username") || password.Equals("Password") || confirmPassword.Equals("Confirm Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

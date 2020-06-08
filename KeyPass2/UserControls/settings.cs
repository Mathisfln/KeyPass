using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KeyPass2
{
    public partial class settings : UserControl
    {
        Model1 model = new Model1();
        public int settings_idUser;

        public settings()
        {
            InitializeComponent();
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            user current_user = model.user.Find(settings_idUser);
            var delete = model.password.Where(p => p.id_user == settings_idUser);


            if (MessageBox.Show("Are you sure to delete your account ? Your passwords will also be deleted", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (password p in delete)
                {
                    model.password.Remove(p);
                }
                model.user.Remove(current_user);
                model.SaveChanges();
                Login login = new Login();
                this.Hide();
                login.Show();
                MessageBox.Show("Your account has been deleted ! ");
            }
            else
            {
                MessageBox.Show("Error !");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            user current_user = model.user.Find(settings_idUser);
            if (!checkValues())
            {
                if (settingsPassword.Text.Equals(settingsPasswordConfirm.Text))
                {
                    if (MessageBox.Show("Are you sure ?", "CONFIRM", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        current_user.username = settingsUsername.Text;
                        current_user.mail = settingsMail.Text;
                        current_user.password = settingsPassword.Text;
                        model.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Error");
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
            String mail = settingsMail.Text;
            String username = settingsUsername.Text;
            String password = settingsPassword.Text;
            String confirmPassword = settingsPasswordConfirm.Text;

            if (mail.Equals("") || username.Equals("") || password.Equals("") || confirmPassword.Equals(""))
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

using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyPass2
{

    public partial class password_add : UserControl
    {
        Model1 model = new Model1();

        public int idUSER;
        public password_add()
        {
            InitializeComponent();
        }


        private void addName_Enter(object sender, EventArgs e)
        {
            String name = addName.Text;
            if (name.ToLower().Trim().Equals("name"))
            {
                addName.Text = "";
                addName.ForeColor = Color.Black;
            }
        }

        private void addName_Leave(object sender, EventArgs e)
        {

            String name = addName.Text;
            if (name.ToLower().Trim().Equals("name") || name.Trim().Equals(""))
            {
                addName.Text = "Name";
                addName.ForeColor = Color.LightGray;
            }
        }
        private void addType_Enter(object sender, EventArgs e)
        {
            String type = addType.Text;
            if (type.ToLower().Trim().Equals("type"))
            {
                addType.Text = "";
                addType.ForeColor = Color.Black;
            }
        }

        private void addType_Leave(object sender, EventArgs e)
        {
            String type = addType.Text;
            if (type.ToLower().Trim().Equals("type") || type.Trim().Equals(""))
            {
                addType.Text = "Type";
                addType.ForeColor = Color.LightGray;
            }
        }
        private void addPassword_Enter(object sender, EventArgs e)
        {
            String password = addPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                addPassword.Text = "";
                addPassword.ForeColor = Color.Black;
            }
        }

        private void addPassword_Leave(object sender, EventArgs e)
        {
            String password = addPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                addPassword.Text = "Password";
                addPassword.ForeColor = Color.LightGray;
            }
        }
        private void addDescription_Enter(object sender, EventArgs e)
        {
            String description = addDescription.Text;
            if (description.ToLower().Trim().Equals("description"))
            {
                addDescription.Text = "";
                addDescription.ForeColor = Color.Black;
            }
        }

        private void addDescription_Leave(object sender, EventArgs e)
        {
            String description = addDescription.Text;
            if (description.ToLower().Trim().Equals("description") || description.Trim().Equals(""))
            {
                addDescription.Text = "Description";
                addDescription.ForeColor = Color.LightGray;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!checkValues())
            {
//                var str = "String to be encrypted";
//                var pass = addPassword.Text;
//                var finalPass = Cipher.Encrypt(str, pass);
                password nPassword = new password { id_user = idUSER, name = addName.Text, type = addType.Text, description = addDescription.Text, password_user = addPassword.Text };
                model.password.Add(nPassword);
                if (model.SaveChanges() > 0)
                {
                    MessageBox.Show("Your password has been successfully added");
                    resetChamps();
                }
                else
                {
                    MessageBox.Show("Error", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter All Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


        public Boolean checkValues()
        {
            String name = addName.Text;
            String type = addType.Text;
            String description = addDescription.Text;
            String password = addPassword.Text;

            if (name.Equals("Name") || type.Equals("Type") || password.Equals("Password") || description.Equals("Description"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void resetChamps()
        {
            addName.Text = "Name";
            addName.ForeColor = Color.LightGray;
            addType.Text = "Type";
            addType.ForeColor = Color.LightGray;
            addPassword.Text = "Password";
            addPassword.ForeColor = Color.LightGray;
            addDescription.Text = "Description";
            addDescription.ForeColor = Color.LightGray;
        }
    }
}

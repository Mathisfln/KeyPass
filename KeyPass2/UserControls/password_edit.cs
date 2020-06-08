using System;
using System.Windows.Forms;

namespace KeyPass2
{
    public partial class password_edit : UserControl
    {
        Model1 model = new Model1();

        public int editPasswordId;
        public string username;
        public password_edit()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            password current_password = model.password.Find(editPasswordId);
            if (!checkValues())
            {
                current_password.name = editName.Text;
                current_password.description = editDescription.Text;
                current_password.type = editType.Text;
                current_password.password_user = editPassword.Text;
                model.SaveChanges();
                MessageBox.Show("Your password has been changed!");
            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public Boolean checkValues()
        {
            String name = editName.Text;
            String description = editDescription.Text;
            String type = editType.Text;
            String password_user = editPassword.Text;

            if (name.Equals("") || description.Equals("") || type.Equals("") || password_user.Equals(""))
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

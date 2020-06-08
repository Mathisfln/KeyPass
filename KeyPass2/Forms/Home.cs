using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyPass2
{
    public partial class Form1 : Form
    {
        Model1 model = new Model1();


        public int userID;

        public Form1(int id_user, string username)
        {
            InitializeComponent();
            username_label.Text = username;
            userID = id_user;
            displayData();
            addPassword_control.idUSER = userID;
            settings_control.settings_idUser = userID;
            panelPassword.Visible = false;
            listPassword_control.Show();
            addPassword_control.Hide();
            settings_control.Hide();
            editPassword_control.Hide();

        }

        // Display data in grid and refresh it
        public void displayData()
        {
                var query = model.password.Where(p => p.id_user == userID).Select(p => new { id = p.id_password, Name = p.name, Description = p.description, Type = p.type, Password = p.password_user });
            listPassword_control.password_grid.DataSource = query.ToList();
        }

        // Add password button
        private void button2_Click(object sender, EventArgs e)
        {
            addPassword_control.Show();
            listPassword_control.Hide();
            settings_control.Hide();
            editPassword_control.Hide();
        }
        // Password list button
        private void password_List_Click(object sender, EventArgs e)
        {
            listPassword_control.Show();
            addPassword_control.Hide();
            settings_control.Hide();
            editPassword_control.Hide();


            displayData();
        }
        // Disconnect Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        // Delete button
        private void button7_Click(object sender, EventArgs e)
        {
            if (listPassword_control.password_grid.CurrentRow == null)
            {
                MessageBox.Show("No item selected.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this record ?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int rowIndex = listPassword_control.password_grid.CurrentCell.RowIndex;
                    DataGridViewRow selectedRowId = listPassword_control.password_grid.Rows[rowIndex];

                    password pass_delete = model.password.Find(selectedRowId.Cells[0].Value);
                    model.password.Remove(pass_delete);
                    model.SaveChanges();

                    //    var query_delete = model.password.Where(p => p.id_user == userID && p.id_password.ToString() == selectedRowId.Cells[0].Value.ToString());
                    displayData();
                }
            }
        }

        //Edit button
        private void button3_Click(object sender, EventArgs e)
        {
            addPassword_control.Hide();
            listPassword_control.Hide();
            settings_control.Hide();
            editPassword_control.Show();
            editPassword_control.username = username_label.Text;

            if (listPassword_control.password_grid.CurrentRow == null)
            {
                MessageBox.Show("No item selected.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = listPassword_control.password_grid.CurrentCell.RowIndex;
                DataGridViewRow selectedRowId = listPassword_control.password_grid.Rows[rowIndex];
                password pass_edit = model.password.Find(selectedRowId.Cells[0].Value);
                if (pass_edit.id_user == userID)
                {
                    editPassword_control.editPasswordId = pass_edit.id_password;
                    editPassword_control.editName.Text = pass_edit.name;
                    editPassword_control.editType.Text = pass_edit.type;
                    editPassword_control.editDescription.Text = pass_edit.description;
                    editPassword_control.editPassword.Text = pass_edit.password_user;
                }
                else
                {
                    MessageBox.Show("Can't modify this password");
                }

            }
        }

        //Settings button
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            addPassword_control.Hide();
            listPassword_control.Hide();
            editPassword_control.Hide();
            settings_control.Show();

            user current_user = model.user.Find(userID);

            if (current_user.id_user == userID)
            {
                settings_control.settingsUsername.Text = current_user.username;
                settings_control.settingsMail.Text = current_user.mail;
                settings_control.settingsPassword.Text = current_user.password;
                settings_control.settingsPasswordConfirm.Text = current_user.password;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void passwordBtn_Click(object sender, EventArgs e)
        {
            if (panelPassword.Visible == true)
            {
                panelPassword.Visible = false;
            }
            else
            {
                panelPassword.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}

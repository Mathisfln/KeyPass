
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KeyPass2
{
    public partial class Login : Form
    {

        Model1 model = new Model1();

        public string username;
        public int user_id;
        public string Username { get { return username; } }
        public int User_id { get { return user_id; } }

        public Login()
        {
            InitializeComponent();
        }

        private void goToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerform = new Register();
            registerform.Show();
        }

        private void goToSignUp_MouseEnter(object sender, EventArgs e)
        {
            goToSignUp.ForeColor = Color.GreenYellow;
        }

        private void goToSignUp_MouseLeave(object sender, EventArgs e)
        {
            goToSignUp.ForeColor = Color.White;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var query = model.user.Where(p => p.username == userTextBox.Text && p.password == passwordTextBox.Text).FirstOrDefault<user>(); ;

            if (query == null)
            {
                MessageBox.Show("Wrong username or password !");
            }
            else
            {

                Form1 home = new Form1(query.id_user, query.username);
                home.Show();
                this.Hide();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPass2
{
    public partial class PasswordList : UserControl
    {
        KeyPassContext model = new KeyPassContext();

        public PasswordList()
        {
            InitializeComponent();
        }

        private void PasswordList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.password.Select(p => new { Name = p.name, Description = p.description, Type = p.type, Password = p.password_user }).ToList();
        }
    }
}

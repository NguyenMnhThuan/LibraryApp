using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryAppWF
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void UserPic_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Owner = this;
            user.Show();
        }
        //OPEN ADMIN LOGIN WINDOW
        private void AdminPic_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Owner = this;
            admin.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LibraryAppWF.BL;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryAppWF
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if ((tbUserEmail.Text != string.Empty || tbUserPass.Text != string.Empty) || (tbUserEmail.Text != string.Empty && tbUserPass.Text != string.Empty))
            {
                AdminBL adminBl = new AdminBL();
                bool isDone = adminBl.AdminLoginBL(tbUserEmail.Text, tbUserPass.Text);
                if (isDone)
                {
                    alertUser.Text = "";
                    MessageBox.Show("Logged in successfully...");
                    UserHomescreen userHomescreen = new UserHomescreen();
                    userHomescreen.Show();
                    this.Owner.Hide();
                    this.Close();
                    tbUserEmail.Clear();
                    tbUserPass.Clear();
                }
                else
                {
                    alertUser.ForeColor = Color.Red;
                    alertUser.Text = "Invalid email id or password...";
                    tbUserEmail.Clear();
                    tbUserPass.Clear();
                }
            }
            else
            {
                alertUser.ForeColor = Color.Red;
                alertUser.Text = "Enter the fields properly...";

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using LibraryAppWF.BL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryAppWF
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            
            if (tbAdminEmail.Text != string.Empty && tbAdminPass.Text != string.Empty)
            {
                AdminBL adminBl = new AdminBL();
                bool isDone = adminBl.LoginBL(tbAdminEmail.Text, tbAdminPass.Text);
                if (isDone)
                {
                    alertAdmin.Text = "";
                    MessageBox.Show("Logged in successfully...");
                    AdminHomescreen adminHomescreen = new AdminHomescreen();
                    adminHomescreen.Show();
                    this.Owner.Hide();
                    this.Close();
                    tbAdminEmail.Clear();
                    tbAdminPass.Clear();
                }
                else
                {
                    alertAdmin.ForeColor = Color.Red;
                    alertAdmin.Text = "Invalid email id or password...";
                    tbAdminEmail.Clear();
                    tbAdminPass.Clear();
                }
            }
            else
            {
                alertAdmin.ForeColor = Color.Red;
                alertAdmin.Text = "Enter the fields properly...";

            }
        }

    }
}

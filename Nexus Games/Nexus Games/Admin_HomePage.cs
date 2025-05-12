using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_Games
{
    public partial class Admin_HomePage : Form
    {
        public Admin_HomePage()
        {
            InitializeComponent();
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Delete_Request_Click(object sender, EventArgs e)
        {
            Admin_DeleteRequestTable admin_DeleteRequest = new Admin_DeleteRequestTable();
            admin_DeleteRequest.Show();
            this.Hide();
        }

        private void UserListButton_Click(object sender, EventArgs e)
        {
            Admin_UserListTable admin_UserListTable = new Admin_UserListTable();
            admin_UserListTable.Show();
            this.Hide();
        }

        private void UserListButton_MouseHover(object sender, EventArgs e)
        {
            UserListButton.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void Delete_Request_MouseHover(object sender, EventArgs e)
        {
            Delete_Request.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void Logout_Button_MouseHover(object sender, EventArgs e)
        {
            Logout_Button.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void UserListButton_MouseLeave(object sender, EventArgs e)
        {
            UserListButton.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void Delete_Request_MouseLeave(object sender, EventArgs e)
        {
            Delete_Request.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void Logout_Button_MouseLeave(object sender, EventArgs e)
        {
            Logout_Button.BackColor = Color.FromArgb(56, 52, 60);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nexus_Games
{
    public partial class DeleteAccount : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId;
        private string username;
        public DeleteAccount(int userId, string username)
        {
            this.userId = userId;
            this.username = username;
            InitializeComponent();
        }

        private int GetUserIdByUsername(string username)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT UID FROM Accounts WHERE USERNAME = @Username", con))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    object result = command.ExecuteScalar();
                    return (result != null) ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            userId = GetUserIdByUsername(username);
            Store_Homepage store_homepage = new Store_Homepage(userId,username);
            store_homepage.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into Delete_Request_Table values(@USER_ID,@USERNAME)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@USER_ID", userId);
                cmd.Parameters.AddWithValue("@USERNAME", username);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    DialogResult result = MessageBox.Show("Your Request Has been sent to Admin!!", "We will miss you", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
            }catch (Exception)
            {
                MessageBox.Show("Somthing went wrong!! Please try again.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

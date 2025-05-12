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

namespace Nexus_Games
{
    public partial class NewPassword : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId;
        private string username;
        public NewPassword(string username,int userId)
        {
            this.username = username;
            this.userId = userId;
            
            InitializeComponent();
        }

        private int GetUserIdByUsername(string username)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT UID FROM Accounts WHERE USERNAME = @Username", con))
                {
                    userId = GetUserIdByUsername(username);
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

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //RetypePasswordTextBox
            //NewPasswordtextBox
            if (ShowPassword.Checked)
            {
                NewPasswordtextBox.UseSystemPasswordChar = false;
                RetypePasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                NewPasswordtextBox.UseSystemPasswordChar = true;
                RetypePasswordTextBox.UseSystemPasswordChar = true;
            }

        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            Verify verify = new Verify();
            verify.Show();
            this.Hide();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            //Update password Database
            SqlConnection con = new SqlConnection(cs);
            
            if (NewPasswordtextBox.Text != "" && USERIDtextBox.Text != "")
            {
                try
                {
                    string query = "update Accounts set password=@password where uid=@uid";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uid", USERIDtextBox.Text);
                    cmd.Parameters.AddWithValue("@password", NewPasswordtextBox.Text);


                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not updated !!! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("Data not Found");
                }
            }
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            //USERIDtextBox.Text = Convert.ToString(userId);
            LoadUserData();

        }

        private void LoadUserData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT UID FROM Accounts WHERE username = @username", con))
                {
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        USERIDtextBox.Text = reader["UID"].ToString();
                    }

                    reader.Close();
                }
            }
        }
    }
}

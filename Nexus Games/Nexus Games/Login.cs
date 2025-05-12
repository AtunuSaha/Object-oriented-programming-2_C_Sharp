using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nexus_Games
{
    public partial class Login : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=Revision-PC\SQLEXPRESS;Initial Catalog=Project_Nexus;Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        private int clickCount = 0;

        private void UsernameTextBox_MouseHover(object sender, EventArgs e)
        {
            UsernameTextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void UsernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            UsernameTextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitLabelButton_MouseHover(object sender, EventArgs e)
        {
            ExitLabelButton.BackColor = Color.Red;
        }

        private void ExitLabelButton_MouseLeave(object sender, EventArgs e)
        {
            ExitLabelButton.BackColor = Color.Transparent;
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeLabel_MouseHover(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void MinimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.Transparent;
        }

        private void PasswordTextBox_MouseHover(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void PasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "admin" && PasswordTextBox.Text == "admin")
            {
                Admin_HomePage admin_homePage = new Admin_HomePage();
                admin_homePage.Show();
                this.Hide();
            }
            else {
                string username, password;
                username = UsernameTextBox.Text;
                password = PasswordTextBox.Text;
                SqlConnection con = new SqlConnection(cs);
                int userId = GetUserIdByUsername(username);
                try
                {
                    string querry = "SELECT * FROM Accounts WHERE USERNAME ='" + UsernameTextBox.Text + "'AND PASSWORD='" + PasswordTextBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
                    
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = UsernameTextBox.Text;
                        password = PasswordTextBox.Text;
                        
                        Store_Homepage store_Homepage = new Store_Homepage(userId,username);
                        store_Homepage.Show();
                        this.Hide();

                        UsernameTextBox.Focus();
                    }
                    else
                    {
                        UserErrorLabel.Text = "* Invalid Username";
                        PassErrorLabel.Text = "* Invalid Password";
                        UsernameTextBox.Clear();
                        PasswordTextBox.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void LoginButton_MouseHover(object sender, EventArgs e)
        {
            LoginButton.Image = Properties.Resources.ButtonHover;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.Image = Properties.Resources.ButtonColour;
        }

        private void CreditLabelButton_Click(object sender, EventArgs e)
        {
            About_us credit = new About_us();
            credit.Show();
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void Forgot_Password_Click(object sender, EventArgs e)
        {
            Verify verify = new Verify();
            verify.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.FromArgb(100,0,0,0);
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

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (clickCount == 0)
            {
                clickCount = 1;
                ShowPassword.Image = Properties.Resources.SeePassword;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                clickCount = 0;
                ShowPassword.Image = Properties.Resources.unseePassword;
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}

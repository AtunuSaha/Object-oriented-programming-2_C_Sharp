using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nexus_Games
{
    public partial class Library : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private string username;
        private int userId;  // Store the logged-in user's ID
        
        public Library(int userId, string username)
        {
            this.userId = userId;
            this.username = username;
            InitializeComponent();
            LoadUserData();
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
        private void LoadUserData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT PICTURE FROM Accounts WHERE UID = @UserId", con))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        if (reader["PICTURE"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["PICTURE"];
                            Profile_PictureBox.Image = GetPhoto(imageBytes);
                        }
                        else
                        {
                            // Set a default profile picture if the path is empty or null
                            Profile_PictureBox.Image = Properties.Resources.defaultProfile; // Replace with your default image resource
                        }
                    }

                    reader.Close();
                }
            }
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        private void ProfliePictureBox_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userId,username);
            profile.Show();
            this.Hide();
        }

        private void CartpictureBox_Click(object sender, EventArgs e)
        {
            Store_Homepage store_homepage = new Store_Homepage(userId,username);
            store_homepage.Show();
            this.Hide();
        }

        private void LibraryBoxButton_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verify verify = new Verify();
            verify.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Library_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Profile_PictureBox_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Profile_PictureBox, new Point(0, Profile_PictureBox.Height));
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library library = new Library(userId,username);
            library.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userId,username);
            profile.Show();
            this.Hide();
        }

        private void Profile_PictureBox_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Profile_PictureBox, new Point(0, Profile_PictureBox.Height));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount(userId, username);
            deleteAccount.Show();
            this.Close();
        }
    }
}

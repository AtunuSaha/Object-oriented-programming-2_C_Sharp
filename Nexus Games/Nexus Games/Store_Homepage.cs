using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nexus_Games
{
    public partial class Store_Homepage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId; // Store the logged-in user's ID
        private string username;
        public Store_Homepage(int userId,string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            LoadUserData();
        }
        int click = 0;
        

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Store_Homepage_MouseClick(object sender, MouseEventArgs e)
        {
            if (click != 0)
            {
                SearchTextBox.Width -= 300;
                SearchTextBox.Text = "Search Here";
                click = 0;
            }
            
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if(SearchTextBox.Text == " Search Here")
            {
                SearchTextBox.Text = "";
                SearchTextBox.Width += 300;
                SearchTextBox.ForeColor = Color.White;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBox.Text = " Search Here";
            SearchTextBox.Width -= 300;
            SearchTextBox.ForeColor = Color.Silver;
        }

        private void Profile_PictureBox_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Profile_PictureBox, new Point(0, Profile_PictureBox.Height));
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = GetUserIdByUsername(username);
            Profile profile = new Profile(userId, username);
            profile.Show();
            this.Hide();
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

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library library = new Library(userId,username);
            library.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitLabelButton_MouseHover(object sender, EventArgs e)
        {
            ExitLabelButton.BackColor = Color.Red;
        }

        private void ExitLabelButton_MouseLeave(object sender, EventArgs e)
        {
            ExitLabelButton.BackColor = Color.Transparent;
        }

        private void SearchTextBox_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void SearchTextBox_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Profile_PictureBox_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Profile_PictureBox, new Point(0, Profile_PictureBox.Height)); 
        }

        private void CartpictureBox_MouseHover(object sender, EventArgs e)
        {
            CartpictureBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void CartpictureBox_MouseLeave(object sender, EventArgs e)
        {
            CartpictureBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void LibraryBoxButton_MouseHover(object sender, EventArgs e)
        {
            LibraryBoxButton.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void LibraryBoxButton_MouseLeave(object sender, EventArgs e)
        {
            LibraryBoxButton.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
        }

        private void ProfliePictureBox_MouseLeave(object sender, EventArgs e)
        {
        }

        private void CartpictureBox_Click(object sender, EventArgs e)
        {

        }

        private void LibraryBoxButton_Click(object sender, EventArgs e)
        {
            Library library = new Library(userId,username);
            library.Show();
            this.Hide();
        }

        private void ProfliePictureBox_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userId,username);
            profile.Show();
            this.Hide();
        }

        private void RECOMMENDATION_LIST_GAME1_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
            R6 gameInfo = new R6(userId, username);
            gameInfo.Show();
            this.Hide();
        }

        private void RECOMMENDATION_LIST_GAME2_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
            RE gameInfo = new RE(userId, username);
            gameInfo.Show();
            this.Hide();
        }
        private void RECOMMENDATION_LIST_GAME3_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
        }

        private void RECOMMENDATION_LIST_GAME4_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
        }

        //Will Update later
        private void RECOMMENDATION_LIST_GAME1_MouseHover(object sender, EventArgs e)
        {
            RECOMMENDATION_LIST_GAME1.Image = Properties.Resources.R6_LOGO2;
        }

        private void RECOMMENDATION_LIST_GAME1_MouseLeave(object sender, EventArgs e)
        {
            RECOMMENDATION_LIST_GAME1.Image = Properties.Resources.R6_Game_Logo;
        }

        private void GAME_LIST_GAME1_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
        }

        private void GAME_LIST_GAME2_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
        }

        private void GAME_LIST_GAME3_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
        }

        private void GAME_LIST_GAME4_Click(object sender, EventArgs e)
        {
            //PurchaseGames();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //It will auto Logout
            Verify verify = new Verify();
            verify.Show();
            this.Hide();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Store_Homepage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            //panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            CartpictureBox.Focus();

        }

        private void GAME_LIST_GAME1_MouseLeave(object sender, EventArgs e)
        {
            GAME_LIST_GAME1.Image = Properties.Resources.R6_Game_Logo;
        }

        private void GAME_LIST_GAME1_MouseHover(object sender, EventArgs e)
        {
            GAME_LIST_GAME1.Image = Properties.Resources.R6_LOGO2;
        }

        private void Profile_PictureBox_MouseLeave(object sender, EventArgs e)
        {

        }

        private void RECOMMENDATION_LIST_GAME2_MouseHover(object sender, EventArgs e)
        {
            RECOMMENDATION_LIST_GAME2.Image = Properties.Resources.RE_LOGO_GIF;
        }

        private void RECOMMENDATION_LIST_GAME2_MouseLeave(object sender, EventArgs e)
        {
            RECOMMENDATION_LIST_GAME2.Image = Properties.Resources.RE_LOGO;
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount(userId,username);
            deleteAccount.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Tom Clancy's Rainbow Six® Siege
            //Resident Evil 2
            if (SearchTextBox.Text == "Tom Clancy's Rainbow Six® Siege" || SearchTextBox.Text == "tom Clancy's Rainbow Six® Siege" || SearchTextBox.Text == "R6" || SearchTextBox.Text == "Rainbow 6")
            {
                R6 GameInfo = new R6(userId, username);
                GameInfo.Show();
                this.Close();

            } else if (SearchTextBox.Text == "Resident Evil 2" || SearchTextBox.Text == "resident Evil 2" || SearchTextBox.Text == "RE2" || SearchTextBox.Text == "re2")
            {
                RE GameInfo = new RE(userId, username);
                GameInfo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Games Not Found");
            }      
        }

        private void GAME_LIST_GAME2_MouseHover(object sender, EventArgs e)
        {
            GAME_LIST_GAME2.Image = Properties.Resources.RE_LOGO_GIF;
        }

        private void GAME_LIST_GAME2_MouseLeave(object sender, EventArgs e)
        {
            GAME_LIST_GAME2.Image = Properties.Resources.RE_LOGO;
        }
    }
}

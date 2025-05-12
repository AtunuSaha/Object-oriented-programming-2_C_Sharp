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
    public partial class Profile : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId; // Store the logged-in user's ID
        private string username;

        public Profile(int loggedInUserId,string username)
        {
            InitializeComponent();
            userId = loggedInUserId;
            this.username = username;
            LoadUserData();
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void LoadUserData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT USERNAME, UID, PICTURE, DATE FROM Accounts WHERE UID = @UserId", con))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        UsernameTextBox.Text = reader["USERNAME"].ToString();
                        USERIDtextBox.Text = reader["UID"].ToString();

                        DateTime dateOfBirth = Convert.ToDateTime(reader["DATE"]);
                        DATEOFBIRTHtextBox.Text = dateOfBirth.ToString("MMMM  dd, yyyy");

                        if (reader["PICTURE"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["PICTURE"];
                            ProfilePictureBox.Image = GetPhoto(imageBytes);
                            Profile_PictureBox.Image = GetPhoto(imageBytes);
                        }
                        else
                        {
                            // Set a default profile picture if the path is empty or null
                            ProfilePictureBox.Image = Properties.Resources.defaultProfile; // Replace with your default image resource
                        }
                    }

                    reader.Close();
                }
            }
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void BindGridView()
        {


            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Accounts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);


            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            ProfilePictureBox.Image.Save(ms, ProfilePictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EditButton.Text == "Edit Profile")
            {
                EditButton.Text = "Save";
                UsernameTextBox.ReadOnly = false;
                USERIDtextBox.ReadOnly = true; //User Cannot change USER ID
                ABOUTUSERtextBox.ReadOnly = false;
            }
            else
            {
                EditButton.Text = "Edit Profile";
                UsernameTextBox.ReadOnly = true;
                ABOUTUSERtextBox.ReadOnly = true;

                //Database here- Override old data using USER ID

                if (UsernameTextBox.Text != "" && USERIDtextBox.Text != "" && DATEOFBIRTHtextBox.Text != "" && ProfilePictureBox.Image != null)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(cs);

                        string query = "update Accounts set USERNAME = @USERNAME,DATE = @DATE,picture=@picture where uid=@uid";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@UID", USERIDtextBox.Text);
                        cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@DATE", DATEOFBIRTHtextBox.Text);
                        cmd.Parameters.AddWithValue("@picture", SavePhoto());


                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Profile updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindGridView();
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

        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            Store_Homepage back = new Store_Homepage(userId,username);
            back.Show();
            this.Hide();
        }
        
        
        private void Profile_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);

            //Profile Load from DATABASE
        }

        private void LibraryBoxButton_Click(object sender, EventArgs e)
        {
            Library library = new Library(userId, username);
            library.Show();
            this.Hide();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            if (EditButton.Text == "Save") {
                string imageLocation = "";
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = openFileDialog.FileName;
                        ProfilePictureBox.ImageLocation = imageLocation;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured Uloading Image");
                }
            }
        }

        private void CartpictureBox_Click(object sender, EventArgs e)
        {
            Store_Homepage store_homepage = new Store_Homepage(userId,username);
            store_homepage.Show();
            this.Hide();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verify verify = new Verify();
            verify.Show();
            this.Hide();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library library = new Library(userId, username);
            library.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Profile_PictureBox_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Profile_PictureBox, new Point(0, Profile_PictureBox.Height));
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Profile_PictureBox_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip.Show(Profile_PictureBox, new Point(0, Profile_PictureBox.Height));
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount(userId, username);
            deleteAccount.Show();
            this.Close();
        }

        private void ProfliePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

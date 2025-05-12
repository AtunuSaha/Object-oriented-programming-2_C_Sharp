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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nexus_Games
{
    public partial class Admin_UserListTable : Form
    {
        public Admin_UserListTable()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

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
            Admin_HomePage admin_HomePage = new Admin_HomePage();
            admin_HomePage.Show();
            this.Hide();
        }

        private void Admin_UserListTable_Load(object sender, EventArgs e)
        {
            BindGridView();
            BindGridView();
        }

        public void BindGridView()
        {


            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Accounts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView.DataSource = data;


            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView.Columns[5];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView.RowTemplate.Height = 100;
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            BindGridView();
        }
        public void Reset()
        {
            USERIDtextBox.Clear();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from Accounts where uid=@uid";
            string query2 = "delete from Delete_Request_Table where USER_ID = @uid";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@uid", USERIDtextBox.Text);
            cmd2.Parameters.AddWithValue("@uid", USERIDtextBox.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            int b = cmd2.ExecuteNonQuery();
            if (a > 0 && b>0)
            {
                MessageBox.Show("Data deleted Successfully.. ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Data not dnserted !!!! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ACCOUNTNAMEtextBox.Text != "" && EMAILADDRESStextBox.Text != "" && PASSWORDtextBox.Text != "" && pictureBox.Image != null)
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);

                    string query = "update Accounts set username=@username,email=@email,password=@password,date=@date,picture=@picture where uid=@uid";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@uid", USERIDtextBox.Text);
                    cmd.Parameters.AddWithValue("@username", ACCOUNTNAMEtextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PASSWORDtextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EMAILADDRESStextBox.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@picture", SavePhoto());


                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data updated Successfully ......... ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Data not updated !!! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("Data not Found");
                }
            }
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Select Image";
                ofd.Filter = "Image File (All files) *.* | *.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(ofd.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured Uloading Image");
            }
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            if (ACCOUNTNAMEtextBox.Text != "" && EMAILADDRESStextBox.Text != "" && PASSWORDtextBox.Text != "" && pictureBox.Image != null)
            {
                SqlConnection con = new SqlConnection(cs);

                string query = "insert into Accounts values(@username,@email,@password,@date,@picture)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", ACCOUNTNAMEtextBox.Text);
                cmd.Parameters.AddWithValue("@password", PASSWORDtextBox.Text);
                cmd.Parameters.AddWithValue("@email", EMAILADDRESStextBox.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("@picture", SavePhoto());


                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data updated Successfully ......... ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Data not updated !!! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ACCOUNTNAMEtextBox_MouseHover(object sender, EventArgs e)
        {
            ACCOUNTNAMEtextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void USERIDtextBox_MouseHover(object sender, EventArgs e)
        {
            USERIDtextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void EMAILADDRESStextBox_MouseHover(object sender, EventArgs e)
        {
            EMAILADDRESStextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void PASSWORDtextBox_MouseHover(object sender, EventArgs e)
        {
            PASSWORDtextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void ACCOUNTNAMEtextBox_MouseLeave(object sender, EventArgs e)
        {
            ACCOUNTNAMEtextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void USERIDtextBox_MouseLeave(object sender, EventArgs e)
        {
            USERIDtextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void EMAILADDRESStextBox_MouseLeave(object sender, EventArgs e)
        {
            EMAILADDRESStextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void PASSWORDtextBox_MouseLeave(object sender, EventArgs e)
        {
            PASSWORDtextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void Insert_button_MouseHover(object sender, EventArgs e)
        {
            Insert_button.Image = Properties.Resources.ButtonHover;
        }

        private void Update_button_MouseHover(object sender, EventArgs e)
        {
            Update_button.Image = Properties.Resources.ButtonHover;
        }

        private void Delete_Button_MouseHover(object sender, EventArgs e)
        {
            Delete_Button.Image = Properties.Resources.ButtonHover;
        }

        private void Browsebutton_MouseHover(object sender, EventArgs e)
        {
            Browsebutton.Image = Properties.Resources.ButtonHover;
        }

        private void Insert_button_MouseLeave(object sender, EventArgs e)
        {
            Insert_button.Image = Properties.Resources.ButtonColour;
        }

        private void Update_button_MouseLeave(object sender, EventArgs e)
        {
            Update_button.Image = Properties.Resources.ButtonColour;
        }

        private void Delete_Button_MouseLeave(object sender, EventArgs e)
        {
            Delete_Button.Image = Properties.Resources.ButtonColour;
        }

        private void Browsebutton_MouseLeave(object sender, EventArgs e)
        {
            Browsebutton.Image = Properties.Resources.ButtonColour;
        }
    }
}

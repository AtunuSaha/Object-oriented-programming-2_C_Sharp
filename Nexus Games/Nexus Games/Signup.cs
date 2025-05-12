using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;

namespace Nexus_Games
{
    public partial class Signup : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=Revision-PC\SQLEXPRESS;Initial Catalog=Project_Nexus;Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Signup()
        {
            InitializeComponent();
        }
        public static int Result;
        public static int Random_value_1;
        public static int Random_value_2;
        private int clickCount = 0; 
        public void SetRandom()
        {
            Random random = new Random();
            Random_value_1 = random.Next(20);
            Random_value_2 = random.Next(20);
            int Operator = random.Next(3);

            if (Operator == 0)
            {
                OPERATORLABEL.Text = " +";
                Result = Random_value_1 + Random_value_2;
            }
            else if (Operator == 1)
            {
                OPERATORLABEL.Text = " -";
                Result = Random_value_1 - Random_value_2;
            }
            else if (Operator == 2)
            {
                OPERATORLABEL.Text = " x";
                Result = Random_value_1 * Random_value_2;
            }

            //UserResult.Text = Convert.ToString(Result); Developer Test
            VALUE1LABEL.Text = Convert.ToString(Random_value_1);
            VALUE2LABEL.Text = Convert.ToString(Random_value_2);
        }
        private void SignupLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitLabel_MouseHover(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.Red;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.Transparent;
        }

        private void MinimizeLabel_MouseHover(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void MinimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.Transparent;
        }

        private void ACCOUNTNAMEtextBox_MouseLeave(object sender, EventArgs e)
        {
            ACCOUNTNAMEtextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void ACCOUNTNAMEtextBox_MouseHover(object sender, EventArgs e)
        {
            ACCOUNTNAMEtextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void EMAILADDRESStextBox_MouseHover(object sender, EventArgs e)
        {
            EMAILADDRESStextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void EMAILADDRESStextBox_MouseLeave(object sender, EventArgs e)
        {
            EMAILADDRESStextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void PASSWORDtextBox_MouseHover(object sender, EventArgs e)
        {
            PASSWORDtextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void PASSWORDtextBox_MouseLeave(object sender, EventArgs e)
        {
            PASSWORDtextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void CONFIRM_PASSWORDtextBox_MouseHover(object sender, EventArgs e)
        {
            CONFIRM_PASSWORDtextBox.BackColor = Color.FromArgb(64, 60, 68);
        }

        private void CONFIRM_PASSWORDtextBox_MouseLeave(object sender, EventArgs e)
        {
            CONFIRM_PASSWORDtextBox.BackColor = Color.FromArgb(56, 52, 60);
        }

        private void UPLOADbutton_MouseHover(object sender, EventArgs e)
        {
            UPLOADbutton.Image = Properties.Resources.ButtonHover;
        }

        private void UPLOADbutton_MouseLeave(object sender, EventArgs e)
        {
            UPLOADbutton.Image = Properties.Resources.ButtonColour;
        }

        private void CreateButton_MouseHover(object sender, EventArgs e)
        {
            CreateButton.Image = Properties.Resources.ButtonHover;
        }

        private void CreateButton_MouseLeave(object sender, EventArgs e)
        {
            CreateButton.Image = Properties.Resources.ButtonColour;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userResult = Convert.ToInt32(UserResult.Text);
                if (Result == userResult)
                {
                    if (validate_emailaddress.IsMatch(EMAILADDRESStextBox.Text) != true)
                    {
                        UserErrorLabel.Text = "* Email Address is not a valid Type";
                        EMAILADDRESStextBox.Focus();
                        return;
                    }
                    else
                    {
                        UserErrorLabel.Text = "";
                        DateTime selectedDate = dateTimePicker.Value;
                        DateTime today = DateTime.Today;
                        int age = today.Year - selectedDate.Year;

                        if (selectedDate > today.AddYears(-age))
                        {
                            age--;
                        }

                        if (age >= 16)
                        {
                            //Account will be Created Here.....
                            SqlConnection con = new SqlConnection(cs);
                            string query = "insert into Accounts values(@username,@email,@password,@date,@picture)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@username", ACCOUNTNAMEtextBox.Text);
                            cmd.Parameters.AddWithValue("@email", EMAILADDRESStextBox.Text);
                            cmd.Parameters.AddWithValue("@password", PASSWORDtextBox.Text);
                            cmd.Parameters.AddWithValue("@date", dateTimePicker.Text);
                            cmd.Parameters.AddWithValue("@picture", SavePhoto());

                            con.Open();
                            int a = cmd.ExecuteNonQuery();
                            if (a > 0)
                            {

                                DialogResult result = MessageBox.Show("Your Account Has been Created!!", "Congratulations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result == DialogResult.OK)
                                {
                                    DateOfBirthErrorLabel.Text = "";
                                    Login login = new Login();
                                    login.Show();
                                    this.Hide();
                                }
                                // BindGridView();
                            }
                        }
                        else {
                            DateOfBirthErrorLabel.Text = "* You must be 16 years or older to sign up.";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Captcha Not Matched");
                    SetRandom();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetRandom();
            }
        }
        byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            SetRandom();
        }

        private void UPLOADbutton_Click(object sender, EventArgs e)
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
            catch(Exception)
            {
                MessageBox.Show("An Error Occured Uloading Image");
            }
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //Email Part
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (clickCount == 0)
            {
                clickCount = 1;
                ShowPassword.Image = Properties.Resources.SeePassword;
                PASSWORDtextBox.UseSystemPasswordChar = false;
                CONFIRM_PASSWORDtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                clickCount = 0;
                ShowPassword.Image = Properties.Resources.unseePassword;
                PASSWORDtextBox.UseSystemPasswordChar = true;
                CONFIRM_PASSWORDtextBox.UseSystemPasswordChar = true;
            }
        }
    }
}

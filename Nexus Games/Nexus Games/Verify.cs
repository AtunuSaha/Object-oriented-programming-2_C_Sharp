using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_Games
{
    public partial class Verify : Form
    {
        private int userId;
        //SqlConnection conn = new SqlConnection(@"Data Source=Revision-PC\SQLEXPRESS;Initial Catalog=NexusGame_Database;Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Verify()
        {
            InitializeComponent();
        }
        public static int Result;
        public static int Random_value_1;
        public static int Random_value_2;
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
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            try { 
            int userResult = Convert.ToInt32(UserResult.Text);
            if (Result == userResult)
            {

                string username;
                username = USERNAMEtextBox.Text;
                try
                {
                    string querry = "SELECT * FROM Accounts WHERE USERNAME ='" + USERNAMEtextBox.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = USERNAMEtextBox.Text;

                        NewPassword newPassword = new NewPassword(username, userId);
                        newPassword.Show();
                        this.Hide();

                        USERNAMEtextBox.Focus();
                    }
                    else
                    {
                        UserErrorLabel.Text = "* No Username Found";
                        SetRandom();
                        USERNAMEtextBox.Clear();
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
            else if (Result != userResult)
            {
                MessageBox.Show("Are you a Robot? Try Again");
            }
         }catch{
                MessageBox.Show("You have not complete Captcha");
                SetRandom();
            }
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            SetRandom();
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
    }
}

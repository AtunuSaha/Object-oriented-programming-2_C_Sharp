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
    public partial class R6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId;
        private string username;
        public R6(int userId, string username)
        {
            this.userId = userId;
            this.username = username;
            InitializeComponent();
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            userId = GetUserIdByUsername(username);
            Store_Homepage store_Homepage = new Store_Homepage(userId,username);
            store_Homepage.Show();
            this.Hide();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            PaymentType paymentype = new PaymentType(userId, username);
            paymentype.Show();
            this.Hide();
        }

        private void GameInfo_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
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
    }
}

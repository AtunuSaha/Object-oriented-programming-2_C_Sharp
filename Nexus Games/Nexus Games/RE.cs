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
    public partial class RE : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId;
        private string username;
        public RE(int userId, string username)
        {
            this.userId = userId;
            this.username = username;
            InitializeComponent();
        }

        private void RE_Load(object sender, EventArgs e)
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

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            PaymentType paymentype = new PaymentType(userId, username);
            paymentype.Show();
            this.Hide();
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            userId = GetUserIdByUsername(username);
            Store_Homepage store_Homepage = new Store_Homepage(userId, username);
            store_Homepage.Show();
            this.Hide();
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

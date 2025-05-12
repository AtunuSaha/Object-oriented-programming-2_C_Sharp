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
    public partial class Admin_DeleteRequestTable : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Admin_DeleteRequestTable()
        {
            InitializeComponent();
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Admin_DeleteRequestTable_Load(object sender, EventArgs e)
        {
            BindGridView();
        }
        public void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Delete_Request_Table";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView.DataSource = data;


            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            //dgv = (DataGridViewImageColumn)dataGridView.Columns[1];


            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView.RowTemplate.Height = 100;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Admin_UserListTable admin_UserListTable = new Admin_UserListTable();
            admin_UserListTable.Show();
            this.Hide();
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            Admin_HomePage admin_HomePage = new Admin_HomePage();
            admin_HomePage.Show();
            this.Hide();
        }
    }
}

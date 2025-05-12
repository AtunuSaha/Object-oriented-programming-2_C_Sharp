using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nexus_Games
{
    public partial class PaymentType : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private int userId;
        private string username;
        public PaymentType(int userId, string username)
        {
            this.userId = userId;
            this.username = username;
            InitializeComponent();
        }

        private void OPTION_BKASH_CheckedChanged(object sender, EventArgs e)
        {
            BKASH bkash = new BKASH() { TopLevel = false, TopMost = true };
            bkash.FormBorderStyle = FormBorderStyle.None;
            PurchaseFormPanel.Controls.Clear();
            PurchaseFormPanel.Controls.Add(bkash);
            bkash.Show();           
        }

        private void OPTION_NAGAD_CheckedChanged(object sender, EventArgs e)
        {

            NAGAD nagad = new NAGAD() { TopLevel = false, TopMost = true };
            nagad.FormBorderStyle = FormBorderStyle.None;
            PurchaseFormPanel.Controls.Clear();
            PurchaseFormPanel.Controls.Add(nagad);
            nagad.Show();
        }

        private void ExitLabelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            Store_Homepage back = new Store_Homepage(userId, username);
            back.Show();
            this.Hide();
        }

        private void OPTION_CREDITCARD_CheckedChanged(object sender, EventArgs e)
        {
            CreditCard creditcard = new CreditCard() { TopLevel = false, TopMost = true };
            creditcard.FormBorderStyle = FormBorderStyle.None;
            PurchaseFormPanel.Controls.Clear();
            PurchaseFormPanel.Controls.Add(creditcard);
            creditcard.Show();
        }

        private void OPTION_DEBITCARD_CheckedChanged(object sender, EventArgs e)
        {
            DebitCard debitcard = new DebitCard() { TopLevel = false, TopMost = true };
            debitcard.FormBorderStyle = FormBorderStyle.None;
            PurchaseFormPanel.Controls.Clear();
            PurchaseFormPanel.Controls.Add(debitcard);
            debitcard.Show();
        }
    }
}

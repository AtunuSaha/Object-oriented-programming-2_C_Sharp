using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Nexus_Games
{
    public partial class NAGAD : Form
    {
        public NAGAD()
        {
            InitializeComponent();
        }

        private void NagadPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            ShowPopup();
            MessageBox.Show("Thanks for Purchasing");  
        }
        private void ShowPopup()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Game Purchase Done";
            popup.ContentText = "You can now download it from Library";
            popup.Popup();
        }
    }
}

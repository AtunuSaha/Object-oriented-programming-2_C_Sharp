using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_Games
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void BackLabelButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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

        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxQuestions.Text == "Select Question?") {
                AnswersTextBox.Text = "";
                //Select Question?
                //I can't log into my account.
                //I forgot my password.
                //I can't complete a purchase.
                //How long it will take to delete my Account?
            }
            else if (comboBoxQuestions.Text == "I can't log into my account.")
            {
                AnswersTextBox.Text = "If you're having trouble logging into your account, please make sure you're using the correct email address and password. If you've forgotten your password, you can use the 'Forgot Password' or 'Reset Password' option on the login page to reset it. If you're still unable to log in, you might want to check if there's any ongoing maintenance or server issues. If the problem persists, consider reaching out to customer support for further assistance.";
            }
            else if(comboBoxQuestions.Text == "I forgot my password.")
            {
                AnswersTextBox.Text = "If you've forgotten your password, don't worry. Just go to the login page and look for the 'Forgot Password' or 'Reset Password' option. Click on it, and you'll receive instructions on how to reset your password through your email. Follow those steps, create a new password, and you should be able to access your account again.";
            }
            else if(comboBoxQuestions.Text == "I can't complete a purchase.")
            {
                AnswersTextBox.Text = "I'm sorry to hear that you're having trouble completing your purchase. To better assist you, could you please provide more details about the issue you're encountering? This will help us identify the problem and guide you toward a solution.\n\nOur Business mail: 22-47411-2@student.aiub.edu";
            }
            else if(comboBoxQuestions.Text == "How long will it takes to delete my Account?")
            {
                AnswersTextBox.Text = "The process of deleting your account typically involves obtaining approval from our administrator. Once the request is approved, the account deletion will be initiated. This entire process is usually completed within 48 hours, ensuring that your account is removed from our system as quickly as possible.";
            }
        }
    }
}

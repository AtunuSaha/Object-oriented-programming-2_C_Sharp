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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingBarPanel.Width += 3;
            if(LoadingBarPanel.Width>= 800)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}

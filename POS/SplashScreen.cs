using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(71,181,183);
        }
        private void cargarLogin()
        {

            this.Hide();
            Login.Login login = new Login.Login();
            login.Show();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarLogin();
            timer1.Enabled = false;
        }
    }
}

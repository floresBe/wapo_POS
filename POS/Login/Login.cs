using POS.Inicio;
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

namespace POS.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(0, 136, 189);
            txtUsuario.ForeColor = Color.FromArgb(88, 43, 115);
            txtPassword.ForeColor = Color.FromArgb(157, 95, 196);
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Favor de ingresar un usuario");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Favor de ingresar una contraseña");
            }
            else
            {
                validar(txtUsuario.Text, txtPassword.Text);
            }
        }
        private void validar(string usuario, string password)
        {
            if(usuario == "wapo" && password == "1234")
            {
                MenuLauncher mainMenu = new MenuLauncher();
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contrasenia incorrectos");
                limpiarForm();
            }
        }
        private void limpiarForm()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsuario.Focus();
        }
        private void onCompleted(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                btnEntrar.PerformClick();
            }

        }
    }
}

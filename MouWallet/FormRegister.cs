using MouWallet.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MouWallet
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        //Este es el botón de cerrar
        private void cerrar_win_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Este es el botón de minimizar
        private void minimizar_win_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        //Evento cambiar de formulario
        private void login_text_Click(object sender, EventArgs e)
        {
            login_form loginForm = new login_form();
            loginForm.Show();
            this.Hide();
        }

        private void usuario_log_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            contraseña_log_text.UseSystemPasswordChar = !contraseña_log_text.UseSystemPasswordChar;
        }

        private void btnVerCC_Click(object sender, EventArgs e)
        {
            confirmar_text.UseSystemPasswordChar = !confirmar_text.UseSystemPasswordChar;
        }

        private void contraseña_log_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmar_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SuperadminConfig superadminConfig = new SuperadminConfig();

            if (contraseña_log_text.Text == confirmar_text.Text)
            {
                SuperadminConfig.Usuario = usuario_log_text.Text;
                SuperadminConfig.Contraseña = contraseña_log_text.Text;
                

                MessageBox.Show("Su cuenta ha sido registrada, regrese al formulario de inicio de sesión");
                usuario_log_text.Text = null;
                contraseña_log_text.Text = null;
                confirmar_text.Text = null;
            }
            else
            {
                MessageBox.Show("Sus contraseñas no son compatibles, intentalo nuevamente");
            }
        }
    }
}

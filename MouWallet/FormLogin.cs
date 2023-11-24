using MouWallet.Config;

namespace MouWallet
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }


        //Este es el botón de cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Este es el boton de máximizar
        private void max_win_Click(object sender, EventArgs e)
        {

        }


        //Este es el botón de minimizar
        private void minimizar_win_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }


        private void usuario_log_text_TextChanged(object sender, EventArgs e)
        {

        }

        //Evento cambiar formulario
        private void registro_text_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            contraseña_log_text.UseSystemPasswordChar = !contraseña_log_text.UseSystemPasswordChar;
        }


        //Evento principal
        private void login_button_Click(object sender, EventArgs e)
        {
            if (usuario_log_text.Text == SuperadminConfig.Usuario && contraseña_log_text.Text == SuperadminConfig.Contraseña)
            {
                Principal principalForm = new Principal();
                principalForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                usuario_log_text.Text = "";
                contraseña_log_text.Text = "";
            }
        }
    }
}
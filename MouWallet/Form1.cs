using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouWallet
{
    public partial class OpcionesForm : Form
    {
        public OpcionesForm()
        {
            InitializeComponent();
        }


        //Evento cerrar formulario y crear tabControl
        public event EventHandler CrearNuevoRegistroClicked = delegate { };
        public event EventHandler VerCuentasRegistradasClicked = delegate { };

        private void btn_añadir_cuenta_Click(object sender, EventArgs e)
        {
            
            // Dispara el evento antes de cerrar el formulario
            CrearNuevoRegistroClicked?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Dispara el evento antes de cerrar el formulario
            VerCuentasRegistradasClicked?.Invoke(this, EventArgs.Empty);

            // Cierra el formulario
            this.Close();
        }

        private void OpcionesForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}

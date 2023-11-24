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
    public partial class Principal : Form
    {
        private List<Registro> ListaDeRegistros = new List<Registro>();

        //animación sideBar
        bool sidebar_expand;
        public Principal()
        {
            InitializeComponent();
        }

        private void sidebar_timer_tick(object sender, EventArgs e)
        {
            if (sidebar_expand)
            {
                pnl_sidebar.Width -= 10;
                if (pnl_sidebar.Width <= pnl_sidebar.MinimumSize.Width)
                {
                    sidebar_expand = false;
                    sidebar_timer.Stop();
                }
            }
            else
            {
                pnl_sidebar.Width += 10;
                if (pnl_sidebar.Width >= pnl_sidebar.MaximumSize.Width)
                {
                    sidebar_expand = true;
                    sidebar_timer.Stop();
                }
            }
        }


        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void btn_cuentas_Click(object sender, EventArgs e)
        {
            OpcionesForm opcionesForm = new OpcionesForm();
            //subscripción al evento

            opcionesForm.CrearNuevoRegistroClicked += OpcionesForm_CrearNuevoRegistroClicked;
            opcionesForm.VerCuentasRegistradasClicked += OpcionesForm_VerCuentasRegistradasClicked;


            // Mostrar el formulario de opciones
            opcionesForm.ShowDialog();
        }
        private void OpcionesForm_VerCuentasRegistradasClicked(object? sender, EventArgs e)
        {
            VerCuentasRegistradas();
        }
        private void OpcionesForm_CrearNuevoRegistroClicked(object? sender, EventArgs e)
        {
            // Realizar la acción deseada al hacer clic en "Crear Nuevo Registro"
            // Por ejemplo, abrir un nuevo control para añadir registros
            AñadirControlDeRegistro();
        }
        private void AñadirControlDeRegistro()
        {
            // Crea una instancia del formulario para añadir registros
            AñadirCuentas añadirCuentas = new AñadirCuentas();

            // Crea una nueva pestaña en el TabControl
            TabPage nuevaPestaña = new TabPage("Nueva Cuenta");

            // Coloca el formulario en la pestaña
            añadirCuentas.TopLevel = false;
            nuevaPestaña.Controls.Add(añadirCuentas);
            añadirCuentas.Dock = DockStyle.Fill;
            añadirCuentas.FormBorderStyle = FormBorderStyle.None;
            añadirCuentas.Show();

            // Agrega la nueva pestaña al TabControl
            tbctrl_añadir_cuentas.TabPages.Add(nuevaPestaña);

            // Selecciona la nueva pestaña para que sea visible
            tbctrl_añadir_cuentas.SelectedTab = nuevaPestaña;
        }
        private void VerCuentasRegistradas()
        {
            VerCuentas verCuentas = new VerCuentas(ListaDeRegistros);
            TabPage nuevaPestaña = new TabPage("Ver cuentas");

            verCuentas.TopLevel = false;
            nuevaPestaña.Controls.Add(verCuentas);
            verCuentas.Dock = DockStyle.Fill;
            verCuentas.FormBorderStyle = FormBorderStyle.None;
            verCuentas.Show();

            tbctrl_añadir_cuentas.TabPages.Add(nuevaPestaña);
            tbctrl_añadir_cuentas.SelectedTab = nuevaPestaña;
        }

        private void btn_nosotros_Click(object sender, EventArgs e)
        {

        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
            AñadirCuentas añadirCuentas = new AñadirCuentas();
            añadirCuentas.ExportarDataGridViewAExcel();
        }
    }
}

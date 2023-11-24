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
    public partial class VerCuentas : Form
    {

        private List<Registro> ListaDeRegistros;
        private BindingSource bindingSource;

        public VerCuentas(List<Registro> registros)
        {

            InitializeComponent();

            dgv_cuentas_registradas.AutoGenerateColumns = false;

            ListaDeRegistros = registros ?? new List<Registro>();
            

            bindingSource = new BindingSource();
            bindingSource.DataSource = ListaDeRegistros;

            MostrarRegistros();
        }





        public void MostrarRegistros()
        {
            // Limpiar las filas existentes en el DataGridView
            //dgv_cuentas_registradas.Rows.Clear();
            dgv_cuentas_registradas.DataSource = null;
            dgv_cuentas_registradas.DataSource = bindingSource;

            // Iterar sobre cada registro en la lista
            foreach (Registro registro in ListaDeRegistros)
            {
                // Añadir una nueva fila al DataGridView y asignar los valores
                int rowIndex = dgv_cuentas_registradas.Rows.Add();
                dgv_cuentas_registradas.Rows[rowIndex].Cells["dtbc_nombre_cuenta"].Value = registro.nombre_cuenta;
                dgv_cuentas_registradas.Rows[rowIndex].Cells["dtbc_categoria_cuenta"].Value = registro.categoria_cuenta;
                dgv_cuentas_registradas.Rows[rowIndex].Cells["dtbc_monto_cuenta"].Value = registro.monto_cuenta;
                dgv_cuentas_registradas.Rows[rowIndex].Cells["dtbc_fecha_cuenta"].Value = registro.fecha_cuenta;
                dgv_cuentas_registradas.Rows[rowIndex].Cells["dtbc_ID_cuenta"].Value = registro.ID_cuenta;
            }

            dgv_cuentas_registradas.Refresh();
        }
    }
}

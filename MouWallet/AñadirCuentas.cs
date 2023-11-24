using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;



namespace MouWallet
{
    public partial class AñadirCuentas : Form
    {
        bool edit = false;
        int id = 1;
        int rows = 0;
        private List<Registro> ListaDeRegistros = new List<Registro>();
        private VerCuentas verCuentasForm;



        public AñadirCuentas()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


            InitializeComponent();
            verCuentasForm = new VerCuentas(ListaDeRegistros);
        }

        //--------------------------Nombre de la cuenta-----------------------------------//
        private void tb_nombre_cuenta_Enter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                // Verifica si el texto actual es igual al texto predeterminado
                if (textBoxWinForms.Text == "Nombre de la cuenta")
                {
                    textBoxWinForms.Text = string.Empty;  // Borra el texto predeterminado
                    textBoxWinForms.ForeColor = SystemColors.WindowText;  // Restaura el color de texto predeterminado
                }
            }
        }

        private void tb_nombre_cuenta_Leave(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                // Si el usuario no ha ingresado ningún texto, restaura el texto predeterminado y el color
                if (string.IsNullOrWhiteSpace(textBoxWinForms.Text))
                {
                    textBoxWinForms.Text = "Nombre de la cuenta";
                    textBoxWinForms.ForeColor = SystemColors.GrayText;  // Cambia el color de texto a gris
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------//


        //--------------------------Monto de la cuenta-----------------------------------//
        private void tb_monto_cuenta_Enter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                if (textBoxWinForms.Text == "Monto de la cuenta")
                {
                    textBoxWinForms.Text = string.Empty;  // Borra el texto predeterminado
                    textBoxWinForms.ForeColor = SystemColors.WindowText;  // Restaura el color de texto predeterminado
                }
            }
        }
        private void tb_monto_cuenta_Leave(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                // Si el usuario no ha ingresado ningún texto, restaura el texto predeterminado y el color
                if (string.IsNullOrWhiteSpace(textBoxWinForms.Text))
                {
                    textBoxWinForms.Text = "Monto de la cuenta";
                    textBoxWinForms.ForeColor = SystemColors.GrayText;  // Cambia el color de texto a gris
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------//


        //--------------------------Categoria de la cuenta-----------------------------------//
        private List<string> categorias_permitidas = new List<string> { "acreedora", "deudora" };
        private void tb_categoria_cuenta_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarPalabra(tb_categoria_cuenta);
            }
        }
        private void tb_categoria_cuenta_Enter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                if (textBoxWinForms.Text == "Categoria de la cuenta")
                {
                    textBoxWinForms.Text = string.Empty;  // Borra el texto predeterminado
                    textBoxWinForms.ForeColor = SystemColors.WindowText;  // Restaura el color de texto predeterminado
                }
            }
        }
        private void tb_categoria_cuenta_Leave(object? sender, EventArgs e)
        {
            ValidarPalabra(tb_categoria_cuenta);
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                // Si el usuario no ha ingresado ningún texto, restaura el texto predeterminado y el color
                if (string.IsNullOrWhiteSpace(textBoxWinForms.Text))
                {
                    textBoxWinForms.Text = "Categoria de la cuenta";
                    textBoxWinForms.ForeColor = SystemColors.GrayText;  // Cambia el color de texto a gris
                }
            }
        }
        private void ValidarPalabra(System.Windows.Forms.TextBox textBox)
        {
            string palabraIngresada = textBox.Text.ToLower();

            if (!categorias_permitidas.Contains(palabraIngresada))
            {
                MessageBox.Show($"Palabra no permitida. Palabras permitidas: {string.Join(", ", categorias_permitidas)}");
                textBox.Clear();
            }
        }

        //-----------------------------------------------------------------------------------------------------//




        //--------------------------Fecha de la cuenta-----------------------------------//
        private void tb_fecha_Enter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                if (textBoxWinForms.Text == "Fecha")
                {
                    textBoxWinForms.Text = string.Empty;  // Borra el texto predeterminado
                    textBoxWinForms.ForeColor = SystemColors.WindowText;  // Restaura el color de texto predeterminado
                }
            }
        }
        private void tb_fecha_Leave(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                // Si el usuario no ha ingresado ningún texto, restaura el texto predeterminado y el color
                if (string.IsNullOrWhiteSpace(textBoxWinForms.Text))
                {
                    textBoxWinForms.Text = "Fecha";
                    textBoxWinForms.ForeColor = SystemColors.GrayText;  // Cambia el color de texto a gris
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------//




        //--------------------------ID de la cuenta-----------------------------------//
        private void tb_ID_Enter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                if (textBoxWinForms.Text == "ID")
                {
                    textBoxWinForms.Text = string.Empty;  // Borra el texto predeterminado
                    textBoxWinForms.ForeColor = SystemColors.WindowText;  // Restaura el color de texto predeterminado
                }
            }
        }
        private void tb_ID_Leave(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBoxWinForms)
            {
                // Si el usuario no ha ingresado ningún texto, restaura el texto predeterminado y el color
                if (string.IsNullOrWhiteSpace(textBoxWinForms.Text))
                {
                    textBoxWinForms.Text = "ID";
                    textBoxWinForms.ForeColor = SystemColors.GrayText;  // Cambia el color de texto a gris
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------//




        private void AñadirCuentas_Load(object sender, EventArgs e)
        {

            btn_añadir_cuenta.Enabled = false;
            btn_añadir_cuenta.BackColor = Color.Gray;


            // Nombre de la cuenta------------------------//
            // Configura el texto predeterminado y el color de texto para el TextBox al cargar el formulario
            tb_nombre_cuenta.Text = "Nombre de la cuenta";
            tb_nombre_cuenta.ForeColor = SystemColors.GrayText;

            // Asocia los eventos Enter y Leave al TextBox
            tb_nombre_cuenta.Enter += tb_nombre_cuenta_Enter;
            tb_nombre_cuenta.Leave += tb_nombre_cuenta_Leave;




            //Monto de la cuenta----------------------//
            tb_monto_cuenta.Text = "Monto de la cuenta";
            tb_monto_cuenta.ForeColor = SystemColors.GrayText;

            // Asocia los eventos Enter y Leave al TextBox
            tb_monto_cuenta.Enter += tb_monto_cuenta_Enter;
            tb_monto_cuenta.Leave += tb_monto_cuenta_Leave;




            //Categoria de la cuenta----------------------//
            tb_categoria_cuenta.Text = "Categoria de la cuenta";
            tb_categoria_cuenta.ForeColor = SystemColors.GrayText;

            // Asocia los eventos Enter y Leave al TextBox
            tb_categoria_cuenta.Enter += tb_categoria_cuenta_Enter;
            tb_categoria_cuenta.Leave += tb_categoria_cuenta_Leave;




            //Fecha de la cuenta----------------------//
            tb_fecha.Text = "Fecha";
            tb_fecha.ForeColor = SystemColors.GrayText;

            // Asocia los eventos Enter y Leave al TextBox
            tb_fecha.Enter += tb_fecha_Enter;
            tb_fecha.Leave += tb_fecha_Leave;




            //ID de la cuenta----------------------//
            tb_ID.Text = "ID";
            tb_ID.ForeColor = SystemColors.GrayText;

            // Asocia los eventos Enter y Leave al TextBox
            tb_ID.Enter += tb_ID_Enter;
            tb_ID.Leave += tb_ID_Leave;
        }



        private void tb_nombre_cuenta_TextChanged(object sender, EventArgs e)
        {

        }
        //lista de categorias permitidas


        private void tb_categoria_cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_añadir_cuenta_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = true;
            btn_nuevo.BackColor = panel2.BackColor;
            if (!edit)
            {
                CRUD CRUD = new CRUD();

                int x = dgv_cuentas_registradas_2.Rows.Add();

                //_____________________________________________________________
                CRUD.Id_cuenta = id;
                CRUD.Nombre_cuenta = tb_nombre_cuenta.Text;
                CRUD.Categoria_cuenta = tb_categoria_cuenta.Text;
                CRUD.Fecha_cuenta = tb_fecha.Text;
                CRUD.Monto_cuenta = Convert.ToInt32(tb_monto_cuenta.Text);
                //_____________________________________________________________
                dgv_cuentas_registradas_2.Rows[x].Cells[0].Value = CRUD.Id_cuenta;
                dgv_cuentas_registradas_2.Rows[x].Cells[1].Value = CRUD.Nombre_cuenta;
                dgv_cuentas_registradas_2.Rows[x].Cells[2].Value = CRUD.Categoria_cuenta;
                dgv_cuentas_registradas_2.Rows[x].Cells[3].Value = CRUD.Fecha_cuenta;
                dgv_cuentas_registradas_2.Rows[x].Cells[4].Value = CRUD.Monto_cuenta;
                id++;
            }
            else
            {
                if (dgv_cuentas_registradas_2.Rows.Count > 0)
                {
                    CRUD CRUD = new CRUD();

                    int x = dgv_cuentas_registradas_2.Rows.Add();

                    //_____________________________________________________________
                    //CRUD.Id_cuenta = id;
                    CRUD.Nombre_cuenta = tb_nombre_cuenta.Text;
                    CRUD.Categoria_cuenta = tb_nombre_cuenta.Text;
                    CRUD.Fecha_cuenta = tb_fecha.Text;
                    CRUD.Monto_cuenta = Convert.ToInt32(tb_monto_cuenta.Text);
                    //_____________________________________________________________
                    //dgv_cuentas_registradas_2.Rows[rows].Cells[0].Value = CRUD.Id_cuenta;
                    dgv_cuentas_registradas_2.Rows[rows].Cells[1].Value = CRUD.Nombre_cuenta;
                    dgv_cuentas_registradas_2.Rows[rows].Cells[2].Value = CRUD.Categoria_cuenta;
                    dgv_cuentas_registradas_2.Rows[rows].Cells[3].Value = CRUD.Fecha_cuenta;
                    dgv_cuentas_registradas_2.Rows[rows].Cells[4].Value = CRUD.Monto_cuenta;

                    rows = 0;
                    edit = false;
                }

            }
            string nombreCuenta = tb_nombre_cuenta.Text;
            string categoriaCuenta = tb_categoria_cuenta.Text;
            string fechaCuenta = tb_fecha.Text;
            int montoCuenta = Convert.ToInt32(tb_monto_cuenta.Text);
            string idCuenta = tb_ID.Text;




            Registro nuevoRegistro = new Registro
            {
                nombre_cuenta = nombreCuenta,
                categoria_cuenta = categoriaCuenta,
                fecha_cuenta = fechaCuenta,
                monto_cuenta = montoCuenta,
                ID_cuenta = idCuenta
            };

            //ListaDeRegistros.Add(nuevoRegistro);

            MessageBox.Show("Registro exitoso", "Cuenta añadida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar las cajas de texto u realizar otras operaciones necesarias
            tb_nombre_cuenta.Text = "Nombre de la cuenta";
            tb_categoria_cuenta.Text = "Categoria de la cuenta";
            tb_fecha.Text = "Fecha";
            tb_monto_cuenta.Text = "Monto de la cuenta";
            tb_ID.Text = "ID";

            // Verificar si ya existe una instancia de VerCuentas
            if (verCuentasForm == null || verCuentasForm.IsDisposed)
            {
                verCuentasForm = new VerCuentas(ListaDeRegistros);
                // Asegurarse de que la instancia se mantenga visible
                verCuentasForm.Show();
            }

            // Mostrar los registros actualizados en el DataGridView
            verCuentasForm.MostrarRegistros();
        }


        public List<Registro> ObtenerListaDeRegistros()
        {
            return ListaDeRegistros;
        }

        private void tb_monto_cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un dígito o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Si no es un dígito o la tecla de retroceso, se cancela la entrada
                e.Handled = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_cuentas_registradas_2.SelectedRows.Count > 0)
            {
                edit = true;
                rows = dgv_cuentas_registradas_2.SelectedRows.Count - 1;


                tb_nombre_cuenta.Text = dgv_cuentas_registradas_2.CurrentRow.Cells[1].Value.ToString();
                tb_categoria_cuenta.Text = dgv_cuentas_registradas_2.CurrentRow.Cells[2].Value.ToString();
                tb_fecha.Text = dgv_cuentas_registradas_2.CurrentRow.Cells[3].Value.ToString();
                tb_monto_cuenta.Text = dgv_cuentas_registradas_2.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            edit = false;

            btn_añadir_cuenta.Enabled = true;
            btn_añadir_cuenta.BackColor = panel2.BackColor;

            btn_nuevo.Enabled = false;
            btn_nuevo.BackColor = Color.Gray;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_cuentas_registradas_2.SelectedRows.Count > 0) 
            {
                int index = dgv_cuentas_registradas_2.SelectedRows[0].Index;
                dgv_cuentas_registradas_2.Rows.RemoveAt(index);
            }
        }



        //metodo generar excel
        public void ExportarDataGridViewAExcel()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Documents (*.xlsx)|*.xlsx",
                    FileName = "CuentasExportadas.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Cuentas");

                        // Encabezados de columna
                        for (int i = 1; i <= dgv_cuentas_registradas_2.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i).Value = dgv_cuentas_registradas_2.Columns[i - 1].HeaderText;
                            worksheet.Cell(1, i).Style.Font.Bold = true;
                            worksheet.Cell(1, i).Style.Fill.BackgroundColor = XLColor.Gray;
                            worksheet.Cell(1, i).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        }

                        // Datos de la cuadrícula
                        for (int i = 0; i < dgv_cuentas_registradas_2.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv_cuentas_registradas_2.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgv_cuentas_registradas_2.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

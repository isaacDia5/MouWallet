namespace MouWallet
{
    partial class VerCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dgv_cuentas_registradas = new DataGridView();
            dtbc_ID_cuenta = new DataGridViewTextBoxColumn();
            dtbc_nombre_cuenta = new DataGridViewTextBoxColumn();
            dtbc_categoria_cuenta = new DataGridViewTextBoxColumn();
            dtbc_fecha_cuenta = new DataGridViewTextBoxColumn();
            dtbc_monto_cuenta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cuentas_registradas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(100, 50, 100, 50);
            panel1.Size = new Size(1140, 672);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 55, 84);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(100, 50);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(107, 50, 107, 50);
            panel2.Size = new Size(940, 572);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_cuentas_registradas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(107, 50);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 472);
            panel3.TabIndex = 10;
            // 
            // dgv_cuentas_registradas
            // 
            dgv_cuentas_registradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cuentas_registradas.Columns.AddRange(new DataGridViewColumn[] { dtbc_ID_cuenta, dtbc_nombre_cuenta, dtbc_categoria_cuenta, dtbc_fecha_cuenta, dtbc_monto_cuenta });
            dgv_cuentas_registradas.Dock = DockStyle.Fill;
            dgv_cuentas_registradas.Location = new Point(0, 0);
            dgv_cuentas_registradas.Name = "dgv_cuentas_registradas";
            dgv_cuentas_registradas.RowTemplate.Height = 25;
            dgv_cuentas_registradas.Size = new Size(726, 472);
            dgv_cuentas_registradas.TabIndex = 12;
            // 
            // dtbc_ID_cuenta
            // 
            dtbc_ID_cuenta.HeaderText = "ID";
            dtbc_ID_cuenta.Name = "dtbc_ID_cuenta";
            dtbc_ID_cuenta.Width = 50;
            // 
            // dtbc_nombre_cuenta
            // 
            dtbc_nombre_cuenta.HeaderText = "Nombre de la cuenta";
            dtbc_nombre_cuenta.Name = "dtbc_nombre_cuenta";
            dtbc_nombre_cuenta.Width = 300;
            // 
            // dtbc_categoria_cuenta
            // 
            dtbc_categoria_cuenta.HeaderText = "Categoria de la cuenta";
            dtbc_categoria_cuenta.Name = "dtbc_categoria_cuenta";
            // 
            // dtbc_fecha_cuenta
            // 
            dtbc_fecha_cuenta.HeaderText = "Fecha de la cuenta";
            dtbc_fecha_cuenta.Name = "dtbc_fecha_cuenta";
            // 
            // dtbc_monto_cuenta
            // 
            dtbc_monto_cuenta.HeaderText = "Monto de la cuenta";
            dtbc_monto_cuenta.Name = "dtbc_monto_cuenta";
            dtbc_monto_cuenta.Width = 135;
            // 
            // VerCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 672);
            Controls.Add(panel1);
            Name = "VerCuentas";
            Text = "VerCuentas";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_cuentas_registradas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgv_cuentas_registradas;
        private DataGridViewTextBoxColumn dtbc_ID_cuenta;
        private DataGridViewTextBoxColumn dtbc_nombre_cuenta;
        private DataGridViewTextBoxColumn dtbc_categoria_cuenta;
        private DataGridViewTextBoxColumn dtbc_fecha_cuenta;
        private DataGridViewTextBoxColumn dtbc_monto_cuenta;
    }
}
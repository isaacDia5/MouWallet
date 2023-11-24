namespace MouWallet
{
    partial class AñadirCuentas
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
            tb_nombre_cuenta = new TextBox();
            tb_monto_cuenta = new TextBox();
            tb_categoria_cuenta = new TextBox();
            tb_fecha = new TextBox();
            tb_ID = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dgv_cuentas_registradas_2 = new DataGridView();
            dtbc_ID_cuenta2 = new DataGridViewTextBoxColumn();
            dtbc_nombre_cuenta2 = new DataGridViewTextBoxColumn();
            dtbc_categoria_cuenta2 = new DataGridViewTextBoxColumn();
            dtbc_fecha_cuenta2 = new DataGridViewTextBoxColumn();
            dtbc_monto_cuenta2 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel6 = new Panel();
            btn_nuevo = new Button();
            btn_editar = new Button();
            btn_añadir_cuenta = new Button();
            btn_eliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cuentas_registradas_2).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tb_nombre_cuenta
            // 
            tb_nombre_cuenta.BackColor = Color.White;
            tb_nombre_cuenta.BorderStyle = BorderStyle.None;
            tb_nombre_cuenta.Cursor = Cursors.IBeam;
            tb_nombre_cuenta.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nombre_cuenta.ForeColor = SystemColors.WindowFrame;
            tb_nombre_cuenta.Location = new Point(0, 0);
            tb_nombre_cuenta.MaximumSize = new Size(326, 35);
            tb_nombre_cuenta.Multiline = true;
            tb_nombre_cuenta.Name = "tb_nombre_cuenta";
            tb_nombre_cuenta.Size = new Size(326, 35);
            tb_nombre_cuenta.TabIndex = 5;
            tb_nombre_cuenta.Text = "Nombre de la cuenta";
            tb_nombre_cuenta.TextChanged += tb_nombre_cuenta_TextChanged;
            // 
            // tb_monto_cuenta
            // 
            tb_monto_cuenta.BackColor = Color.White;
            tb_monto_cuenta.BorderStyle = BorderStyle.None;
            tb_monto_cuenta.Cursor = Cursors.IBeam;
            tb_monto_cuenta.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_monto_cuenta.ForeColor = SystemColors.WindowFrame;
            tb_monto_cuenta.Location = new Point(0, 214);
            tb_monto_cuenta.MaximumSize = new Size(326, 35);
            tb_monto_cuenta.Multiline = true;
            tb_monto_cuenta.Name = "tb_monto_cuenta";
            tb_monto_cuenta.Size = new Size(326, 35);
            tb_monto_cuenta.TabIndex = 6;
            tb_monto_cuenta.Text = "Monto de la cuenta";
            tb_monto_cuenta.KeyPress += tb_monto_cuenta_KeyPress;
            // 
            // tb_categoria_cuenta
            // 
            tb_categoria_cuenta.BackColor = Color.White;
            tb_categoria_cuenta.BorderStyle = BorderStyle.None;
            tb_categoria_cuenta.Cursor = Cursors.IBeam;
            tb_categoria_cuenta.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_categoria_cuenta.ForeColor = SystemColors.WindowFrame;
            tb_categoria_cuenta.Location = new Point(0, 68);
            tb_categoria_cuenta.MaximumSize = new Size(326, 35);
            tb_categoria_cuenta.Multiline = true;
            tb_categoria_cuenta.Name = "tb_categoria_cuenta";
            tb_categoria_cuenta.Size = new Size(326, 35);
            tb_categoria_cuenta.TabIndex = 7;
            tb_categoria_cuenta.Text = "Categoria de la cuenta";
            tb_categoria_cuenta.TextChanged += tb_categoria_cuenta_TextChanged;
            // 
            // tb_fecha
            // 
            tb_fecha.BackColor = Color.White;
            tb_fecha.BorderStyle = BorderStyle.None;
            tb_fecha.Cursor = Cursors.IBeam;
            tb_fecha.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_fecha.ForeColor = SystemColors.WindowFrame;
            tb_fecha.Location = new Point(0, 138);
            tb_fecha.MaximumSize = new Size(326, 35);
            tb_fecha.Multiline = true;
            tb_fecha.Name = "tb_fecha";
            tb_fecha.Size = new Size(153, 35);
            tb_fecha.TabIndex = 8;
            tb_fecha.Text = "Fecha";
            // 
            // tb_ID
            // 
            tb_ID.BackColor = Color.White;
            tb_ID.BorderStyle = BorderStyle.None;
            tb_ID.Cursor = Cursors.IBeam;
            tb_ID.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ID.ForeColor = SystemColors.WindowFrame;
            tb_ID.Location = new Point(169, 138);
            tb_ID.MaximumSize = new Size(326, 35);
            tb_ID.Multiline = true;
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(157, 35);
            tb_ID.TabIndex = 9;
            tb_ID.Text = "ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50);
            panel1.Size = new Size(1140, 672);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 55, 84);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(50, 50);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(107, 50, 107, 50);
            panel2.Size = new Size(1040, 572);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(107, 50);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(826, 472);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgv_cuentas_registradas_2);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(452, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30);
            panel5.Size = new Size(374, 472);
            panel5.TabIndex = 16;
            // 
            // dgv_cuentas_registradas_2
            // 
            dgv_cuentas_registradas_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cuentas_registradas_2.Columns.AddRange(new DataGridViewColumn[] { dtbc_ID_cuenta2, dtbc_nombre_cuenta2, dtbc_categoria_cuenta2, dtbc_fecha_cuenta2, dtbc_monto_cuenta2 });
            dgv_cuentas_registradas_2.Dock = DockStyle.Fill;
            dgv_cuentas_registradas_2.Location = new Point(30, 30);
            dgv_cuentas_registradas_2.Name = "dgv_cuentas_registradas_2";
            dgv_cuentas_registradas_2.RowTemplate.Height = 25;
            dgv_cuentas_registradas_2.Size = new Size(314, 412);
            dgv_cuentas_registradas_2.TabIndex = 13;
            // 
            // dtbc_ID_cuenta2
            // 
            dtbc_ID_cuenta2.HeaderText = "ID";
            dtbc_ID_cuenta2.Name = "dtbc_ID_cuenta2";
            dtbc_ID_cuenta2.Width = 50;
            // 
            // dtbc_nombre_cuenta2
            // 
            dtbc_nombre_cuenta2.HeaderText = "Nombre de la cuenta";
            dtbc_nombre_cuenta2.Name = "dtbc_nombre_cuenta2";
            // 
            // dtbc_categoria_cuenta2
            // 
            dtbc_categoria_cuenta2.HeaderText = "Categoria de la cuenta";
            dtbc_categoria_cuenta2.Name = "dtbc_categoria_cuenta2";
            // 
            // dtbc_fecha_cuenta2
            // 
            dtbc_fecha_cuenta2.HeaderText = "Fecha de la cuenta";
            dtbc_fecha_cuenta2.Name = "dtbc_fecha_cuenta2";
            // 
            // dtbc_monto_cuenta2
            // 
            dtbc_monto_cuenta2.HeaderText = "Monto de la cuenta";
            dtbc_monto_cuenta2.Name = "dtbc_monto_cuenta2";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(tb_nombre_cuenta);
            panel4.Controls.Add(tb_ID);
            panel4.Controls.Add(tb_monto_cuenta);
            panel4.Controls.Add(tb_categoria_cuenta);
            panel4.Controls.Add(tb_fecha);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 472);
            panel4.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_nuevo);
            panel6.Controls.Add(btn_editar);
            panel6.Controls.Add(btn_añadir_cuenta);
            panel6.Controls.Add(btn_eliminar);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 339);
            panel6.Name = "panel6";
            panel6.Size = new Size(328, 133);
            panel6.TabIndex = 15;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.Transparent;
            btn_nuevo.Cursor = Cursors.Hand;
            btn_nuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btn_nuevo.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nuevo.ForeColor = Color.Transparent;
            btn_nuevo.Location = new Point(175, 20);
            btn_nuevo.Margin = new Padding(0);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(153, 35);
            btn_nuevo.TabIndex = 14;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.Transparent;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btn_editar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.Transparent;
            btn_editar.Location = new Point(175, 75);
            btn_editar.Margin = new Padding(0);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(153, 35);
            btn_editar.TabIndex = 13;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_añadir_cuenta
            // 
            btn_añadir_cuenta.BackColor = Color.Transparent;
            btn_añadir_cuenta.Cursor = Cursors.Hand;
            btn_añadir_cuenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btn_añadir_cuenta.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_añadir_cuenta.FlatStyle = FlatStyle.Flat;
            btn_añadir_cuenta.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_añadir_cuenta.ForeColor = Color.Transparent;
            btn_añadir_cuenta.Location = new Point(0, 20);
            btn_añadir_cuenta.Margin = new Padding(0);
            btn_añadir_cuenta.Name = "btn_añadir_cuenta";
            btn_añadir_cuenta.Size = new Size(153, 35);
            btn_añadir_cuenta.TabIndex = 11;
            btn_añadir_cuenta.Text = "Guardar";
            btn_añadir_cuenta.UseVisualStyleBackColor = false;
            btn_añadir_cuenta.Click += btn_añadir_cuenta_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Transparent;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btn_eliminar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.Transparent;
            btn_eliminar.Location = new Point(0, 75);
            btn_eliminar.Margin = new Padding(0);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(153, 35);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // AñadirCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 672);
            Controls.Add(panel1);
            Name = "AñadirCuentas";
            Text = "AñadirCuentas";
            Load += AñadirCuentas_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_cuentas_registradas_2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_nombre_cuenta;
        private TextBox tb_monto_cuenta;
        private TextBox tb_categoria_cuenta;
        private TextBox tb_fecha;
        private TextBox tb_ID;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_añadir_cuenta;
        private Button btn_editar;
        private Button btn_eliminar;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dgv_cuentas_registradas_2;
        private Panel panel6;
        private DataGridViewTextBoxColumn dtbc_ID_cuenta2;
        private DataGridViewTextBoxColumn dtbc_nombre_cuenta2;
        private DataGridViewTextBoxColumn dtbc_categoria_cuenta2;
        private DataGridViewTextBoxColumn dtbc_fecha_cuenta2;
        private DataGridViewTextBoxColumn dtbc_monto_cuenta2;
        private Button btn_nuevo;
    }
}
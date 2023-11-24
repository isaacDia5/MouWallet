namespace MouWallet
{
    partial class OpcionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesForm));
            btn_añadir_cuenta = new Button();
            btn_ver_cuenta = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_añadir_cuenta
            // 
            btn_añadir_cuenta.Cursor = Cursors.Hand;
            btn_añadir_cuenta.Dock = DockStyle.Fill;
            btn_añadir_cuenta.FlatStyle = FlatStyle.Flat;
            btn_añadir_cuenta.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_añadir_cuenta.ForeColor = Color.White;
            btn_añadir_cuenta.Image = Properties.Resources.Agregar_50x50px;
            btn_añadir_cuenta.Location = new Point(100, 100);
            btn_añadir_cuenta.Name = "btn_añadir_cuenta";
            btn_añadir_cuenta.Size = new Size(200, 261);
            btn_añadir_cuenta.TabIndex = 0;
            btn_añadir_cuenta.Text = "Añadir Cuenta";
            btn_añadir_cuenta.TextAlign = ContentAlignment.BottomCenter;
            btn_añadir_cuenta.UseVisualStyleBackColor = true;
            btn_añadir_cuenta.Click += btn_añadir_cuenta_Click;
            // 
            // btn_ver_cuenta
            // 
            btn_ver_cuenta.AccessibleName = "";
            btn_ver_cuenta.Cursor = Cursors.Hand;
            btn_ver_cuenta.Dock = DockStyle.Fill;
            btn_ver_cuenta.FlatStyle = FlatStyle.Flat;
            btn_ver_cuenta.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ver_cuenta.ForeColor = Color.White;
            btn_ver_cuenta.Image = Properties.Resources.Ventas_50x50px;
            btn_ver_cuenta.Location = new Point(100, 100);
            btn_ver_cuenta.Name = "btn_ver_cuenta";
            btn_ver_cuenta.Size = new Size(200, 261);
            btn_ver_cuenta.TabIndex = 1;
            btn_ver_cuenta.Text = "Ver Cuentas";
            btn_ver_cuenta.TextAlign = ContentAlignment.BottomCenter;
            btn_ver_cuenta.UseVisualStyleBackColor = true;
            btn_ver_cuenta.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_añadir_cuenta);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(100);
            panel1.Size = new Size(400, 461);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_ver_cuenta);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(384, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(100);
            panel2.Size = new Size(400, 461);
            panel2.TabIndex = 3;
            // 
            // OpcionesForm
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(48, 55, 84);
            ClientSize = new Size(784, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "OpcionesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MouWallet";
            Load += OpcionesForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_añadir_cuenta;
        private Button btn_ver_cuenta;
        private Panel panel1;
        private Panel panel2;
    }
}
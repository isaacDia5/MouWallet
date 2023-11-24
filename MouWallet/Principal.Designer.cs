namespace MouWallet
{
    partial class Principal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pnl_sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            Menu = new Label();
            btn_menu = new PictureBox();
            pnl_cuentas = new Panel();
            btn_cuentas = new Button();
            pnl_libros = new Panel();
            btn_libros = new Button();
            pnl_nosotros = new Panel();
            btn_nosotros = new Button();
            pnl_manual = new Panel();
            btn_manual = new Button();
            sidebar_timer = new System.Windows.Forms.Timer(components);
            tbctrl_añadir_cuentas = new TabControl();
            pnl_sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_menu).BeginInit();
            pnl_cuentas.SuspendLayout();
            pnl_libros.SuspendLayout();
            pnl_nosotros.SuspendLayout();
            pnl_manual.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.BackColor = Color.FromArgb(48, 55, 84);
            pnl_sidebar.Controls.Add(panel1);
            pnl_sidebar.Controls.Add(pnl_cuentas);
            pnl_sidebar.Controls.Add(pnl_libros);
            pnl_sidebar.Controls.Add(pnl_nosotros);
            pnl_sidebar.Controls.Add(pnl_manual);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 0);
            pnl_sidebar.Margin = new Padding(0);
            pnl_sidebar.MaximumSize = new Size(245, 1080);
            pnl_sidebar.MinimumSize = new Size(107, 1080);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(245, 1080);
            pnl_sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Menu);
            panel1.Controls.Add(btn_menu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(35, 50, 0, 0);
            panel1.Size = new Size(245, 130);
            panel1.TabIndex = 1;
            // 
            // Menu
            // 
            Menu.AutoSize = true;
            Menu.Cursor = Cursors.Hand;
            Menu.ForeColor = Color.White;
            Menu.Location = new Point(121, 55);
            Menu.Name = "Menu";
            Menu.Size = new Size(62, 26);
            Menu.TabIndex = 1;
            Menu.Text = "Menu";
            // 
            // btn_menu
            // 
            btn_menu.BackgroundImageLayout = ImageLayout.Center;
            btn_menu.Cursor = Cursors.Hand;
            btn_menu.Image = Properties.Resources.Menu_50x50px;
            btn_menu.Location = new Point(35, 50);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(35, 35);
            btn_menu.TabIndex = 0;
            btn_menu.TabStop = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // pnl_cuentas
            // 
            pnl_cuentas.Controls.Add(btn_cuentas);
            pnl_cuentas.Dock = DockStyle.Bottom;
            pnl_cuentas.Location = new Point(0, 130);
            pnl_cuentas.Margin = new Padding(0);
            pnl_cuentas.Name = "pnl_cuentas";
            pnl_cuentas.Size = new Size(245, 50);
            pnl_cuentas.TabIndex = 1;
            // 
            // btn_cuentas
            // 
            btn_cuentas.Cursor = Cursors.Hand;
            btn_cuentas.FlatStyle = FlatStyle.Flat;
            btn_cuentas.ForeColor = Color.White;
            btn_cuentas.Image = Properties.Resources.account;
            btn_cuentas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cuentas.Location = new Point(-19, -16);
            btn_cuentas.Name = "btn_cuentas";
            btn_cuentas.Padding = new Padding(50, 0, 0, 0);
            btn_cuentas.Size = new Size(306, 79);
            btn_cuentas.TabIndex = 2;
            btn_cuentas.Text = "                 Cuentas";
            btn_cuentas.TextAlign = ContentAlignment.MiddleLeft;
            btn_cuentas.UseVisualStyleBackColor = true;
            btn_cuentas.Click += btn_cuentas_Click;
            // 
            // pnl_libros
            // 
            pnl_libros.Controls.Add(btn_libros);
            pnl_libros.Dock = DockStyle.Bottom;
            pnl_libros.Location = new Point(0, 180);
            pnl_libros.Margin = new Padding(0);
            pnl_libros.Name = "pnl_libros";
            pnl_libros.Size = new Size(245, 50);
            pnl_libros.TabIndex = 2;
            // 
            // btn_libros
            // 
            btn_libros.Cursor = Cursors.Hand;
            btn_libros.FlatStyle = FlatStyle.Flat;
            btn_libros.ForeColor = Color.White;
            btn_libros.Image = Properties.Resources.book;
            btn_libros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_libros.Location = new Point(-19, -16);
            btn_libros.Name = "btn_libros";
            btn_libros.Padding = new Padding(50, 0, 0, 0);
            btn_libros.Size = new Size(306, 79);
            btn_libros.TabIndex = 3;
            btn_libros.Text = "                 Libros";
            btn_libros.TextAlign = ContentAlignment.MiddleLeft;
            btn_libros.UseVisualStyleBackColor = true;
            btn_libros.Click += btn_libros_Click;
            // 
            // pnl_nosotros
            // 
            pnl_nosotros.Controls.Add(btn_nosotros);
            pnl_nosotros.Dock = DockStyle.Bottom;
            pnl_nosotros.Location = new Point(0, 230);
            pnl_nosotros.Margin = new Padding(0);
            pnl_nosotros.Name = "pnl_nosotros";
            pnl_nosotros.Size = new Size(245, 50);
            pnl_nosotros.TabIndex = 3;
            // 
            // btn_nosotros
            // 
            btn_nosotros.Cursor = Cursors.Hand;
            btn_nosotros.FlatStyle = FlatStyle.Flat;
            btn_nosotros.ForeColor = Color.White;
            btn_nosotros.Image = Properties.Resources.nosotros;
            btn_nosotros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nosotros.Location = new Point(-19, -13);
            btn_nosotros.Name = "btn_nosotros";
            btn_nosotros.Padding = new Padding(50, 0, 0, 0);
            btn_nosotros.Size = new Size(306, 79);
            btn_nosotros.TabIndex = 4;
            btn_nosotros.Text = "                 Nosotros";
            btn_nosotros.TextAlign = ContentAlignment.MiddleLeft;
            btn_nosotros.UseVisualStyleBackColor = true;
            btn_nosotros.Click += btn_nosotros_Click;
            // 
            // pnl_manual
            // 
            pnl_manual.Controls.Add(btn_manual);
            pnl_manual.Dock = DockStyle.Bottom;
            pnl_manual.Location = new Point(0, 280);
            pnl_manual.Margin = new Padding(0);
            pnl_manual.Name = "pnl_manual";
            pnl_manual.Size = new Size(245, 50);
            pnl_manual.TabIndex = 4;
            // 
            // btn_manual
            // 
            btn_manual.Cursor = Cursors.Hand;
            btn_manual.FlatStyle = FlatStyle.Flat;
            btn_manual.ForeColor = Color.White;
            btn_manual.Image = Properties.Resources.manual;
            btn_manual.ImageAlign = ContentAlignment.MiddleLeft;
            btn_manual.Location = new Point(-19, -14);
            btn_manual.Name = "btn_manual";
            btn_manual.Padding = new Padding(50, 0, 0, 0);
            btn_manual.Size = new Size(306, 79);
            btn_manual.TabIndex = 5;
            btn_manual.Text = "                 Manual";
            btn_manual.TextAlign = ContentAlignment.MiddleLeft;
            btn_manual.UseVisualStyleBackColor = true;
            // 
            // sidebar_timer
            // 
            sidebar_timer.Interval = 10;
            sidebar_timer.Tick += sidebar_timer_tick;
            // 
            // tbctrl_añadir_cuentas
            // 
            tbctrl_añadir_cuentas.Dock = DockStyle.Fill;
            tbctrl_añadir_cuentas.Location = new Point(245, 0);
            tbctrl_añadir_cuentas.Margin = new Padding(0);
            tbctrl_añadir_cuentas.Name = "tbctrl_añadir_cuentas";
            tbctrl_añadir_cuentas.SelectedIndex = 0;
            tbctrl_añadir_cuentas.Size = new Size(539, 761);
            tbctrl_añadir_cuentas.TabIndex = 1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(tbctrl_añadir_cuentas);
            Controls.Add(pnl_sidebar);
            Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(300, 300);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MouWallet";
            pnl_sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_menu).EndInit();
            pnl_cuentas.ResumeLayout(false);
            pnl_libros.ResumeLayout(false);
            pnl_nosotros.ResumeLayout(false);
            pnl_manual.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_sidebar;
        private Panel panel1;
        private Panel pnl_cuentas;
        private Button btn_cuentas;
        private Panel pnl_libros;
        private Button btn_libros;
        private Panel pnl_nosotros;
        private Panel pnl_manual;
        private Button btn_nosotros;
        private Button btn_manual;
        private PictureBox btn_menu;
        private Label Menu;
        private System.Windows.Forms.Timer sidebar_timer;
        private TabControl tbctrl_añadir_cuentas;
    }
}
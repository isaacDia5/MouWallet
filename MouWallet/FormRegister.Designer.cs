namespace MouWallet
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            login_text = new Label();
            texto2 = new Label();
            texto1 = new Label();
            login_button = new Button();
            contraseña_log_logo = new PictureBox();
            usuario_log_logo = new PictureBox();
            contraseña_log_text = new TextBox();
            usuario_log_text = new TextBox();
            Titulo = new Label();
            max_win = new Button();
            minimizar_win = new Button();
            cerrar_win = new Button();
            ususario_label = new Label();
            contraseña_label = new Label();
            label1 = new Label();
            confirmar_text = new TextBox();
            pictureBox1 = new PictureBox();
            btnVer = new Button();
            btnVerCC = new Button();
            ((System.ComponentModel.ISupportInitialize)contraseña_log_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuario_log_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_text
            // 
            login_text.AutoSize = true;
            login_text.BackColor = Color.Transparent;
            login_text.Cursor = Cursors.Hand;
            login_text.FlatStyle = FlatStyle.Flat;
            login_text.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            login_text.ForeColor = Color.White;
            login_text.Location = new Point(736, 553);
            login_text.Name = "login_text";
            login_text.Size = new Size(124, 24);
            login_text.TabIndex = 26;
            login_text.Text = "Presiona aquí,";
            login_text.TextAlign = ContentAlignment.MiddleCenter;
            login_text.Click += login_text_Click;
            // 
            // texto2
            // 
            texto2.AutoSize = true;
            texto2.BackColor = Color.Transparent;
            texto2.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            texto2.ForeColor = SystemColors.Window;
            texto2.Location = new Point(850, 553);
            texto2.Margin = new Padding(0);
            texto2.Name = "texto2";
            texto2.Size = new Size(168, 24);
            texto2.TabIndex = 27;
            texto2.Text = " para acceder a ella";
            texto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texto1
            // 
            texto1.AutoSize = true;
            texto1.BackColor = Color.Transparent;
            texto1.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            texto1.ForeColor = SystemColors.Window;
            texto1.Location = new Point(776, 529);
            texto1.Name = "texto1";
            texto1.Size = new Size(199, 24);
            texto1.TabIndex = 25;
            texto1.Text = "¿Ya tienes una cuenta?";
            texto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            login_button.BackColor = Color.Transparent;
            login_button.Cursor = Cursors.Hand;
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            login_button.FlatAppearance.MouseOverBackColor = Color.Gray;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.ForeColor = Color.Transparent;
            login_button.Location = new Point(824, 436);
            login_button.Margin = new Padding(0);
            login_button.Name = "login_button";
            login_button.Size = new Size(100, 35);
            login_button.TabIndex = 24;
            login_button.Text = "Registrarse";
            login_button.UseVisualStyleBackColor = false;
            // 
            // contraseña_log_logo
            // 
            contraseña_log_logo.BackColor = Color.Transparent;
            contraseña_log_logo.BackgroundImageLayout = ImageLayout.Stretch;
            contraseña_log_logo.Image = Properties.Resources.Contraseña;
            contraseña_log_logo.Location = new Point(690, 267);
            contraseña_log_logo.Name = "contraseña_log_logo";
            contraseña_log_logo.Size = new Size(35, 35);
            contraseña_log_logo.TabIndex = 21;
            contraseña_log_logo.TabStop = false;
            // 
            // usuario_log_logo
            // 
            usuario_log_logo.BackColor = Color.Transparent;
            usuario_log_logo.BackgroundImageLayout = ImageLayout.Stretch;
            usuario_log_logo.Image = Properties.Resources.Usuario;
            usuario_log_logo.Location = new Point(690, 151);
            usuario_log_logo.Name = "usuario_log_logo";
            usuario_log_logo.Size = new Size(35, 35);
            usuario_log_logo.TabIndex = 20;
            usuario_log_logo.TabStop = false;
            // 
            // contraseña_log_text
            // 
            contraseña_log_text.BorderStyle = BorderStyle.None;
            contraseña_log_text.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            contraseña_log_text.ForeColor = SystemColors.WindowFrame;
            contraseña_log_text.Location = new Point(731, 267);
            contraseña_log_text.Multiline = true;
            contraseña_log_text.Name = "contraseña_log_text";
            contraseña_log_text.PasswordChar = '•';
            contraseña_log_text.Size = new Size(295, 35);
            contraseña_log_text.TabIndex = 19;
            // 
            // usuario_log_text
            // 
            usuario_log_text.BorderStyle = BorderStyle.None;
            usuario_log_text.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            usuario_log_text.ForeColor = SystemColors.WindowFrame;
            usuario_log_text.Location = new Point(731, 151);
            usuario_log_text.Multiline = true;
            usuario_log_text.Name = "usuario_log_text";
            usuario_log_text.Size = new Size(326, 35);
            usuario_log_text.TabIndex = 18;
            usuario_log_text.TextChanged += usuario_log_text_TextChanged;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.ForeColor = SystemColors.Window;
            Titulo.Location = new Point(698, 61);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(380, 61);
            Titulo.TabIndex = 17;
            Titulo.Text = "Crear una cuenta";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // max_win
            // 
            max_win.BackColor = Color.Transparent;
            max_win.BackgroundImage = Properties.Resources.Maximizar_opaco;
            max_win.BackgroundImageLayout = ImageLayout.Center;
            max_win.FlatAppearance.BorderSize = 0;
            max_win.FlatAppearance.MouseDownBackColor = Color.FromArgb(149, 165, 166);
            max_win.FlatAppearance.MouseOverBackColor = Color.FromArgb(149, 165, 166);
            max_win.FlatStyle = FlatStyle.Flat;
            max_win.Location = new Point(1099, 0);
            max_win.Name = "max_win";
            max_win.Size = new Size(30, 30);
            max_win.TabIndex = 16;
            max_win.UseVisualStyleBackColor = false;
            // 
            // minimizar_win
            // 
            minimizar_win.BackColor = Color.Transparent;
            minimizar_win.BackgroundImage = Properties.Resources.Minimizar1;
            minimizar_win.BackgroundImageLayout = ImageLayout.Center;
            minimizar_win.FlatAppearance.BorderSize = 0;
            minimizar_win.FlatAppearance.MouseDownBackColor = Color.FromArgb(225, 225, 230);
            minimizar_win.FlatAppearance.MouseOverBackColor = Color.FromArgb(149, 165, 166);
            minimizar_win.FlatStyle = FlatStyle.Flat;
            minimizar_win.Location = new Point(1063, 0);
            minimizar_win.Name = "minimizar_win";
            minimizar_win.Size = new Size(30, 30);
            minimizar_win.TabIndex = 15;
            minimizar_win.UseVisualStyleBackColor = false;
            minimizar_win.Click += minimizar_win_Click;
            // 
            // cerrar_win
            // 
            cerrar_win.BackColor = Color.Transparent;
            cerrar_win.BackgroundImage = Properties.Resources.Cerrar1;
            cerrar_win.BackgroundImageLayout = ImageLayout.Center;
            cerrar_win.FlatAppearance.BorderSize = 0;
            cerrar_win.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            cerrar_win.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 17, 3);
            cerrar_win.FlatStyle = FlatStyle.Flat;
            cerrar_win.Location = new Point(1135, 0);
            cerrar_win.Name = "cerrar_win";
            cerrar_win.Size = new Size(30, 30);
            cerrar_win.TabIndex = 14;
            cerrar_win.UseVisualStyleBackColor = false;
            cerrar_win.Click += cerrar_win_Click;
            // 
            // ususario_label
            // 
            ususario_label.AutoSize = true;
            ususario_label.BackColor = Color.Transparent;
            ususario_label.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ususario_label.ForeColor = SystemColors.Window;
            ususario_label.Location = new Point(728, 127);
            ususario_label.Name = "ususario_label";
            ususario_label.Size = new Size(79, 26);
            ususario_label.TabIndex = 22;
            ususario_label.Text = "Usuario";
            ususario_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contraseña_label
            // 
            contraseña_label.AutoSize = true;
            contraseña_label.BackColor = Color.Transparent;
            contraseña_label.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            contraseña_label.ForeColor = SystemColors.Window;
            contraseña_label.Location = new Point(728, 241);
            contraseña_label.Name = "contraseña_label";
            contraseña_label.Size = new Size(114, 26);
            contraseña_label.TabIndex = 23;
            contraseña_label.Text = "Contraseña";
            contraseña_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(728, 352);
            label1.Name = "label1";
            label1.Size = new Size(206, 26);
            label1.TabIndex = 23;
            label1.Text = "Confirmar contraseña";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmar_text
            // 
            confirmar_text.BorderStyle = BorderStyle.None;
            confirmar_text.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmar_text.ForeColor = SystemColors.WindowFrame;
            confirmar_text.Location = new Point(731, 378);
            confirmar_text.Multiline = true;
            confirmar_text.Name = "confirmar_text";
            confirmar_text.PasswordChar = '•';
            confirmar_text.Size = new Size(295, 35);
            confirmar_text.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Contraseña;
            pictureBox1.Location = new Point(690, 378);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.White;
            btnVer.BackgroundImage = Properties.Resources.Ver_contraseña;
            btnVer.BackgroundImageLayout = ImageLayout.Stretch;
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatAppearance.BorderColor = Color.White;
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Location = new Point(1022, 267);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(35, 35);
            btnVer.TabIndex = 28;
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnVerCC
            // 
            btnVerCC.BackColor = Color.White;
            btnVerCC.BackgroundImage = Properties.Resources.Ver_contraseña;
            btnVerCC.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerCC.Cursor = Cursors.Hand;
            btnVerCC.FlatAppearance.BorderColor = Color.White;
            btnVerCC.FlatAppearance.BorderSize = 0;
            btnVerCC.FlatStyle = FlatStyle.Flat;
            btnVerCC.Location = new Point(1022, 378);
            btnVerCC.Name = "btnVerCC";
            btnVerCC.Size = new Size(35, 35);
            btnVerCC.TabIndex = 29;
            btnVerCC.UseVisualStyleBackColor = false;
            btnVerCC.Click += btnVerCC_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_Definitivo2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1165, 605);
            Controls.Add(btnVerCC);
            Controls.Add(btnVer);
            Controls.Add(login_text);
            Controls.Add(texto2);
            Controls.Add(texto1);
            Controls.Add(login_button);
            Controls.Add(pictureBox1);
            Controls.Add(contraseña_log_logo);
            Controls.Add(usuario_log_logo);
            Controls.Add(confirmar_text);
            Controls.Add(contraseña_log_text);
            Controls.Add(usuario_log_text);
            Controls.Add(Titulo);
            Controls.Add(max_win);
            Controls.Add(minimizar_win);
            Controls.Add(cerrar_win);
            Controls.Add(label1);
            Controls.Add(ususario_label);
            Controls.Add(contraseña_label);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1165, 605);
            MinimumSize = new Size(1165, 605);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)contraseña_log_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuario_log_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_text;
        private Label texto2;
        private Label texto1;
        private Button login_button;
        private PictureBox contraseña_log_logo;
        private PictureBox usuario_log_logo;
        private TextBox contraseña_log_text;
        private TextBox usuario_log_text;
        private Label Titulo;
        private Button max_win;
        private Button minimizar_win;
        private Button cerrar_win;
        private Label ususario_label;
        private Label contraseña_label;
        private Label label1;
        private TextBox confirmar_text;
        private PictureBox pictureBox1;
        private Button btnVer;
        private Button btnVerCC;
    }
}
namespace MouWallet
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            cerrar_win = new Button();
            minimizar_win = new Button();
            max_win = new Button();
            Titulo = new Label();
            usuario_log_text = new TextBox();
            contraseña_log_text = new TextBox();
            usuario_log_logo = new PictureBox();
            contraseña_log_logo = new PictureBox();
            ususario_label = new Label();
            contraseña_label = new Label();
            login_button = new Button();
            texto1 = new Label();
            registro_text = new Label();
            texto2 = new Label();
            btnver = new Button();
            ((System.ComponentModel.ISupportInitialize)usuario_log_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contraseña_log_logo).BeginInit();
            SuspendLayout();
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
            cerrar_win.TabIndex = 0;
            cerrar_win.UseVisualStyleBackColor = false;
            cerrar_win.Click += button1_Click;
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
            minimizar_win.TabIndex = 1;
            minimizar_win.UseVisualStyleBackColor = false;
            minimizar_win.Click += minimizar_win_Click;
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
            max_win.TabIndex = 2;
            max_win.UseVisualStyleBackColor = false;
            max_win.Click += max_win_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(739, 61);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(298, 61);
            Titulo.TabIndex = 3;
            Titulo.Text = "Iniciar sesión";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usuario_log_text
            // 
            usuario_log_text.BackColor = Color.White;
            usuario_log_text.BorderStyle = BorderStyle.None;
            usuario_log_text.Cursor = Cursors.IBeam;
            usuario_log_text.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            usuario_log_text.ForeColor = SystemColors.WindowFrame;
            usuario_log_text.Location = new Point(731, 227);
            usuario_log_text.Multiline = true;
            usuario_log_text.Name = "usuario_log_text";
            usuario_log_text.Size = new Size(326, 35);
            usuario_log_text.TabIndex = 4;
            usuario_log_text.TextChanged += usuario_log_text_TextChanged;
            // 
            // contraseña_log_text
            // 
            contraseña_log_text.BackColor = Color.White;
            contraseña_log_text.BorderStyle = BorderStyle.None;
            contraseña_log_text.Cursor = Cursors.IBeam;
            contraseña_log_text.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            contraseña_log_text.ForeColor = SystemColors.WindowFrame;
            contraseña_log_text.Location = new Point(731, 343);
            contraseña_log_text.Multiline = true;
            contraseña_log_text.Name = "contraseña_log_text";
            contraseña_log_text.PasswordChar = '•';
            contraseña_log_text.Size = new Size(292, 35);
            contraseña_log_text.TabIndex = 5;
            // 
            // usuario_log_logo
            // 
            usuario_log_logo.BackColor = Color.Transparent;
            usuario_log_logo.BackgroundImage = Properties.Resources.Usuario;
            usuario_log_logo.BackgroundImageLayout = ImageLayout.Stretch;
            usuario_log_logo.Location = new Point(690, 227);
            usuario_log_logo.Name = "usuario_log_logo";
            usuario_log_logo.Size = new Size(35, 35);
            usuario_log_logo.TabIndex = 6;
            usuario_log_logo.TabStop = false;
            // 
            // contraseña_log_logo
            // 
            contraseña_log_logo.BackColor = Color.Transparent;
            contraseña_log_logo.BackgroundImage = Properties.Resources.Contraseña;
            contraseña_log_logo.BackgroundImageLayout = ImageLayout.Stretch;
            contraseña_log_logo.Location = new Point(690, 343);
            contraseña_log_logo.Name = "contraseña_log_logo";
            contraseña_log_logo.Size = new Size(35, 35);
            contraseña_log_logo.TabIndex = 7;
            contraseña_log_logo.TabStop = false;
            // 
            // ususario_label
            // 
            ususario_label.AutoSize = true;
            ususario_label.BackColor = Color.Transparent;
            ususario_label.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ususario_label.ForeColor = Color.White;
            ususario_label.Location = new Point(727, 202);
            ususario_label.Name = "ususario_label";
            ususario_label.Size = new Size(79, 26);
            ususario_label.TabIndex = 8;
            ususario_label.Text = "Usuario";
            ususario_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contraseña_label
            // 
            contraseña_label.AutoSize = true;
            contraseña_label.BackColor = Color.Transparent;
            contraseña_label.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            contraseña_label.ForeColor = Color.White;
            contraseña_label.Location = new Point(727, 318);
            contraseña_label.Name = "contraseña_label";
            contraseña_label.Size = new Size(114, 26);
            contraseña_label.TabIndex = 9;
            contraseña_label.Text = "Contraseña";
            contraseña_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            login_button.BackColor = Color.Transparent;
            login_button.Cursor = Cursors.Hand;
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            login_button.FlatAppearance.MouseOverBackColor = Color.Gray;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.ForeColor = Color.Transparent;
            login_button.Location = new Point(824, 436);
            login_button.Margin = new Padding(0);
            login_button.Name = "login_button";
            login_button.Size = new Size(100, 35);
            login_button.TabIndex = 10;
            login_button.Text = "Acceder";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // texto1
            // 
            texto1.AutoSize = true;
            texto1.BackColor = Color.Transparent;
            texto1.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            texto1.ForeColor = SystemColors.Window;
            texto1.Location = new Point(767, 529);
            texto1.Name = "texto1";
            texto1.Size = new Size(234, 24);
            texto1.TabIndex = 11;
            texto1.Text = "¿Aún no tienes una cuenta?";
            texto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registro_text
            // 
            registro_text.AutoSize = true;
            registro_text.BackColor = Color.Transparent;
            registro_text.Cursor = Cursors.Hand;
            registro_text.FlatStyle = FlatStyle.Flat;
            registro_text.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            registro_text.ForeColor = Color.White;
            registro_text.Location = new Point(764, 553);
            registro_text.Name = "registro_text";
            registro_text.Size = new Size(124, 24);
            registro_text.TabIndex = 12;
            registro_text.Text = "Presiona aquí,";
            registro_text.TextAlign = ContentAlignment.MiddleCenter;
            registro_text.Click += registro_text_Click;
            // 
            // texto2
            // 
            texto2.AutoSize = true;
            texto2.BackColor = Color.Transparent;
            texto2.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            texto2.ForeColor = SystemColors.Window;
            texto2.Location = new Point(878, 553);
            texto2.Margin = new Padding(0);
            texto2.Name = "texto2";
            texto2.Size = new Size(132, 24);
            texto2.TabIndex = 13;
            texto2.Text = " para crear una";
            texto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnver
            // 
            btnver.BackColor = Color.White;
            btnver.BackgroundImage = Properties.Resources.Ver_contraseña;
            btnver.BackgroundImageLayout = ImageLayout.Stretch;
            btnver.Cursor = Cursors.Hand;
            btnver.FlatAppearance.BorderColor = Color.White;
            btnver.FlatAppearance.BorderSize = 0;
            btnver.FlatStyle = FlatStyle.Flat;
            btnver.Location = new Point(1022, 343);
            btnver.Name = "btnver";
            btnver.Size = new Size(35, 35);
            btnver.TabIndex = 14;
            btnver.UseVisualStyleBackColor = false;
            btnver.Click += btnver_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_Definitivo2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1165, 605);
            Controls.Add(btnver);
            Controls.Add(registro_text);
            Controls.Add(texto2);
            Controls.Add(texto1);
            Controls.Add(login_button);
            Controls.Add(contraseña_log_logo);
            Controls.Add(usuario_log_logo);
            Controls.Add(contraseña_log_text);
            Controls.Add(usuario_log_text);
            Controls.Add(Titulo);
            Controls.Add(max_win);
            Controls.Add(minimizar_win);
            Controls.Add(cerrar_win);
            Controls.Add(ususario_label);
            Controls.Add(contraseña_label);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1165, 605);
            MinimumSize = new Size(1165, 605);
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MouWallet";
            ((System.ComponentModel.ISupportInitialize)usuario_log_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)contraseña_log_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cerrar_win;
        private Button minimizar_win;
        private Button max_win;
        private Label Titulo;
        private TextBox usuario_log_text;
        private TextBox contraseña_log_text;
        private PictureBox usuario_log_logo;
        private PictureBox contraseña_log_logo;
        private Label ususario_label;
        private Label contraseña_label;
        private Button login_button;
        private Label texto1;
        private Label registro_text;
        private Label texto2;
        private Button btnver;
    }
}
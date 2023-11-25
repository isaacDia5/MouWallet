namespace MouWallet
{
    partial class aboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutUs));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            Titulo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50);
            panel1.Size = new Size(1140, 672);
            panel1.TabIndex = 11;
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
            panel3.Controls.Add(label1);
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
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 344);
            panel5.Name = "panel5";
            panel5.Size = new Size(826, 128);
            panel5.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.xd;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(826, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 103);
            label1.Name = "label1";
            label1.Size = new Size(926, 185);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(Titulo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(826, 100);
            panel4.TabIndex = 5;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(258, 20);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(340, 61);
            Titulo.TabIndex = 4;
            Titulo.Text = "DAMI Solutions";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            Titulo.Click += Titulo_Click;
            // 
            // aboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 672);
            Controls.Add(panel1);
            Name = "aboutUs";
            Text = "aboutUs";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label Titulo;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
    }
}
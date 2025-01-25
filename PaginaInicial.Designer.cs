namespace Projeto_PAP_WilliamAlves_24_25
{
    partial class PaginaInicial
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
            DiarioBtn = new Button();
            SemanalBtn = new Button();
            MensalBtn = new Button();
            Dicas_txt = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DiarioBtn
            // 
            DiarioBtn.FlatAppearance.BorderSize = 4;
            DiarioBtn.FlatStyle = FlatStyle.Flat;
            DiarioBtn.Font = new Font("Bernard MT Condensed", 13.8F);
            DiarioBtn.ForeColor = Color.DarkGoldenrod;
            DiarioBtn.Location = new Point(12, 394);
            DiarioBtn.Name = "DiarioBtn";
            DiarioBtn.Size = new Size(121, 44);
            DiarioBtn.TabIndex = 0;
            DiarioBtn.Text = "Diário";
            DiarioBtn.UseVisualStyleBackColor = true;
            DiarioBtn.Click += DiarioBtn_Click;
            // 
            // SemanalBtn
            // 
            SemanalBtn.FlatAppearance.BorderSize = 4;
            SemanalBtn.FlatStyle = FlatStyle.Flat;
            SemanalBtn.Font = new Font("Bernard MT Condensed", 13.8F);
            SemanalBtn.ForeColor = Color.DarkGoldenrod;
            SemanalBtn.Location = new Point(153, 394);
            SemanalBtn.Name = "SemanalBtn";
            SemanalBtn.Size = new Size(121, 44);
            SemanalBtn.TabIndex = 1;
            SemanalBtn.Text = "Semanal";
            SemanalBtn.UseVisualStyleBackColor = true;
            SemanalBtn.Click += SemanalBtn_Click;
            // 
            // MensalBtn
            // 
            MensalBtn.FlatAppearance.BorderSize = 4;
            MensalBtn.FlatStyle = FlatStyle.Flat;
            MensalBtn.Font = new Font("Bernard MT Condensed", 13.8F);
            MensalBtn.ForeColor = Color.DarkGoldenrod;
            MensalBtn.Location = new Point(294, 394);
            MensalBtn.Name = "MensalBtn";
            MensalBtn.Size = new Size(121, 44);
            MensalBtn.TabIndex = 2;
            MensalBtn.Text = "Mensal";
            MensalBtn.UseVisualStyleBackColor = true;
            MensalBtn.Click += MensalBtn_Click;
            // 
            // Dicas_txt
            // 
            Dicas_txt.AutoSize = true;
            Dicas_txt.BackColor = Color.Black;
            Dicas_txt.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dicas_txt.ForeColor = Color.Gold;
            Dicas_txt.Location = new Point(110, 9);
            Dicas_txt.Name = "Dicas_txt";
            Dicas_txt.Size = new Size(557, 33);
            Dicas_txt.TabIndex = 3;
            Dicas_txt.Text = "Dicas para uma melhor gestão financeira pessoal.";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 222);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PaginaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Dicas_txt);
            Controls.Add(MensalBtn);
            Controls.Add(SemanalBtn);
            Controls.Add(DiarioBtn);
            Name = "PaginaInicial";
            Text = "PaginaInicial";
            Load += PaginaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DiarioBtn;
        private Button SemanalBtn;
        private Button MensalBtn;
        private Label Dicas_txt;
        private PictureBox pictureBox1;
    }
}
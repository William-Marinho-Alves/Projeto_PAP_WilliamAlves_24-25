namespace Projeto_PAP_WilliamAlves_24_25
{
    partial class Tipo_de_Utilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_de_Utilizador));
            estavel_btn = new Button();
            endividado_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // estavel_btn
            // 
            estavel_btn.BackColor = Color.Black;
            estavel_btn.FlatAppearance.BorderColor = Color.Lime;
            estavel_btn.FlatAppearance.BorderSize = 6;
            estavel_btn.FlatStyle = FlatStyle.Flat;
            estavel_btn.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estavel_btn.ForeColor = Color.Lime;
            estavel_btn.Location = new Point(205, 204);
            estavel_btn.Name = "estavel_btn";
            estavel_btn.Size = new Size(159, 111);
            estavel_btn.TabIndex = 6;
            estavel_btn.Text = "Estável";
            estavel_btn.UseVisualStyleBackColor = false;
            // 
            // endividado_btn
            // 
            endividado_btn.BackColor = Color.Black;
            endividado_btn.FlatAppearance.BorderColor = Color.Red;
            endividado_btn.FlatAppearance.BorderSize = 6;
            endividado_btn.FlatStyle = FlatStyle.Flat;
            endividado_btn.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endividado_btn.ForeColor = Color.Red;
            endividado_btn.Location = new Point(451, 204);
            endividado_btn.Name = "endividado_btn";
            endividado_btn.Size = new Size(159, 111);
            endividado_btn.TabIndex = 7;
            endividado_btn.Text = "Endividado";
            endividado_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 51);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Tipo_de_Utilizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(endividado_btn);
            Controls.Add(estavel_btn);
            Name = "Tipo_de_Utilizador";
            Text = "Tipo_de_Utilizador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button estavel_btn;
        private Button endividado_btn;
        private PictureBox pictureBox1;
    }
}
namespace Projeto_PAP_WilliamAlves_24_25
{
    partial class DadosIniciais
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
            Nome_txtBox = new TextBox();
            Nome_txt = new Label();
            Financeiro_txtBox = new TextBox();
            label1 = new Label();
            Feito_btn = new Button();
            sla_txt = new Label();
            Exemplo_txt = new TextBox();
            SuspendLayout();
            // 
            // Nome_txtBox
            // 
            Nome_txtBox.BackColor = SystemColors.InactiveCaptionText;
            Nome_txtBox.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome_txtBox.ForeColor = Color.DarkGoldenrod;
            Nome_txtBox.Location = new Point(182, 71);
            Nome_txtBox.Name = "Nome_txtBox";
            Nome_txtBox.Size = new Size(444, 25);
            Nome_txtBox.TabIndex = 7;
            Nome_txtBox.TextChanged += Nome_txtBox_TextChanged;
            // 
            // Nome_txt
            // 
            Nome_txt.AutoSize = true;
            Nome_txt.BackColor = Color.Black;
            Nome_txt.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome_txt.ForeColor = Color.Gold;
            Nome_txt.Location = new Point(377, 9);
            Nome_txt.Name = "Nome_txt";
            Nome_txt.Size = new Size(74, 33);
            Nome_txt.TabIndex = 8;
            Nome_txt.Text = "Nome";
            Nome_txt.Click += Dicas_txt_Click;
            // 
            // Financeiro_txtBox
            // 
            Financeiro_txtBox.BackColor = SystemColors.InactiveCaptionText;
            Financeiro_txtBox.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Financeiro_txtBox.ForeColor = Color.DarkGoldenrod;
            Financeiro_txtBox.Location = new Point(182, 291);
            Financeiro_txtBox.Name = "Financeiro_txtBox";
            Financeiro_txtBox.Size = new Size(444, 25);
            Financeiro_txtBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(275, 240);
            label1.Name = "label1";
            label1.Size = new Size(281, 33);
            label1.TabIndex = 10;
            label1.Text = "Valor Financeiro Pessoal\r\n";
            // 
            // Feito_btn
            // 
            Feito_btn.BackColor = Color.Black;
            Feito_btn.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            Feito_btn.FlatAppearance.BorderSize = 3;
            Feito_btn.FlatStyle = FlatStyle.Flat;
            Feito_btn.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Feito_btn.ForeColor = Color.DarkGoldenrod;
            Feito_btn.Location = new Point(337, 341);
            Feito_btn.Name = "Feito_btn";
            Feito_btn.Size = new Size(159, 41);
            Feito_btn.TabIndex = 11;
            Feito_btn.Text = "Feito";
            Feito_btn.UseVisualStyleBackColor = false;
            Feito_btn.Click += Feito_btn_Click;
            // 
            // sla_txt
            // 
            sla_txt.AutoSize = true;
            sla_txt.BackColor = Color.Black;
            sla_txt.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sla_txt.ForeColor = Color.Gold;
            sla_txt.Location = new Point(363, 117);
            sla_txt.Name = "sla_txt";
            sla_txt.Size = new Size(107, 33);
            sla_txt.TabIndex = 13;
            sla_txt.Text = "Exemplo";
            // 
            // Exemplo_txt
            // 
            Exemplo_txt.BackColor = SystemColors.InactiveCaptionText;
            Exemplo_txt.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exemplo_txt.ForeColor = Color.DarkGoldenrod;
            Exemplo_txt.Location = new Point(182, 179);
            Exemplo_txt.Name = "Exemplo_txt";
            Exemplo_txt.Size = new Size(444, 25);
            Exemplo_txt.TabIndex = 12;
            // 
            // DadosIniciais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(sla_txt);
            Controls.Add(Exemplo_txt);
            Controls.Add(Feito_btn);
            Controls.Add(label1);
            Controls.Add(Financeiro_txtBox);
            Controls.Add(Nome_txt);
            Controls.Add(Nome_txtBox);
            Name = "DadosIniciais";
            Text = "DadosIniciais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nome_txtBox;
        private Label Nome_txt;
        private TextBox Financeiro_txtBox;
        private Label label1;
        private Button Feito_btn;
        private Label sla_txt;
        private TextBox Exemplo_txt;
    }
}
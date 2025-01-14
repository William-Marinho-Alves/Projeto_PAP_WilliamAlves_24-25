namespace Projeto_PAP_WilliamAlves_24_25
{
    partial class registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registo));
            password_txt = new TextBox();
            gmail_txt = new TextBox();
            registo_btn = new Button();
            Logo = new PictureBox();
            link_login = new LinkLabel();
            VerPasseRegisto = new CheckBox();
            Login_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Login_logo).BeginInit();
            SuspendLayout();
            // 
            // password_txt
            // 
            password_txt.BackColor = Color.Black;
            password_txt.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.ForeColor = Color.DarkGoldenrod;
            password_txt.Location = new Point(182, 241);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(444, 25);
            password_txt.TabIndex = 7;
            password_txt.UseSystemPasswordChar = true;
            password_txt.TextChanged += password_txt_TextChanged;
            // 
            // gmail_txt
            // 
            gmail_txt.BackColor = SystemColors.InactiveCaptionText;
            gmail_txt.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gmail_txt.ForeColor = Color.DarkGoldenrod;
            gmail_txt.Location = new Point(182, 176);
            gmail_txt.Name = "gmail_txt";
            gmail_txt.Size = new Size(444, 25);
            gmail_txt.TabIndex = 6;
            // 
            // registo_btn
            // 
            registo_btn.BackColor = Color.Black;
            registo_btn.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            registo_btn.FlatAppearance.BorderSize = 3;
            registo_btn.FlatStyle = FlatStyle.Flat;
            registo_btn.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registo_btn.ForeColor = Color.DarkGoldenrod;
            registo_btn.Location = new Point(330, 334);
            registo_btn.Name = "registo_btn";
            registo_btn.Size = new Size(159, 41);
            registo_btn.TabIndex = 5;
            registo_btn.Text = "Registar";
            registo_btn.UseVisualStyleBackColor = false;
            registo_btn.Click += registo_btn_Click;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.Location = new Point(-154, -39);
            Logo.Name = "Logo";
            Logo.Size = new Size(407, 247);
            Logo.TabIndex = 8;
            Logo.TabStop = false;
            // 
            // link_login
            // 
            link_login.AutoSize = true;
            link_login.LinkColor = Color.Gold;
            link_login.Location = new Point(280, 392);
            link_login.Name = "link_login";
            link_login.Size = new Size(248, 20);
            link_login.TabIndex = 9;
            link_login.TabStop = true;
            link_login.Text = "Já possui uma conta? logue-se aqui!";
            link_login.LinkClicked += link_login_LinkClicked;
            // 
            // VerPasseRegisto
            // 
            VerPasseRegisto.AutoSize = true;
            VerPasseRegisto.ForeColor = Color.Gold;
            VerPasseRegisto.Location = new Point(339, 284);
            VerPasseRegisto.Name = "VerPasseRegisto";
            VerPasseRegisto.Size = new Size(142, 24);
            VerPasseRegisto.TabIndex = 10;
            VerPasseRegisto.Text = "Ver Palavra Passe";
            VerPasseRegisto.UseVisualStyleBackColor = true;
            VerPasseRegisto.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login_logo
            // 
            Login_logo.BackColor = Color.Transparent;
            Login_logo.BackgroundImage = Properties.Resources.Cool_Text___Registo_473802581981536;
            Login_logo.Location = new Point(259, 42);
            Login_logo.Name = "Login_logo";
            Login_logo.Size = new Size(308, 69);
            Login_logo.TabIndex = 11;
            Login_logo.TabStop = false;
            // 
            // registo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Login_logo);
            Controls.Add(VerPasseRegisto);
            Controls.Add(link_login);
            Controls.Add(password_txt);
            Controls.Add(gmail_txt);
            Controls.Add(registo_btn);
            Controls.Add(Logo);
            Name = "registo";
            Text = "registo";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Login_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox password_txt;
        private TextBox gmail_txt;
        private Button registo_btn;
        private PictureBox Logo;
        private LinkLabel link_login;
        private CheckBox VerPasseRegisto;
        private PictureBox Login_logo;
    }
}
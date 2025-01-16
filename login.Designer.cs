namespace Projeto_PAP_WilliamAlves_24_25
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            Login_btn = new Button();
            link_registo = new LinkLabel();
            Login_logo = new PictureBox();
            gmail_txt = new TextBox();
            password_txt = new TextBox();
            VerPasseLogin = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Login_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.Black;
            Login_btn.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            Login_btn.FlatAppearance.BorderSize = 3;
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_btn.ForeColor = Color.DarkGoldenrod;
            Login_btn.Location = new Point(330, 336);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(159, 41);
            Login_btn.TabIndex = 0;
            Login_btn.Text = "Logar";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // link_registo
            // 
            link_registo.AutoSize = true;
            link_registo.LinkColor = Color.Gold;
            link_registo.Location = new Point(270, 393);
            link_registo.Name = "link_registo";
            link_registo.Size = new Size(270, 20);
            link_registo.TabIndex = 1;
            link_registo.TabStop = true;
            link_registo.Text = "Não possui uma conta? registe-se aqui!";
            link_registo.LinkClicked += link_registo_LinkClicked;
            // 
            // Login_logo
            // 
            Login_logo.BackColor = Color.Transparent;
            Login_logo.BackgroundImage = Properties.Resources.Cool_Text___Login_473802255350792;
            Login_logo.Location = new Point(294, 40);
            Login_logo.Name = "Login_logo";
            Login_logo.Size = new Size(235, 69);
            Login_logo.TabIndex = 2;
            Login_logo.TabStop = false;
            // 
            // gmail_txt
            // 
            gmail_txt.BackColor = SystemColors.InactiveCaptionText;
            gmail_txt.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gmail_txt.ForeColor = Color.DarkGoldenrod;
            gmail_txt.Location = new Point(182, 178);
            gmail_txt.Name = "gmail_txt";
            gmail_txt.Size = new Size(444, 25);
            gmail_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            password_txt.BackColor = Color.Black;
            password_txt.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.ForeColor = Color.DarkGoldenrod;
            password_txt.Location = new Point(182, 238);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(444, 25);
            password_txt.TabIndex = 4;
            password_txt.UseSystemPasswordChar = true;
            password_txt.TextChanged += password_txt_TextChanged;
            // 
            // VerPasseLogin
            // 
            VerPasseLogin.AutoSize = true;
            VerPasseLogin.ForeColor = Color.Gold;
            VerPasseLogin.Location = new Point(339, 280);
            VerPasseLogin.Name = "VerPasseLogin";
            VerPasseLogin.Size = new Size(142, 24);
            VerPasseLogin.TabIndex = 11;
            VerPasseLogin.Text = "Ver Palavra Passe";
            VerPasseLogin.UseVisualStyleBackColor = true;
            VerPasseLogin.CheckedChanged += VerPasseLogin_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-151, -42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(VerPasseLogin);
            Controls.Add(password_txt);
            Controls.Add(gmail_txt);
            Controls.Add(Login_logo);
            Controls.Add(link_registo);
            Controls.Add(Login_btn);
            Controls.Add(pictureBox1);
            Name = "login";
            Text = "login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Login_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_btn;
        private LinkLabel link_registo;
        private PictureBox Login_logo;
        private TextBox gmail_txt;
        private TextBox password_txt;
        private CheckBox VerPasseLogin;
        private PictureBox pictureBox1;
    }
}

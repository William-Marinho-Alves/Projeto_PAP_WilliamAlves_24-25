using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Projeto_PAP_WilliamAlves_24_25
{
    public partial class registo : Form
    {
        public registo()
        {
        InitializeComponent();
        
        ConfigurePlaceholder(); 
        }

        private void ConfigurePlaceholder()
        {
            
            gmail_txt.Text = "Insira o seu email";
            gmail_txt.ForeColor = Color.DarkGoldenrod;
            password_txt.Text = "Insira sua Palavra-Passe";
            password_txt.ForeColor = Color.DarkGoldenrod;
            password_txt.UseSystemPasswordChar = false;


            password_txt.Enter += (s, e) =>
            {
                if (password_txt.Text == "Insira sua Palavra-Passe")
                {
                    password_txt.Text = "";
                    password_txt.ForeColor = Color.Gold;
                }
            };

            password_txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(password_txt.Text))
                {
                    password_txt.Text = "Insira sua Palavra-Passe";
                    password_txt.ForeColor = Color.DarkGoldenrod;
                    password_txt.UseSystemPasswordChar = false;
                }
            };
            gmail_txt.Enter += (s, e) =>
            {
                if (gmail_txt.Text == "Insira o seu email")
                {
                    gmail_txt.Text = "";
                    gmail_txt.ForeColor = Color.Gold;
                }
            };

            gmail_txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(gmail_txt.Text))
                {
                    gmail_txt.Text = "Insira o seu email";
                    gmail_txt.ForeColor = Color.DarkGoldenrod;

                }
            };
        }
        private void registo_btn_Click(object sender, EventArgs e)
        {
            string email = gmail_txt.Text;
            string palavraPasse = password_txt.Text;

            //Garante ser um provedor email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, insira um email válido do Gmail, Hotmail ou outro provedor de email.");
                return;
            }

            // String de conexão à base de dados
            string connString = @"Server=JONNY;Database=UtilizadoresDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Utilizadores (Email, PalavraPasse) VALUES (@Email, @PalavraPasse)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PalavraPasse", palavraPasse);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registo efetuado com sucesso!");
                // Voltar para o formulário de login
                this.Hide();
                login Login = new login();
                Login.Show();
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|hotmail\.com|outlook\.com|yahoo\.com)$";
            return Regex.IsMatch(email, pattern);
        }






        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();


            this.Hide();
            login.Show();
            //está feito
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (VerPasseRegisto.Checked)
            {
                // Exibe a senha no TextBox
                password_txt.UseSystemPasswordChar = false;
            }
            else if (!VerPasseRegisto.Checked && password_txt.ForeColor == Color.DarkGoldenrod)
            {
                // Exibe a senha no TextBox
                password_txt.UseSystemPasswordChar = false;
            }
            
            else {
                // Oculta a senha no TextBox
                password_txt.UseSystemPasswordChar = true;
            }
        }

        private void gmail_txt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

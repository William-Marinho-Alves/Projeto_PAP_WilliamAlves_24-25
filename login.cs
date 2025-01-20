using System.Data.SqlClient;



namespace Projeto_PAP_WilliamAlves_24_25
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            ConfigurePlaceholder();
        }

        private void ConfigurePlaceholder()
        {

            gmail_txt.Text = "Insira o seu gmail";
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
                if (gmail_txt.Text == "Insira o seu gmail")
                {
                    gmail_txt.Text = "";
                    gmail_txt.ForeColor = Color.Gold;
                }
            };

            gmail_txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(gmail_txt.Text))
                {
                    gmail_txt.Text = "Insira o seu gmail";
                    gmail_txt.ForeColor = Color.DarkGoldenrod;
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void link_registo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registo registo = new registo();


            this.Hide();
            registo.Show();
            //está feito

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string nomeUtilizador = gmail_txt.Text;
            string palavraPasse = password_txt.Text;

            // String de conexão à base de dados
            string connString = @"Server=JONNY;Database=UtilizadoresDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(1) FROM Utilizadores WHERE NomeUtilizador = @NomeUtilizador AND PalavraPasse = @PalavraPasse";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NomeUtilizador", nomeUtilizador);
                cmd.Parameters.AddWithValue("@PalavraPasse", palavraPasse);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    this.Hide();

                    Tipo_de_Utilizador Tipo_De_Utilizador = new Tipo_de_Utilizador();
                    Tipo_De_Utilizador.Show();
                }
                else
                {
                    MessageBox.Show("Nome de utilizador ou palavra-passe incorretos!");
                }
            }
        

            
        }

        private void VerPasseLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (VerPasseLogin.Checked)
            {
                // Exibe a senha no TextBox
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                // Oculta a senha no TextBox
                password_txt.UseSystemPasswordChar = true;
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void gmail_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

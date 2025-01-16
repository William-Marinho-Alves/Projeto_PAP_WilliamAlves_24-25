namespace Projeto_PAP_WilliamAlves_24_25
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
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


            this.Hide();
            Tipo_de_Utilizador Tipo_De_Utilizador = new Tipo_de_Utilizador();
            Tipo_De_Utilizador.Show();
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
    }
}

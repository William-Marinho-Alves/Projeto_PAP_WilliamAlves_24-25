using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PAP_WilliamAlves_24_25
{
    public partial class DadosIniciais : Form
    {
        private int estadoFinanceiro;
        public DadosIniciais(int estadoFinanceiro)
        {
            InitializeComponent();
            this.estadoFinanceiro = estadoFinanceiro;
        }

        private void Dicas_txt_Click(object sender, EventArgs e)
        {

        }

        private void Feito_btn_Click(object sender, EventArgs e)
        {
            int valorFinanceiro;
            bool isValid = int.TryParse(Financeiro_txtBox.Text, out valorFinanceiro);


            Tipo_de_Utilizador tipoDeUtilizador = new Tipo_de_Utilizador();

            if (!isValid)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");

            }
            else if (estadoFinanceiro == 0 && valorFinanceiro <= 0)
            {
                this.Hide();
                PaginaInicial paginaInicial = new PaginaInicial();
                paginaInicial.Show();
            }
            else if (estadoFinanceiro == 1 && valorFinanceiro >= 0)
            {
                this.Hide();
                PaginaInicial paginaInicial = new PaginaInicial();
                paginaInicial.Show();

            }
            else
            {
                MessageBox.Show("Insira o valor de acordo com o Estádo Financeiro que inseriu");
            }

        }

        private void Nome_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exemplo_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

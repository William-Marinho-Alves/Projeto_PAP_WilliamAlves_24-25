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
    public partial class Tipo_de_Utilizador : Form
    {
        private int estadoFinanceiro;

        public int EstadoFinanceiro
        {
            get { return estadoFinanceiro; }
            set { estadoFinanceiro = value; }
        }
        public Tipo_de_Utilizador()
        {

            InitializeComponent();
        }

        private void estavel_btn_Click(object sender, EventArgs e)
        {
             EstadoFinanceiro = 1;
            this.Hide();
            DadosIniciais DadosIniciais = new DadosIniciais(EstadoFinanceiro);
            DadosIniciais.Show();
            
        }

        private void endividado_btn_Click(object sender, EventArgs e)
        {
             EstadoFinanceiro = 0;
            this.Hide();
            DadosIniciais DadosIniciais = new DadosIniciais(EstadoFinanceiro);
            DadosIniciais.Show();
        
        }
    }
}

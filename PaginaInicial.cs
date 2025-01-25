using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Projeto_PAP_WilliamAlves_24_25
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            // Carregar quaisquer configurações iniciais se necessário
        }

        private void DiarioBtn_Click(object sender, EventArgs e)
        {
            ExibirGrafico("Diário");
        }

        private void SemanalBtn_Click(object sender, EventArgs e)
        {
            ExibirGrafico("Semanal");
        }

        private void MensalBtn_Click(object sender, EventArgs e)
        {
            ExibirGrafico("Mensal");
        }

        private void ExibirGrafico(string tipo)
        {
            // Dados simulados (substitua por dados reais)
            DataTable dados = ObterDados(tipo);

            try
            {
                // Gerar gráfico no Excel
                string caminhoImagem = CriarGraficoExcel(dados, tipo);

                // Exibir gráfico no PictureBox
                pictureBox1.Image = Image.FromFile(caminhoImagem);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Erro: O Microsoft Office não está instalado ou configurado corretamente.\n\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: \n" + ex.Message);
            }
        }

        private DataTable ObterDados(string tipo)
        {
            // Simulando dados baseados no tipo (substitua por dados reais do banco de dados ou outra fonte)
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Data", typeof(string));
            tabela.Columns.Add("Gasto", typeof(double));

            switch (tipo)
            {
                case "Diário":
                    tabela.Rows.Add("Segunda", 50);
                    tabela.Rows.Add("Terça", 30);
                    tabela.Rows.Add("Quarta", 20);
                    break;
                case "Semanal":
                    tabela.Rows.Add("Semana 1", 300);
                    tabela.Rows.Add("Semana 2", 400);
                    break;
                case "Mensal":
                    tabela.Rows.Add("Janeiro", 1200);
                    tabela.Rows.Add("Fevereiro", 1500);
                    break;
            }

            return tabela;
        }

        private string CriarGraficoExcel(DataTable dados, string tipo)
        {
            // Caminho para salvar a imagem do gráfico
            string caminhoImagem = $"{Application.StartupPath}\\Grafico_{tipo}.png";

            // Criar instância do Excel
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Criar o arquivo Excel
                workbook = excelApp.Workbooks.Add();
                worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Inserir dados na planilha
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    worksheet.Cells[i + 1, 1] = dados.Rows[i]["Data"];
                    worksheet.Cells[i + 1, 2] = dados.Rows[i]["Gasto"];
                }

                // Criar gráfico
                Excel.Range chartRange = worksheet.Range[
                    worksheet.Cells[1, 1],
                    worksheet.Cells[dados.Rows.Count, 2]
                ];
                Excel.ChartObjects charts = (Excel.ChartObjects)worksheet.ChartObjects();
                Excel.ChartObject chartObject = charts.Add(60, 10, 400, 300);
                Excel.Chart chart = chartObject.Chart;

                chart.SetSourceData(chartRange);
                chart.ChartType = Excel.XlChartType.xlColumnClustered;

                // Salvar gráfico como imagem
                chart.Export(caminhoImagem, "PNG", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o gráfico: " + ex.Message);
            }
            finally
            {
                // Fechar Excel
                if (workbook != null)
                {
                    workbook.Close(false);
                }
                excelApp.Quit();
            }

            return caminhoImagem;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

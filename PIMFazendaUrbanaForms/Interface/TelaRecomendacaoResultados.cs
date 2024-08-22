using PIMFazendaUrbanaLib;
using System.Text;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaRecomendacaoResultados : Form
    {
        public TelaRecomendacaoResultados(List<Cultivo> resultados, string regiao, string estacao, bool ambienteControlado)
        {
            InitializeComponent();

            if (ambienteControlado == true)
            {
                // Inverte as estações
                switch (estacao)
                {
                    case "Verão":
                        estacao = "Inverno";
                        break;
                    case "Outono":
                        estacao = "Primavera";
                        break;
                    case "Inverno":
                        estacao = "Verão";
                        break;
                    case "Primavera":
                        estacao = "Outono";
                        break;
                    // Adicione mais casos conforme necessário
                    default:
                        // Caso a estação não esteja nas opções esperadas, não faz nada
                        break;
                }

                TextBoxRecomenda.Text = $"Recomenda-se o plantio das seguintes culturas na região {regiao} durante a estação {estacao} em um ambiente controlado, para suprir a demanda do mercado:";
            }
            else
            {
                TextBoxRecomenda.Text = $"Recomenda-se o plantio das seguintes culturas na região {regiao} durante a estação {estacao}, para as melhores condições de cultivo:";
                //TextBoxRecomenda.Height = 48;
                //DataGridViewResultados.Height = 259;
                //DataGridViewResultados.Location = new Point(28, 121);
            }

            // Define AutoGenerateColumns como false para evitar a geração automática de colunas
            DataGridViewResultados.AutoGenerateColumns = false;

            // Adicione manualmente as colunas necessárias
            DataGridViewResultados.Columns.Add("IDColumn", "ID");
            DataGridViewResultados.Columns.Add("NomeColumn", "Nome");
            DataGridViewResultados.Columns.Add("VariedadeColumn", "Variedade");
            DataGridViewResultados.Columns.Add("CategoriaColumn", "Categoria");
            DataGridViewResultados.Columns["IDColumn"].DataPropertyName = "ID";
            DataGridViewResultados.Columns["NomeColumn"].DataPropertyName = "Nome";
            DataGridViewResultados.Columns["VariedadeColumn"].DataPropertyName = "Variedade";
            DataGridViewResultados.Columns["CategoriaColumn"].DataPropertyName = "Categoria";
            if (ambienteControlado == true)
            {
                DataGridViewResultados.Columns.Add("Tempo2Column", "Tempo Médio de Produção (dias)");
                DataGridViewResultados.Columns["Tempo2Column"].DataPropertyName = "TempoProdControlado";
            }
            else
            {
                DataGridViewResultados.Columns.Add("Tempo1Column", "Tempo Médio de Produção (dias)");
                DataGridViewResultados.Columns["Tempo1Column"].DataPropertyName = "TempoProdTradicional";
            }

            // Configurar o modo de redimensionamento das colunas
            foreach (DataGridViewColumn column in DataGridViewResultados.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (resultados != null && resultados.Count > 0)
            {
                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = resultados.Select(c => new
                {
                    c.ID,
                    c.Nome,
                    c.Variedade,
                    c.Categoria,
                    c.TempoProdTradicional,
                    c.TempoProdControlado,
                }).ToList();

                // Preencher o DataGridView com os dados formatados
                DataGridViewResultados.DataSource = data;
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "Recomendacoes_de_plantio_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewResultados, saveFileDialog.FileName);
            }
        }

        private void ExportToCSV(DataGridView dataGridView, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    // Escreve os cabeçalhos das colunas
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        writer.Write(dataGridView.Columns[i].HeaderText);
                        if (i < dataGridView.Columns.Count - 1)
                        {
                            writer.Write(";");
                        }
                    }
                    writer.WriteLine();

                    // Escreve os dados das células
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            // Obter o valor da célula e converter para string
                            string cellValue = Convert.ToString(row.Cells[i].Value);

                            // Substituir ponto e vírgula por vírgula, para evitar conflito com o delimitador
                            cellValue = cellValue.Replace(";", ",");

                            // Escrever o valor da célula
                            writer.Write(cellValue);

                            if (i < dataGridView.Columns.Count - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Dados exportados com sucesso para " + fileName, "Relatório Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

using PIMFazendaUrbanaLib;
using System.Text;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCompra : Form
    {
        InsumoService insumoService;
        CompraService compraService;

        public TelaCompra()
        {
            InitializeComponent();
            insumoService = new InsumoService();
            compraService = new CompraService();

            // Formatação do DataGridViewListaInsumos:
            // Define AutoGenerateColumns como false para evitar a geração automática de colunas
            DataGridViewListaInsumos.AutoGenerateColumns = false;
            // Adicionar manualmente as colunas necessárias
            DataGridViewListaInsumos.Columns.Add("IDColumn", "ID");
            DataGridViewListaInsumos.Columns.Add("NomeColumn", "Nome");
            DataGridViewListaInsumos.Columns.Add("CategoriaColumn", "Categoria");
            DataGridViewListaInsumos.Columns.Add("QtdColumn", "Quantidade");
            DataGridViewListaInsumos.Columns.Add("UnidQtdColumn", "Unidade");
            // Configurar as propriedades DataPropertyName das colunas  
            DataGridViewListaInsumos.Columns["IDColumn"].DataPropertyName = "Id";
            DataGridViewListaInsumos.Columns["NomeColumn"].DataPropertyName = "Nome";
            DataGridViewListaInsumos.Columns["CategoriaColumn"].DataPropertyName = "Categoria";
            DataGridViewListaInsumos.Columns["QtdColumn"].DataPropertyName = "Qtd";
            DataGridViewListaInsumos.Columns["UnidQtdColumn"].DataPropertyName = "Unidqtd";
            /*
            foreach (DataGridViewColumn column in DataGridViewListaInsumos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            */
            // Definir o tamanho padrão das colunas
            DataGridViewListaInsumos.Columns["IDColumn"].Width = 40;
            DataGridViewListaInsumos.Columns["NomeColumn"].Width = 200;
            DataGridViewListaInsumos.Columns["CategoriaColumn"].Width = 100;
            DataGridViewListaInsumos.Columns["QtdColumn"].Width = 95;
            DataGridViewListaInsumos.Columns["UnidQtdColumn"].Width = 75;
            DataGridViewListaInsumos.Columns["NomeColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // ------------------------------------------------------------------------------------------------

            // Formatação do DataGridViewRegistroDeCompras:
            // Define AutoGenerateColumns como false para evitar a geração automática de colunas
            DataGridViewRegistroDeCompras.AutoGenerateColumns = false;
            // Adicionar manualmente as colunas necessárias
            DataGridViewRegistroDeCompras.Columns.Add("IdPedidoCompraColumn", "ID do Pedido");
            DataGridViewRegistroDeCompras.Columns.Add("NomeInsumoColumn", "Insumo");
            DataGridViewRegistroDeCompras.Columns.Add("QtdColumn", "Quantidade");
            DataGridViewRegistroDeCompras.Columns.Add("UnidQtdColumn", "Unidade");
            DataGridViewRegistroDeCompras.Columns.Add("DataColumn", "Data");
            DataGridViewRegistroDeCompras.Columns.Add("NomeFornecedorColumn", "Fornecedor");
            DataGridViewRegistroDeCompras.Columns.Add("ValorUnitColumn", "Valor Unitário");
            DataGridViewRegistroDeCompras.Columns.Add("ValorTotalColumn", "Valor Total");
            // Configurar as propriedades DataPropertyName das colunas
            DataGridViewRegistroDeCompras.Columns["IdPedidoCompraColumn"].DataPropertyName = "IdPedidoCompra";
            DataGridViewRegistroDeCompras.Columns["NomeInsumoColumn"].DataPropertyName = "NomeInsumo";
            DataGridViewRegistroDeCompras.Columns["QtdColumn"].DataPropertyName = "Qtd";
            DataGridViewRegistroDeCompras.Columns["UnidQtdColumn"].DataPropertyName = "UnidQtd";
            DataGridViewRegistroDeCompras.Columns["DataColumn"].DataPropertyName = "Data";
            DataGridViewRegistroDeCompras.Columns["NomeFornecedorColumn"].DataPropertyName = "NomeFornecedor";
            DataGridViewRegistroDeCompras.Columns["ValorUnitColumn"].DataPropertyName = "ValorUnit";
            DataGridViewRegistroDeCompras.Columns["ValorTotalColumn"].DataPropertyName = "ValorTotal";
            // Configurar o modo de redimensionamento das colunas
            /*
            foreach (DataGridViewColumn column in DataGridViewRegistroDeCompras.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            */
            // Definir o tamanho padrão das colunas
            DataGridViewRegistroDeCompras.Columns["NomeInsumoColumn"].Width = 180;
            DataGridViewRegistroDeCompras.Columns["QtdColumn"].Width = 95;
            DataGridViewRegistroDeCompras.Columns["UnidQtdColumn"].Width = 75;
            DataGridViewRegistroDeCompras.Columns["ValorUnitColumn"].Width = 85;
            DataGridViewRegistroDeCompras.Columns["ValorTotalColumn"].Width = 95;
            DataGridViewRegistroDeCompras.Columns["DataColumn"].Width = 130;
            DataGridViewRegistroDeCompras.Columns["NomeFornecedorColumn"].Width = 280;
            DataGridViewRegistroDeCompras.Columns["IdPedidoCompraColumn"].Width = 65;
            DataGridViewRegistroDeCompras.Columns["NomeInsumoColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TelaCompra_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            try
            {
                CarregarInsumos();
                //MessageBox.Show("Lista de insumos atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                CarregarRegistroDeCompras();
                //MessageBox.Show("Lista de compras atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInsumos()
        {
            try
            {
                DataGridViewListaInsumos.DataSource = null; // Limpa a DataSource do DataGridView

                List<Insumo> insumos = insumoService.ListarInsumosAtivos();

                if (insumos != null && insumos.Count > 0)
                {
                    // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                    var data = insumos.Select(i => new
                    {
                        i.Id,
                        i.Nome,
                        i.Categoria,
                        i.Qtd,
                        i.Unidqtd
                    }).ToList();

                    DataGridViewListaInsumos.DataSource = data; // Preencher o DataGridView com os dados formatados
                }
                else
                {
                    MessageBox.Show("Nenhum insumo em estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarRegistroDeCompras()
        {
            try
            {
                DataGridViewRegistroDeCompras.DataSource = null; // Limpa a DataSource do DataGridView

                List<PedidoCompraItem> compraItens = compraService.ListarRegistrosDeCompra();

                if (compraItens != null && compraItens.Count > 0)
                {
                    // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                    var data = compraItens.Select(i => new
                    {
                        i.NomeInsumo,
                        i.Qtd,
                        i.UnidQtd,
                        ValorUnit = "R$ " + i.Valor.ToString("N2"), // Formatar o valor como "R$ valor,centavos"
                        ValorTotal = "R$ " + (i.Valor * i.Qtd).ToString("N2"), // Formatar o valor como "R$ valor,centavos"
                        // Data = i.Data.ToShortDateString(), // Para exibir apenas a data
                        i.Data, // Para exibir a data e a hora
                        i.NomeFornecedor,
                        i.IdPedidoCompra
                    }).ToList();

                    DataGridViewRegistroDeCompras.DataSource = data; // Preencher o DataGridView com os dados formatados
                }
                else
                {
                    MessageBox.Show("Nenhum registro de compra encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            string insumoNome = TextBoxPesquisar.Text;
            List<Insumo> insumos = insumoService.FiltrarInsumosNome(insumoNome);

            if (insumos != null && insumos.Count > 0)
            {
                var data = insumos.Select(i => new
                {
                    i.Id,
                    i.Nome,
                    i.Categoria,
                    i.Qtd,
                    i.Unidqtd
                }).ToList();

                DataGridViewListaInsumos.DataSource = data;
            }
            else
            {
                DataGridViewListaInsumos.DataSource = null;
            }
        }

        private void TextBoxInsumosComprados_TextChanged(object sender, EventArgs e)
        {
            //MaskedTextBoxPeriodo1.Text = null;
            //MaskedTextBoxPeriodo2.Text = null;
            string insumoNome = TextBoxInsumosComprados.Text;

            List<PedidoCompraItem> compraItens = compraService.FiltrarRegistrosDeCompraNome(insumoNome);

            if (compraItens != null && compraItens.Count > 0)
            {
                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = compraItens.Select(i => new
                {
                    i.NomeInsumo,
                    i.Qtd,
                    i.UnidQtd,
                    Valor = "R$ " + i.Valor.ToString("N2"), // Formatar o valor como "R$ valor,centavos"
                    // Data = i.Data.ToShortDateString(), // Para exibir apenas a data
                    i.Data, // Para exibir a data e a hora
                    i.NomeFornecedor,
                    i.IdPedidoCompra
                }).ToList();

                DataGridViewRegistroDeCompras.DataSource = data; // Preencher o DataGridView com os dados formatados
            }
            else
            {
                DataGridViewRegistroDeCompras.DataSource = null;
            }
        }

        private void PictureBoxIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastrarCompra telaCadastrarCompra = new TelaCadastrarCompra();
            telaCadastrarCompra.Show();
            telaCadastrarCompra.CompraCadastradaSucesso += TelaCadastrarCompra_CompraCadastradaSucesso;
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void TelaCadastrarCompra_CompraCadastradaSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void PictureBoxRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Salvar Relatório de Estoque Insumos";
            saveFileDialog.FileName = "Estoque_de_insumos_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewListaInsumos, saveFileDialog.FileName);
            }
        }

        private void PictureBoxRelatorio2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Salvar Relatório de Compra de Insumos";
            saveFileDialog.FileName = "Compra_de_insumos_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewRegistroDeCompras, saveFileDialog.FileName);
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
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewListaInsumos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewListaInsumos.Rows)
            {
                bool qtdEstoque = Convert.ToInt32(row.Cells["QtdColumn"].Value) < 1;
                if (qtdEstoque)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void PictureBoxPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string insumoNome = TextBoxInsumosComprados.Text;

                DateTime dataInicio;
                DateTime dataFim;

                if (DateTime.TryParseExact(MaskedTextBoxPeriodo1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataInicio) &&
                    DateTime.TryParseExact(MaskedTextBoxPeriodo2.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataFim))
                {
                    if (dataFim < dataInicio)
                    {
                        MessageBox.Show("A data final deve ser maior ou igual à data inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<PedidoCompraItem> compraItens = compraService.FiltrarRegistrosDeCompraPorNomeEPeriodo(insumoNome, dataInicio, dataFim);

                    if (compraItens != null && compraItens.Count > 0)
                    {
                        var data = compraItens.Select(i => new
                        {
                            i.NomeInsumo,
                            i.Qtd,
                            i.UnidQtd,
                            ValorUnit = "R$ " + i.Valor.ToString("N2"), // Formatar o valor como "R$ valor,centavos"
                            ValorTotal = "R$ " + (i.Valor * i.Qtd).ToString("N2"), // Formatar o valor como "R$ valor,centavos"
                            i.Data, // Para exibir a data e a hora
                            i.NomeFornecedor,
                            i.IdPedidoCompra
                        }).ToList();

                        DataGridViewRegistroDeCompras.DataSource = data; // Preencher o DataGridView com os dados formatados
                    }
                    else
                    {
                        DataGridViewRegistroDeCompras.DataSource = null;
                        MessageBox.Show("Nenhum registro de compra encontrado no período especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Datas inválidas. Por favor, insira datas no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxInsumosComprados_Click(object sender, EventArgs e)
        {
            TextBoxInsumosComprados.Clear();
            MaskedTextBoxPeriodo1.Clear();
            MaskedTextBoxPeriodo2.Clear();
        }
    }
}

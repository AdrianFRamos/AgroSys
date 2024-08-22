using PIMFazendaUrbanaLib;
using System.Text;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaFornecedores : Form
    {
        FornecedorService fornecedorService; // Declaração de uma instância de FornecedorService
        public TelaFornecedores()
        {
            InitializeComponent();

            fornecedorService = new FornecedorService(); // Cria uma instância de FornecedorService

            // Define AutoGenerateColumns como false para evitar a geração automática de colunas
            DataGridViewListaFornecedores.AutoGenerateColumns = false;

            // Adicione manualmente as colunas necessárias
            DataGridViewListaFornecedores.Columns.Add("IDColumn", "ID");
            DataGridViewListaFornecedores.Columns.Add("NomeColumn", "Nome");
            DataGridViewListaFornecedores.Columns.Add("EmailColumn", "Email");
            DataGridViewListaFornecedores.Columns.Add("CNPJColumn", "CNPJ");

            DataGridViewListaFornecedores.Columns.Add("TelefoneColumn", "Telefone");
            DataGridViewListaFornecedores.Columns.Add("EnderecoColumn", "Endereço");
            DataGridViewListaFornecedores.Columns.Add("CEPColumn", "CEP");

            // Configurar as propriedades DataPropertyName das colunas
            DataGridViewListaFornecedores.Columns["IDColumn"].DataPropertyName = "ID";
            DataGridViewListaFornecedores.Columns["NomeColumn"].DataPropertyName = "Nome";
            DataGridViewListaFornecedores.Columns["EmailColumn"].DataPropertyName = "Email";
            DataGridViewListaFornecedores.Columns["CNPJColumn"].DataPropertyName = "CNPJ";

            DataGridViewListaFornecedores.Columns["TelefoneColumn"].DataPropertyName = "Telefone";
            DataGridViewListaFornecedores.Columns["EnderecoColumn"].DataPropertyName = "Endereco";
            DataGridViewListaFornecedores.Columns["CEPColumn"].DataPropertyName = "CEP";

            // Configurar o modo de redimensionamento das colunas
            /*
            foreach (DataGridViewColumn column in DataGridViewListaFornecedores.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            */

            // Definindo o tamanho padrão das colunas
            DataGridViewListaFornecedores.Columns["IDColumn"].Width = 40;
            DataGridViewListaFornecedores.Columns["NomeColumn"].Width = 380;
            DataGridViewListaFornecedores.Columns["EmailColumn"].Width = 300;
            DataGridViewListaFornecedores.Columns["CNPJColumn"].Width = 150;
            DataGridViewListaFornecedores.Columns["TelefoneColumn"].Width = 125;
            DataGridViewListaFornecedores.Columns["EnderecoColumn"].Width = 500;
            DataGridViewListaFornecedores.Columns["CEPColumn"].Width = 85;

            DataGridViewListaFornecedores.Columns["EnderecoColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void TelaListarFornecedores_Load(object sender, EventArgs e)
        {
            ListarFornecedoresAtivosDataGrid();
        }

        // Manipulador de eventos para o evento FornecedorCadastradoSucesso
        private void TelaCadastrarFornecedor_FornecedorCadastradoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Manipulador de eventos para o evento FornecedorEditadoSucesso
        private void TelaEditarFornecedor_FornecedorEditadoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Método para atualizar o DataGridView
        private void AtualizarDataGridView()
        {
            ListarFornecedoresAtivosDataGrid();
        }

        private void ListarFornecedoresAtivosDataGrid()
        {
            try
            {
                DataGridViewListaFornecedores.DataSource = null; // Limpa a DataSource do DataGridView

                List<Fornecedor> fornecedores = fornecedorService.ListarFornecedoresAtivos();

                if (fornecedores != null && fornecedores.Count > 0) // Verificar se a lista de fornecedores não está vazia
                {
                    // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                    var data = fornecedores.Select(f => new
                    {
                        f.ID,
                        f.Nome,
                        f.Email,
                        CNPJ = FormatarCNPJ(f.CNPJ), // Formatar o CNPJ
                        Telefone = FormatarTelefone(f.Telefone), // Formatar o telefone
                        Endereco = FormatarEndereco(f.Endereco), // Formatar o endereço
                        CEP = FormatarCEP(f.Endereco) // Formatar o CEP
                    }).ToList();

                    DataGridViewListaFornecedores.DataSource = data; // Preencher o DataGridView com os dados formatados
                }
                else
                {
                    MessageBox.Show("Nenhum fornecedor encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar fornecedores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para formatar o telefone
        private string FormatarTelefone(TelefoneFornecedor telefone)
        {
            string numeroFormatado = telefone.Numero;

            if (numeroFormatado.Length == 8) // Verifica o tamanho do número de telefone
            {
                numeroFormatado = $"{numeroFormatado.Substring(0, 4)}-{numeroFormatado.Substring(4)}"; // Insere o hífen após os 4 primeiros dígitos
            }
            else if (numeroFormatado.Length == 9)
            {
                numeroFormatado = $"{numeroFormatado.Substring(0, 5)}-{numeroFormatado.Substring(5)}"; // Insere o hífen após os 5 primeiros dígitos
            }
            return $"({telefone.DDD}) {numeroFormatado}"; // Formata a exibição do telefone como (DDD) Número
        }

        // Método para formatar o endereço
        private string FormatarEndereco(EnderecoFornecedor endereco)
        {
            string enderecoFormatado = $"{endereco.Logradouro}, {endereco.Numero}";
            if (!string.IsNullOrWhiteSpace(endereco.Complemento))
            {
                enderecoFormatado += $", {endereco.Complemento}";
            }

            enderecoFormatado += $", {endereco.Bairro}, {endereco.Cidade} - {endereco.UF}";
            return enderecoFormatado;
        }

        // Método para formatar o CEP
        private object FormatarCEP(EnderecoFornecedor endereco)
        {
            string cepFormatado = endereco.CEP;
            if (cepFormatado.Length == 8) // Insere o hífen no CEP
            {
                cepFormatado = $"{cepFormatado.Substring(0, 5)}-{cepFormatado.Substring(5)}";
            }
            return cepFormatado;
        }

        // Método para formatar o CNPJ
        private object FormatarCNPJ(string cnpj)
        {
            string cnpjFormatado = cnpj;
            if (cnpjFormatado.Length == 14) // Insere os pontos e a barra no CNPJ
            {
                cnpjFormatado = $"{cnpjFormatado.Substring(0, 2)}.{cnpjFormatado.Substring(2, 3)}.{cnpjFormatado.Substring(5, 3)}/{cnpjFormatado.Substring(8, 4)}-{cnpjFormatado.Substring(12)}";
            }
            return cnpjFormatado;
        }

        private void PictureBoxIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastrarFornecedor telaCadastrarFornecedor = new TelaCadastrarFornecedor(); // Criar uma instância do form cadastrar
            telaCadastrarFornecedor.Show(); // Exibir o form cadastrar
            telaCadastrarFornecedor.FornecedorCadastradoSucesso += TelaCadastrarFornecedor_FornecedorCadastradoSucesso; // Evento para atualizar
        }

        private void PictureBoxAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
            MessageBox.Show("Lista de fornecedores atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaFornecedores.SelectedRows.Count == 1) // Verifica se alguma linha está selecionada no DataGridView
            {
                int selectedIndex = DataGridViewListaFornecedores.SelectedRows[0].Index; // Obter o índice da linha selecionada
                int fornecedorID = (int)DataGridViewListaFornecedores.Rows[selectedIndex].Cells["IDColumn"].Value; // Obter o ID do fornecedor selecionado
                TelaEditarFornecedor telaEditarFornecedor = new TelaEditarFornecedor(fornecedorID); // Criar uma instância do form editar
                telaEditarFornecedor.Show(); // Exibir o form editar
                telaEditarFornecedor.FornecedorEditadoSucesso += TelaEditarFornecedor_FornecedorEditadoSucesso; // Evento para atualizar
            }
            else if (DataGridViewListaFornecedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um fornecedor para editar (botão '>' à esquerda do ID do fornecedor).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, selecione apenas um fornecedor para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxDeletar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaFornecedores.SelectedRows.Count > 0) // Verificar se alguma linha está selecionada no DataGridView
            {
                int selectedIndex = DataGridViewListaFornecedores.SelectedRows[0].Index; // Obter o índice da linha selecionada
                int fornecedorID = (int)DataGridViewListaFornecedores.Rows[selectedIndex].Cells["IDColumn"].Value; // Obter o ID do fornecedor selecionado

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        fornecedorService.ExcluirFornecedor(fornecedorID); // Excluir o fornecedor
                        MessageBox.Show("Fornecedor excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarFornecedoresAtivosDataGrid(); // Atualizar o DataGridView após a exclusão
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor para excluir (botão '>' à esquerda do ID do fornecedor).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            string fornecedorNome = TextBoxPesquisar.Text;
            List<Fornecedor> fornecedores = fornecedorService.FiltrarFornecedoresNome(fornecedorNome);

            if (fornecedores != null && fornecedores.Count > 0) // Verificar se a lista de fornecedores não está vazia
            {
                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = fornecedores.Select(f => new
                {
                    f.ID,
                    f.Nome,
                    f.Email,
                    CNPJ = FormatarCNPJ(f.CNPJ), // Formatar o CNPJ
                    Telefone = FormatarTelefone(f.Telefone), // Formatar o telefone
                    Endereco = FormatarEndereco(f.Endereco), // Formatar o endereço
                    CEP = FormatarCEP(f.Endereco) // Formatar o CEP
                }).ToList();

                DataGridViewListaFornecedores.DataSource = data; // Preencher o DataGridView com os dados formatados
            }
        }

        private void PictureBoxRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Salvar Relatório de Fornecedores";
            saveFileDialog.FileName = "Fornecedores_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewListaFornecedores, saveFileDialog.FileName);
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

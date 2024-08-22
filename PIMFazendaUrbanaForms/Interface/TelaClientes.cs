using PIMFazendaUrbanaLib;
using System.Text;
using System.Windows.Forms;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaClientes : Form
    {
        ClienteService clienteService; // Declaração de uma instância de ClienteService
        public TelaClientes()
        {
            InitializeComponent();

            clienteService = new ClienteService(); // Cria uma instância de ClienteService

            // Define AutoGenerateColumns como false para evitar a geração automática de colunas
            DataGridViewListaClientes.AutoGenerateColumns = false;

            // Adicione manualmente as colunas necessárias
            DataGridViewListaClientes.Columns.Add("IDColumn", "ID");
            DataGridViewListaClientes.Columns.Add("NomeColumn", "Nome");
            DataGridViewListaClientes.Columns.Add("EmailColumn", "Email");
            DataGridViewListaClientes.Columns.Add("CNPJColumn", "CNPJ");

            DataGridViewListaClientes.Columns.Add("TelefoneColumn", "Telefone");
            DataGridViewListaClientes.Columns.Add("EnderecoColumn", "Endereço");
            DataGridViewListaClientes.Columns.Add("CEPColumn", "CEP");

            // Configurar as propriedades DataPropertyName das colunas
            DataGridViewListaClientes.Columns["IDColumn"].DataPropertyName = "ID";
            DataGridViewListaClientes.Columns["NomeColumn"].DataPropertyName = "Nome";
            DataGridViewListaClientes.Columns["EmailColumn"].DataPropertyName = "Email";
            DataGridViewListaClientes.Columns["CNPJColumn"].DataPropertyName = "CNPJ";

            DataGridViewListaClientes.Columns["TelefoneColumn"].DataPropertyName = "Telefone";
            DataGridViewListaClientes.Columns["EnderecoColumn"].DataPropertyName = "Endereco";
            DataGridViewListaClientes.Columns["CEPColumn"].DataPropertyName = "CEP";


            // Configurar o modo de redimensionamento das colunas
            /*
            foreach (DataGridViewColumn column in DataGridViewListaClientes.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            */

            // Definindo o tamanho padrão das colunas
            DataGridViewListaClientes.Columns["IDColumn"].Width = 40;
            DataGridViewListaClientes.Columns["NomeColumn"].Width = 400;
            DataGridViewListaClientes.Columns["EmailColumn"].Width = 270;
            DataGridViewListaClientes.Columns["CNPJColumn"].Width = 150;
            DataGridViewListaClientes.Columns["TelefoneColumn"].Width = 125;
            DataGridViewListaClientes.Columns["EnderecoColumn"].Width = 500;
            DataGridViewListaClientes.Columns["CEPColumn"].Width = 85;

            DataGridViewListaClientes.Columns["EnderecoColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //DataGridViewListaClientes.AllowUserToResizeColumns = true;
        }

        private void TelaListarClientes_Load(object sender, EventArgs e)
        {
            ListarClientesAtivosDataGrid();
        }

        // Manipulador de eventos para o evento ClienteCadastradoSucesso
        private void TelaCadastrarCliente_ClienteCadastradoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Manipulador de eventos para o evento ClienteEditadoSucesso
        private void TelaEditarCliente_ClienteEditadoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Método para atualizar o DataGridView
        private void AtualizarDataGridView()
        {
            ListarClientesAtivosDataGrid();
        }

        private void ListarClientesAtivosDataGrid()
        {
            try
            {
                DataGridViewListaClientes.DataSource = null; // Limpa a DataSource do DataGridView

                List<Cliente> clientes = clienteService.ListarClientesAtivos();

                if (clientes != null && clientes.Count > 0) // Verificar se a lista de clientes não está vazia
                {
                    // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                    var data = clientes.Select(c => new
                    {
                        c.ID,
                        c.Nome,
                        c.Email,
                        CNPJ = FormatarCNPJ(c.CNPJ), // Formatar o CNPJ
                        Telefone = FormatarTelefone(c.Telefone), // Formatar o telefone
                        Endereco = FormatarEndereco(c.Endereco), // Formatar o endereço
                        CEP = FormatarCEP(c.Endereco) // Formatar o CEP
                    }).ToList();

                    DataGridViewListaClientes.DataSource = data; // Preencher o DataGridView com os dados formatados
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para formatar o telefone
        private string FormatarTelefone(TelefoneCliente telefone)
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
        private string FormatarEndereco(EnderecoCliente endereco)
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
        private object FormatarCEP(EnderecoCliente endereco)
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
            TelaCadastrarCliente telaCadastrarCliente = new TelaCadastrarCliente(); // Criar uma instância do form cadastrar
            telaCadastrarCliente.Show(); // Exibir o form cadastrar
            telaCadastrarCliente.ClienteCadastradoSucesso += TelaCadastrarCliente_ClienteCadastradoSucesso; // Evento para atualizar
        }

        private void PictureBoxAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
            MessageBox.Show("Lista de clientes atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaClientes.SelectedRows.Count == 1) // Verifica se alguma linha está selecionada no DataGridView
            {
                int selectedIndex = DataGridViewListaClientes.SelectedRows[0].Index; // Obter o índice da linha selecionada
                int clienteID = (int)DataGridViewListaClientes.Rows[selectedIndex].Cells["IDColumn"].Value; // Obter o ID do cliente selecionado
                TelaEditarCliente telaEditarCliente = new TelaEditarCliente(clienteID); // Criar uma instância do form editar
                telaEditarCliente.Show(); // Exibir o form editar
                telaEditarCliente.ClienteEditadoSucesso += TelaEditarCliente_ClienteEditadoSucesso; // Evento para atualizar
            }
            else if (DataGridViewListaClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente para editar (botão '>' à esquerda do ID do cliente).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, selecione apenas um cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxDeletar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaClientes.SelectedRows.Count > 0) // Verificar se alguma linha está selecionada no DataGridView
            {
                int selectedIndex = DataGridViewListaClientes.SelectedRows[0].Index; // Obter o índice da linha selecionada
                int clienteID = (int)DataGridViewListaClientes.Rows[selectedIndex].Cells["IDColumn"].Value; // Obter o ID do cliente selecionado

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        clienteService.ExcluirCliente(clienteID); // Excluir o cliente
                        MessageBox.Show("Cliente excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientesAtivosDataGrid(); // Atualizar o DataGridView após a exclusão
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir (botão '>' à esquerda do ID do cliente).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            string clienteNome = TextBoxPesquisar.Text;
            List<Cliente> clientes = clienteService.FiltrarClientesNome(clienteNome);

            if (clientes != null && clientes.Count > 0) // Verificar se a lista de clientes não está vazia
            {
                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = clientes.Select(c => new
                {
                    c.ID,
                    c.Nome,
                    c.Email,
                    CNPJ = FormatarCNPJ(c.CNPJ), // Formatar o CNPJ
                    Telefone = FormatarTelefone(c.Telefone), // Formatar o telefone
                    Endereco = FormatarEndereco(c.Endereco), // Formatar o endereço
                    CEP = FormatarCEP(c.Endereco) // Formatar o CEP
                }).ToList();

                DataGridViewListaClientes.DataSource = data; // Preencher o DataGridView com os dados formatados
            }
        }

        private void PictureBoxRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Salvar Relatório de Clientes";
            saveFileDialog.FileName = "Clientes_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewListaClientes, saveFileDialog.FileName);
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

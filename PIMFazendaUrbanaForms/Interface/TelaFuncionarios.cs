using PIMFazendaUrbanaLib;
using System.Text;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaFuncionarios : Form
    {
        FuncionarioService funcionarioService; // Declaração de uma instância de FuncionarioService
        public TelaFuncionarios()
        {
            InitializeComponent();

            funcionarioService = new FuncionarioService(); // Cria uma instância de FuncionarioService

            // Define AutoGenerateColumns como false para evitar a geração automática de colunas
            DataGridViewListaFuncionarios.AutoGenerateColumns = false;

            // Adicione manualmente as colunas necessárias
            DataGridViewListaFuncionarios.Columns.Add("IDColumn", "ID");
            DataGridViewListaFuncionarios.Columns.Add("NomeColumn", "Nome");
            DataGridViewListaFuncionarios.Columns.Add("SexoColumn", "Sexo");
            DataGridViewListaFuncionarios.Columns.Add("EmailColumn", "Email");
            DataGridViewListaFuncionarios.Columns.Add("CPFColumn", "CPF");
            DataGridViewListaFuncionarios.Columns.Add("CargoColumn", "Cargo");
            DataGridViewListaFuncionarios.Columns.Add("UsuarioColumn", "Usuário"); // talvez não listar o nome de usuário dos funcionários?

            DataGridViewListaFuncionarios.Columns.Add("TelefoneColumn", "Telefone");
            DataGridViewListaFuncionarios.Columns.Add("EnderecoColumn", "Endereço");
            DataGridViewListaFuncionarios.Columns.Add("CEPColumn", "CEP");

            // Configurar as propriedades DataPropertyName das colunas
            DataGridViewListaFuncionarios.Columns["IDColumn"].DataPropertyName = "ID";
            DataGridViewListaFuncionarios.Columns["NomeColumn"].DataPropertyName = "Nome";
            DataGridViewListaFuncionarios.Columns["SexoColumn"].DataPropertyName = "Sexo";
            DataGridViewListaFuncionarios.Columns["EmailColumn"].DataPropertyName = "Email";
            DataGridViewListaFuncionarios.Columns["CPFColumn"].DataPropertyName = "CPF";
            DataGridViewListaFuncionarios.Columns["CargoColumn"].DataPropertyName = "Cargo";
            DataGridViewListaFuncionarios.Columns["UsuarioColumn"].DataPropertyName = "Usuario"; // talvez não listar o nome de usuário dos funcionários?

            DataGridViewListaFuncionarios.Columns["TelefoneColumn"].DataPropertyName = "Telefone";
            DataGridViewListaFuncionarios.Columns["EnderecoColumn"].DataPropertyName = "Endereco";
            DataGridViewListaFuncionarios.Columns["CEPColumn"].DataPropertyName = "CEP";

            // Configurar o modo de redimensionamento das colunas
            /*
            foreach (DataGridViewColumn column in DataGridViewListaFuncionarios.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            */

            // Definindo o tamanho padrão das colunas
            DataGridViewListaFuncionarios.Columns["IDColumn"].Width = 40;
            DataGridViewListaFuncionarios.Columns["NomeColumn"].Width = 320;
            DataGridViewListaFuncionarios.Columns["SexoColumn"].Width = 45;
            DataGridViewListaFuncionarios.Columns["EmailColumn"].Width = 220;
            DataGridViewListaFuncionarios.Columns["CPFColumn"].Width = 120;
            DataGridViewListaFuncionarios.Columns["CargoColumn"].Width = 100;
            DataGridViewListaFuncionarios.Columns["UsuarioColumn"].Width = 85;
            DataGridViewListaFuncionarios.Columns["TelefoneColumn"].Width = 125;
            DataGridViewListaFuncionarios.Columns["EnderecoColumn"].Width = 500;
            DataGridViewListaFuncionarios.Columns["CEPColumn"].Width = 85;

            DataGridViewListaFuncionarios.Columns["EnderecoColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void TelaFuncionarios_Load(object sender, EventArgs e)
        {
            ListarFuncionariosAtivosDataGrid();
        }

        // Manipulador de eventos para o evento FuncionarioCadastradoSucesso
        private void TelaCadastrarFuncionario_FuncionarioCadastradoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Manipulador de eventos para o evento FuncionarioEditadoSucesso
        private void TelaEditarFuncionario_FuncionarioEditadoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Definir um evento para notificar a exclusão bem-sucedida de um funcionário
        public event EventHandler FuncionarioExcluidoSucesso;

        // Manipulador de eventos para o evento FuncionarioExcluidoSucesso
        private void TelaExcluirFuncionario_FuncionarioExcluidoSucesso(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        // Método para atualizar o DataGridView
        private void AtualizarDataGridView()
        {
            ListarFuncionariosAtivosDataGrid();
        }

        private void ListarFuncionariosAtivosDataGrid()
        {
            try
            {
                DataGridViewListaFuncionarios.DataSource = null; // Limpa a DataSource do DataGridView

                List<Funcionario> funcionarios = funcionarioService.ListarFuncionariosAtivos();

                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = funcionarios?.Select(f => new
                {
                    f.ID,
                    f.Nome,
                    f.Sexo,
                    f.Email,
                    CPF = FormatarCPF(f.CPF),
                    f.Cargo,
                    f.Usuario, // talvez não listar o nome de usuário dos funcionários?
                    Telefone = FormatarTelefone(f.Telefone), // Formatar o telefone
                    Endereco = FormatarEndereco(f.Endereco), // Formatar o endereço
                    CEP = FormatarCEP(f.Endereco) // Formatar o CEP
                }).ToList();

                // Atualizar o DataGridView com a lista de funcionários formatados ou limpa se a lista for vazia
                DataGridViewListaFuncionarios.DataSource = data;

                // Verificar se a lista de funcionários não está vazia
                if (data == null || data.Count == 0)
                {
                    MessageBox.Show("Nenhum funcionário encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar funcionários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para formatar o CPF
        private object FormatarCPF(string cpf)
        {
            string cpfFormatado = cpf;
            if (cpfFormatado.Length == 11) // Insere os pontos e traço no CPF
            {
                cpfFormatado = $"{cpfFormatado.Substring(0, 3)}.{cpfFormatado.Substring(3, 3)}.{cpfFormatado.Substring(6, 3)}-{cpfFormatado.Substring(9)}";
            }
            return cpfFormatado;
        }

        // Método para formatar o telefone
        private string FormatarTelefone(TelefoneFuncionario telefone)
        {
            string numeroFormatado = telefone.Numero;

            // Verifica o tamanho do número de telefone
            if (numeroFormatado.Length == 8)
            {
                // Insere o hífen após os 4 primeiros dígitos
                numeroFormatado = $"{numeroFormatado.Substring(0, 4)}-{numeroFormatado.Substring(4)}";
            }
            else if (numeroFormatado.Length == 9)
            {
                // Insere o hífen após os 5 primeiros dígitos
                numeroFormatado = $"{numeroFormatado.Substring(0, 5)}-{numeroFormatado.Substring(5)}";
            }

            // Formata a exibição do telefone como (DDD) Número
            return $"({telefone.DDD}) {numeroFormatado}";
        }

        // Método para formatar o endereço
        private string FormatarEndereco(EnderecoFuncionario endereco)
        {
            string enderecoFormatado = $"{endereco.Logradouro}, {endereco.Numero}";

            if (!string.IsNullOrWhiteSpace(endereco.Complemento))
            {
                enderecoFormatado += $", {endereco.Complemento}";
            }

            enderecoFormatado += $", {endereco.Bairro}, {endereco.Cidade} - {endereco.UF}";

            // Retorna o endereço formatado
            return enderecoFormatado;
        }

        // Método para formatar o CEP
        private object FormatarCEP(EnderecoFuncionario endereco)
        {
            string cepFormatado = endereco.CEP;

            // Insere o hífen no CEP
            if (cepFormatado.Length == 8)
            {
                cepFormatado = $"{cepFormatado.Substring(0, 5)}-{cepFormatado.Substring(5)}";
            }

            return cepFormatado;
        }

        private void PictureBoxIncluir_Click(object sender, EventArgs e)
        {
            // Criar uma instância do segundo formulário
            TelaCadastrarFuncionario telaCadastrarFuncionario = new TelaCadastrarFuncionario();

            // Exibir o segundo formulário
            telaCadastrarFuncionario.Show();

            telaCadastrarFuncionario.FuncionarioCadastradoSucesso += TelaCadastrarFuncionario_FuncionarioCadastradoSucesso;
        }

        private void PictureBoxAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
            MessageBox.Show("Lista de usuários atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBoxDeletar_Click(object sender, EventArgs e)
        {
            // Verificar se alguma linha está selecionada no DataGridView
            if (DataGridViewListaFuncionarios.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                int selectedIndex = DataGridViewListaFuncionarios.SelectedRows[0].Index;

                // Obter o ID do funcionário selecionado
                int funcionarioID = (int)DataGridViewListaFuncionarios.Rows[selectedIndex].Cells["IDColumn"].Value;

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        funcionarioService.ExcluirFuncionario(funcionarioID); // Excluir o funcionário
                        MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarDataGridView(); // Atualizar o DataGridView
                        FuncionarioExcluidoSucesso?.Invoke(this, EventArgs.Empty); // Disparar o evento FuncionarioExcluidoSucesso
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário para excluir (botão '>' à esquerda do ID do usuário).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxEditar_Click(object sender, EventArgs e)
        {
            // Verificar se alguma linha está selecionada no DataGridView
            if (DataGridViewListaFuncionarios.SelectedRows.Count == 1)
            {
                // Obter o índice da linha selecionada
                int selectedIndex = DataGridViewListaFuncionarios.SelectedRows[0].Index;

                // Obter o ID do funcionário selecionado
                int funcionarioID = (int)DataGridViewListaFuncionarios.Rows[selectedIndex].Cells["IDColumn"].Value;

                // Criar uma instância do segundo formulário
                TelaEditarFuncionario telaEditarFuncionario = new TelaEditarFuncionario(funcionarioID);

                // Exibir o segundo formulário
                telaEditarFuncionario.Show();

                telaEditarFuncionario.FuncionarioEditadoSucesso += TelaEditarFuncionario_FuncionarioEditadoSucesso;
            }
            else if (DataGridViewListaFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um usuário para editar (botão '>' à esquerda do ID do usuário).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, selecione apenas um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            string funcionarioNome = TextBoxPesquisar.Text;
            List<Funcionario> funcionarios = funcionarioService.FiltrarFuncionariosNome(funcionarioNome);

            if (funcionarios != null && funcionarios.Count > 0) // Verificar se a lista de clientes não está vazia
            {
                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = funcionarios?.Select(f => new
                {
                    f.ID,
                    f.Nome,
                    f.Sexo,
                    f.Email,
                    CPF = FormatarCPF(f.CPF),
                    f.Cargo,
                    f.Usuario, // talvez não listar o nome de usuário dos funcionários?
                    Telefone = FormatarTelefone(f.Telefone), // Formatar o telefone
                    Endereco = FormatarEndereco(f.Endereco), // Formatar o endereço
                    CEP = FormatarCEP(f.Endereco) // Formatar o CEP
                }).ToList();

                DataGridViewListaFuncionarios.DataSource = data; // Preencher o DataGridView com os dados formatados
            }
        }

        private void PictureBoxRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Salvar Relatório de Funcionários";
            saveFileDialog.FileName = "Funcionários_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewListaFuncionarios, saveFileDialog.FileName);
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

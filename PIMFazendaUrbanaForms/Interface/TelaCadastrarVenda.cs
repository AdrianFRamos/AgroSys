using PIMFazendaUrbanaLib;
using System.ComponentModel;
using System.Globalization;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarVenda : Form
    {
        private ClienteService clienteService;
        private EstoqueProdutoService produtoService;
        private VendaService vendaService;
        private List<Cliente> clientes;
        private List<EstoqueProduto> produtos;
        private BindingList<PedidoVendaItem> vendaItems; // BindingList para armazenar os itens do pedido
        private decimal valorUnitario; // Valor unitário do produto selecionado
        private EstoqueProduto produtoSelecionado = new EstoqueProduto();
        public event EventHandler VendaCadastradaSucesso;

        public TelaCadastrarVenda()
        {
            InitializeComponent();
            clienteService = new ClienteService();
            produtoService = new EstoqueProdutoService();
            vendaService = new VendaService();
            vendaItems = new BindingList<PedidoVendaItem>(); // Inicializa a BindingList

            // Configura o DataGridView para usar a BindingList
            DataGridItensPedidoVenda.AutoGenerateColumns = false;
            DataGridItensPedidoVenda.DataSource = vendaItems;

            // Adiciona as colunas manualmente
            DataGridItensPedidoVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeProduto",
                HeaderText = "Nome do Produto",
                Name = "NomeProduto",
                ReadOnly = true,
            });

            DataGridItensPedidoVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qtd",
                HeaderText = "Quantidade",
                Name = "Quantidade",
                ReadOnly = true
            });

            DataGridItensPedidoVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidQtd",
                HeaderText = "Unidade",
                Name = "Unidade",
                ReadOnly = true
            });

            DataGridItensPedidoVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Valor",
                HeaderText = "Valor Unitário",
                Name = "ValorUnitario",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Adiciona a coluna calculada para "Valor Total"
            DataGridViewTextBoxColumn valorTotalColumn = new DataGridViewTextBoxColumn();
            valorTotalColumn.Name = "ValorTotal"; // Define um nome único para a coluna
            valorTotalColumn.HeaderText = "Valor Total";
            valorTotalColumn.ReadOnly = true;
            DataGridItensPedidoVenda.Columns.Add(valorTotalColumn);

            // Ajustar o tamanho das colunas
            DataGridItensPedidoVenda.Columns["NomeProduto"].Width = 260;
            DataGridItensPedidoVenda.Columns["Quantidade"].Width = 95;
            DataGridItensPedidoVenda.Columns["Unidade"].Width = 75;
            DataGridItensPedidoVenda.Columns["ValorUnitario"].Width = 127;
            DataGridItensPedidoVenda.Columns["ValorTotal"].Width = 107;

            // Definir autofill para a coluna "Nome do Produto"
            DataGridItensPedidoVenda.Columns["NomeProduto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Configura o evento de formatação de células
            DataGridItensPedidoVenda.CellFormatting += DataGridItensPedidoVenda_CellFormatting;

            // Adiciona eventos de validação para os TextBoxes
            TextBoxQuantidade.Validating += TextBoxQuantidade_Validating;
            TextBoxValorUnitario.Validating += TextBoxValorUnitario_Validating;
            TextBoxValorUnitario.TextChanged += TextBoxValorUnitario_TextChanged;

            // Atualiza o valor total do pedido
            vendaItems.ListChanged += VendaItems_ListChanged;
        }

        private void TelaCadastrarVenda_Load(object sender, EventArgs e)
        {
            // Carregar clientes e produtos nos ComboBoxes
            clientes = clienteService.ListarClientesAtivos();
            produtos = produtoService.ListarEstoqueProdutoAtivos();

            if (clientes != null && clientes.Count > 0)
            {
                ComboBoxCliente.Items.Clear();
                foreach (var cliente in clientes)
                {
                    ComboBoxCliente.Items.Add(cliente.Nome);
                }
            }

            if (produtos != null && produtos.Count > 0)
            {
                ComboBoxProduto.Items.Clear();
                foreach (var produto in produtos)
                {
                    ComboBoxProduto.Items.Add(produto.VariedadeCultivo);
                }
            }
        }

        private void TextBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void TextBoxValorUnitario_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void TextBoxQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxQuantidade.Text))
            {
                TextBoxQuantidade.ForeColor = Color.Black;
                return; // Ignora a validação se o campo estiver vazio
            }

            if (!int.TryParse(TextBoxQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                e.Cancel = true;
                TextBoxQuantidade.ForeColor = Color.Red;
                MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (quantidade > produtoSelecionado.Qtd)
            {
                e.Cancel = true;
                TextBoxQuantidade.ForeColor = Color.Red;
                MessageBox.Show("A quantidade informada é maior que a quantidade em estoque.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TextBoxQuantidade.ForeColor = Color.Black;
            }
        }

        private void TextBoxValorUnitario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxValorUnitario.Text))
            {
                TextBoxValorUnitario.ForeColor = Color.Black;
                return; // Ignora a validação se o campo estiver vazio
            }

            if (decimal.TryParse(TextBoxValorUnitario.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("pt-BR"), out decimal valor))
            {
                TextBoxValorUnitario.Text = valor.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
                TextBoxValorUnitario.ForeColor = Color.Black;
            }
            else
            {
                e.Cancel = true;
                TextBoxValorUnitario.ForeColor = Color.Red;
                MessageBox.Show("O valor unitário deve ser um número decimal maior que zero.", "Valor Unitário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarValorTotal()
        {
            if (int.TryParse(TextBoxQuantidade.Text, out int quantidade) && decimal.TryParse(TextBoxValorUnitario.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valor))
            {
                decimal valorTotal = quantidade * valor;
                TextBoxValorTotal.Text = valorTotal.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                TextBoxValorTotal.Text = string.Empty;
            }
        }

        private void AtualizarValorTotalPedido()
        {
            decimal totalPedido = vendaItems.Sum(item => item.Qtd * item.Valor);
            TextBoxValorTotalPedido.Text = totalPedido.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void VendaItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            AtualizarValorTotalPedido();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxAdicionar_Click(object sender, EventArgs e)
        {
            ComboBoxCliente.Enabled = false;

            if (ComboBoxProduto.SelectedItem == null || string.IsNullOrEmpty(TextBoxQuantidade.Text) || string.IsNullOrEmpty(TextBoxValorUnitario.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar ao carrinho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeProdutoSelecionado = ComboBoxProduto.SelectedItem.ToString();
            produtoSelecionado = produtos.FirstOrDefault(p => p.VariedadeCultivo == nomeProdutoSelecionado);

            if (produtoSelecionado != null)
            {
                // Verificação para evitar itens duplicados
                if (vendaItems.Any(item => item.IdProduto == produtoSelecionado.Id))
                {
                    MessageBox.Show("O produto já foi adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PedidoVendaItem item = new PedidoVendaItem
                {
                    IdProduto = produtoSelecionado.Id,
                    NomeProduto = produtoSelecionado.VariedadeCultivo,
                    Qtd = int.Parse(TextBoxQuantidade.Text),
                    Valor = decimal.Parse(TextBoxValorUnitario.Text, CultureInfo.GetCultureInfo("pt-BR")),
                    UnidQtd = TextBoxUnidade.Text
                };

                vendaItems.Add(item);
                AtualizarValorTotalDataGrid();
            }
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            bool quantidadeValida = int.TryParse(TextBoxQuantidade.Text, out int quantidade) && quantidade > 0;
            bool valorunitarioValido = decimal.TryParse(TextBoxValorUnitario.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valorUnitario) && valorUnitario > 0;
            bool clienteValido = ComboBoxCliente.SelectedItem != null;
            bool produtoValido = ComboBoxProduto.SelectedItem != null;

            if (!clienteValido)
            {
                MessageBox.Show("Cliente inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!produtoValido)
            {
                MessageBox.Show("Produto inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!quantidadeValida)
            {
                MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxQuantidade;
                return;
            }

            if (!valorunitarioValido)
            {
                MessageBox.Show("O valor unitário deve ser um número decimal maior que zero.", "Valor Unitário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxValorUnitario;
                return;
            }

            if (quantidadeValida && valorunitarioValido && clienteValido && produtoValido)
            {
                if (DataGridItensPedidoVenda.Rows.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um item ao carrinho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int idPedidoVenda = 0;
                    try
                    {
                        int? ultimoId = vendaService.ObterUltimoIdPedidoVenda();
                        idPedidoVenda = ultimoId.HasValue ? ultimoId.Value + 1 : 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter último ID de pedido de venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<PedidoVendaItem> vendaItemsList = new List<PedidoVendaItem>();
                    foreach (DataGridViewRow row in DataGridItensPedidoVenda.Rows)
                    {
                        if (row.Cells["NomeProduto"].Value != null && row.Cells["Quantidade"].Value != null && row.Cells["ValorUnitario"].Value != null)
                        {
                            vendaItemsList.Add(new PedidoVendaItem
                            {
                                NomeProduto = row.Cells["NomeProduto"].Value.ToString(),
                                Qtd = Convert.ToInt32(row.Cells["Quantidade"].Value),
                                UnidQtd = row.Cells["Unidade"].Value.ToString(),
                                Valor = Convert.ToDecimal(row.Cells["ValorUnitario"].Value, CultureInfo.GetCultureInfo("pt-BR")),
                                IdPedidoVenda = idPedidoVenda,
                                IdProduto = produtos.First(p => p.VariedadeCultivo == row.Cells["NomeProduto"].Value.ToString()).Id
                            });
                        }
                    }

                    try
                    {
                        PedidoVenda pedidoVenda = new PedidoVenda
                        {
                            Data = DateTime.Now,
                            IdCliente = clienteService.ConsultarClienteNome(ComboBoxCliente.SelectedItem.ToString()).ID
                        };

                        vendaService.CadastrarPedidoVendaComItens(pedidoVenda, vendaItemsList);

                        MessageBox.Show("Venda cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VendaCadastradaSucesso?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void TextBoxUnidade_TextChanged(object sender, EventArgs e)
        {
            string unidade = TextBoxUnidade.Text;
            if (!string.IsNullOrEmpty(unidade))
            {
                var produtosFiltrados = produtoService.FiltrarProdutosPorUnidade(unidade);
                string produtosNomes = string.Join(", ", produtosFiltrados.Select(p => p.VariedadeCultivo));
            }
        }

        private void ComboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeProdutoSelecionado = ComboBoxProduto.SelectedItem.ToString();
            produtoSelecionado = produtos.FirstOrDefault(p => p.VariedadeCultivo == nomeProdutoSelecionado);

            if (produtoSelecionado != null)
            {
                TextBoxCategoria.Text = produtoSelecionado.CategoriaCultivo;
                TextBoxUnidade.Text = produtoSelecionado.Unidqtd;
            }
            else
            {
                MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxDeletar_Click(object sender, EventArgs e)
        {
            if (DataGridItensPedidoVenda.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridItensPedidoVenda.SelectedRows)
                {
                    string nomeProduto = row.Cells[0].Value.ToString();
                    PedidoVendaItem item = vendaItems.FirstOrDefault(p => produtos.First(produto => produto.Id == p.IdProduto).VariedadeCultivo == nomeProduto);

                    if (item != null)
                    {
                        vendaItems.Remove(item);
                    }
                }
                AtualizarValorTotalDataGrid();
            }

            if (vendaItems.Count == 0)
            {
                ComboBoxCliente.Enabled = true;
            }
        }

        private void PictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (DataGridItensPedidoVenda.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DataGridItensPedidoVenda.SelectedRows[0];
                string nomeProduto = row.Cells[0].Value.ToString();
                PedidoVendaItem item = vendaItems.FirstOrDefault(p => produtos.First(produto => produto.Id == p.IdProduto).VariedadeCultivo == nomeProduto);

                if (item != null)
                {
                    ComboBoxProduto.SelectedItem = nomeProduto;
                    TextBoxQuantidade.Text = item.Qtd.ToString();
                    TextBoxValorUnitario.Text = item.Valor.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
                    TextBoxUnidade.Text = item.UnidQtd;

                    vendaItems.Remove(item);
                    AtualizarValorTotalDataGrid();
                }
            }
        }

        private void DataGridItensPedidoVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifique se a coluna "ValorTotal" está sendo formatada
            if (e.ColumnIndex == DataGridItensPedidoVenda.Columns["ValorTotal"].Index)
            {
                DataGridViewRow row = DataGridItensPedidoVenda.Rows[e.RowIndex];

                // Obtém os valores de "Quantidade" e "Valor Unitário"
                int quantidade = (int)row.Cells[DataGridItensPedidoVenda.Columns["Quantidade"].Index].Value;
                decimal valorUnitario = (decimal)row.Cells[DataGridItensPedidoVenda.Columns["ValorUnitario"].Index].Value;

                // Calcula o valor total
                e.Value = (quantidade * valorUnitario).ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            }

            // Verifique se a coluna "ValorUnitario" está sendo formatada
            if (e.ColumnIndex == DataGridItensPedidoVenda.Columns["ValorUnitario"].Index)
            {
                decimal valorUnitario = (decimal)e.Value;
                e.Value = valorUnitario.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            }
        }

        private void AtualizarValorTotalDataGrid()
        {
            foreach (DataGridViewRow row in DataGridItensPedidoVenda.Rows)
            {
                if (row.Cells["Quantidade"].Value != null && row.Cells["ValorUnitario"].Value != null)
                {
                    int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    decimal valorUnitario = Convert.ToDecimal(row.Cells["ValorUnitario"].Value, CultureInfo.GetCultureInfo("pt-BR"));
                    row.Cells["ValorTotal"].Value = (quantidade * valorUnitario).ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
                }
            }
            AtualizarValorTotalPedido();
        }

        private void TextBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e teclas de controle como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números, vírgula e teclas de controle como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permitir apenas uma vírgula
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}

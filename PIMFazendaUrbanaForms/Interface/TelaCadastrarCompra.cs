using PIMFazendaUrbanaLib;
using System.ComponentModel;
using System.Globalization;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarCompra : Form
    {
        private FornecedorService fornecedorService;
        private InsumoService insumoService;
        private CompraService compraService;
        private List<Fornecedor> fornecedores;
        private List<Insumo> insumos;
        private BindingList<PedidoCompraItem> compraItems; // BindingList para armazenar os itens do pedido
        private decimal valorUnitario; // Valor unitário do insumo selecionado
        Insumo insumo = new Insumo();
        public event EventHandler CompraCadastradaSucesso;

        public TelaCadastrarCompra()
        {
            InitializeComponent();
            fornecedorService = new FornecedorService();
            insumoService = new InsumoService();
            compraService = new CompraService();
            compraItems = new BindingList<PedidoCompraItem>(); // Inicializa a BindingList

            // Configura o DataGridView para usar a BindingList
            DataGridItensPedidoCompra.AutoGenerateColumns = false;
            DataGridItensPedidoCompra.DataSource = compraItems;

            // Adiciona as colunas manualmente
            DataGridItensPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeInsumo",
                HeaderText = "Nome do Insumo",
                Name = "NomeInsumo",
                ReadOnly = true,
            });

            DataGridItensPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qtd",
                HeaderText = "Quantidade",
                Name = "Quantidade",
                ReadOnly = true
            });

            DataGridItensPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidQtd",
                HeaderText = "Unidade",
                Name = "Unidade",
                ReadOnly = true
            });

            DataGridItensPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn
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
            DataGridItensPedidoCompra.Columns.Add(valorTotalColumn);

            // Ajustar o tamanho das colunas
            DataGridItensPedidoCompra.Columns["NomeInsumo"].Width = 260;
            DataGridItensPedidoCompra.Columns["Quantidade"].Width = 95;
            DataGridItensPedidoCompra.Columns["Unidade"].Width = 75;
            DataGridItensPedidoCompra.Columns["ValorUnitario"].Width = 127;
            DataGridItensPedidoCompra.Columns["ValorTotal"].Width = 107;

            // Definir autofill para a coluna "Nome do Insumo"
            DataGridItensPedidoCompra.Columns["NomeInsumo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Configura o evento de formatação de células
            DataGridItensPedidoCompra.CellFormatting += DataGridItensPedidoCompra_CellFormatting;

            // Adiciona eventos de validação para os TextBoxes
            TextBoxQuantidade.Validating += TextBoxQuantidade_Validating;
            TextBoxValorUnitario.Validating += TextBoxValorUnitario_Validating;
            TextBoxValorUnitario.TextChanged += TextBoxValorUnitario_TextChanged;

            // Atualiza o valor total do pedido
            compraItems.ListChanged += CompraItems_ListChanged;
        }

        private void TelaCadastrarCompra_Load(object sender, EventArgs e)
        {
            // Carregar fornecedores e insumos nos ComboBoxes
            fornecedores = fornecedorService.ListarFornecedoresAtivos();
            insumos = insumoService.ListarInsumosAtivos();

            if (fornecedores != null && fornecedores.Count > 0)
            {
                ComboBoxFornecedor.Items.Clear();
                foreach (var fornecedor in fornecedores)
                {
                    ComboBoxFornecedor.Items.Add(fornecedor.Nome);
                }
            }

            if (insumos != null && insumos.Count > 0)
            {
                ComboBoxProduto.Items.Clear();
                foreach (var insumo in insumos)
                {
                    ComboBoxProduto.Items.Add(insumo.Nome);
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
            decimal totalPedido = compraItems.Sum(item => item.Qtd * item.Valor);
            TextBoxValorTotalPedido.Text = totalPedido.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void CompraItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            AtualizarValorTotalPedido();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxAdicionar_Click(object sender, EventArgs e)
        {
            ComboBoxFornecedor.Enabled = false;

            if (ComboBoxProduto.SelectedItem == null || string.IsNullOrEmpty(TextBoxQuantidade.Text) || string.IsNullOrEmpty(TextBoxValorUnitario.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar ao carrinho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeInsumoSelecionado = ComboBoxProduto.SelectedItem.ToString();
            Insumo insumoSelecionado = insumos.FirstOrDefault(i => i.Nome == nomeInsumoSelecionado);

            if (insumoSelecionado != null)
            {
                // Verificação para evitar itens duplicados
                if (compraItems.Any(item => item.IdInsumo == insumoSelecionado.Id))
                {
                    MessageBox.Show("O produto já foi adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PedidoCompraItem item = new PedidoCompraItem
                {
                    IdInsumo = insumoSelecionado.Id,
                    NomeInsumo = insumoSelecionado.Nome,
                    Qtd = int.Parse(TextBoxQuantidade.Text),
                    Valor = decimal.Parse(TextBoxValorUnitario.Text, CultureInfo.GetCultureInfo("pt-BR")),
                    UnidQtd = TextBoxUnidade.Text
                };

                compraItems.Add(item);
                AtualizarValorTotalDataGrid();
            }
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            bool quantidadeValida = int.TryParse(TextBoxQuantidade.Text, out int quantidade) && quantidade > 0;
            bool valorunitarioValido = decimal.TryParse(TextBoxValorUnitario.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valorUnitario) && valorUnitario > 0;
            bool fornecedorValido = ComboBoxFornecedor.SelectedItem != null;
            bool insumoValido = ComboBoxProduto.SelectedItem != null;

            if (!fornecedorValido)
            {
                MessageBox.Show("Fornecedor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!insumoValido)
            {
                MessageBox.Show("Insumo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (quantidadeValida && valorunitarioValido && fornecedorValido && insumoValido)
            {
                if (DataGridItensPedidoCompra.Rows.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um item ao carrinho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int idPedidoCompra = 0;
                    try
                    {
                        int? ultimoId = compraService.ObterUltimoIdPedidoCompra();
                        idPedidoCompra = ultimoId.HasValue ? ultimoId.Value + 1 : 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter último ID de pedido de compra: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<PedidoCompraItem> compraItemsList = new List<PedidoCompraItem>();
                    foreach (DataGridViewRow row in DataGridItensPedidoCompra.Rows)
                    {
                        if (row.Cells["NomeInsumo"].Value != null && row.Cells["Quantidade"].Value != null && row.Cells["ValorUnitario"].Value != null)
                        {
                            compraItemsList.Add(new PedidoCompraItem
                            {
                                NomeInsumo = row.Cells["NomeInsumo"].Value.ToString(),
                                Qtd = Convert.ToInt32(row.Cells["Quantidade"].Value),
                                UnidQtd = row.Cells["Unidade"].Value.ToString(),
                                Valor = Convert.ToDecimal(row.Cells["ValorUnitario"].Value, CultureInfo.GetCultureInfo("pt-BR")),
                                IdPedidoCompra = idPedidoCompra,
                                IdInsumo = insumos.First(i => i.Nome == row.Cells["NomeInsumo"].Value.ToString()).Id
                            });
                        }
                    }

                    try
                    {
                        PedidoCompra pedidoCompra = new PedidoCompra
                        {
                            Data = DateTime.Now,
                            IdFornecedor = fornecedorService.ConsultarFornecedorNome(ComboBoxFornecedor.SelectedItem.ToString()).ID
                        };

                        compraService.CadastrarPedidoCompraComItens(pedidoCompra, compraItemsList);

                        MessageBox.Show("Compra cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CompraCadastradaSucesso?.Invoke(this, EventArgs.Empty);
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
                var insumosFiltrados = insumoService.FiltrarInsumosPorUnidade(unidade);
                string insumosNomes = string.Join(", ", insumosFiltrados.Select(i => i.Nome));
            }
        }

        private void ComboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeInsumoSelecionado = ComboBoxProduto.SelectedItem.ToString();
            Insumo insumoSelecionado = insumos.FirstOrDefault(i => i.Nome == nomeInsumoSelecionado);

            if (insumoSelecionado != null)
            {
                TextBoxCategoria.Text = insumoSelecionado.Categoria;
                TextBoxUnidade.Text = insumoSelecionado.Unidqtd;
            }
            else
            {
                MessageBox.Show("Insumo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxDeletar_Click(object sender, EventArgs e)
        {
            if (DataGridItensPedidoCompra.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridItensPedidoCompra.SelectedRows)
                {
                    string nomeInsumo = row.Cells[0].Value.ToString();
                    PedidoCompraItem item = compraItems.FirstOrDefault(i => insumos.First(insumo => insumo.Id == i.IdInsumo).Nome == nomeInsumo);

                    if (item != null)
                    {
                        compraItems.Remove(item);
                    }
                }
                AtualizarValorTotalDataGrid();
            }

            if (compraItems.Count == 0)
            {
                ComboBoxFornecedor.Enabled = true;
            }
        }

        private void PictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (DataGridItensPedidoCompra.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DataGridItensPedidoCompra.SelectedRows[0];
                string nomeInsumo = row.Cells[0].Value.ToString();
                PedidoCompraItem item = compraItems.FirstOrDefault(i => insumos.First(insumo => insumo.Id == i.IdInsumo).Nome == nomeInsumo);

                if (item != null)
                {
                    ComboBoxProduto.SelectedItem = nomeInsumo;
                    TextBoxQuantidade.Text = item.Qtd.ToString();
                    TextBoxValorUnitario.Text = item.Valor.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
                    TextBoxUnidade.Text = item.UnidQtd;

                    compraItems.Remove(item);
                    AtualizarValorTotalDataGrid();
                }
            }
        }

        private void DataGridItensPedidoCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifique se a coluna "ValorTotal" está sendo formatada
            if (e.ColumnIndex == DataGridItensPedidoCompra.Columns["ValorTotal"].Index)
            {
                DataGridViewRow row = DataGridItensPedidoCompra.Rows[e.RowIndex];

                // Obtém os valores de "Quantidade" e "Valor Unitário"
                int quantidade = (int)row.Cells[DataGridItensPedidoCompra.Columns["Quantidade"].Index].Value;
                decimal valorUnitario = (decimal)row.Cells[DataGridItensPedidoCompra.Columns["ValorUnitario"].Index].Value;

                // Calcula o valor total
                e.Value = (quantidade * valorUnitario).ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            }

            // Verifique se a coluna "ValorUnitario" está sendo formatada
            if (e.ColumnIndex == DataGridItensPedidoCompra.Columns["ValorUnitario"].Index)
            {
                decimal valorUnitario = (decimal)e.Value;
                e.Value = valorUnitario.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            }
        }

        private void AtualizarValorTotalDataGrid()
        {
            foreach (DataGridViewRow row in DataGridItensPedidoCompra.Rows)
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

using PIMFazendaUrbanaLib;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaInsumo : Form
    {
        InsumoService insumoService;

        public TelaInsumo()
        {
            InitializeComponent();

            insumoService = new InsumoService();

            this.Load += new EventHandler(PictureBoxAtualizar_Click);

            // Configurar o DataGridView para estoque de insumos
            DataGridViewListaInsumos.AutoGenerateColumns = false;

            DataGridViewListaInsumos.Columns.Add("IDColumn", "ID");
            DataGridViewListaInsumos.Columns.Add("NomeColumn", "Nome");
            DataGridViewListaInsumos.Columns.Add("CategoriaColumn", "Categoria");
            DataGridViewListaInsumos.Columns.Add("QtdColumn", "Quantidade");
            DataGridViewListaInsumos.Columns.Add("UnidQtdColumn", "Unidade");

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

            // Definindo o tamanho padrão das colunas
            DataGridViewListaInsumos.Columns["IDColumn"].Width = 40;
            DataGridViewListaInsumos.Columns["NomeColumn"].Width = 200;
            DataGridViewListaInsumos.Columns["CategoriaColumn"].Width = 100;
            DataGridViewListaInsumos.Columns["QtdColumn"].Width = 95;
            DataGridViewListaInsumos.Columns["UnidQtdColumn"].Width = 75;

            DataGridViewListaInsumos.Columns["NomeColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //----------------------------------------------------------------------------------------
            // Configurar o DataGridView para registro de saída de insumos
            DataGridViewSaidaInsumos.AutoGenerateColumns = false;

            DataGridViewSaidaInsumos.Columns.Add("IDColumn", "ID");
            DataGridViewSaidaInsumos.Columns.Add("NomeColumn", "Nome");
            DataGridViewSaidaInsumos.Columns.Add("CategoriaColumn", "Categoria");
            DataGridViewSaidaInsumos.Columns.Add("QtdColumn", "Quantidade");
            DataGridViewSaidaInsumos.Columns.Add("UnidQtdColumn", "Unidade");
            DataGridViewSaidaInsumos.Columns.Add("DataColumn", "Data");

            DataGridViewSaidaInsumos.Columns["IDColumn"].DataPropertyName = "IdInsumo";
            DataGridViewSaidaInsumos.Columns["NomeColumn"].DataPropertyName = "NomeInsumo";
            DataGridViewSaidaInsumos.Columns["CategoriaColumn"].DataPropertyName = "CategoriaInsumo";
            DataGridViewSaidaInsumos.Columns["QtdColumn"].DataPropertyName = "Qtd";
            DataGridViewSaidaInsumos.Columns["UnidQtdColumn"].DataPropertyName = "Unidqtd";
            DataGridViewSaidaInsumos.Columns["DataColumn"].DataPropertyName = "Data";

            /*
            foreach (DataGridViewColumn column in DataGridViewSaidaInsumos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            */

            // Definindo o tamanho padrão das colunas
            DataGridViewSaidaInsumos.Columns["IDColumn"].Width = 40;
            DataGridViewSaidaInsumos.Columns["NomeColumn"].Width = 200;
            DataGridViewSaidaInsumos.Columns["CategoriaColumn"].Width = 100;
            DataGridViewSaidaInsumos.Columns["QtdColumn"].Width = 95;
            DataGridViewSaidaInsumos.Columns["UnidQtdColumn"].Width = 75;
            DataGridViewSaidaInsumos.Columns["DataColumn"].Width = 130;

            DataGridViewSaidaInsumos.Columns["NomeColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                    MessageBox.Show("Nenhum insumo encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarSaidaInsumos()
        {
            try
            {
                DataGridViewSaidaInsumos.DataSource = null; // Limpa a DataSource do DataGridView

                List<SaidaInsumo> saidainsumos = insumoService.ListarSaidaInsumos();

                if (saidainsumos != null && saidainsumos.Count > 0)
                {
                    // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                    var data = saidainsumos.Select(si => new
                    {
                        si.IdInsumo,
                        si.NomeInsumo,
                        si.CategoriaInsumo,
                        si.Qtd,
                        si.Unidqtd,
                        //Data = si.Data.ToShortDateString(), // Para exibir só a data
                        si.Data, // Para exibir a data e a hora
                    }).ToList();

                    DataGridViewSaidaInsumos.DataSource = data; // Preencher o DataGridView com os dados formatados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastrarSaidaInsumo_SaidaInsumoCadastradoSucesso(object sender, EventArgs e)
        {
            CarregarSaidaInsumos();
            CarregarInsumos();
        }

        private void TelaCadastrarInsumo_InsumoCadastradoSucesso(object sender, EventArgs e)
        {
            CarregarInsumos();
        }

        private void TelaEditarInsumo_InsumoEditadoSucesso(object sender, EventArgs e)
        {
            CarregarInsumos();
        }

        private void PictureBoxAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarInsumos();
                CarregarSaidaInsumos();
                //MessageBox.Show("Listas de insumos e registros de saída atualizadas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Erro ao atualizar a lista de insumos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastrarInsumo telaCadastrarInsumo = new TelaCadastrarInsumo();
            telaCadastrarInsumo.InsumoCadastradoSucesso += TelaCadastrarInsumo_InsumoCadastradoSucesso;
            telaCadastrarInsumo.Show();
        }

        private void PictureBoxCadastrarSaida_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaInsumos.SelectedRows.Count == 1) // Verifica se alguma linha está selecionada no DataGridView
            {
                int selectedIndex = DataGridViewListaInsumos.SelectedRows[0].Index; // Obter o índice da linha selecionada
                int insumoID = (int)DataGridViewListaInsumos.Rows[selectedIndex].Cells["IDColumn"].Value; // Obter o ID do insumo selecionado

                TelaCadastrarSaidaInsumo telaCadastrarSaidaInsumo = new TelaCadastrarSaidaInsumo(insumoID); // Criar uma instância do form de cadastrar saída
                telaCadastrarSaidaInsumo.Show(); // Exibir o form cadastrar saída
                telaCadastrarSaidaInsumo.SaidaInsumoCadastradoSucesso += TelaCadastrarSaidaInsumo_SaidaInsumoCadastradoSucesso; // Evento para atualizar
            }
            else if (DataGridViewListaInsumos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um insumo da tabela da esquerda para dar saída (botão '>' à esquerda do ID do insumo).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, selecione apenas um insumo para dar saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaInsumos.SelectedRows.Count == 1)
            {
                int selectedIndex = DataGridViewListaInsumos.SelectedRows[0].Index;
                int insumoID = (int)DataGridViewListaInsumos.Rows[selectedIndex].Cells["IDColumn"].Value;
                TelaEditarInsumo telaEditarInsumo = new TelaEditarInsumo(insumoID);
                telaEditarInsumo.InsumoEditadoSucesso += TelaEditarInsumo_InsumoEditadoSucesso;
                telaEditarInsumo.Show();
            }
            else if (DataGridViewListaInsumos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um insumo para editar (botão '>' à esquerda do ID do insumo).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, selecione apenas um insumo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxDeletar_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaInsumos.SelectedRows.Count > 0) // Verificar se alguma linha está selecionada no DataGridView
            {
                int selectedIndex = DataGridViewListaInsumos.SelectedRows[0].Index; // Obter o índice da linha selecionada
                int insumoID = (int)DataGridViewListaInsumos.Rows[selectedIndex].Cells["IDColumn"].Value; // Obter o ID do insumo selecionado

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este insumo?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        insumoService.DesativarInsumo(insumoID);
                        MessageBox.Show("Insumo excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarInsumos(); // Atualizar o DataGridView após a exclusão
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um insumo para excluir (botão '>' à esquerda do ID do insumo).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            string insumoNome = TextBoxPesquisar.Text;
            List<Insumo> insumos = insumoService.FiltrarInsumosNome(insumoNome);

            if (insumos != null && insumos.Count > 0) // Verificar se a lista de insumos não está vazia
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
        }

        private void TextBoxPesquisarSaidaInsumo_TextChanged(object sender, EventArgs e)
        {
            string insumoNome = TextBoxPesquisarSaidaInsumo.Text;
            List<SaidaInsumo> saidainsumos = insumoService.FiltrarSaidaInsumosNome(insumoNome);

            if (saidainsumos != null && saidainsumos.Count > 0)
            {
                // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                var data = saidainsumos.Select(si => new
                {
                    si.IdInsumo,
                    si.NomeInsumo,
                    si.CategoriaInsumo,
                    si.Qtd,
                    si.Unidqtd,
                    //Data = si.Data.ToShortDateString(), // Para exibir só a data
                    si.Data, // Para exibir a data e a hora
                }).ToList();

                DataGridViewSaidaInsumos.DataSource = data; // Preencher o DataGridView com os dados formatados
            }
            else
            {
                DataGridViewSaidaInsumos.DataSource = null;
            }
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
            saveFileDialog.Title = "Salvar Relatório de Saída de Insumos";
            saveFileDialog.FileName = "Saída_de_insumos_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(DataGridViewListaInsumos, saveFileDialog.FileName);
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

        private void TextBoxPesquisarSaidaInsumo_Click(object sender, EventArgs e)
        {
            TextBoxPesquisarSaidaInsumo.Clear();
            MaskedTextBoxPeriodo1.Clear();
            MaskedTextBoxPeriodo2.Clear();
        }

        private void PictureBoxPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string insumoNome = TextBoxPesquisarSaidaInsumo.Text;

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

                    List<SaidaInsumo> saidainsumos = insumoService.FiltrarSaidaInsumosPorNomeEPeriodo(insumoNome, dataInicio, dataFim);

                    if (saidainsumos != null && saidainsumos.Count > 0)
                    {
                        // Criar uma lista temporária de objetos anônimos para armazenar os dados formatados
                        var data = saidainsumos.Select(si => new
                        {
                            si.IdInsumo,
                            si.NomeInsumo,
                            si.CategoriaInsumo,
                            si.Qtd,
                            si.Unidqtd,
                            //Data = si.Data.ToShortDateString(), // Para exibir só a data
                            si.Data, // Para exibir a data e a hora
                        }).ToList();

                        DataGridViewSaidaInsumos.DataSource = data; // Preencher o DataGridView com os dados formatados
                    }
                    else
                    {
                        DataGridViewSaidaInsumos.DataSource = null;
                        MessageBox.Show("Nenhum registro de saída encontrado no período especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}

using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarProducao : Form
    {
        private Cultivo cultivo;
        private CultivoService cultivoService;
        public event EventHandler ProducaoCadastradaSucesso;
        private Producao producao;
        private ProducaoService producaoService;

        public TelaCadastrarProducao(int cultivoID)
        {
            InitializeComponent();
            cultivoService = new CultivoService();
            producaoService = new ProducaoService();
            producao = new Producao();
            cultivo = cultivoService.ConsultarCultivoID(cultivoID);
            if (cultivo != null)
            {
                PreencherCampos(cultivo);
            }
            else
            {
                MessageBox.Show("Erro ao carregar dados do cultivo. Se o erro persistir, entre em contato com o administrador do banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            // Adicionando as unidades de medida na ComboBox
            ComboBoxUnidade.Items.AddRange(new string[] {
                "kg", "g", "unidade"
            });
        }

        private void PreencherCampos(Cultivo cultivo)
        {
            TextBoxNome.Text = cultivo.Nome;
            TextBoxVariedade.Text = cultivo.Variedade;
            TextBoxCategoria.Text = cultivo.Categoria;
            MaskedTextBoxTempoProducao.Text = cultivo.TempoProdTradicional.ToString();
            TextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            AtualizarTempodeProducao();
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            string unidade = ComboBoxUnidade.SelectedItem?.ToString();
            int quantidade = Convert.ToInt32(TextBoxQuantidade.Text);
            bool unidadeValida = false;
            bool quantidadeValida = false;

            // Lista de unidades permitidas
            List<string> unidadesPermitidas = new List<string>
            {
                "kg", "g", "unidade"
            };

            // Verifica se a unidade está na lista de permitidas
            if (unidade == null || !unidadesPermitidas.Contains(unidade))
            {
                ComboBoxUnidade.ForeColor = Color.Red;
                MessageBox.Show("Por favor, selecione uma unidade válida.", "Unidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ComboBoxUnidade;
                unidadeValida = false;
            }
            else
            {
                ComboBoxUnidade.ForeColor = Color.Black;
                unidadeValida = true;
            }

            // Verifica se a quantidade é válida
            if (quantidade <= 0)
            {
                TextBoxQuantidade.ForeColor = Color.Red;
                MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxQuantidade;
                quantidadeValida = false;
            }
            else
            {
                TextBoxQuantidade.ForeColor = Color.Black;
                quantidadeValida = true;
            }

            // Se todas as validações passarem, pode prosseguir com a ação do botão Confirmar
            if (unidadeValida == true && quantidadeValida == true)
            {
                producao.IdCultivo = cultivo.ID;
                producao.Nome = cultivo.Nome;
                producao.Categoria = cultivo.Categoria;
                producao.Variedade = cultivo.Variedade;
                producao.Qtd = quantidade;
                producao.Unidqtd = unidade;

                producao.Data = DateTime.Now;
                producao.AmbienteControlado = checkBox1.Checked;
                producao.DataColheita = producao.CalcularDataHoraColheita(producao);
                producao.StatusFinalizado = false;

                try
                {
                    producaoService.CadastrarProducao(producao);
                    ProducaoCadastradaSucesso?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTempodeProducao();
        }

        private void AtualizarTempodeProducao()
        {
            producao.TempoProdTradicional = Convert.ToInt32(cultivo.TempoProdTradicional);
            producao.TempoProdControlado = Convert.ToInt32(cultivo.TempoProdControlado);

            if (checkBox1.Checked)
            {
                producao.AmbienteControlado = true;
                MaskedTextBoxTempoProducao.Text = cultivo.TempoProdControlado.ToString();
            }
            else
            {
                producao.AmbienteControlado = false;
                MaskedTextBoxTempoProducao.Text = cultivo.TempoProdTradicional.ToString();
            }
            TextBoxDataColheita.Text = producao.CalcularDataColheita(producao);
        }
    }
}



using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaEditarInsumo : Form
    {
        Insumo insumo = new Insumo();
        Insumo insumo1 = new Insumo();

        public event EventHandler InsumoEditadoSucesso;

        InsumoService insumoService; // Declaração de uma instância de InsumoService

        public TelaEditarInsumo(int insumoID)
        {
            InitializeComponent();

            // Adicionando as unidades de medida na ComboBox
            ComboBoxUnidade.Items.AddRange(new string[] {
                "kg", "g", "l", "ml", "m", "cm", "mm", "unidade", "caixa", "tambor"
            });

            insumoService = new InsumoService(); // Cria uma instância de InsumoService

            insumo = insumoService.ConsultarInsumoPorID(insumoID); // Chamando o método ConsultarInsumoID da instância insumoService

            if (insumo != null)
            {
                PreencherCampos(insumo);
            }
            else
            {
                MessageBox.Show("Erro ao carregar dados do insumo. Se o erro persistir, entre em contato com o administrador do banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PreencherCampos(Insumo insumo)
        {
            TextBoxNome.Text = insumo.Nome;
            ComboBoxCategoria.SelectedItem = insumo.Categoria;
            ComboBoxUnidade.SelectedItem = insumo.Unidqtd;
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            string categoria = ComboBoxCategoria.SelectedItem?.ToString();
            string unidade = ComboBoxUnidade.SelectedItem?.ToString();
            bool nomeValido = true;
            bool categoriaValida = true;
            bool unidadeValida = true;

            // Verifica se o nome tem pelo menos 3 caracteres alfabéticos
            if (nome.Length < 3)
            {
                TextBoxNome.ForeColor = Color.Red;
                MessageBox.Show("O nome do insumo deve conter pelo menos 3 caracteres.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxNome;
                nomeValido = false;
            }
            else
            {
                TextBoxNome.ForeColor = Color.Black;
                nomeValido = true;
            }

            // Verifica se a categoria é "Sementes" ou "Fertilizantes"
            List<string> categoriasPermitidas = new List<string> { "Sementes", "Fertilizantes" };

            if (categoria == null || !categoriasPermitidas.Contains(categoria))
            {
                MessageBox.Show("Por favor, selecione uma categoria válida (Sementes ou Fertilizantes).", "Categoria Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ComboBoxCategoria;
                categoriaValida = false;
            }
            else
            {
                ComboBoxCategoria.ForeColor = Color.Black;
                categoriaValida = true;
            }

            // Lista de unidades permitidas
            List<string> unidadesPermitidas = new List<string>
            {
                "kg", "g", "l", "ml", "m", "cm", "mm", "unidade", "caixa", "tambor"
            };

            // Verifica se a unidade está na lista de permitidas
            if (unidade == null || !unidadesPermitidas.Contains(unidade))
            {
                MessageBox.Show("Por favor, selecione uma unidade válida.", "Unidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ComboBoxUnidade;
                unidadeValida = false;
            }
            else
            {
                ComboBoxUnidade.ForeColor = Color.Black;
                unidadeValida = true;
            }

            // Se todas as validações passarem, pode prosseguir com a ação do botão Confirmar
            if (nomeValido == true && categoriaValida == true && unidadeValida == true)
            {
                insumo1.Id = insumo.Id;
                insumo1.Nome = nome;
                insumo1.Categoria = categoria;
                insumo1.Qtd = insumo.Qtd;
                insumo1.Unidqtd = unidade;
                insumo1.Ativo = insumo.Ativo;

                try
                {
                    insumoService.AlterarInsumo(insumo1);
                    MessageBox.Show("Insumo alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsumoEditadoSucesso?.Invoke(this, EventArgs.Empty); // Disparar o evento
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

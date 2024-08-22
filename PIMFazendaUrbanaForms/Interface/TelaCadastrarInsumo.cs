using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarInsumo : Form
    {
        public event EventHandler InsumoCadastradoSucesso;

        public TelaCadastrarInsumo()
        {
            InitializeComponent();
            // Adicionando as unidades de medida na ComboBox
            ComboBoxUnidade.Items.AddRange(new string[] {
                "kg", "g", "l", "ml", "m", "cm", "mm", "unidade", "caixa", "tambor"
            });       
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            string categoria = ComboBoxCategoria.SelectedItem?.ToString();
            string unidade = ComboBoxUnidade.SelectedItem?.ToString();
            bool nomeValido = false;
            bool categoriaValida = false;
            bool unidadeValida = false;

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
                ComboBoxCategoria.ForeColor = Color.Red;
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

            // Se todas as validações passarem, pode prosseguir com a ação do botão Confirmar
            if (nomeValido == true && categoriaValida == true && unidadeValida == true)
            {
                InsumoService insumoService = new InsumoService();
                Insumo insumo = new Insumo();
                insumo.Nome = nome;
                insumo.Categoria = categoria;
                insumo.Qtd = 0;
                insumo.Unidqtd = unidade;
                insumo.Ativo = true;

                try
                {
                    insumoService.CadastrarInsumo(insumo);
                    MessageBox.Show("Insumo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsumoCadastradoSucesso?.Invoke(this, EventArgs.Empty); // Disparar o evento
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



    }
}

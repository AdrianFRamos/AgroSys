using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaEditarCultivo : Form
    {
        private Cultivo cultivo;
        private CultivoService cultivoService;
        public event EventHandler CultivoEditadoSucesso;

        public TelaEditarCultivo(int cultivoID)
        {
            InitializeComponent();
            cultivoService = new CultivoService();

            PreencherComboBoxCategorias();

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
        }

        private void PreencherCampos(Cultivo cultivo)
        {
            TextBoxNome.Text = cultivo.Nome;
            TextBoxVariedade.Text = cultivo.Variedade;
            ComboBoxCategoria.SelectedItem = cultivo.Categoria;
            MaskedTextBoxTempoTradicional.Text = cultivo.TempoProdTradicional.ToString();
            MaskedTextBoxTempoControlado.Text = cultivo.TempoProdControlado.ToString();
        }

        private void PreencherComboBoxCategorias()
        {
            List<string> categorias = cultivoService.ListarCategorias();
            ComboBoxCategoria.Items.Clear();
            ComboBoxCategoria.Items.AddRange(categorias.ToArray());
        }
        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            string variedade = TextBoxVariedade.Text;
            string categoria = ComboBoxCategoria.SelectedItem?.ToString();
            string tempoTradicional = MaskedTextBoxTempoTradicional.Text;
            string tempoControlado = MaskedTextBoxTempoControlado.Text;
            bool nomeValido = true;
            bool variedadeValida = true;
            bool categoriaValida = true;
            bool tempoTradicionalValido = true;
            bool tempoControladoValido = true;

            // Verifica se o nome tem pelo menos 3 caracteres alfabéticos
            if (nome.Length < 3)
            {
                TextBoxNome.ForeColor = Color.Red;
                MessageBox.Show("O nome do produto deve conter pelo menos 3 caracteres.");
                this.ActiveControl = TextBoxNome;
                nomeValido = false;
            }
            else
            {
                TextBoxNome.ForeColor = Color.Black;
                nomeValido = true;
            }

            // Verifica se a variedade tem pelo menos 3 caracteres alfabéticos
            if (variedade.Length < 3)
            {
                MessageBox.Show("A variedade deve conter pelo menos 3 caracteres.");
                this.ActiveControl = TextBoxVariedade;
                variedadeValida = false;
            }
            else
            {
                TextBoxVariedade.ForeColor = Color.Black;
                variedadeValida = true;
            }

            // Lista de categorias permitidas
            List<string> categoriasPermitidas = new List<string>
            {
                "Verdura",
                "Legume",
                "Fruta",
                "Outro"
            };

            // Verifica se a categoria está na lista de permitidas
            if (categoria == null || !categoriasPermitidas.Contains(categoria))
            {
                ComboBoxCategoria.ForeColor = Color.Red;
                MessageBox.Show("Por favor, selecione uma categoria válida.");
                this.ActiveControl = ComboBoxCategoria;
                categoriaValida = false;
            }
            else
            {
                ComboBoxCategoria.ForeColor = Color.Black;
                categoriaValida = true;
            }

            // Verifica se os campos de tempo estão preenchidos corretamente
            if (string.IsNullOrWhiteSpace(tempoTradicional) || !int.TryParse(tempoTradicional, out _))
            {
                MaskedTextBoxTempoTradicional.ForeColor = Color.Red;
                MessageBox.Show("Por favor, insira um valor válido para o tempo tradicional (número inteiro).");
                this.ActiveControl = MaskedTextBoxTempoTradicional;
                tempoTradicionalValido = false;
            }
            else
            {
                MaskedTextBoxTempoTradicional.ForeColor = Color.Black;
                tempoTradicionalValido = true;
            }

            if (string.IsNullOrWhiteSpace(tempoControlado) || !int.TryParse(tempoControlado, out _))
            {
                MaskedTextBoxTempoControlado.ForeColor = Color.Red;
                MessageBox.Show("Por favor, insira um valor válido para o tempo controlado (número inteiro).");
                this.ActiveControl = MaskedTextBoxTempoControlado;
                tempoControladoValido = false;
            }
            else
            {
                MaskedTextBoxTempoControlado.ForeColor = Color.Black;
                tempoControladoValido = true;
            }

            if (nomeValido == true && variedadeValida == true && categoriaValida == true && tempoTradicionalValido == true && tempoControladoValido == true)
            {

                cultivo.Nome = nome;
                cultivo.Variedade = variedade;
                cultivo.Categoria = categoria;
                cultivo.TempoProdTradicional = int.Parse(tempoTradicional);
                cultivo.TempoProdControlado = int.Parse(tempoControlado);

                try
                {
                    cultivoService.AlterarCultivo(cultivo);
                    MessageBox.Show("Cultivo alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CultivoEditadoSucesso?.Invoke(this, EventArgs.Empty); // Disparar o evento
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

    }
}



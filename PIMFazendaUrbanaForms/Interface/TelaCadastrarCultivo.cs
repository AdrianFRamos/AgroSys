using System.Text.RegularExpressions;
using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarCultivo : Form
    {
        private CultivoService cultivoService;
        public event EventHandler CultivoCadastradoSucesso;

        public TelaCadastrarCultivo()
        {
            InitializeComponent();
            cultivoService = new CultivoService();
        }

        private void TextBoxTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas dígitos e a tecla de controle de backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, insira apenas números inteiros.");
            }
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            string variedade = TextBoxVariedade.Text;
            string categoria = ComboBoxCategoria.SelectedItem?.ToString();
            string tempoTradicional = MaskedTextBoxTempoTradicional.Text;
            string tempoControlado = MaskedTextBoxTempoControlado.Text;
            bool nomeValido = false;
            bool variedadeValida = false;
            bool categoriaValida = false;
            bool tempoTradicionalValido = false;
            bool tempoControladoValido = false;

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
                // Se todas as validações passarem, pode prosseguir com a ação do botão Confirmar
                Cultivo cultivo = new Cultivo
                {
                    Nome = nome,
                    Variedade = variedade,
                    Categoria = categoria,
                    TempoProdTradicional = int.Parse(tempoTradicional),
                    TempoProdControlado = int.Parse(tempoControlado),
                    StatusAtivo = true  // Supondo que um cultivo recém-cadastrado é ativo por padrão
                };

                try
                {
                    cultivoService.CadastrarCultivo(cultivo);
                    MessageBox.Show("Cultivo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CultivoCadastradoSucesso?.Invoke(this, EventArgs.Empty); // Disparar o evento
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

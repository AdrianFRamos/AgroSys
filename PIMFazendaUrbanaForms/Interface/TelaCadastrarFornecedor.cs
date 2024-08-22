using System.ComponentModel;
using System.Text.RegularExpressions;
using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarFornecedor : Form
    {
        Fornecedor fornecedor1 = new Fornecedor();

        bool nomevalido = false;
        bool cnpjvalido = false;
        bool emailvalido = false;

        bool dddvalido = false;
        bool telefonevalido = false;

        bool logradourovalido = false;
        bool numerocasavalido = false;
        bool bairrovalido = false;
        bool cidadevalida = false;
        bool ufvalido = false;
        bool cepvalido = false;

        FornecedorService fornecedorService; // Declaração de uma instância de FornecedorService

        public TelaCadastrarFornecedor()
        {
            InitializeComponent();
            fornecedorService = new FornecedorService(); // Cria uma instância de FornecedorService
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            // Alguns nomes de Strings fora trocados para evitar conflito com string "text" 

            string Nome = TextBoxNome.Text; // Confirmar Nome
            if (Nome.Length < 3)
            {
                // Define a cor de texto para vermelho
                TextBoxNome.ForeColor = Color.Red;

                // Exibe a mensagem de erro
                MessageBox.Show("Preencha o campo Nome corretamente. O nome deve ter ao menos 3 caracteres", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                nomevalido = false;
                this.ActiveControl = TextBoxNome; // Define o foco para o TextBoxNome
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxNome.ForeColor = Color.Black;
                nomevalido = true;
            }


            string Email = TextBoxEmail.Text; // Confirmar Email
            if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                // Define a cor de texto para vermelho
                TextBoxEmail.ForeColor = Color.Red;

                // Exibe a mensagem de erro
                MessageBox.Show("Preencha o campo E-mail corretamente.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                emailvalido = false;
                this.ActiveControl = TextBoxEmail; // Define o foco para o TextBoxEmail
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxEmail.ForeColor = Color.Black;
                emailvalido = true;
            }


            // Remove todos os caracteres não numéricos do texto    -   Valida CNPJ
            string cnpjDigitsOnly = TextBoxCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            // Verifica se o CNPJ tem exatamente 14 dígitos
            if (cnpjDigitsOnly.Length != 14 || !cnpjDigitsOnly.All(char.IsDigit))
            {
                // Define a cor de texto para vermelho
                TextBoxCNPJ.ForeColor = Color.Red;

                // Exibe a mensagem de erro
                MessageBox.Show("Preencha o campo CNPJ corretamente. O CNPJ deve conter 14 números.", "CNPJ Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cnpjvalido = false;
                this.ActiveControl = TextBoxCNPJ; // Define o foco para o TextBoxCNPJ
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxCNPJ.ForeColor = Color.Black;

                cnpjvalido = true;
            }


            string text = TextBoxDDD.Text; // Valida DDD
            if (!Regex.IsMatch(text, @"^\d{2}$"))
            {
                // Define a cor de texto para vermelho
                TextBoxDDD.ForeColor = Color.Red;

                MessageBox.Show("O DDD deve conter exatamente 2 caracteres numéricos.", "DDD Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dddvalido = false;
                this.ActiveControl = TextBoxDDD;
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxDDD.ForeColor = Color.Black;
                dddvalido = true;
            }


            string textTelefone = TextBoxTelefone.Text; // Valida Telefone. Troquei o nome para evitar conflito com string "text"
            if (!Regex.IsMatch(textTelefone, @"^\d{8,9}$"))
            {
                // Define a cor de texto para vermelho
                TextBoxTelefone.ForeColor = Color.Red;

                MessageBox.Show("O número de telefone deve conter 8 ou 9 caracteres numéricos.", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telefonevalido = false;
                this.ActiveControl = TextBoxTelefone;
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxTelefone.ForeColor = Color.Black;
                telefonevalido = true;
            }


            string textLogradouro = TextBoxLogradouro.Text; // Valida Logradouro. Troquei o nome para evitar conflito com string "text"
            if (textLogradouro.Length < 3)
            {
                // Define a cor de texto para vermelho
                TextBoxLogradouro.ForeColor = Color.Red;

                MessageBox.Show("O logradouro deve conter ao menos 3 caracteres.", "Logradouro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logradourovalido = false;
                this.ActiveControl = TextBoxLogradouro; // Define o foco para o TextBoxLogradouro
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxLogradouro.ForeColor = Color.Black;
                logradourovalido = true;
            }


            string textNumero = TextBoxNumero.Text; // Valida Numero do local. Troquei o nome para evitar conflito com string "text"
            if (!Regex.IsMatch(textNumero, @"^\d+$"))
            {
                // Define a cor de texto para vermelho
                TextBoxNumero.ForeColor = Color.Red;

                MessageBox.Show("O número deve conter apenas caracteres numéricos.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numerocasavalido = false;
                this.ActiveControl = TextBoxNumero; // Define o foco para o TextBoxNumero
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxNumero.ForeColor = Color.Black;
                numerocasavalido = true;
            }


            string textBairro = TextBoxBairro.Text; // Valida Bairro. Troquei o nome para evitar conflito com string "text"
            if (textBairro.Length < 3)
            {
                // Define a cor de texto para vermelho
                TextBoxBairro.ForeColor = Color.Red;

                MessageBox.Show("O bairro deve conter ao menos 3 caracteres.", "Bairro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bairrovalido = false;
                this.ActiveControl = TextBoxBairro; // Define o foco para o TextBoxBairro
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxBairro.ForeColor = Color.Black;
                bairrovalido = true;
            }


            string textCidade = TextBoxCidade.Text; // Valida Cidade. Troquei o nome para evitar conflito com string "text"
            if (textCidade.Length < 3)
            {
                // Define a cor de texto para vermelho
                TextBoxCidade.ForeColor = Color.Red;

                MessageBox.Show("A cidade deve conter ao menos 3 caracteres.", "Cidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cidadevalida = false;
                this.ActiveControl = TextBoxCidade; // Define o foco para o TextBoxCidade
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxCidade.ForeColor = Color.Black;
                cidadevalida = true;
            }

                                                    // Valida UF. Troquei o nome para evitar conflito com string "text"
            string textUf = ComboBoxUF.Text.Trim(); // Remover espaços em branco extras
            if (!Regex.IsMatch(textUf, @"^(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)$"))
            {
                // Define a cor de texto para vermelho
                ComboBoxUF.ForeColor = Color.Red;

                MessageBox.Show("Selecione uma UF válida.", "UF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ufvalido = false;
                this.ActiveControl = ComboBoxUF; // Define o foco para o ComboBoxUF
            }
            else
            {
                // Define a cor de texto para preto
                ComboBoxUF.ForeColor = Color.Black;
                ufvalido = true;
            }


            // Remove todos os caracteres não numéricos do texto
            string cepDigitsOnly = TextBoxCEP.Text.Replace("-", ""); // Valida CEP. Troquei o nome para evitar conflito com string "text"

            // Verifica se o CEP tem exatamente 8 dígitos
            if (cepDigitsOnly.Length != 8 || !cepDigitsOnly.All(char.IsDigit))
            {
                // Define a cor de texto para vermelho
                TextBoxCEP.ForeColor = Color.Red;

                // Exibe a mensagem de erro
                MessageBox.Show("Preencha o campo CEP corretamente. O CEP deve conter 8 números.", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cepvalido = false;
                this.ActiveControl = TextBoxCEP; // Define o foco para o TextBoxCEP
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxCEP.ForeColor = Color.Black;
                cepvalido = true;
            }


            //-------------------------------------------------------------------------------------//


            if (!nomevalido || !cnpjvalido || !emailvalido || !dddvalido || !telefonevalido || !logradourovalido ||
                !numerocasavalido || !bairrovalido || !cidadevalida || !ufvalido || !cepvalido)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fornecedor1.Nome = TextBoxNome.Text;
            fornecedor1.CNPJ = TextBoxCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""); ; // Marcelo falou para no banco guardar como varchar, mas antes tirar os pontos, barras e traços
            fornecedor1.Email = TextBoxEmail.Text;
            fornecedor1.StatusAtivo = true;

            fornecedor1.Endereco = new EnderecoFornecedor();
            fornecedor1.Endereco.Logradouro = TextBoxLogradouro.Text;
            fornecedor1.Endereco.Numero = TextBoxNumero.Text;
            fornecedor1.Endereco.Complemento = TextBoxComplemento.Text;
            fornecedor1.Endereco.Bairro = TextBoxBairro.Text;
            fornecedor1.Endereco.Cidade = TextBoxCidade.Text;
            fornecedor1.Endereco.UF = ComboBoxUF.Text;
            fornecedor1.Endereco.CEP = TextBoxCEP.Text.Replace("-", ""); // Marcelo falou para no banco guardar como varchar, mas antes tirar os traços
            fornecedor1.Endereco.StatusAtivo = true;

            fornecedor1.Telefone = new TelefoneFornecedor();
            fornecedor1.Telefone.DDD = TextBoxDDD.Text;
            fornecedor1.Telefone.Numero = TextBoxTelefone.Text;
            fornecedor1.Telefone.StatusAtivo = true;

            try
            {
                fornecedorService.CadastrarFornecedor(fornecedor1);
                MessageBox.Show("Fornecedor cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FornecedorCadastradoSucesso?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Definir um evento para notificar o cadastro bem-sucedido do fornecedor
        public event EventHandler FornecedorCadastradoSucesso;

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Os códigos de todos os "Validating" foram colocados em "BotaoConfirmar_Click" acima para evitar "travar o usuário"
        private void TextBoxNome_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxEmail_Validating(object sender, EventArgs e)
        {
            
        }
        private void TextBoxCNPJ_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxDDD_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxTelefone_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxLogradouro_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxBairro_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxCidade_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void ComboBoxUF_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxCEP_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um dígito
            if (char.IsDigit(e.KeyChar))
            {
                // Obtém o texto atual do TextBox
                string text = TextBoxTelefone.Text;

                // Se o comprimento do texto atual for 9, impede a inserção de mais dígitos
                if (text.Length >= 9)
                {
                    e.Handled = true;
                    MessageBox.Show("O número de telefone deve conter no máximo 9 dígitos.", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}

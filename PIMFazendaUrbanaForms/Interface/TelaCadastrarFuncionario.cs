using System.ComponentModel;
using System.Text.RegularExpressions;
using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarFuncionario : Form
    {
        Funcionario funcionario1 = new Funcionario();

        bool nomevalido = false;
        bool emailvalido = false;
        bool cpfvalido = false;
        bool usuariovalido = false;
        bool senhavalida = false;
        bool cargovalido = false;
        bool sexovalido = false;

        bool dddvalido = false;
        bool telefonevalido = false;

        bool logradourovalido = false;
        bool numerocasavalido = false;
        bool bairrovalido = false;
        bool cidadevalida = false;
        bool ufvalido = false;
        bool cepvalido = false;

        FuncionarioService funcionarioService; // Declaração de uma instância de FuncionarioService

        public TelaCadastrarFuncionario()
        {
            InitializeComponent();

            funcionarioService = new FuncionarioService(); // Cria uma instância de FuncionarioService

            TextBoxSenha1.UseSystemPasswordChar = true;
            TextBoxSenha2.UseSystemPasswordChar = true;
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            // Alguns nomes de Strings fora trocados para evitar conflito com string "text"

            string Nome = TextBoxNome.Text; // Valida Nome
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


            string Email = TextBoxEmail.Text; // Valida Email
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


            string text = ComboBoxCargo.Text.Trim(); // Remover espaços em branco extras    // Valida Cargo
            if (text != "Funcionário" && text != "Gerente")
            {
                // Define a cor de texto para vermelho
                ComboBoxCargo.ForeColor = Color.Red;

                MessageBox.Show("O cargo deve ser 'Funcionário' ou 'Gerente'.", "Cargo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargovalido = false;
                this.ActiveControl = ComboBoxCargo; // Define o foco para o ComboBoxCargo
            }
            else
            {
                // Define a cor de texto para preto
                ComboBoxCargo.ForeColor = Color.Black;
                cargovalido = true;
            }


            string textSexo = ComboBoxSexo.Text.Trim(); // Remover espaços em branco extras     // Valida Sexo
            if (textSexo != "M" && textSexo != "F" && textSexo != "-")
            {
                // Define a cor de texto para vermelho
                ComboBoxSexo.ForeColor = Color.Red;

                MessageBox.Show("O sexo deve ser 'M', 'F' ou '-'.", "Sexo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sexovalido = false;
                this.ActiveControl = ComboBoxSexo; // Define o foco para o ComboBoxSexo
            }
            else
            {
                // Define a cor de texto para preto
                ComboBoxSexo.ForeColor = Color.Black;
                sexovalido = true;
            }


            string usuario = TextBoxUsuario.Text; // Valida Usuario

            if (TextBoxUsuario.Text.Length < 3)
            {
                TextBoxUsuario.ForeColor = Color.Red;

                // Exibe a mensagem de erro
                MessageBox.Show("Preencha o campo Usuário corretamente. O nome de usuário deve ter ao menos 3 caracteres", "Nome de Usuário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                usuariovalido = false;
                this.ActiveControl = TextBoxUsuario; // Define o foco para o TextBoxUsuario
            }
            else
            {
                if (VerificarUsuarioDisponivel(usuario) == true)
                {
                    TextBoxUsuario.ForeColor = Color.Black;
                    usuariovalido = true;
                }
                else
                {
                    TextBoxUsuario.ForeColor = Color.Red;
                    usuariovalido = false;
                    this.ActiveControl = TextBoxUsuario; // Define o foco para o TextBoxUsuario
                }
            }


            string textD = TextBoxDDD.Text; // Valida DDD   // Mudei nome "text" para "textD" para evitar conflito com "ComboBoxText" acima
            if (!Regex.IsMatch(textD, @"^\d{2}$"))
            {
                // Define a cor de texto para vermelho
                TextBoxDDD.ForeColor = Color.Red;

                MessageBox.Show("O DDD deve conter exatamente 2 caracteres numéricos.", "DDD Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dddvalido = false;
                this.ActiveControl = TextBoxDDD; // Define o foco para o TextBoxDDD
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxDDD.ForeColor = Color.Black;
                dddvalido = true;
            }


            string textTelefone = TextBoxTelefone.Text; // Valida Telefone
            if (!Regex.IsMatch(textTelefone, @"^\d{8,9}$"))
            {
                // Define a cor de texto para vermelho
                TextBoxTelefone.ForeColor = Color.Red;

                MessageBox.Show("O número de telefone deve conter 8 ou 9 caracteres numéricos.", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telefonevalido = false;
                this.ActiveControl = TextBoxTelefone; // Define o foco para o TextBoxTelefone
            }
            else
            {
                // Define a cor de texto para preto
                TextBoxTelefone.ForeColor = Color.Black;
                telefonevalido = true;
            }


            string textLogradouro = TextBoxLogradouro.Text; // Valida Logradouro
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


            string textNumero = TextBoxNumero.Text; // Valida Numero
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


            string textBairro = TextBoxBairro.Text; // Valida Bairro
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


            string textCidade = TextBoxCidade.Text; // Valida Cidade
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


            string textUf = ComboBoxUF.Text.Trim(); // Remover espaços em branco extras   Valida UF
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
            string cepDigitsOnly = TextBoxCEP.Text.Replace("-", ""); // Valida CEP

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


            if (TextBoxSenha1.Text == null) // Valida Senha 01
            {
                MessageBox.Show("Preencha o campo Senha", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxSenha1.ForeColor = Color.Red;
            }
            else
            {
                string senha1 = TextBoxSenha1.Text;

                // Verificar se a senha é forte o suficiente
                bool senhaforte = VerificarSenhaForte(senha1);

                if (senhaforte == false)
                {
                    senhavalida = false;
                    TextBoxSenha1.ForeColor = Color.Red;
                    TextBoxSenha2.ForeColor = Color.Red;
                    this.ActiveControl = TextBoxSenha1; // Define o foco para o TextBoxSenha1
                    return;
                }
                else
                {
                    TextBoxSenha1.ForeColor = Color.Black;
                    TextBoxSenha2.ForeColor = Color.Black;
                    this.ActiveControl = TextBoxSenha2; // Define o foco para o TextBoxSenha2
                }
            }


            if (TextBoxSenha1.Text == null) // Valida Senha 02
            {
                MessageBox.Show("Preencha o campo Senha", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxSenha1.ForeColor = Color.Red;
            }
            else
            {
                string senha1 = TextBoxSenha1.Text;
                string senha2 = TextBoxSenha2.Text;

                // Verificar se a senha é forte o suficiente
                bool senhaforte = VerificarSenhaForte(senha1);

                if (senhaforte == false)
                {
                    senhavalida = false;
                    TextBoxSenha1.ForeColor = Color.Red;
                    TextBoxSenha2.ForeColor = Color.Red;
                    this.ActiveControl = TextBoxSenha1; // Define o foco para o TextBoxSenha1
                    return;
                }
                else
                {
                    if (senha1 != senha2)
                    {
                        MessageBox.Show("As senhas são diferentes, confira e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        senhavalida = false;
                        TextBoxSenha2.ForeColor = Color.Red;
                        this.ActiveControl = TextBoxSenha2; // Define o foco para o TextBoxSenha1
                    }
                    else
                    {
                        senhavalida = true;
                        TextBoxSenha1.ForeColor = Color.Black;
                        TextBoxSenha2.ForeColor = Color.Black;
                    }
                }
            }


            // Remove todos os caracteres não numéricos do texto    Valida CPF
            string cpfDigitsOnly = MaskedTextBoxCPF.Text.Replace(".", "").Replace("-", "");

            // Verifica se o CPF tem exatamente 11 dígitos
            if (cpfDigitsOnly.Length != 11 || !cpfDigitsOnly.All(char.IsDigit))
            {
                // Define a cor de texto para vermelho
                MaskedTextBoxCPF.ForeColor = Color.Red;

                // Exibe a mensagem de erro
                MessageBox.Show("Preencha o campo CPF corretamente. O CPF deve conter 11 números.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cpfvalido = false;
                this.ActiveControl = MaskedTextBoxCPF; // Define o foco para o TextBoxCNPJ
            }
            else
            {
                // Define a cor de texto para preto
                MaskedTextBoxCPF.ForeColor = Color.Black;

                cpfvalido = true;
            }


            //-------------------------------------------------------------------------------------//


            if (nomevalido == false)
            {
                MessageBox.Show("Preencha o campo Nome corretamente. O nome deve ter ao menos 3 caracteres", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxNome; // Define o foco para o TextBoxNome
                return;
            }
            else if (emailvalido == false)
            {
                MessageBox.Show("Preencha o campo E-mail corretamente.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxEmail; // Define o foco para o TextBoxEmail
                return;
            }
            else if (cpfvalido == false)
            {
                MessageBox.Show("Preencha o campo CPF corretamente. O CPF deve ter 11 números", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = MaskedTextBoxCPF; // Define o foco para o MaskedTextBoxCPF
                return;
            }
            else if (cargovalido == false)
            {
                MessageBox.Show("Preencha o campo Cargo corretamente. O cargo deve ser 'Funcionário' ou 'Gerente'", "Cargo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ComboBoxCargo; // Define o foco para o ComboBoxCargo
                return;
            }
            else if (sexovalido == false)
            {
                MessageBox.Show("Preencha o campo Sexo corretamente. O sexo deve ser 'M', 'F' ou '-'", "Sexo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ComboBoxSexo; // Define o foco para o ComboBoxSexo
                return;
            }
            else if (usuariovalido == false)
            {
                MessageBox.Show("Preencha o campo Usuário corretamente. O usuário deve ter ao menos 3 caracteres", "Usuário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxUsuario; // Define o foco para o TextBoxUsuario
                return;
            }
            else if (senhavalida == false)
            {
                MessageBox.Show("Preencha ambos os campos de Senha corretamente. A senha deve ter ao menos 8 caracteres, uma letra maiúscula, uma letra minúscula, um número e um caracter especial", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxSenha1; // Define o foco para o TextBoxSenha1
                return;
            }
            else if (dddvalido == false)
            {
                MessageBox.Show("Preencha o campo DDD corretamente. O DDD deve ter 2 números", "DDD Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxDDD; // Define o foco para o TextBoxDDD
                return;
            }
            else if (telefonevalido == false)
            {
                MessageBox.Show("Preencha o campo Telefone corretamente. O telefone deve ter 8 ou 9 números", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxTelefone; // Define o foco para o TextBoxTelefone
                return;
            }
            else if (logradourovalido == false)
            {
                MessageBox.Show("Preencha o campo Logradouro corretamente. O logradouro deve ter ao menos 3 caracteres", "Logradouro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxLogradouro; // Define o foco para o TextBoxLogradouro
                return;
            }
            else if (numerocasavalido == false)
            {
                MessageBox.Show("Preencha o campo Número corretamente. O número deve ter apenas caracteres numéricos", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxNumero; // Define o foco para o TextBoxNumero
                return;
            }
            else if (bairrovalido == false)
            {
                MessageBox.Show("Preencha o campo Bairro corretamente. O bairro deve ter ao menos 3 caracteres", "Bairro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxBairro; // Define o foco para o TextBoxBairro
                return;
            }
            else if (cidadevalida == false)
            {
                MessageBox.Show("Preencha o campo Cidade corretamente. A cidade deve ter ao menos 3 caracteres", "Cidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxCidade; // Define o foco para o TextBoxCidade
                return;
            }
            else if (ufvalido == false)
            {
                MessageBox.Show("Preencha o campo UF corretamente. A UF deve ter 2 caracteres maiúsculos do alfabeto", "UF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ComboBoxUF; // Define o foco para o ComboBoxUF
                return;
            }
            else if (cepvalido == false)
            {
                MessageBox.Show("Preencha o campo CEP corretamente. O CEP deve ter 8 números", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxCEP; // Define o foco para o TextBoxCEP
                return;
            }
            else
            {
                funcionario1.Nome = TextBoxNome.Text;
                funcionario1.Email = TextBoxEmail.Text;
                funcionario1.CPF = MaskedTextBoxCPF.Text.Replace(".", "").Replace("/", "").Replace("-", ""); // Marcelo falou para no banco guardar como varchar, mas antes tirar os pontos, barras e traços
                funcionario1.Usuario = TextBoxUsuario.Text;
                funcionario1.Senha = TextBoxSenha1.Text;
                funcionario1.Cargo = ComboBoxCargo.Text;
                funcionario1.Sexo = ComboBoxSexo.Text;
                funcionario1.StatusAtivo = true;

                funcionario1.Endereco = new EnderecoFuncionario();
                funcionario1.Endereco.Logradouro = TextBoxLogradouro.Text;
                funcionario1.Endereco.Numero = TextBoxNumero.Text;
                funcionario1.Endereco.Complemento = TextBoxComplemento.Text;
                funcionario1.Endereco.Bairro = TextBoxBairro.Text;
                funcionario1.Endereco.Cidade = TextBoxCidade.Text;
                funcionario1.Endereco.UF = ComboBoxUF.Text;
                funcionario1.Endereco.CEP = TextBoxCEP.Text.Replace("-", ""); // Marcelo falou para no banco guardar como varchar, mas antes tirar os traços
                funcionario1.Endereco.StatusAtivo = true;

                funcionario1.Telefone = new TelefoneFuncionario();
                funcionario1.Telefone.DDD = TextBoxDDD.Text;
                funcionario1.Telefone.Numero = TextBoxTelefone.Text;
                funcionario1.Telefone.StatusAtivo = true;

                try
                {
                    funcionarioService.CadastrarFuncionario(funcionario1); // Chamando o método CadastrarFuncionario da instância funcionarioService
                    MessageBox.Show("Usuário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FuncionarioCadastradoSucesso?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        // Definir um evento para notificar o cadastro bem-sucedido do funcionario
        public event EventHandler FuncionarioCadastradoSucesso;

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Os códigos de todos os "Validating" foram colocados em "BotaoConfirmar_Click" acima para evitar "travar o usuário"
        private void TextBoxNome_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxEmail_Validating(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxCargo_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void ComboBoxSexo_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxUsuario_Validating(object sender, CancelEventArgs e)
        {
            
        }

        // Verificar se um nome de usuário já está em uso
        private bool VerificarUsuarioDisponivel(string usuario)
        {
            string verificarUsuarioDisponivel = funcionarioService.VerificarUsuarioDisponivel(usuario); // Chamando o método VerificarUsuarioDisponivel da instância funcionarioService
            if (verificarUsuarioDisponivel == "disponivel")
            {
                MessageBox.Show("Nome de usuário disponível.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (verificarUsuarioDisponivel == "indisponivel")
            {
                MessageBox.Show("Nome de usuário indisponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (verificarUsuarioDisponivel == "erro")
            {
                MessageBox.Show("Erro ao verificar disponibilidade do nome de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return false;
            }
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

        private void TextBoxSenha1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TextBoxSenha2_Validating(object sender, CancelEventArgs e)
        {
            
        }

        // Método dedicado para verificar se a senha é forte o suficiente
        // ********** FUNCIONAL **********
        public bool VerificarSenhaForte(string senha)
        {
            // Verifica se a senha tem pelo menos 8 caracteres
            if (senha.Length < 8)
            {
                MessageBox.Show("A senha deve conter no mínimo 8 caracteres.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Verifica se a senha contém pelo menos um número
            bool contemNumero = false;
            foreach (char c in senha)
            {
                if (char.IsDigit(c))
                {
                    contemNumero = true;
                    break;
                }
            }
            if (!contemNumero)
            {
                MessageBox.Show("A senha deve conter pelo menos um número.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se a senha contém pelo menos uma letra maiúscula
            bool contemMaiuscula = false;
            foreach (char c in senha)
            {
                if (char.IsUpper(c))
                {
                    contemMaiuscula = true;
                    break;
                }
            }
            if (!contemMaiuscula)
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra maiúscula.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se a senha contém pelo menos uma letra minúscula
            bool contemMinuscula = false;
            foreach (char c in senha)
            {
                if (char.IsLower(c))
                {
                    contemMinuscula = true;
                    break;
                }
            }
            if (!contemMinuscula)
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra minúscula.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se a senha contém pelo menos um caractere especial
            bool contemEspecial = false;
            foreach (char c in senha)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    contemEspecial = true;
                    break;
                }
            }
            if (!contemEspecial)
            {
                MessageBox.Show("A senha deve conter pelo menos um caractere especial.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Se a senha passar por todas as verificações, é considerada forte
            return true;
            //MessageBox.Show("Senha forte.", "Senha Forte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PictureBoxMostrarSenha_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            TextBoxSenha1.UseSystemPasswordChar = !TextBoxSenha1.UseSystemPasswordChar;
            TextBoxSenha2.UseSystemPasswordChar = !TextBoxSenha2.UseSystemPasswordChar;
        }

        private void MaskedTextBoxCPF_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}

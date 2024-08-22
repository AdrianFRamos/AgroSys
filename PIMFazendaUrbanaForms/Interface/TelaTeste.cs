using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaTeste : Form
    {

        Funcionario funcionario = new Funcionario();
        FuncionarioService funcionarioService; // Declaração de uma instância de FuncionarioService

        public TelaTeste()
        {
            InitializeComponent();

            funcionarioService = new FuncionarioService(); // Cria uma instância de FuncionarioService
        }

        // Autenticar login de funcionário
        // ********** FUNCIONAL **********
        private void BotaoAutenticarFuncionario_Click(object sender, EventArgs e)
        {

            string usuario = "igor123";
            string senha = "SenhaIgor1!";

            /*
            string usuario = CampoUsuario.Text; // Obtendo o valor do campo de texto do usuário
            string senha = CampoSenha.Text; // Obtendo o valor do campo de texto da senha
            */

            bool autenticado = AutenticarFuncionario(usuario, senha); // Chamando o método dedicado AutenticarFuncionario daqui dessa classe TelaTeste
        }

        // Método dedicado para autenticar login do funcionário
        // ********** FUNCIONAL **********
        private bool AutenticarFuncionario(string usuario, string senha)
        {
            string autenticarfuncionario = funcionarioService.AutenticarFuncionario(usuario, senha); // Chamando o método AutenticarFuncionario da instância funcionarioService
            if (autenticarfuncionario == "autenticado")
            {
                MessageBox.Show("Acesso permitido, usuário autenticado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (autenticarfuncionario == "naoautenticado")
            {
                MessageBox.Show("Acesso negado, usuário não autenticado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (autenticarfuncionario == "inativo")
            {
                MessageBox.Show("Acesso negado, usuário inativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (autenticarfuncionario == "naoexiste")
            {
                MessageBox.Show("Acesso negado, usuário não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (autenticarfuncionario == "erro")
            {
                MessageBox.Show("Erro ao autenticar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (autenticarfuncionario == "errodesconhecido")
            {
                MessageBox.Show("Erro desconhecido ao autenticar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return false;
            }
        }

        // Autenticar um funcionário como gerente
        // ********** FUNCIONAL **********
        private void BotaoAutenticarGerente_Click(object sender, EventArgs e)
        {
            string usuario = "caiqueuser";
            string senha = "CaiqueSenha1@";

            /*
            string usuario = CampoUsuario.Text; // Obtendo o valor do campo de texto do usuário
            string senha = CampoSenha.Text; // Obtendo o valor do campo de texto da senha
            */

            bool autenticado = AutenticarFuncionario(usuario, senha); // Chamando o método dedicado AutenticarFuncionario daqui dessa classe TelaTeste
            if (autenticado == true)
            {
                string autenticargerente = funcionarioService.AutenticarGerente(usuario); // Chamando o método AutenticarGerente da instância funcionarioService
                if (autenticargerente == "gerente")
                {
                    MessageBox.Show("Acesso permitido, usuário autenticado como gerente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Criar uma instância do segundo formulário
                    //TelaFuncionarios telaFuncionarios = new TelaFuncionarios();

                    // Exibir o segundo formulário
                    //telaFuncionarios.Show();
                }
                else if (autenticargerente == "naogerente")
                {
                    MessageBox.Show("Acesso negado, usuário não autenticado como gerente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (autenticargerente == "erro")
                {
                    MessageBox.Show("Erro ao autenticar usuário como gerente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        // Alterar senha de um funcionário
        // ********** FUNCIONAL **********
        private void BotaoAlterarSenhaFuncionario_Click(object sender, EventArgs e)
        {
            string usuario = "igor123";
            string senha = "SenhaIgor1!";

            /*
            string usuario = CampoUsuario.Text; // Obtendo o valor do campo de texto do usuário
            string senha = CampoSenha.Text; // Obtendo o valor do campo de texto da senha
            */

            bool autenticado = AutenticarFuncionario(usuario, senha); // Chamando o método dedicado AutenticarFuncionario daqui dessa classe TelaTeste

            if (autenticado == false)
            {
                return;
            }
            else
            {
                /*
                string novasenha1 = CampoNovaSenha1.Text; // Obtendo o valor do campo de texto da nova senha
                string novasenha2 = CampoNovaSenha2.Text; // Obtendo o valor do campo de texto da nova senha
                */

                string novasenha1 = "NovaSenha1!";
                string novasenha2 = "NovaSenha1!";

                bool senhasiguais = false;

                //pode colocar a verificação de novas senhas iguais aqui ou na validação dos campos
                if (novasenha1 != novasenha2)
                {
                    MessageBox.Show("As senhas são diferentes, confira e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    senhasiguais = false;
                }
                else
                {
                    senhasiguais = true;
                }

                if (senhasiguais == false)
                {
                    return;
                }
                else
                {
                    // Verificar se a nova senha é forte o suficiente
                    bool senhaforte = VerificarSenhaForte(novasenha1);

                    if (senhaforte == false)
                    {
                        return;
                    }
                    else
                    {
                        bool alterarSenha = funcionarioService.AlterarSenhaFuncionario(usuario, novasenha1); // Chamando o método AlterarSenhaFuncionario da instância funcionarioService
                        if (alterarSenha == true)
                        {
                            MessageBox.Show("Senha alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
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
            MessageBox.Show("Senha forte.", "Senha Forte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        // Consultar funcionário por nome
        // ********** NÃO TESTADO **********
        private void BotaoConsultarFuncionarioNome_Click(object sender, EventArgs e)
        {
            /*
            string nome = CampoNome.Text; // Obtendo o valor do campo de texto do nome

            Funcionario funcionario = funcionarioService.ConsultarFuncionarioNome(nome); // Chamando o método ConsultarFuncionarioNome da instância funcionarioService
            if (funcionario != null)
            {
                MessageBox.Show($"Funcionário encontrado: {funcionario.Nome}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        // Consultar funcionário por nome de usuário
        // ********** NÃO TESTADO **********
        private void BotaoConsultarFuncionarioUsuario_Click(object sender, EventArgs e)
        {
            /*
            string usuario = CampoUsuario.Text; // Obtendo o valor do campo de texto do usuário

            Funcionario funcionario = funcionarioService.ConsultarFuncionarioUsuario(usuario); // Chamando o método ConsultarFuncionarioUsuario da instância funcionarioService
            if (funcionario != null)
            {
                MessageBox.Show($"Funcionário encontrado: {funcionario.Nome}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }


     
    }

}

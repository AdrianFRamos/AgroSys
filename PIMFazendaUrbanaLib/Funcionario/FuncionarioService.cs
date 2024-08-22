namespace PIMFazendaUrbanaLib
{
    public class FuncionarioService
    {
        private FuncionarioDAO funcionarioDAO;
        public FuncionarioService()
        {
            this.funcionarioDAO = new FuncionarioDAO();
        }

        // 1- Método para autenticar funcionário
        public string AutenticarFuncionario(string usuario, string senha)
        {
            try
            {
                string autenticado = funcionarioDAO.AutenticarFuncionario(usuario, senha);
                if (autenticado == "autenticado")
                {
                    return "autenticado"; // Retorna "autenticado" para indicar que o funcionário foi autenticado
                }
                else if (autenticado == "inativo")
                {
                    return "inativo"; // Retorna "inativo" para indicar que o funcionário está inativo
                }
                else if (autenticado == "naoautenticado")
                {
                    return "naoautenticado"; // Retorna "naoautenticado" para indicar que o funcionário não foi autenticado
                }
                else if (autenticado == "naoexiste")
                {
                    return "naoexiste"; // Retorna "naoexiste" para indicar que o funcionário não existe
                }
                else
                {
                    return "erro desconhecido";
                }
            }
            catch (Exception ex)
            {
                return "erro"; // Retorna "erro" para indicar que houve um erro ao autenticar o funcionário
            }
        }

        // 2- Método para autenticar funcionário
        public string AutenticarGerente(string usuario)
        {
            try
            {
                if (funcionarioDAO.AutenticarGerente(usuario) == true)
                {
                    // Aqui você pode fazer algo com os dados do funcionário autenticado.

                    return "gerente"; // Retorna "gerente" para indicar que o funcionário foi autenticado como gerente
                }
                else
                {
                    // Aqui você pode lidar com o caso em que o funcionário não é autenticado.

                    return "naogerente"; // Retorna "naogerente" para indicar que o funcionário não foi autenticado como gerente
                }
            }
            catch (Exception ex)
            {
                return "erro"; // Retorna "erro" para indicar que houve um erro ao autenticar o funcionário como gerente
            }
        }

        // 3- Método para verificar se um nome de usuário já está em uso
        public string VerificarUsuarioDisponivel(string usuario)
        {
            try
            {
                if (funcionarioDAO.VerificarUsuarioDisponivel(usuario) == true)
                {
                    return "disponivel"; // Retorna "disponivel" para indicar que o usuário está disponível
                }
                else
                {
                    return "indisponivel"; // Retorna "indisponivel" para indicar que o usuário já está em uso
                }
            }
            catch (Exception ex)
            {
                return "erro"; // Retorna "erro" para indicar que houve um erro ao verificar a disponibilidade do usuário
            }
        }

        // 4- Método para alterar senha do funcionário
        public bool AlterarSenhaFuncionario(string usuario, string novaSenha)
        {
            try
            {
                funcionarioDAO.AlterarSenhaFuncionario(usuario, novaSenha);

                return true; // Retorna true para indicar que a alteração da senha foi bem-sucedida
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar senha do funcionário: " + ex.Message);
            }
        }

        // 5- Método para cadastrar novo funcionário
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                // Aqui você pode realizar validações dos dados do funcionário antes de chamara o DAO
                
                funcionarioDAO.CadastrarFuncionario(funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        // 6- Método para alterar dados do funcionário
        public void AlterarFuncionario(Funcionario funcionario)
        {
            try
            {
                funcionarioDAO.AlterarFuncionario(funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar funcionário: " + ex.Message);
            }
        }

        // 7- Método para excluir (desativar) funcionário
        public void ExcluirFuncionario(int funcionarioId)
        {
            try
            {
                funcionarioDAO.ExcluirFuncionario(funcionarioId);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir funcionário: " + ex.Message);
            }
        }

        // 8 - Listagem
        // 8.1- Método para listar funcionários ativos
        public List<Funcionario> ListarFuncionariosAtivos()
        {
            try
            {
                List<Funcionario> funcionarios = funcionarioDAO.ListarFuncionariosAtivos();
                return funcionarios; // Retorna a lista de funcionarios quando tudo corre bem
            }
            catch (Exception ex)
            {
                // Lança uma exceção indicando que ocorreu um erro ao listar funcionarios ativos
                throw new Exception("Erro ao listar funcionários ativos: " + ex.Message);
            }
        }

        // 8.2- Método para listar funcionários inativos
        public List<Funcionario> ListarFuncionariosInativos()
        {
            try
            {
                List<Funcionario> funcionariosInativos = funcionarioDAO.ListarFuncionariosInativos();
                return funcionariosInativos; // Retorna a lista de funcionarios quando tudo corre bem
            }
            catch (Exception ex)
            {
                // Lança uma exceção indicando que ocorreu um erro ao listar funcionarios inativos
                throw new Exception("Erro ao listar funcionários inativos: " + ex.Message);
            }
        }

        // 9 - Consulta
        // 9.1- Método para consultar funcionário por ID
        public Funcionario ConsultarFuncionarioID(int funcionarioId)
        {
            try
            {
                Funcionario funcionario = funcionarioDAO.ConsultarFuncionarioID(funcionarioId);
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar funcionário: " + ex.Message);
            }
        }

        // 9.2- Método para consultar funcionário por nome
        public Funcionario ConsultarFuncionarioNome(string funcionarioNome)
        {
            try
            {
                Funcionario funcionario = funcionarioDAO.ConsultarFuncionarioNome(funcionarioNome);
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar funcionário: " + ex.Message);
            }
        }

        // 9.3- Método para consultar funcionário por nome de usuário
        public Funcionario ConsultarFuncionarioUsuario(string funcionarioUsuario)
        {
            try
            {
                Funcionario funcionario = funcionarioDAO.ConsultarFuncionarioUsuario(funcionarioUsuario);
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar funcionário: " + ex.Message);
            }
        }

        // 10 - Método para filtrar lista de funcionários por nome
        public List<Funcionario> FiltrarFuncionariosNome(string funcionarioNome)
        {
            try
            {
                List<Funcionario> funcionarios = funcionarioDAO.FiltrarFuncionariosNome(funcionarioNome);
                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar funcionários por nome: " + ex.Message);
            }
        }

    }
}

namespace PIMFazendaUrbanaLib
{
    public class ClienteService // A classe ClienteService é responsável por implementar a lógica de negócio relacionada a clientes
    {
        private ClienteDAO clienteDAO;
        public ClienteService()
        {
            this.clienteDAO = new ClienteDAO();
        }

        // 1- Cadastrar Cliente
        // O método CadastrarCliente é responsável por cadastrar um novo cliente. Antes de chamar o DAO para inserir um cliente no banco de dados, este método pode realizar validações dos dados, se necessário.
        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                clienteDAO.CadastrarCliente(cliente); // Chama o método CadastrarCliente do DAO para inserir o novo cliente no banco de dados, passando o objeto cliente como argumento
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar cliente: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao cadastrar o cliente
            }
        }

        // 2- Alterar Cliente
        // O método AlterarCliente é responsável por alterar os dados de um cliente existente. Antes de chamar o DAO para atualizar os dados no banco de dados, este método pode realizar validações dos dados, se necessário.
        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                clienteDAO.AlterarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar cliente: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao alterar o cliente
            }
        }

        // 3- Excluir (DESATIVAR) Cliente
        // O método ExcluirCliente é responsável por excluir (DESATIVAR) um cliente do banco de dados. Antes de chamar o DAO para realizar a exclusão, este método pode realizar validações ou outras operações necessárias.
        public void ExcluirCliente(int clienteId)
        {
            try
            {
                clienteDAO.ExcluirCliente(clienteId); // Chama o método ExcluirCliente da classe ClienteDAO, passando o ID do cliente como argumento
                //return true; // Retorna true para indicar que a exclusão foi bem-sucedida
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir cliente: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao excluir o cliente
            }
        }

        // 4- Listagem
        // 4.1- Listar Clientes Ativos
        // O método ListarClientesAtivos é responsável por obter a lista de todos os clientes com a flag "ativo_cliente = true" cadastrados no banco de dados e exibir esses dados na tela.
        public List<Cliente> ListarClientesAtivos()
        {
            try
            {
                List<Cliente> clientes = clienteDAO.ListarClientesAtivos();
                return clientes; // Retorna a lista de clientes quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar clientes ativos: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao listar clientes ativos
            }
        }

        // 4.2- Listar Clientes Inativos
        // O método ListarClientesInativos é responsável por obter a lista de todos os clientes inativos cadastrados no banco de dados e exibir esses dados na tela.
        public List<Cliente> ListarClientesInativos()
        {
            try
            {
                List<Cliente> clientesInativos = clienteDAO.ListarClientesInativos();
                return clientesInativos; // Retorna a lista de clientes inativos quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar clientes inativos: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao listar clientes inativos
            }
        }

        // 5- Consulta
        // 5.1 - Consultar Cliente por ID
        public Cliente ConsultarClienteID(int clienteId)
        {
            try
            {
                Cliente cliente = clienteDAO.ConsultarClienteID(clienteId); // Chama o método ConsultarCliente da classe ClienteDAO para obter os dados de um cliente pelo ID
                return cliente; // Retorna o cliente encontrado
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar cliente: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao consultar o cliente
            }
        }

        // 5.2 - Consultar Cliente por nome
        public Cliente ConsultarClienteNome(string clienteNome)
        {
            try
            {
                Cliente cliente = clienteDAO.ConsultarClienteNome(clienteNome); // Chama o método ConsultarCliente da classe ClienteDAO para obter os dados de um cliente pelo nome
                return cliente; // Retorna o cliente encontrado
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar cliente: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao consultar o cliente
            }
        }

        // 5.3 - Consultar Cliente por CNPJ
        public Cliente ConsultarClienteCNPJ(string clienteCNPJ)
        {
            try
            {
                Cliente cliente = clienteDAO.ConsultarClienteCNPJ(clienteCNPJ); // Chama o método ConsultarCliente da classe ClienteDAO para obter os dados de um cliente pelo cnpj
                return cliente; // Retorna o cliente encontrado
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar cliente: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro ao consultar o cliente
            }
        }

        // 6 - Filtragem
        // 6.1 - Filtrar lista de clientes por nome
        public List<Cliente> FiltrarClientesNome(string clienteNome)
        {
            try
            {
                List<Cliente> clientes = clienteDAO.FiltrarClientesNome(clienteNome);
                return clientes;
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
                throw new Exception("Erro ao filtrar clientes por nome: " + ex.Message);
            }
        }


    }
}
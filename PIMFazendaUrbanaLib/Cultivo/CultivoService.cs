namespace PIMFazendaUrbanaLib
{
    public class CultivoService
    {
        private CultivoDAO cultivoDAO;

        public CultivoService()
        {
            this.cultivoDAO = new CultivoDAO();
        }

        // 1- Cadastrar Cultivo
        public void CadastrarCultivo(Cultivo cultivo)
        {
            try
            {
                cultivoDAO.CadastrarCultivo(cultivo); // Chama o método CadastrarCultivo do DAO para inserir o novo cultivo no banco de dados, passando o objeto cultivo como argumento
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar cultivo: " + ex.Message);
            }
        }

        // 2- Alterar Cultivo
        public void AlterarCultivo(Cultivo cultivo)
        {
            try
            {
                cultivoDAO.AlterarCultivo(cultivo); // Chama o método AlterarCultivo do DAO para atualizar os dados do cultivo no banco de dados
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar cultivo: " + ex.Message);
            }
        }

        // 3- Excluir (DESATIVAR) Cultivo
        public bool ExcluirCultivo(int cultivoId)
        {
            try
            {
                cultivoDAO.ExcluirCultivo(cultivoId); // Chama o método ExcluirCultivo do DAO para desativar o cultivo no banco de dados
                return true; // Retorna true para indicar que a exclusão foi bem-sucedida
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir cultivo: " + ex.Message);
            }
        }

        // 4- Listagem
        // 4.1- Listar Cultivos Ativos
        public List<Cultivo> ListarCultivosAtivos()
        {
            try
            {
                List<Cultivo> cultivos = cultivoDAO.ListarCultivosAtivos(); // Chama o método ListarCultivosAtivos do DAO para obter a lista de cultivos ativos
                return cultivos; // Retorna a lista de cultivos ativos quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cultivos ativos: " + ex.Message);
            }
        }

        // 4.2- Listar Cultivos Inativos
        public List<Cultivo> ListarCultivosInativos()
        {
            try
            {
                List<Cultivo> cultivosInativos = cultivoDAO.ListarCultivosInativos(); // Chama o método ListarCultivosInativos do DAO para obter a lista de cultivos inativos
                return cultivosInativos; // Retorna a lista de cultivos inativos quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cultivos inativos: " + ex.Message);
            }
        }

        // 4.3 - Listar Categorias
        public List<string> ListarCategorias()
        {
            try
            {
                return cultivoDAO.ListarCategorias();
            }
            catch (Exception ex)
            {
                return new List<string>();
                throw new Exception("Erro ao listar categorias: " + ex.Message);
            }
        }

        // 5- Consulta
        // 5.1 - Consultar Cultivo por ID
        public Cultivo ConsultarCultivoID(int cultivoId)
        {
            try
            {
                Cultivo cultivo = cultivoDAO.ConsultarCultivoID(cultivoId); // Chama o método ConsultarCultivoID do DAO para obter os dados de um cultivo pelo ID
                return cultivo; // Retorna o cultivo encontrado
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar cultivo: " + ex.Message);
            }
        }

        // 5.2 - Consultar Cultivo por nome
        public Cultivo ConsultarCultivoNome(string cultivoNome)
        {
            try
            {
                Cultivo cultivo = cultivoDAO.ConsultarCultivoNome(cultivoNome); // Chama o método ConsultarCultivoNome do DAO para obter os dados de um cultivo pelo nome
                return cultivo; // Retorna o cultivo encontrado
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar cultivo: " + ex.Message);
            }
        }

        // 6- Filtragem
        // 6.1 - Filtrar lista de cultivos por nome
        public List<Cultivo> FiltrarCultivosNome(string cultivoNome)
        {
            try
            {
                return cultivoDAO.FiltrarCultivosNome(cultivoNome);
            }
            catch (Exception ex)
            {
                return new List<Cultivo>();
                throw new Exception("Erro ao filtrar cultivos por nome: " + ex.Message);
            }
            
        }

    }
}

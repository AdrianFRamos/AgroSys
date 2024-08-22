namespace PIMFazendaUrbanaLib
{
    public class ProducaoService
    {
        private ProducaoDAO producaoDAO;

        public ProducaoService()
        {
            this.producaoDAO = new ProducaoDAO();
        }

        // 1 - MÉTODO CADASTRAR PRODUCAO
        public void CadastrarProducao(Producao producao)
        {
            try
            {
                producaoDAO.CadastrarProducao(producao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar produção: " + ex.Message);
            }
        }

        // 2 - MÉTODO ALTERAR PRODUCAO
        public bool AlterarProducao(Producao producao)
        {
            try
            {
                producaoDAO.AlterarProducao(producao);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar produção: " + ex.Message);
            }
        }

        // 3 - MÉTODO FINALIZAR PRODUCAO
        public bool FinalizarProducao(int producaoId)
        {
            try
            {
                producaoDAO.FinalizarProducao(producaoId);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao finalizar produção: " + ex.Message);
            }
        }

        // 4 - Listagem
        // 4.1 - MÉTODO LISTAR PRODUCOES
        public List<Producao> ListarProducoes()
        {
            try
            {
                List<Producao> producoes = producaoDAO.ListarProducoes();
                return producoes; // Retorna a lista de produções quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar produções: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro
            }
        }

        // 4.2 - MÉTODO LISTAR PRODUCOES (NÃO FINALIZADAS)
        public List<Producao> ListarProducoesNaoFinalizadas()
        {
            try
            {
                List<Producao> producoes = producaoDAO.ListarProducoesNaoFinalizadas();
                return producoes; // Retorna a lista de produções quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar produções: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro
            }
        }

        // 4.3 - MÉTODO FILTRAR PRODUCOES POR NOME DE CULTIVO
        public List<Producao> FiltrarProducoesNome(string nomeCultivo)
        {
            try
            {
                List<Producao> producoes = producaoDAO.FiltrarProducoesNome(nomeCultivo);
                return producoes; // Retorna a lista de produções quando tudo corre bem
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar produções por nome de cultivo: " + ex.Message); // Lança uma exceção indicando que ocorreu um erro
            }
        }

        // 5 - MÉTODO CONSULTAR PRODUCAO POR ID
        public Producao ConsultarProducaoID(int producaoId)
        {
            try
            {
                Producao producao = producaoDAO.ConsultarProducaoID(producaoId);
                return producao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar produção: " + ex.Message);
            }
        }

        public List<Producao> FiltrarProducoesPorNomeEPeriodo(string cultivoNome, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                return producaoDAO.FiltrarProducoesPorNomeEPeriodo(cultivoNome, dataInicio, dataFim);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar produções por nome de cultivo e período: " + ex.Message);
            }
        }

    }
}

namespace PIMFazendaUrbanaLib
{
    public class RecomendacaoService
    {
        private RecomendacaoDAO recomendacaoDAO;
        public RecomendacaoService()
        {
            this.recomendacaoDAO = new RecomendacaoDAO();
        }

        public List<Cultivo> GerarRecomendacao(string regiao, string estacao)
        {
            try
            {
                List<Cultivo> recomendacoes = recomendacaoDAO.GerarRecomendacao(regiao, estacao);
                return recomendacoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cultivos: " + ex.Message);
            }
        }

    }
}

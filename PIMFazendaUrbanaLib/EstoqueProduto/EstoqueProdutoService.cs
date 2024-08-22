namespace PIMFazendaUrbanaLib
{
    public class EstoqueProdutoService
    {
        private EstoqueProdutoDAO estoqueProdutoDAO;

        public EstoqueProdutoService()
        {
            this.estoqueProdutoDAO = new EstoqueProdutoDAO();
        }

        public List<EstoqueProduto> ListarEstoqueProdutoAtivos()
        {
            try
            {
                List<EstoqueProduto> produtos = estoqueProdutoDAO.ListarEstoqueProdutoAtivos();
                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar estoque de produtos: " + ex.Message);
            }
        }

        public List<EstoqueProduto> FiltrarProdutosNome(string produtoNome)
        {
            try
            {
                List<EstoqueProduto> produtos = estoqueProdutoDAO.FiltrarProdutosNome(produtoNome);
                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar produtos por nome: " + ex.Message);
            }
        }

        // Método para filtrar produtos pela unidade
        public List<EstoqueProduto> FiltrarProdutosPorUnidade(string unidade)
        {
            try
            {
                return estoqueProdutoDAO.FiltrarProdutosPorUnidade(unidade);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar produtos pela unidade: " + ex.Message);
            }
        }

    }
}

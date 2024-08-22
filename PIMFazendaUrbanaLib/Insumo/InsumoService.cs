namespace PIMFazendaUrbanaLib
{
    public class InsumoService
    {
        private InsumoDAO insumoDAO;

        public InsumoService()
        {
            this.insumoDAO = new InsumoDAO();
        }

        public void CadastrarInsumo(Insumo insumo)
        {
            try
            {
                insumoDAO.CadastrarInsumo(insumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar insumo: " + ex.Message);
            }
        }

        public void AlterarInsumo(Insumo insumo)
        {
            try
            {
                insumoDAO.AlterarInsumo(insumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar insumo: " + ex.Message);
            }
        }

        public Insumo ConsultarInsumoPorID(int insumoID)
        {
            try
            {
                Insumo insumo = insumoDAO.ConsultarInsumoPorID(insumoID);
                return insumo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar insumo por ID: " + ex.Message);
            }
        }

        public List<Insumo> ListarInsumosAtivos()
        {
            try
            {
                List<Insumo> insumos = insumoDAO.ListarInsumosAtivos();
                return insumos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar insumos ativos: " + ex.Message);
            }
        }

        public List<Insumo> ListarInsumosEmEstoque()
        {
            try
            {
                List<Insumo> insumos = insumoDAO.ListarInsumosEmEstoque();
                return insumos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar insumos em estoque: " + ex.Message);
            }
        }

        public List<Insumo> ListarInsumosInativos()
        {
            try
            {
                List<Insumo> insumosInativos = insumoDAO.ListarInsumosInativos();
                return insumosInativos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar insumos inativos: " + ex.Message);
            }
        }

        public void DesativarInsumo(int insumoID)
        {
            try
            {
                insumoDAO.DesativarInsumo(insumoID);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao desativar insumo: " + ex.Message);
            }
        }

        public List<Insumo> FiltrarInsumosNome(string insumoNome)
        {
            try
            {
                List<Insumo> insumos = insumoDAO.FiltrarInsumosNome(insumoNome);
                return insumos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar insumos por nome: " + ex.Message);
            }
        }

        public List<SaidaInsumo> ListarSaidaInsumos()
        {
            try
            {
                List<SaidaInsumo> saidainsumos = insumoDAO.ListarSaidaInsumos();
                return saidainsumos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar registros de saída de insumos: " + ex.Message);
            }
        }

        public List<SaidaInsumo> FiltrarSaidaInsumosNome(string insumoNome)
        {
            try
            {
                List<SaidaInsumo> saidainsumos = insumoDAO.FiltrarSaidaInsumosNome(insumoNome);
                return saidainsumos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar registros de saída de insumos: " + ex.Message);
            }
        }

        // Método para filtrar insumos pela unidade
        public List<Insumo> FiltrarInsumosPorUnidade(string unidade)
        {
            try
            {
                return insumoDAO.FiltrarInsumosPorUnidade(unidade);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar insumos pela unidade: " + ex.Message);
            }
        }

        // Método para obter a categoria do insumo pelo nome
        public string ObterCategoriaPorNomeInsumo(string nomeInsumo)
        {
            try
            {
                return insumoDAO.ObterCategoriaPorNomeInsumo(nomeInsumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter categoria do insumo pelo nome: " + ex.Message);
            }
        }

        public void CadastrarSaidaInsumo(SaidaInsumo saidainsumo, Insumo insumo)
        {
            try
            {
                insumoDAO.CadastrarSaidaInsumo(saidainsumo, insumo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar saída de insumo: " + ex.Message);
            }
        }

        public bool AumentarQtdInsumo(Insumo insumo, int qtd)
        {
            try
            {
                insumoDAO.AumentarQtdInsumo(insumo, qtd);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar quantidade do insumo: " + ex.Message);
            }
        }

        public List<SaidaInsumo> FiltrarSaidaInsumosPorNomeEPeriodo(string insumoNome, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                return insumoDAO.FiltrarSaidaInsumosPorNomeEPeriodo(insumoNome, dataInicio, dataFim);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao filtrar registros de saída por nome de insumo e período: " + ex.Message);
            }
        }

    }
}

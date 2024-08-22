using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaCadastrarSaidaInsumo : Form
    {
        Insumo insumo = new Insumo();

        public event EventHandler SaidaInsumoCadastradoSucesso;

        InsumoService insumoService; // Declaração de uma instância de InsumoService

        public TelaCadastrarSaidaInsumo(int insumoID)
        {
            InitializeComponent();

            insumoService = new InsumoService(); // Cria uma instância de InsumoService

            insumo = insumoService.ConsultarInsumoPorID(insumoID); // Chamando o método ConsultarInsumoID da instância insumoService

            if (insumo != null)
            {
                PreencherCampos(insumo);
            }
            else
            {
                MessageBox.Show("Erro ao carregar dados do insumo. Se o erro persistir, entre em contato com o administrador do banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PreencherCampos(Insumo insumo)
        {
            TextBoxNome.Text = insumo.Nome;
            TextBoxCategoria.Text = insumo.Categoria;
            TextBoxQuantidadeAtual.Text = insumo.Qtd.ToString();
            TextBoxUnidade.Text = insumo.Unidqtd;
            TextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            string quantidade = TextBoxQuantidade.Text;
            string data = TextBoxData.Text;
            bool quantidadeValida = false;
            int qtd;

            // Verifica se a quantidade é válida
            if (quantidade == null || !int.TryParse(quantidade, out qtd) || qtd <= 0)
            {
                TextBoxQuantidade.ForeColor = Color.Red;
                MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxQuantidade;
                quantidadeValida = false;
            }
            else if (qtd > insumo.Qtd)
            {
                TextBoxQuantidade.ForeColor = Color.Red;
                MessageBox.Show("A quantidade de saída deve ser menor ou igual a quantidade atual no estoque.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = TextBoxQuantidade;
                quantidadeValida = false;
            }
            else
            {
                TextBoxQuantidade.ForeColor = Color.Black;
                quantidadeValida = true;
            }

            // Se todas as validações passarem, pode prosseguir com a ação do botão Confirmar
            if (quantidadeValida == true)
            {
                SaidaInsumo saidainsumo = new SaidaInsumo();
                saidainsumo.Qtd = Convert.ToInt32(quantidade);
                saidainsumo.Unidqtd = insumo.Unidqtd;
                saidainsumo.Data = DateTime.Now;
                saidainsumo.IdInsumo = insumo.Id;
                saidainsumo.NomeInsumo = insumo.Nome;
                saidainsumo.CategoriaInsumo = insumo.Categoria;

                try
                {
                    insumoService.CadastrarSaidaInsumo(saidainsumo, insumo);
                    MessageBox.Show("Saída de insumo cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaidaInsumoCadastradoSucesso?.Invoke(this, EventArgs.Empty); // Disparar o evento
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



    }
}

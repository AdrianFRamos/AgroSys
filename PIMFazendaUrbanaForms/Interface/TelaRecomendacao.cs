using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaRecomendacao : Form
    {
        RecomendacaoService recomendacaoService;

        bool ambienteControlado = false;

        public TelaRecomendacao()
        {
            InitializeComponent();

            recomendacaoService = new RecomendacaoService();

            
        }

        private void ComboBoxRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se alguma região está selecionada
            if (ComboBoxRegiao.SelectedItem == null)
            {
                return; // Não há região selecionada, então não precisamos fazer mais nada
            }

            string regiaoSelecionada = ComboBoxRegiao.SelectedItem.ToString().Trim(); // Removendo espaços extras

            // Verificar se a região selecionada é uma das opções aceitas
            string[] regioesAceitas = { "Norte", "Nordeste", "Sul", "Sudeste", "Centro-Oeste" };

            // Verificando se a região selecionada está na lista de regiões aceitas, ignorando a diferença de caixa
            if (!regioesAceitas.Any(r => string.Equals(r, regiaoSelecionada, StringComparison.OrdinalIgnoreCase)))
            {
                // Se a região selecionada não estiver na lista de regiões aceitas, exibir uma mensagem de erro
                MessageBox.Show("Por favor, selecione uma das seguintes regiões: Norte, Nordeste, Sul, Sudeste, Centro-Oeste", "Região Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpar a seleção do ComboBox
                ComboBoxRegiao.SelectedIndex = -1;
                ActiveControl = ComboBoxRegiao;
            }
        }

        private void ComboBoxEstacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se alguma estação está selecionada
            if (ComboBoxEstacao.SelectedItem == null)
            {
                return; // Não há estação selecionada, então não precisamos fazer mais nada
            }

            string estacaoSelecionada = ComboBoxEstacao.SelectedItem.ToString().Trim(); // Removendo espaços extras

            // Verificar se a estação selecionada é uma das opções aceitas
            string[] estacoesAceitas = { "Verão", "Outono", "Inverno", "Primavera" };

            // Verificando se a estação selecionada está na lista de estações aceitas, ignorando a diferença de caixa
            if (!estacoesAceitas.Any(r => string.Equals(r, estacaoSelecionada, StringComparison.OrdinalIgnoreCase)))
            {
                // Se a estação selecionada não estiver na lista de estações aceitas, exibir uma mensagem de erro
                MessageBox.Show("Por favor, selecione uma das seguintes estações: Verão, Outono, Inverno, Primavera", "Estação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpar a seleção do ComboBox
                ComboBoxRegiao.SelectedIndex = -1;
                ActiveControl = ComboBoxRegiao;
            }
        }

        private void BotaoGerar_Click(object sender, EventArgs e)
        {
            string regiao = ComboBoxRegiao.SelectedItem.ToString();
            string estacao = ComboBoxEstacao.SelectedItem.ToString();

            if (ambienteControlado == true)
            {
                // Inverte as estações
                switch (estacao)
                {
                    case "Verão":
                        estacao = "Inverno";
                        break;
                    case "Outono":
                        estacao = "Primavera";
                        break;
                    case "Inverno":
                        estacao = "Verão";
                        break;
                    case "Primavera":
                        estacao = "Outono";
                        break;
                    // Adicione mais casos conforme necessário
                    default:
                        // Caso a estação não esteja nas opções esperadas, não faz nada
                        break;
                }
            }

            // Gerar os resultados da recomendação como objetos Cultivo
            List<Cultivo> resultados = recomendacaoService.GerarRecomendacao(regiao, estacao);

            // Abrir a nova janela para exibir os resultados
            TelaRecomendacaoResultados telaRecomendacaoResultados = new TelaRecomendacaoResultados(resultados, regiao, estacao, ambienteControlado);
            telaRecomendacaoResultados.Show();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ambienteControlado = checkBox1.Checked;
        }
    }
}

using System.Drawing.Imaging;

namespace PIMFazendaUrbanaForms
{
    public partial class TelaPrincipal : Form
    {
        private int currentImageIndex = 0;
        private Image[] images;
        private float opacityIncrement = 0.05f;
        private float currentOpacity = 1.0f;

        public TelaPrincipal()
        {
            InitializeComponent();

            this.Icon = new Icon("FazendaUrbana.ico");
            // this.Icon = new Icon(@"C:\Users\User\source\repos\PIMADSRP\PIMFazendaUrbana\PIMFazendaUrbanaForms\FazendaUrbana.ico");

            AtualizarInterfaceUsuario();

            RichTextBoxNotas.SelectionBullet = true;
            RichTextBoxNotas.SelectionIndent = 10;

            // Adicionar manchetes ao ListBoxNoticias
            ListBoxNoticias.Items.Add("Mercado global de fazendas urbanas deve movimentar US$ 236 bilhões em 2024");
            ListBoxNoticias.Items.Add("Exportações do agro mineiro batem novo recorde no período de janeiro a abril  (Exame)");
            ListBoxNoticias.Items.Add("Educação no agro: por que crianças devem saber mais sobre alimentos e cultivos (Forbes)");
            ListBoxNoticias.Items.Add("PIB paulista cresce 2,3% em março impulsionado pelo agro e indústria (Governo do Estado de São Paulo)");
            ListBoxNoticias.Items.Add("Combate ao Greening: SP cria linha de crédito para citricultores (Band)");
            ListBoxNoticias.Items.Add("Agro do RS estima perdas de R$ 3 bi e uma década para recuperar produções inundadas (CNN)");

            // Adicionar manchetes ao ListBoxNoticiasInternas
            ListBoxNoticiasInternas.Items.Add("Atualização do sistema agendada para: 11/06/2024");

            // Carregar as imagens
            images = new Image[]
            {
                Properties.Resources.slideshow1,
                Properties.Resources.slideshow2,
                Properties.Resources.slideshow3,
                Properties.Resources.slideshow4,
                Properties.Resources.slideshow5,
                Properties.Resources.slideshow6,
                Properties.Resources.slideshow7,
                Properties.Resources.slideshow8,
                Properties.Resources.slideshow9,
                Properties.Resources.slideshow10,
                Properties.Resources.slideshow11,
                // Adicionar mais imagens conforme necessário
            };

            // Configurar PictureBox
            PictureBoxSlideShow.Image = images[currentImageIndex];
            PictureBoxSlideShow.Paint += PictureBoxSlideshow_Paint;

            // Configurar Timer
            TimerSlideShow.Interval = 7000; // Intervalo entre as imagens, em milissegundos
            TimerSlideShow.Tick += TimerSlideShow_Tick;

            TimerFade.Interval = 1; // Efeito de transição, em milissegundos
            TimerFade.Tick += TimerFade_Tick;

            TimerSlideShow.Start();

        }

        private void AtualizarInterfaceUsuario()
        {
            if (Program.UsuarioLogado != null)
            {
                string nomeUsuario = Program.UsuarioLogado.Nome;
                var words = nomeUsuario.Split(' ');
                if (words.Length == 1)
                {
                    nomeUsuario = words[0]; // Apenas uma palavra no nome
                }
                else
                {
                    nomeUsuario = $"{words[0]} {words[words.Length - 1]}"; // Primeira e última palavra
                }

                LabelBemVindo.Text = $"Bem-vindo(a), {nomeUsuario}";

                // Medir o tamanho do texto
                Size textSize = TextRenderer.MeasureText(LabelBemVindo.Text, LabelBemVindo.Font);

                // Calcular a nova posição da label com base no tamanho do texto
                int deslocamento = textSize.Width;

                // Ajustar a posição horizontal da label para mover à esquerda com base no comprimento do texto
                int novaPosicaoX = ClientSize.Width - deslocamento - 150;

                // Definir a nova localização
                LabelBemVindo.Location = new Point(novaPosicaoX, LabelBemVindo.Location.Y);
            }
        }

        private void TimerFade_Tick(object sender, EventArgs e)
        {
            // Metade do tempo total para cada fase da transição
            int halfFadeTime = TimerFade.Interval / 2;

            // Gradualmente diminuir a opacidade da imagem atual
            if (currentOpacity > 0 && TimerFade.Tag.ToString() == "fadeout")
            {
                currentOpacity -= opacityIncrement;
                if (currentOpacity <= 0)
                {
                    currentOpacity = 0;
                    TimerFade.Tag = "fadein"; // Alterna para a próxima fase da transição

                    // Alternar para a próxima imagem
                    currentImageIndex = (currentImageIndex + 1) % images.Length;
                    PictureBoxSlideShow.Image = images[currentImageIndex];
                }
            }
            // Gradualmente aumentar a opacidade da próxima imagem
            else if (currentOpacity < 1 && TimerFade.Tag.ToString() == "fadein")
            {
                currentOpacity += opacityIncrement;
                if (currentOpacity >= 1)
                {
                    currentOpacity = 1;
                    TimerFade.Stop(); // Fim da transição
                }
            }

            PictureBoxSlideShow.Invalidate(); // Forçar o redesenho do PictureBox
        }

        private void TimerSlideShow_Tick(object sender, EventArgs e)
        {
            currentOpacity = 1.0f;
            TimerFade.Tag = "fadeout"; // Inicia a transição
            TimerFade.Start();
        }

        private void PictureBoxSlideshow_Paint(object sender, PaintEventArgs e)
        {
            // Aplicar a opacidade atual
            e.Graphics.Clear(PictureBoxSlideShow.BackColor);
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = currentOpacity;
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            e.Graphics.DrawImage(PictureBoxSlideShow.Image, new Rectangle(0, 0, PictureBoxSlideShow.Width, PictureBoxSlideShow.Height), 0, 0, PictureBoxSlideShow.Image.Width, PictureBoxSlideShow.Image.Height, GraphicsUnit.Pixel, attributes);
        }

        private void PictureBoxFuncionarios_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioLogado == null)
            {
                MessageBox.Show("Acesso permitido para testes.", "Acesso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaFuncionarios telaUser = new TelaFuncionarios();
                telaUser.ShowDialog();
            }
            else
            {
                if (Program.UsuarioLogado.Cargo != "Gerente")
                {
                    MessageBox.Show("Acesso negado: usuário deve ser Gerente para acessar menu de funcionários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TelaFuncionarios telaUser = new TelaFuncionarios();
                    telaUser.ShowDialog();
                }
            }
        }

        private void PictureBoxClientes_Click(object sender, EventArgs e)
        {
            TelaClientes telaListarClientes = new TelaClientes();
            telaListarClientes.Show();
        }

        private void PictureBoxFornecedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores telaListarFornecedores = new TelaFornecedores();
            telaListarFornecedores.Show();
        }

        private void PictureBoxInsumos_Click(object sender, EventArgs e)
        {
            TelaInsumo telaInsumo = new TelaInsumo();
            telaInsumo.Show();
        }

        private void PictureBoxProducao_Click(object sender, EventArgs e)
        {
            TelaProducao telaCultivo = new TelaProducao();
            telaCultivo.Show();
        }

        private void PictureBoxCompras_Click(object sender, EventArgs e)
        {
            TelaCompra telaCompra = new TelaCompra();
            telaCompra.Show();
        }

        private void PictureBoxVendas_Click(object sender, EventArgs e)
        {
            TelaVenda telaVenda = new TelaVenda();
            telaVenda.Show();
        }

        private void PictureBoxRecomendarPlantio_Click(object sender, EventArgs e)
        {
            TelaRecomendacao telaRecomendacao = new TelaRecomendacao();
            telaRecomendacao.Show();
        }

        private void PictureBoxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxLogoff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Você realmente deseja fazer logoff? Suas notas atuais serão perdidas.",
                "Confirmar Logoff",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Program.UsuarioLogado = null;
                Application.Restart();
            }
        }

        private void BotaoAbrirTelaDeTeste_Click(object sender, EventArgs e)
        {
            TelaTeste telaTeste = new TelaTeste();
            telaTeste.Show();
        }

        private void ListBoxNoticias_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = ListBoxNoticias.Items[e.Index].ToString();
            Font myFont = new Font("Segoe UI", 9, FontStyle.Bold);

            // Medir o tamanho necessário para o texto
            SizeF size = e.Graphics.MeasureString(itemText, myFont, ListBoxNoticias.Width);
            e.ItemHeight = (int)size.Height + 20; // Adicionar espaçamento entre linhas e espaço para o separador
        }

        private void ListBoxNoticias_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = ListBoxNoticias.Items[e.Index].ToString();
            Font myFont = new Font("Segoe UI", 9, FontStyle.Bold);
            string bullet = "\u2022 "; // Código Unicode para marcador de lista

            // Definir a cor da fonte
            Color fontColor = Color.Green;

            // Definir a área de desenho
            Rectangle bounds = e.Bounds;
            bounds.X += 15; // Indentar um pouco para o marcador

            // Desenhar o fundo
            e.DrawBackground();

            // Desenhar o texto com o marcador de lista e quebra de linha automática
            using (Brush textBrush = new SolidBrush(fontColor))
            {
                e.Graphics.DrawString(bullet + itemText, myFont, textBrush, bounds);
            }

            // Desenhar o separador de linha
            int separatorY = e.Bounds.Bottom - 10;
            e.Graphics.DrawLine(Pens.Gray, e.Bounds.Left, separatorY, e.Bounds.Right, separatorY);

            // Desenhar o foco se o item estiver selecionado
            e.DrawFocusRectangle();
        }

        private void ListBoxNoticiasInternas_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = ListBoxNoticiasInternas.Items[e.Index].ToString();
            Font myFont = new Font("Segoe UI", 9, FontStyle.Bold);

            // Medir o tamanho necessário para o texto
            SizeF size = e.Graphics.MeasureString(itemText, myFont, ListBoxNoticiasInternas.Width);
            e.ItemHeight = (int)size.Height + 20; // Adicionar espaçamento entre linhas e espaço para o separador
        }

        private void ListBoxNoticiasInternas_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = ListBoxNoticiasInternas.Items[e.Index].ToString();
            Font myFont = new Font("Segoe UI", 9, FontStyle.Bold);
            string bullet = "\u2022 "; // Código Unicode para marcador de lista

            // Definir a cor da fonte
            Color fontColor = Color.Green;

            // Definir a área de desenho
            Rectangle bounds = e.Bounds;
            bounds.X += 15; // Indentar um pouco para o marcador

            // Desenhar o fundo
            e.DrawBackground();

            // Desenhar o texto com o marcador de lista e quebra de linha automática
            using (Brush textBrush = new SolidBrush(fontColor))
            {
                e.Graphics.DrawString(bullet + itemText, myFont, textBrush, bounds);
            }

            // Desenhar o separador de linha
            int separatorY = e.Bounds.Bottom - 10;
            e.Graphics.DrawLine(Pens.Gray, e.Bounds.Left, separatorY, e.Bounds.Right, separatorY);

            // Desenhar o foco se o item estiver selecionado
            e.DrawFocusRectangle();
        }

        private void PictureBoxFuncionarios_MouseHover(object sender, EventArgs e)
        {
            ToolTipUsuarios.SetToolTip(PictureBoxFuncionarios, "Funcionários");
        }

        private void PictureBoxClientes_MouseHover(object sender, EventArgs e)
        {
            ToolTipClientes.SetToolTip(PictureBoxClientes, "Clientes");
        }

        private void PictureBoxFornecedores_MouseHover(object sender, EventArgs e)
        {
            ToolTipFornecedores.SetToolTip(PictureBoxFornecedores, "Fornecedores");
        }

        private void PictureBoxInsumos_MouseHover(object sender, EventArgs e)
        {
            ToolTipInsumos.SetToolTip(PictureBoxInsumos, "Insumos");
        }

        private void PictureBoxProducao_MouseHover(object sender, EventArgs e)
        {
            ToolTipProducao.SetToolTip(PictureBoxProducao, "Produção");
        }

        private void PictureBoxCompras_MouseHover(object sender, EventArgs e)
        {
            ToolTipCompras.SetToolTip(PictureBoxCompras, "Compras");
        }

        private void PictureBoxVendas_MouseHover(object sender, EventArgs e)
        {
            ToolTipVendas.SetToolTip(PictureBoxVendas, "Vendas");
        }

        private void PictureBoxRecomendarPlantio_MouseHover(object sender, EventArgs e)
        {
            ToolTipRecomendarPlantio.SetToolTip(PictureBoxRecomendarPlantio, "Recomendar Plantio");
        }

    }
}

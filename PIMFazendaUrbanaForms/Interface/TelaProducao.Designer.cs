namespace PIMFazendaUrbanaForms
{
    partial class TelaProducao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProducao));
            PanelHeader = new Panel();
            MaskedTextBoxPeriodo2 = new MaskedTextBox();
            PictureBoxRelatorio = new PictureBox();
            LabelA = new Label();
            LabelRelatorio = new Label();
            MaskedTextBoxPeriodo1 = new MaskedTextBox();
            PictureBoxFinalizarProducao = new PictureBox();
            LabelFinalizarProducao = new Label();
            LabelPeríodo = new Label();
            PictureBoxPesquisar = new PictureBox();
            PictureBoxCadastrarProducao = new PictureBox();
            TextBoxPesquisarProducoes = new TextBox();
            LabelCadastrarSaida = new Label();
            LabelPesquisar = new Label();
            LabelPesquisarProducoes = new Label();
            TextBoxPesquisar = new TextBox();
            PictureBoxHome = new PictureBox();
            LabelHome = new Label();
            LabelPesquisarCultivo = new Label();
            PictureBoxAtualizar = new PictureBox();
            PictureBoxEditarCultivo = new PictureBox();
            PictureBoxDeletarCultivo = new PictureBox();
            LabelAtualizar = new Label();
            PictureBoxIncluir = new PictureBox();
            LabelDeletar = new Label();
            LabelIncluir = new Label();
            LabelEditar = new Label();
            DataGridViewListaCultivos = new DataGridView();
            PanelFooter = new Panel();
            label1 = new Label();
            LabelCultivos = new Label();
            LabelRegistroSaida = new Label();
            DataGridViewProducao = new DataGridView();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFinalizarProducao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCadastrarProducao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditarCultivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletarCultivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaCultivos).BeginInit();
            PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducao).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(MaskedTextBoxPeriodo2);
            PanelHeader.Controls.Add(PictureBoxRelatorio);
            PanelHeader.Controls.Add(LabelA);
            PanelHeader.Controls.Add(LabelRelatorio);
            PanelHeader.Controls.Add(MaskedTextBoxPeriodo1);
            PanelHeader.Controls.Add(PictureBoxFinalizarProducao);
            PanelHeader.Controls.Add(LabelFinalizarProducao);
            PanelHeader.Controls.Add(LabelPeríodo);
            PanelHeader.Controls.Add(PictureBoxPesquisar);
            PanelHeader.Controls.Add(PictureBoxCadastrarProducao);
            PanelHeader.Controls.Add(TextBoxPesquisarProducoes);
            PanelHeader.Controls.Add(LabelCadastrarSaida);
            PanelHeader.Controls.Add(LabelPesquisar);
            PanelHeader.Controls.Add(LabelPesquisarProducoes);
            PanelHeader.Controls.Add(TextBoxPesquisar);
            PanelHeader.Controls.Add(PictureBoxHome);
            PanelHeader.Controls.Add(LabelHome);
            PanelHeader.Controls.Add(LabelPesquisarCultivo);
            PanelHeader.Controls.Add(PictureBoxAtualizar);
            PanelHeader.Controls.Add(PictureBoxEditarCultivo);
            PanelHeader.Controls.Add(PictureBoxDeletarCultivo);
            PanelHeader.Controls.Add(LabelAtualizar);
            PanelHeader.Controls.Add(PictureBoxIncluir);
            PanelHeader.Controls.Add(LabelDeletar);
            PanelHeader.Controls.Add(LabelIncluir);
            PanelHeader.Controls.Add(LabelEditar);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1533, 60);
            PanelHeader.TabIndex = 53;
            // 
            // MaskedTextBoxPeriodo2
            // 
            MaskedTextBoxPeriodo2.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxPeriodo2.Location = new Point(1027, 33);
            MaskedTextBoxPeriodo2.Mask = "00/00/0000";
            MaskedTextBoxPeriodo2.Name = "MaskedTextBoxPeriodo2";
            MaskedTextBoxPeriodo2.Size = new Size(78, 23);
            MaskedTextBoxPeriodo2.TabIndex = 73;
            MaskedTextBoxPeriodo2.ValidatingType = typeof(DateTime);
            // 
            // PictureBoxRelatorio
            // 
            PictureBoxRelatorio.Image = Properties.Resources.ExportarRelatorio;
            PictureBoxRelatorio.Location = new Point(1357, 10);
            PictureBoxRelatorio.Name = "PictureBoxRelatorio";
            PictureBoxRelatorio.Size = new Size(29, 25);
            PictureBoxRelatorio.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRelatorio.TabIndex = 70;
            PictureBoxRelatorio.TabStop = false;
            PictureBoxRelatorio.Click += PictureBoxRelatorio_Click;
            // 
            // LabelA
            // 
            LabelA.AutoSize = true;
            LabelA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelA.ForeColor = Color.White;
            LabelA.Location = new Point(1008, 34);
            LabelA.Name = "LabelA";
            LabelA.Size = new Size(15, 17);
            LabelA.TabIndex = 78;
            LabelA.Text = "a";
            // 
            // LabelRelatorio
            // 
            LabelRelatorio.AutoSize = true;
            LabelRelatorio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRelatorio.ForeColor = Color.White;
            LabelRelatorio.Location = new Point(1343, 36);
            LabelRelatorio.Name = "LabelRelatorio";
            LabelRelatorio.Size = new Size(62, 17);
            LabelRelatorio.TabIndex = 71;
            LabelRelatorio.Text = "Relatório";
            // 
            // MaskedTextBoxPeriodo1
            // 
            MaskedTextBoxPeriodo1.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxPeriodo1.Location = new Point(926, 33);
            MaskedTextBoxPeriodo1.Mask = "00/00/0000";
            MaskedTextBoxPeriodo1.Name = "MaskedTextBoxPeriodo1";
            MaskedTextBoxPeriodo1.Size = new Size(78, 23);
            MaskedTextBoxPeriodo1.TabIndex = 72;
            MaskedTextBoxPeriodo1.ValidatingType = typeof(DateTime);
            // 
            // PictureBoxFinalizarProducao
            // 
            PictureBoxFinalizarProducao.Image = Properties.Resources.SaidaDeEstoque;
            PictureBoxFinalizarProducao.Location = new Point(1281, 10);
            PictureBoxFinalizarProducao.Name = "PictureBoxFinalizarProducao";
            PictureBoxFinalizarProducao.Size = new Size(29, 25);
            PictureBoxFinalizarProducao.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxFinalizarProducao.TabIndex = 63;
            PictureBoxFinalizarProducao.TabStop = false;
            PictureBoxFinalizarProducao.Click += PictureBoxFinalizarProducao_Click;
            // 
            // LabelFinalizarProducao
            // 
            LabelFinalizarProducao.AutoSize = true;
            LabelFinalizarProducao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFinalizarProducao.ForeColor = Color.White;
            LabelFinalizarProducao.Location = new Point(1269, 36);
            LabelFinalizarProducao.Name = "LabelFinalizarProducao";
            LabelFinalizarProducao.Size = new Size(57, 17);
            LabelFinalizarProducao.TabIndex = 64;
            LabelFinalizarProducao.Text = "Finalizar";
            // 
            // LabelPeríodo
            // 
            LabelPeríodo.AutoSize = true;
            LabelPeríodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPeríodo.ForeColor = Color.White;
            LabelPeríodo.Location = new Point(860, 34);
            LabelPeríodo.Name = "LabelPeríodo";
            LabelPeríodo.Size = new Size(60, 17);
            LabelPeríodo.TabIndex = 77;
            LabelPeríodo.Text = "Período:";
            // 
            // PictureBoxPesquisar
            // 
            PictureBoxPesquisar.Image = Properties.Resources.Pesquisar;
            PictureBoxPesquisar.Location = new Point(1127, 10);
            PictureBoxPesquisar.Name = "PictureBoxPesquisar";
            PictureBoxPesquisar.Size = new Size(29, 25);
            PictureBoxPesquisar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxPesquisar.TabIndex = 74;
            PictureBoxPesquisar.TabStop = false;
            PictureBoxPesquisar.Click += PictureBoxPesquisar_Click;
            // 
            // PictureBoxCadastrarProducao
            // 
            PictureBoxCadastrarProducao.Image = Properties.Resources.Incluir;
            PictureBoxCadastrarProducao.Location = new Point(1204, 10);
            PictureBoxCadastrarProducao.Name = "PictureBoxCadastrarProducao";
            PictureBoxCadastrarProducao.Size = new Size(29, 25);
            PictureBoxCadastrarProducao.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxCadastrarProducao.TabIndex = 61;
            PictureBoxCadastrarProducao.TabStop = false;
            PictureBoxCadastrarProducao.Click += PictureBoxCadastrarProducao_Click;
            // 
            // TextBoxPesquisarProducoes
            // 
            TextBoxPesquisarProducoes.Location = new Point(926, 4);
            TextBoxPesquisarProducoes.Name = "TextBoxPesquisarProducoes";
            TextBoxPesquisarProducoes.PlaceholderText = "Digite o nome do cultivo";
            TextBoxPesquisarProducoes.Size = new Size(179, 23);
            TextBoxPesquisarProducoes.TabIndex = 71;
            TextBoxPesquisarProducoes.Click += TextBoxPesquisarProducoes_Click;
            TextBoxPesquisarProducoes.TextChanged += TextBoxPesquisarProducoes_TextChanged;
            // 
            // LabelCadastrarSaida
            // 
            LabelCadastrarSaida.AutoSize = true;
            LabelCadastrarSaida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarSaida.ForeColor = Color.White;
            LabelCadastrarSaida.Location = new Point(1187, 36);
            LabelCadastrarSaida.Name = "LabelCadastrarSaida";
            LabelCadastrarSaida.Size = new Size(66, 17);
            LabelCadastrarSaida.TabIndex = 62;
            LabelCadastrarSaida.Text = "Cadastrar";
            // 
            // LabelPesquisar
            // 
            LabelPesquisar.AutoSize = true;
            LabelPesquisar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisar.ForeColor = Color.White;
            LabelPesquisar.Location = new Point(1112, 35);
            LabelPesquisar.Name = "LabelPesquisar";
            LabelPesquisar.Size = new Size(66, 17);
            LabelPesquisar.TabIndex = 75;
            LabelPesquisar.Text = "Pesquisar";
            // 
            // LabelPesquisarProducoes
            // 
            LabelPesquisarProducoes.AutoSize = true;
            LabelPesquisarProducoes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisarProducoes.ForeColor = Color.White;
            LabelPesquisarProducoes.Location = new Point(781, 5);
            LabelPesquisarProducoes.Name = "LabelPesquisarProducoes";
            LabelPesquisarProducoes.Size = new Size(139, 17);
            LabelPesquisarProducoes.TabIndex = 76;
            LabelPesquisarProducoes.Text = "Pesquisar Produções:";
            // 
            // TextBoxPesquisar
            // 
            TextBoxPesquisar.Location = new Point(204, 19);
            TextBoxPesquisar.Name = "TextBoxPesquisar";
            TextBoxPesquisar.PlaceholderText = "Digite o nome do cultivo";
            TextBoxPesquisar.Size = new Size(287, 23);
            TextBoxPesquisar.TabIndex = 2;
            TextBoxPesquisar.TextChanged += TextBoxPesquisar_TextChanged;
            // 
            // PictureBoxHome
            // 
            PictureBoxHome.AccessibleDescription = "Usuarios";
            PictureBoxHome.AccessibleName = "Usuarios";
            PictureBoxHome.AccessibleRole = AccessibleRole.TitleBar;
            PictureBoxHome.Image = Properties.Resources.Home;
            PictureBoxHome.Location = new Point(12, 4);
            PictureBoxHome.Name = "PictureBoxHome";
            PictureBoxHome.Size = new Size(40, 37);
            PictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxHome.TabIndex = 18;
            PictureBoxHome.TabStop = false;
            PictureBoxHome.Click += PictureBoxHome_Click;
            // 
            // LabelHome
            // 
            LabelHome.AutoSize = true;
            LabelHome.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelHome.ForeColor = SystemColors.ControlLightLight;
            LabelHome.Location = new Point(14, 41);
            LabelHome.Name = "LabelHome";
            LabelHome.Size = new Size(38, 13);
            LabelHome.TabIndex = 46;
            LabelHome.Text = "Home";
            // 
            // LabelPesquisarCultivo
            // 
            LabelPesquisarCultivo.AutoSize = true;
            LabelPesquisarCultivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisarCultivo.ForeColor = Color.White;
            LabelPesquisarCultivo.Location = new Point(74, 20);
            LabelPesquisarCultivo.Name = "LabelPesquisarCultivo";
            LabelPesquisarCultivo.Size = new Size(125, 17);
            LabelPesquisarCultivo.TabIndex = 53;
            LabelPesquisarCultivo.Text = "Pesquisar Cultivos:";
            // 
            // PictureBoxAtualizar
            // 
            PictureBoxAtualizar.Image = (Image)resources.GetObject("PictureBoxAtualizar.Image");
            PictureBoxAtualizar.Location = new Point(676, 10);
            PictureBoxAtualizar.Name = "PictureBoxAtualizar";
            PictureBoxAtualizar.Size = new Size(29, 25);
            PictureBoxAtualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAtualizar.TabIndex = 51;
            PictureBoxAtualizar.TabStop = false;
            PictureBoxAtualizar.Click += PictureBoxAtualizar_Click;
            // 
            // PictureBoxEditarCultivo
            // 
            PictureBoxEditarCultivo.Image = (Image)resources.GetObject("PictureBoxEditarCultivo.Image");
            PictureBoxEditarCultivo.Location = new Point(560, 10);
            PictureBoxEditarCultivo.Name = "PictureBoxEditarCultivo";
            PictureBoxEditarCultivo.Size = new Size(29, 25);
            PictureBoxEditarCultivo.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxEditarCultivo.TabIndex = 44;
            PictureBoxEditarCultivo.TabStop = false;
            PictureBoxEditarCultivo.Click += PictureBoxEditarCultivo_Click;
            // 
            // PictureBoxDeletarCultivo
            // 
            PictureBoxDeletarCultivo.Image = (Image)resources.GetObject("PictureBoxDeletarCultivo.Image");
            PictureBoxDeletarCultivo.Location = new Point(618, 10);
            PictureBoxDeletarCultivo.Name = "PictureBoxDeletarCultivo";
            PictureBoxDeletarCultivo.Size = new Size(29, 25);
            PictureBoxDeletarCultivo.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxDeletarCultivo.TabIndex = 45;
            PictureBoxDeletarCultivo.TabStop = false;
            PictureBoxDeletarCultivo.Click += PictureBoxDeletarCultivo_Click;
            // 
            // LabelAtualizar
            // 
            LabelAtualizar.AutoSize = true;
            LabelAtualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelAtualizar.ForeColor = Color.White;
            LabelAtualizar.Location = new Point(662, 35);
            LabelAtualizar.Name = "LabelAtualizar";
            LabelAtualizar.Size = new Size(61, 17);
            LabelAtualizar.TabIndex = 50;
            LabelAtualizar.Text = "Atualizar";
            // 
            // PictureBoxIncluir
            // 
            PictureBoxIncluir.Image = (Image)resources.GetObject("PictureBoxIncluir.Image");
            PictureBoxIncluir.Location = new Point(504, 10);
            PictureBoxIncluir.Name = "PictureBoxIncluir";
            PictureBoxIncluir.Size = new Size(29, 25);
            PictureBoxIncluir.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxIncluir.TabIndex = 46;
            PictureBoxIncluir.TabStop = false;
            PictureBoxIncluir.Click += PictureBoxIncluir_Click;
            // 
            // LabelDeletar
            // 
            LabelDeletar.AutoSize = true;
            LabelDeletar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelDeletar.ForeColor = Color.White;
            LabelDeletar.Location = new Point(609, 35);
            LabelDeletar.Name = "LabelDeletar";
            LabelDeletar.Size = new Size(51, 17);
            LabelDeletar.TabIndex = 49;
            LabelDeletar.Text = "Deletar";
            // 
            // LabelIncluir
            // 
            LabelIncluir.AutoSize = true;
            LabelIncluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIncluir.ForeColor = Color.White;
            LabelIncluir.Location = new Point(497, 35);
            LabelIncluir.Name = "LabelIncluir";
            LabelIncluir.Size = new Size(45, 17);
            LabelIncluir.TabIndex = 47;
            LabelIncluir.Text = "Incluir";
            // 
            // LabelEditar
            // 
            LabelEditar.AutoSize = true;
            LabelEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelEditar.ForeColor = Color.White;
            LabelEditar.Location = new Point(555, 35);
            LabelEditar.Name = "LabelEditar";
            LabelEditar.Size = new Size(43, 17);
            LabelEditar.TabIndex = 48;
            LabelEditar.Text = "Editar";
            // 
            // DataGridViewListaCultivos
            // 
            DataGridViewListaCultivos.AllowUserToAddRows = false;
            DataGridViewListaCultivos.AllowUserToDeleteRows = false;
            DataGridViewListaCultivos.BackgroundColor = SystemColors.Menu;
            DataGridViewListaCultivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewListaCultivos.Location = new Point(56, 93);
            DataGridViewListaCultivos.Name = "DataGridViewListaCultivos";
            DataGridViewListaCultivos.ReadOnly = true;
            DataGridViewListaCultivos.RowHeadersWidth = 27;
            DataGridViewListaCultivos.Size = new Size(667, 645);
            DataGridViewListaCultivos.TabIndex = 0;
            DataGridViewListaCultivos.VirtualMode = true;
            // 
            // PanelFooter
            // 
            PanelFooter.BackColor = Color.FromArgb(120, 220, 120);
            PanelFooter.Controls.Add(label1);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.ForeColor = Color.White;
            PanelFooter.Location = new Point(0, 694);
            PanelFooter.Margin = new Padding(5);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(1533, 35);
            PanelFooter.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(615, 5);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 0;
            label1.Text = "FARM SYSTEM | VERSÃO 1.0";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelCultivos
            // 
            LabelCultivos.AutoSize = true;
            LabelCultivos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCultivos.ForeColor = Color.DarkGreen;
            LabelCultivos.Location = new Point(56, 73);
            LabelCultivos.Name = "LabelCultivos";
            LabelCultivos.Size = new Size(141, 17);
            LabelCultivos.TabIndex = 58;
            LabelCultivos.Text = "Cultivos Cadastrados:";
            // 
            // LabelRegistroSaida
            // 
            LabelRegistroSaida.AutoSize = true;
            LabelRegistroSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRegistroSaida.ForeColor = Color.DarkGreen;
            LabelRegistroSaida.Location = new Point(781, 73);
            LabelRegistroSaida.Name = "LabelRegistroSaida";
            LabelRegistroSaida.Size = new Size(152, 17);
            LabelRegistroSaida.TabIndex = 59;
            LabelRegistroSaida.Text = "Produções cadastradas:";
            // 
            // DataGridViewProducao
            // 
            DataGridViewProducao.AllowUserToAddRows = false;
            DataGridViewProducao.AllowUserToDeleteRows = false;
            DataGridViewProducao.BackgroundColor = SystemColors.Menu;
            DataGridViewProducao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProducao.Location = new Point(781, 93);
            DataGridViewProducao.Name = "DataGridViewProducao";
            DataGridViewProducao.ReadOnly = true;
            DataGridViewProducao.RowHeadersWidth = 27;
            DataGridViewProducao.Size = new Size(700, 645);
            DataGridViewProducao.TabIndex = 1;
            DataGridViewProducao.VirtualMode = true;
            DataGridViewProducao.DataBindingComplete += DataGridViewProducao_DataBindingComplete;
            // 
            // TelaProducao
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1533, 729);
            Controls.Add(PanelFooter);
            Controls.Add(DataGridViewProducao);
            Controls.Add(LabelRegistroSaida);
            Controls.Add(LabelCultivos);
            Controls.Add(DataGridViewListaCultivos);
            Controls.Add(PanelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaProducao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produção";
            WindowState = FormWindowState.Maximized;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFinalizarProducao).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCadastrarProducao).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditarCultivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletarCultivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaCultivos).EndInit();
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private PictureBox PictureBoxHome;
        private Label LabelHome;
        private Label LabelPesquisarCultivo;
        private PictureBox PictureBoxAtualizar;
        private PictureBox PictureBoxEditarCultivo;
        private PictureBox PictureBoxDeletarCultivo;
        private Label LabelAtualizar;
        private PictureBox PictureBoxIncluir;
        private Label LabelDeletar;
        private Label LabelIncluir;
        private Label LabelEditar;
        private DataGridView DataGridViewListaCultivos;
        private Panel PanelFooter;
        private Label label1;
        private TextBox TextBoxPesquisar;
        private Label LabelCultivos;
        private Label LabelRegistroSaida;
        private DataGridView DataGridViewProducao;
        private PictureBox PictureBoxCadastrarProducao;
        private Label LabelCadastrarSaida;
        private PictureBox PictureBoxFinalizarProducao;
        private Label LabelFinalizarProducao;
        private PictureBox PictureBoxRelatorio;
        private Label LabelRelatorio;
        private MaskedTextBox MaskedTextBoxPeriodo2;
        private Label LabelA;
        private MaskedTextBox MaskedTextBoxPeriodo1;
        private Label LabelPeríodo;
        private PictureBox PictureBoxPesquisar;
        private TextBox TextBoxPesquisarProducoes;
        private Label LabelPesquisar;
        private Label LabelPesquisarProducoes;
    }
}
namespace PIMFazendaUrbanaForms
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelHeader = new Panel();
            LabelVendas = new Label();
            PictureBoxVendas = new PictureBox();
            PictureBoxRecomendarPlantio = new PictureBox();
            LabelRecomendarPlantio = new Label();
            PictureBoxLogoff = new PictureBox();
            LabelLogoff = new Label();
            LabelBemVindo = new Label();
            LabelCompras = new Label();
            PictureBoxCompras = new PictureBox();
            LabelProducao = new Label();
            PictureBoxProducao = new PictureBox();
            LabelInsumos = new Label();
            PictureBoxInsumos = new PictureBox();
            LabelFornecedores = new Label();
            PictureBoxFornecedores = new PictureBox();
            LabelClientes = new Label();
            PictureBoxClientes = new PictureBox();
            PictureBoxFuncionarios = new PictureBox();
            LabelFuncionarios = new Label();
            PanelFooter = new Panel();
            LabelFarmSystem = new Label();
            ToolTipUsuarios = new ToolTip(components);
            ToolTipClientes = new ToolTip(components);
            ToolTipFornecedores = new ToolTip(components);
            ToolTipInsumos = new ToolTip(components);
            ToolTipProducao = new ToolTip(components);
            ToolTipInventario = new ToolTip(components);
            ToolTipCompras = new ToolTip(components);
            ToolTipVendas = new ToolTip(components);
            ToolTipRecomendarPlantio = new ToolTip(components);
            PictureBoxLogoFundo = new PictureBox();
            RichTextBoxNotas = new RichTextBox();
            LabelNotas = new Label();
            PictureBoxSlideShow = new PictureBox();
            TimerSlideShow = new System.Windows.Forms.Timer(components);
            TimerFade = new System.Windows.Forms.Timer(components);
            ListBoxNoticias = new ListBox();
            LabelNoticias = new Label();
            ListBoxNoticiasInternas = new ListBox();
            LabelNoticiasInternas = new Label();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRecomendarPlantio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogoff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxProducao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxInsumos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFornecedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFuncionarios).BeginInit();
            PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogoFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSlideShow).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelVendas);
            PanelHeader.Controls.Add(PictureBoxVendas);
            PanelHeader.Controls.Add(PictureBoxRecomendarPlantio);
            PanelHeader.Controls.Add(LabelRecomendarPlantio);
            PanelHeader.Controls.Add(PictureBoxLogoff);
            PanelHeader.Controls.Add(LabelLogoff);
            PanelHeader.Controls.Add(LabelBemVindo);
            PanelHeader.Controls.Add(LabelCompras);
            PanelHeader.Controls.Add(PictureBoxCompras);
            PanelHeader.Controls.Add(LabelProducao);
            PanelHeader.Controls.Add(PictureBoxProducao);
            PanelHeader.Controls.Add(LabelInsumos);
            PanelHeader.Controls.Add(PictureBoxInsumos);
            PanelHeader.Controls.Add(LabelFornecedores);
            PanelHeader.Controls.Add(PictureBoxFornecedores);
            PanelHeader.Controls.Add(LabelClientes);
            PanelHeader.Controls.Add(PictureBoxClientes);
            PanelHeader.Controls.Add(PictureBoxFuncionarios);
            PanelHeader.Controls.Add(LabelFuncionarios);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1536, 67);
            PanelHeader.TabIndex = 1;
            // 
            // LabelVendas
            // 
            LabelVendas.AutoSize = true;
            LabelVendas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelVendas.ForeColor = SystemColors.ControlLightLight;
            LabelVendas.Location = new Point(550, 46);
            LabelVendas.Name = "LabelVendas";
            LabelVendas.Size = new Size(46, 15);
            LabelVendas.TabIndex = 27;
            LabelVendas.Text = "Vendas";
            // 
            // PictureBoxVendas
            // 
            PictureBoxVendas.Image = Properties.Resources.Vendas;
            PictureBoxVendas.Location = new Point(552, 6);
            PictureBoxVendas.Name = "PictureBoxVendas";
            PictureBoxVendas.Size = new Size(40, 37);
            PictureBoxVendas.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxVendas.TabIndex = 26;
            PictureBoxVendas.TabStop = false;
            PictureBoxVendas.Click += PictureBoxVendas_Click;
            PictureBoxVendas.MouseHover += PictureBoxVendas_MouseHover;
            // 
            // PictureBoxRecomendarPlantio
            // 
            PictureBoxRecomendarPlantio.Image = Properties.Resources.RecPlantio;
            PictureBoxRecomendarPlantio.Location = new Point(646, 6);
            PictureBoxRecomendarPlantio.Name = "PictureBoxRecomendarPlantio";
            PictureBoxRecomendarPlantio.Size = new Size(40, 37);
            PictureBoxRecomendarPlantio.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRecomendarPlantio.TabIndex = 25;
            PictureBoxRecomendarPlantio.TabStop = false;
            PictureBoxRecomendarPlantio.Click += PictureBoxRecomendarPlantio_Click;
            // 
            // LabelRecomendarPlantio
            // 
            LabelRecomendarPlantio.AutoSize = true;
            LabelRecomendarPlantio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRecomendarPlantio.ForeColor = SystemColors.ControlLightLight;
            LabelRecomendarPlantio.Location = new Point(611, 46);
            LabelRecomendarPlantio.Name = "LabelRecomendarPlantio";
            LabelRecomendarPlantio.Size = new Size(119, 15);
            LabelRecomendarPlantio.TabIndex = 24;
            LabelRecomendarPlantio.Text = "Recomendar Plantio";
            // 
            // PictureBoxLogoff
            // 
            PictureBoxLogoff.Image = Properties.Resources.Sair;
            PictureBoxLogoff.Location = new Point(1459, 6);
            PictureBoxLogoff.Name = "PictureBoxLogoff";
            PictureBoxLogoff.Size = new Size(40, 37);
            PictureBoxLogoff.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxLogoff.TabIndex = 23;
            PictureBoxLogoff.TabStop = false;
            PictureBoxLogoff.Click += PictureBoxLogoff_Click;
            // 
            // LabelLogoff
            // 
            LabelLogoff.AutoSize = true;
            LabelLogoff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelLogoff.ForeColor = Color.White;
            LabelLogoff.Location = new Point(1442, 44);
            LabelLogoff.Name = "LabelLogoff";
            LabelLogoff.Size = new Size(77, 15);
            LabelLogoff.TabIndex = 8;
            LabelLogoff.Text = "Fazer Logoff";
            // 
            // LabelBemVindo
            // 
            LabelBemVindo.AutoSize = true;
            LabelBemVindo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBemVindo.ForeColor = Color.White;
            LabelBemVindo.Location = new Point(1324, 24);
            LabelBemVindo.Name = "LabelBemVindo";
            LabelBemVindo.Size = new Size(100, 17);
            LabelBemVindo.TabIndex = 22;
            LabelBemVindo.Text = "Bem-vindo(a), ";
            // 
            // LabelCompras
            // 
            LabelCompras.AutoSize = true;
            LabelCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCompras.ForeColor = SystemColors.ControlLightLight;
            LabelCompras.Location = new Point(461, 46);
            LabelCompras.Name = "LabelCompras";
            LabelCompras.Size = new Size(55, 15);
            LabelCompras.TabIndex = 13;
            LabelCompras.Text = "Compras";
            // 
            // PictureBoxCompras
            // 
            PictureBoxCompras.Image = Properties.Resources.Compras;
            PictureBoxCompras.Location = new Point(468, 6);
            PictureBoxCompras.Name = "PictureBoxCompras";
            PictureBoxCompras.Size = new Size(40, 37);
            PictureBoxCompras.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxCompras.TabIndex = 5;
            PictureBoxCompras.TabStop = false;
            PictureBoxCompras.Click += PictureBoxCompras_Click;
            PictureBoxCompras.MouseHover += PictureBoxCompras_MouseHover;
            // 
            // LabelProducao
            // 
            LabelProducao.AutoSize = true;
            LabelProducao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelProducao.ForeColor = SystemColors.ControlLightLight;
            LabelProducao.Location = new Point(374, 46);
            LabelProducao.Name = "LabelProducao";
            LabelProducao.Size = new Size(59, 15);
            LabelProducao.TabIndex = 11;
            LabelProducao.Text = "Produção";
            // 
            // PictureBoxProducao
            // 
            PictureBoxProducao.Image = Properties.Resources.Produtos;
            PictureBoxProducao.Location = new Point(382, 6);
            PictureBoxProducao.Name = "PictureBoxProducao";
            PictureBoxProducao.Size = new Size(40, 37);
            PictureBoxProducao.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxProducao.TabIndex = 3;
            PictureBoxProducao.TabStop = false;
            PictureBoxProducao.Click += PictureBoxProducao_Click;
            PictureBoxProducao.MouseHover += PictureBoxProducao_MouseHover;
            // 
            // LabelInsumos
            // 
            LabelInsumos.AutoSize = true;
            LabelInsumos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelInsumos.ForeColor = SystemColors.ControlLightLight;
            LabelInsumos.Location = new Point(290, 46);
            LabelInsumos.Name = "LabelInsumos";
            LabelInsumos.Size = new Size(53, 15);
            LabelInsumos.TabIndex = 10;
            LabelInsumos.Text = "Insumos";
            // 
            // PictureBoxInsumos
            // 
            PictureBoxInsumos.Image = Properties.Resources.Insumos;
            PictureBoxInsumos.Location = new Point(295, 6);
            PictureBoxInsumos.Name = "PictureBoxInsumos";
            PictureBoxInsumos.Size = new Size(40, 37);
            PictureBoxInsumos.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxInsumos.TabIndex = 7;
            PictureBoxInsumos.TabStop = false;
            PictureBoxInsumos.Click += PictureBoxInsumos_Click;
            PictureBoxInsumos.MouseHover += PictureBoxInsumos_MouseHover;
            // 
            // LabelFornecedores
            // 
            LabelFornecedores.AutoSize = true;
            LabelFornecedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFornecedores.ForeColor = SystemColors.ControlLightLight;
            LabelFornecedores.Location = new Point(191, 46);
            LabelFornecedores.Name = "LabelFornecedores";
            LabelFornecedores.Size = new Size(83, 15);
            LabelFornecedores.TabIndex = 15;
            LabelFornecedores.Text = "Fornecedores";
            // 
            // PictureBoxFornecedores
            // 
            PictureBoxFornecedores.Image = Properties.Resources.Fornecedores;
            PictureBoxFornecedores.Location = new Point(209, 6);
            PictureBoxFornecedores.Name = "PictureBoxFornecedores";
            PictureBoxFornecedores.Size = new Size(40, 37);
            PictureBoxFornecedores.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxFornecedores.TabIndex = 8;
            PictureBoxFornecedores.TabStop = false;
            PictureBoxFornecedores.Click += PictureBoxFornecedores_Click;
            PictureBoxFornecedores.MouseHover += PictureBoxFornecedores_MouseHover;
            // 
            // LabelClientes
            // 
            LabelClientes.AutoSize = true;
            LabelClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelClientes.ForeColor = SystemColors.ControlLightLight;
            LabelClientes.Location = new Point(117, 46);
            LabelClientes.Name = "LabelClientes";
            LabelClientes.Size = new Size(51, 15);
            LabelClientes.TabIndex = 14;
            LabelClientes.Text = "Clientes";
            // 
            // PictureBoxClientes
            // 
            PictureBoxClientes.Image = Properties.Resources.Clientes;
            PictureBoxClientes.Location = new Point(121, 6);
            PictureBoxClientes.Name = "PictureBoxClientes";
            PictureBoxClientes.Size = new Size(40, 37);
            PictureBoxClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxClientes.TabIndex = 2;
            PictureBoxClientes.TabStop = false;
            PictureBoxClientes.Click += PictureBoxClientes_Click;
            PictureBoxClientes.MouseHover += PictureBoxClientes_MouseHover;
            // 
            // PictureBoxFuncionarios
            // 
            PictureBoxFuncionarios.AccessibleDescription = "Usuarios";
            PictureBoxFuncionarios.AccessibleName = "Usuarios";
            PictureBoxFuncionarios.AccessibleRole = AccessibleRole.TitleBar;
            PictureBoxFuncionarios.Image = Properties.Resources.Usuarios;
            PictureBoxFuncionarios.Location = new Point(35, 6);
            PictureBoxFuncionarios.Name = "PictureBoxFuncionarios";
            PictureBoxFuncionarios.Size = new Size(40, 37);
            PictureBoxFuncionarios.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxFuncionarios.TabIndex = 2;
            PictureBoxFuncionarios.TabStop = false;
            PictureBoxFuncionarios.Click += PictureBoxFuncionarios_Click;
            PictureBoxFuncionarios.MouseHover += PictureBoxFuncionarios_MouseHover;
            // 
            // LabelFuncionarios
            // 
            LabelFuncionarios.AutoSize = true;
            LabelFuncionarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFuncionarios.ForeColor = SystemColors.ControlLightLight;
            LabelFuncionarios.Location = new Point(18, 46);
            LabelFuncionarios.Name = "LabelFuncionarios";
            LabelFuncionarios.Size = new Size(76, 15);
            LabelFuncionarios.TabIndex = 2;
            LabelFuncionarios.Text = "Funcionários";
            // 
            // PanelFooter
            // 
            PanelFooter.BackColor = Color.FromArgb(120, 220, 120);
            PanelFooter.Controls.Add(LabelFarmSystem);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.ForeColor = Color.White;
            PanelFooter.Location = new Point(0, 694);
            PanelFooter.Margin = new Padding(5);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(1536, 35);
            PanelFooter.TabIndex = 0;
            // 
            // LabelFarmSystem
            // 
            LabelFarmSystem.AutoSize = true;
            LabelFarmSystem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFarmSystem.Location = new Point(623, 5);
            LabelFarmSystem.Margin = new Padding(5, 0, 5, 0);
            LabelFarmSystem.Name = "LabelFarmSystem";
            LabelFarmSystem.Size = new Size(263, 25);
            LabelFarmSystem.TabIndex = 0;
            LabelFarmSystem.Text = "FARM SYSTEM | VERSÃO 1.0";
            // 
            // PictureBoxLogoFundo
            // 
            PictureBoxLogoFundo.Image = Properties.Resources.Logo;
            PictureBoxLogoFundo.Location = new Point(592, 135);
            PictureBoxLogoFundo.Name = "PictureBoxLogoFundo";
            PictureBoxLogoFundo.Size = new Size(351, 539);
            PictureBoxLogoFundo.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxLogoFundo.TabIndex = 2;
            PictureBoxLogoFundo.TabStop = false;
            // 
            // RichTextBoxNotas
            // 
            RichTextBoxNotas.BackColor = Color.LightGreen;
            RichTextBoxNotas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RichTextBoxNotas.Location = new Point(1135, 140);
            RichTextBoxNotas.Name = "RichTextBoxNotas";
            RichTextBoxNotas.Size = new Size(357, 254);
            RichTextBoxNotas.TabIndex = 3;
            RichTextBoxNotas.Text = "";
            // 
            // LabelNotas
            // 
            LabelNotas.AutoSize = true;
            LabelNotas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNotas.ForeColor = Color.DarkGreen;
            LabelNotas.Location = new Point(1135, 116);
            LabelNotas.Name = "LabelNotas";
            LabelNotas.Size = new Size(199, 17);
            LabelNotas.TabIndex = 4;
            LabelNotas.Text = "Suas notas para a sessão atual:";
            // 
            // PictureBoxSlideShow
            // 
            PictureBoxSlideShow.Location = new Point(1135, 461);
            PictureBoxSlideShow.Name = "PictureBoxSlideShow";
            PictureBoxSlideShow.Size = new Size(357, 238);
            PictureBoxSlideShow.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxSlideShow.TabIndex = 5;
            PictureBoxSlideShow.TabStop = false;
            // 
            // TimerSlideShow
            // 
            TimerSlideShow.Enabled = true;
            TimerSlideShow.Interval = 7000;
            // 
            // TimerFade
            // 
            TimerFade.Interval = 1;
            // 
            // ListBoxNoticias
            // 
            ListBoxNoticias.BackColor = Color.WhiteSmoke;
            ListBoxNoticias.DrawMode = DrawMode.OwnerDrawVariable;
            ListBoxNoticias.ForeColor = Color.Green;
            ListBoxNoticias.FormattingEnabled = true;
            ListBoxNoticias.Location = new Point(51, 140);
            ListBoxNoticias.Name = "ListBoxNoticias";
            ListBoxNoticias.Size = new Size(352, 254);
            ListBoxNoticias.TabIndex = 6;
            ListBoxNoticias.DrawItem += ListBoxNoticias_DrawItem;
            ListBoxNoticias.MeasureItem += ListBoxNoticias_MeasureItem;
            // 
            // LabelNoticias
            // 
            LabelNoticias.AutoSize = true;
            LabelNoticias.ForeColor = Color.DarkGreen;
            LabelNoticias.Location = new Point(51, 110);
            LabelNoticias.Name = "LabelNoticias";
            LabelNoticias.Size = new Size(83, 25);
            LabelNoticias.TabIndex = 7;
            LabelNoticias.Text = "Notícias";
            // 
            // ListBoxNoticiasInternas
            // 
            ListBoxNoticiasInternas.BackColor = Color.WhiteSmoke;
            ListBoxNoticiasInternas.DrawMode = DrawMode.OwnerDrawVariable;
            ListBoxNoticiasInternas.ForeColor = Color.Green;
            ListBoxNoticiasInternas.FormattingEnabled = true;
            ListBoxNoticiasInternas.Location = new Point(51, 461);
            ListBoxNoticiasInternas.Name = "ListBoxNoticiasInternas";
            ListBoxNoticiasInternas.Size = new Size(352, 238);
            ListBoxNoticiasInternas.TabIndex = 8;
            ListBoxNoticiasInternas.DrawItem += ListBoxNoticiasInternas_DrawItem;
            ListBoxNoticiasInternas.MeasureItem += ListBoxNoticiasInternas_MeasureItem;
            // 
            // LabelNoticiasInternas
            // 
            LabelNoticiasInternas.AutoSize = true;
            LabelNoticiasInternas.ForeColor = Color.DarkGreen;
            LabelNoticiasInternas.Location = new Point(52, 431);
            LabelNoticiasInternas.Name = "LabelNoticiasInternas";
            LabelNoticiasInternas.Size = new Size(161, 25);
            LabelNoticiasInternas.TabIndex = 9;
            LabelNoticiasInternas.Text = "Notícias Internas";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1536, 729);
            Controls.Add(LabelNoticiasInternas);
            Controls.Add(ListBoxNoticiasInternas);
            Controls.Add(LabelNoticias);
            Controls.Add(ListBoxNoticias);
            Controls.Add(PictureBoxSlideShow);
            Controls.Add(LabelNotas);
            Controls.Add(RichTextBoxNotas);
            Controls.Add(PictureBoxLogoFundo);
            Controls.Add(PanelFooter);
            Controls.Add(PanelHeader);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farm System";
            WindowState = FormWindowState.Maximized;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRecomendarPlantio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogoff).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxProducao).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxInsumos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFornecedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFuncionarios).EndInit();
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogoFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSlideShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelFooter;
        private Panel PanelHeader;
        private Label LabelFarmSystem;
        private ToolTip ToolTipUsuarios;
        private ToolTip ToolTipClientes;
        private ToolTip ToolTipFornecedores;
        private ToolTip ToolTipInsumos;
        private ToolTip ToolTipProducao;
        private ToolTip ToolTipInventario;
        private ToolTip ToolTipCompras;
        private ToolTip ToolTipVendas;
        private ToolTip ToolTipRecomendarPlantio;
        private Label LabelFuncionarios;
        private Label LabelClientes;
        private Label LabelFornecedores;
        private Label LabelInsumos;
        private Label LabelProducao;
        private Label LabelCompras;
        private Label LabelVendas;
        private Label LabelRecomendarPlantio;
        private PictureBox PictureBoxFuncionarios;
        private PictureBox PictureBoxClientes;
        private PictureBox PictureBoxFornecedores;
        private PictureBox PictureBoxInsumos;
        private PictureBox PictureBoxProducao;
        private PictureBox PictureBoxCompras;
        private PictureBox PictureBoxVendas;
        private PictureBox PictureBoxRecomendarPlantio;
        private PictureBox PictureBoxLogoFundo;
        private RichTextBox RichTextBoxNotas;
        private Label LabelNotas;
        private PictureBox PictureBoxSlideShow;
        private System.Windows.Forms.Timer TimerSlideShow;
        private System.Windows.Forms.Timer TimerFade;
        private ListBox ListBoxNoticias;
        private Label LabelNoticias;
        private Label LabelBemVindo;
        private PictureBox PictureBoxLogoff;
        private Label LabelLogoff;
        private ListBox ListBoxNoticiasInternas;
        private Label LabelNoticiasInternas;

    }
}

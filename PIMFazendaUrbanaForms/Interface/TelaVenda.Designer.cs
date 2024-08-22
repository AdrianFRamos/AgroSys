namespace PIMFazendaUrbanaForms
{
    partial class TelaVenda
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
            LabelEstoqueInsumos = new Label();
            DataGridViewListaProdutos = new DataGridView();
            PanelHeader = new Panel();
            PictureBoxRelatorio2 = new PictureBox();
            LabelRelatorio2 = new Label();
            MaskedTextBoxPeriodo2 = new MaskedTextBox();
            PictureBoxHome = new PictureBox();
            TextBoxPesquisar = new TextBox();
            LabelA = new Label();
            LabelHome = new Label();
            LabelPesquisarProdutoEstoque = new Label();
            MaskedTextBoxPeriodo1 = new MaskedTextBox();
            PictureBoxAtualizar = new PictureBox();
            LabelPeriodo = new Label();
            LabelAtualizar = new Label();
            PictureBoxRelatorio = new PictureBox();
            PictureBoxPesquisar = new PictureBox();
            LabelRelatorio = new Label();
            PictureBoxIncluir = new PictureBox();
            TextBoxProdutosVendidos = new TextBox();
            LabelPesquisar = new Label();
            LabelIncluir = new Label();
            LabelPesquisarVendas = new Label();
            PanelFooter = new Panel();
            label3 = new Label();
            LabelEstoqueInsumo = new Label();
            LabelRegistroDeVendas = new Label();
            DataGridViewRegistroDeVendas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProdutos).BeginInit();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).BeginInit();
            PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroDeVendas).BeginInit();
            SuspendLayout();
            // 
            // LabelEstoqueInsumos
            // 
            LabelEstoqueInsumos.AutoSize = true;
            LabelEstoqueInsumos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEstoqueInsumos.ForeColor = Color.DarkGreen;
            LabelEstoqueInsumos.Location = new Point(94, -72);
            LabelEstoqueInsumos.Name = "LabelEstoqueInsumos";
            LabelEstoqueInsumos.Size = new Size(136, 17);
            LabelEstoqueInsumos.TabIndex = 60;
            LabelEstoqueInsumos.Text = "Estoque de Insumos:";
            // 
            // DataGridViewListaProdutos
            // 
            DataGridViewListaProdutos.AllowUserToAddRows = false;
            DataGridViewListaProdutos.AllowUserToDeleteRows = false;
            DataGridViewListaProdutos.BackgroundColor = SystemColors.Menu;
            DataGridViewListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewListaProdutos.Location = new Point(41, 91);
            DataGridViewListaProdutos.Name = "DataGridViewListaProdutos";
            DataGridViewListaProdutos.ReadOnly = true;
            DataGridViewListaProdutos.RowHeadersWidth = 27;
            DataGridViewListaProdutos.Size = new Size(573, 645);
            DataGridViewListaProdutos.TabIndex = 0;
            DataGridViewListaProdutos.VirtualMode = true;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(PictureBoxRelatorio2);
            PanelHeader.Controls.Add(LabelRelatorio2);
            PanelHeader.Controls.Add(MaskedTextBoxPeriodo2);
            PanelHeader.Controls.Add(PictureBoxHome);
            PanelHeader.Controls.Add(TextBoxPesquisar);
            PanelHeader.Controls.Add(LabelA);
            PanelHeader.Controls.Add(LabelHome);
            PanelHeader.Controls.Add(LabelPesquisarProdutoEstoque);
            PanelHeader.Controls.Add(MaskedTextBoxPeriodo1);
            PanelHeader.Controls.Add(PictureBoxAtualizar);
            PanelHeader.Controls.Add(LabelPeriodo);
            PanelHeader.Controls.Add(LabelAtualizar);
            PanelHeader.Controls.Add(PictureBoxRelatorio);
            PanelHeader.Controls.Add(PictureBoxPesquisar);
            PanelHeader.Controls.Add(LabelRelatorio);
            PanelHeader.Controls.Add(PictureBoxIncluir);
            PanelHeader.Controls.Add(TextBoxProdutosVendidos);
            PanelHeader.Controls.Add(LabelPesquisar);
            PanelHeader.Controls.Add(LabelIncluir);
            PanelHeader.Controls.Add(LabelPesquisarVendas);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1350, 60);
            PanelHeader.TabIndex = 59;
            // 
            // PictureBoxRelatorio2
            // 
            PictureBoxRelatorio2.Image = Properties.Resources.ExportarRelatorio;
            PictureBoxRelatorio2.Location = new Point(1179, 10);
            PictureBoxRelatorio2.Name = "PictureBoxRelatorio2";
            PictureBoxRelatorio2.Size = new Size(29, 25);
            PictureBoxRelatorio2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRelatorio2.TabIndex = 71;
            PictureBoxRelatorio2.TabStop = false;
            PictureBoxRelatorio2.Click += PictureBoxRelatorio2_Click;
            // 
            // LabelRelatorio2
            // 
            LabelRelatorio2.AutoSize = true;
            LabelRelatorio2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRelatorio2.ForeColor = Color.White;
            LabelRelatorio2.Location = new Point(1165, 35);
            LabelRelatorio2.Name = "LabelRelatorio2";
            LabelRelatorio2.Size = new Size(62, 17);
            LabelRelatorio2.TabIndex = 72;
            LabelRelatorio2.Text = "Relatório";
            // 
            // MaskedTextBoxPeriodo2
            // 
            MaskedTextBoxPeriodo2.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxPeriodo2.Location = new Point(886, 33);
            MaskedTextBoxPeriodo2.Mask = "00/00/0000";
            MaskedTextBoxPeriodo2.Name = "MaskedTextBoxPeriodo2";
            MaskedTextBoxPeriodo2.Size = new Size(78, 23);
            MaskedTextBoxPeriodo2.TabIndex = 5;
            MaskedTextBoxPeriodo2.ValidatingType = typeof(DateTime);
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
            // TextBoxPesquisar
            // 
            TextBoxPesquisar.Location = new Point(276, 18);
            TextBoxPesquisar.Name = "TextBoxPesquisar";
            TextBoxPesquisar.PlaceholderText = "Digite o nome do produto";
            TextBoxPesquisar.Size = new Size(270, 23);
            TextBoxPesquisar.TabIndex = 2;
            TextBoxPesquisar.TextChanged += TextBoxPesquisar_TextChanged;
            // 
            // LabelA
            // 
            LabelA.AutoSize = true;
            LabelA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelA.ForeColor = Color.White;
            LabelA.Location = new Point(865, 34);
            LabelA.Name = "LabelA";
            LabelA.Size = new Size(15, 17);
            LabelA.TabIndex = 70;
            LabelA.Text = "a";
            // 
            // LabelHome
            // 
            LabelHome.AutoSize = true;
            LabelHome.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelHome.ForeColor = SystemColors.ControlLightLight;
            LabelHome.Location = new Point(14, 41);
            LabelHome.Name = "LabelHome";
            LabelHome.Size = new Size(38, 13);
            LabelHome.TabIndex = 19;
            LabelHome.Text = "Home";
            // 
            // LabelPesquisarProdutoEstoque
            // 
            LabelPesquisarProdutoEstoque.AutoSize = true;
            LabelPesquisarProdutoEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisarProdutoEstoque.ForeColor = Color.White;
            LabelPesquisarProdutoEstoque.Location = new Point(72, 19);
            LabelPesquisarProdutoEstoque.Name = "LabelPesquisarProdutoEstoque";
            LabelPesquisarProdutoEstoque.Size = new Size(198, 17);
            LabelPesquisarProdutoEstoque.TabIndex = 53;
            LabelPesquisarProdutoEstoque.Text = "Pesquisar Produto no Estoque:";
            // 
            // MaskedTextBoxPeriodo1
            // 
            MaskedTextBoxPeriodo1.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxPeriodo1.Location = new Point(781, 33);
            MaskedTextBoxPeriodo1.Mask = "00/00/0000";
            MaskedTextBoxPeriodo1.Name = "MaskedTextBoxPeriodo1";
            MaskedTextBoxPeriodo1.Size = new Size(78, 23);
            MaskedTextBoxPeriodo1.TabIndex = 4;
            MaskedTextBoxPeriodo1.ValidatingType = typeof(DateTime);
            // 
            // PictureBoxAtualizar
            // 
            PictureBoxAtualizar.Image = Properties.Resources.Atualizar;
            PictureBoxAtualizar.Location = new Point(1113, 10);
            PictureBoxAtualizar.Name = "PictureBoxAtualizar";
            PictureBoxAtualizar.Size = new Size(29, 25);
            PictureBoxAtualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAtualizar.TabIndex = 51;
            PictureBoxAtualizar.TabStop = false;
            PictureBoxAtualizar.Click += PictureBoxAtualizar_Click;
            // 
            // LabelPeriodo
            // 
            LabelPeriodo.AutoSize = true;
            LabelPeriodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPeriodo.ForeColor = Color.White;
            LabelPeriodo.Location = new Point(715, 36);
            LabelPeriodo.Name = "LabelPeriodo";
            LabelPeriodo.Size = new Size(60, 17);
            LabelPeriodo.TabIndex = 68;
            LabelPeriodo.Text = "Período:";
            // 
            // LabelAtualizar
            // 
            LabelAtualizar.AutoSize = true;
            LabelAtualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelAtualizar.ForeColor = Color.White;
            LabelAtualizar.Location = new Point(1099, 35);
            LabelAtualizar.Name = "LabelAtualizar";
            LabelAtualizar.Size = new Size(61, 17);
            LabelAtualizar.TabIndex = 50;
            LabelAtualizar.Text = "Atualizar";
            // 
            // PictureBoxRelatorio
            // 
            PictureBoxRelatorio.Image = Properties.Resources.ExportarRelatorio;
            PictureBoxRelatorio.Location = new Point(566, 10);
            PictureBoxRelatorio.Name = "PictureBoxRelatorio";
            PictureBoxRelatorio.Size = new Size(29, 25);
            PictureBoxRelatorio.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRelatorio.TabIndex = 64;
            PictureBoxRelatorio.TabStop = false;
            PictureBoxRelatorio.Click += PictureBoxRelatorio_Click;
            // 
            // PictureBoxPesquisar
            // 
            PictureBoxPesquisar.Image = Properties.Resources.Pesquisar;
            PictureBoxPesquisar.Location = new Point(992, 10);
            PictureBoxPesquisar.Name = "PictureBoxPesquisar";
            PictureBoxPesquisar.Size = new Size(29, 25);
            PictureBoxPesquisar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxPesquisar.TabIndex = 55;
            PictureBoxPesquisar.TabStop = false;
            PictureBoxPesquisar.Click += PictureBoxPesquisar_Click;
            // 
            // LabelRelatorio
            // 
            LabelRelatorio.AutoSize = true;
            LabelRelatorio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRelatorio.ForeColor = Color.White;
            LabelRelatorio.Location = new Point(552, 35);
            LabelRelatorio.Name = "LabelRelatorio";
            LabelRelatorio.Size = new Size(62, 17);
            LabelRelatorio.TabIndex = 65;
            LabelRelatorio.Text = "Relatório";
            // 
            // PictureBoxIncluir
            // 
            PictureBoxIncluir.Image = Properties.Resources.Incluir;
            PictureBoxIncluir.Location = new Point(1054, 10);
            PictureBoxIncluir.Name = "PictureBoxIncluir";
            PictureBoxIncluir.Size = new Size(29, 25);
            PictureBoxIncluir.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxIncluir.TabIndex = 46;
            PictureBoxIncluir.TabStop = false;
            PictureBoxIncluir.Click += PictureBoxIncluir_Click;
            // 
            // TextBoxProdutosVendidos
            // 
            TextBoxProdutosVendidos.Location = new Point(781, 5);
            TextBoxProdutosVendidos.Name = "TextBoxProdutosVendidos";
            TextBoxProdutosVendidos.PlaceholderText = "Digite o nome do produto";
            TextBoxProdutosVendidos.Size = new Size(183, 23);
            TextBoxProdutosVendidos.TabIndex = 3;
            TextBoxProdutosVendidos.Click += TextBoxProdutosVendidos_Click;
            TextBoxProdutosVendidos.TextChanged += TextBoxProdutosVendidos_TextChanged;
            // 
            // LabelPesquisar
            // 
            LabelPesquisar.AutoSize = true;
            LabelPesquisar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisar.ForeColor = Color.White;
            LabelPesquisar.Location = new Point(976, 35);
            LabelPesquisar.Name = "LabelPesquisar";
            LabelPesquisar.Size = new Size(66, 17);
            LabelPesquisar.TabIndex = 56;
            LabelPesquisar.Text = "Pesquisar";
            // 
            // LabelIncluir
            // 
            LabelIncluir.AutoSize = true;
            LabelIncluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIncluir.ForeColor = Color.White;
            LabelIncluir.Location = new Point(1047, 35);
            LabelIncluir.Name = "LabelIncluir";
            LabelIncluir.Size = new Size(45, 17);
            LabelIncluir.TabIndex = 47;
            LabelIncluir.Text = "Incluir";
            // 
            // LabelPesquisarVendas
            // 
            LabelPesquisarVendas.AutoSize = true;
            LabelPesquisarVendas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisarVendas.ForeColor = Color.White;
            LabelPesquisarVendas.Location = new Point(656, 7);
            LabelPesquisarVendas.Name = "LabelPesquisarVendas";
            LabelPesquisarVendas.Size = new Size(119, 17);
            LabelPesquisarVendas.TabIndex = 67;
            LabelPesquisarVendas.Text = "Pesquisar Vendas:";
            // 
            // PanelFooter
            // 
            PanelFooter.BackColor = Color.FromArgb(120, 220, 120);
            PanelFooter.Controls.Add(label3);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.ForeColor = Color.White;
            PanelFooter.Location = new Point(0, 694);
            PanelFooter.Margin = new Padding(5);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(1350, 35);
            PanelFooter.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(615, 5);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(263, 25);
            label3.TabIndex = 0;
            label3.Text = "FARM SYSTEM | VERSÃO 1.0";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelEstoqueInsumo
            // 
            LabelEstoqueInsumo.AutoSize = true;
            LabelEstoqueInsumo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEstoqueInsumo.ForeColor = Color.DarkGreen;
            LabelEstoqueInsumo.Location = new Point(41, 71);
            LabelEstoqueInsumo.Name = "LabelEstoqueInsumo";
            LabelEstoqueInsumo.Size = new Size(140, 17);
            LabelEstoqueInsumo.TabIndex = 62;
            LabelEstoqueInsumo.Text = "Estoque de Produtos:";
            // 
            // LabelRegistroDeVendas
            // 
            LabelRegistroDeVendas.AutoSize = true;
            LabelRegistroDeVendas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRegistroDeVendas.ForeColor = Color.DarkGreen;
            LabelRegistroDeVendas.Location = new Point(656, 71);
            LabelRegistroDeVendas.Name = "LabelRegistroDeVendas";
            LabelRegistroDeVendas.Size = new Size(203, 17);
            LabelRegistroDeVendas.TabIndex = 64;
            LabelRegistroDeVendas.Text = "Registro de Venda de Produtos:";
            // 
            // DataGridViewRegistroDeVendas
            // 
            DataGridViewRegistroDeVendas.AllowUserToAddRows = false;
            DataGridViewRegistroDeVendas.AllowUserToDeleteRows = false;
            DataGridViewRegistroDeVendas.BackgroundColor = SystemColors.Menu;
            DataGridViewRegistroDeVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRegistroDeVendas.Location = new Point(656, 91);
            DataGridViewRegistroDeVendas.Name = "DataGridViewRegistroDeVendas";
            DataGridViewRegistroDeVendas.ReadOnly = true;
            DataGridViewRegistroDeVendas.RowHeadersWidth = 27;
            DataGridViewRegistroDeVendas.Size = new Size(840, 645);
            DataGridViewRegistroDeVendas.TabIndex = 1;
            DataGridViewRegistroDeVendas.VirtualMode = true;
            // 
            // TelaVenda
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1350, 729);
            Controls.Add(PanelFooter);
            Controls.Add(LabelRegistroDeVendas);
            Controls.Add(DataGridViewRegistroDeVendas);
            Controls.Add(LabelEstoqueInsumo);
            Controls.Add(LabelEstoqueInsumos);
            Controls.Add(DataGridViewListaProdutos);
            Controls.Add(PanelHeader);
            Name = "TelaVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            WindowState = FormWindowState.Maximized;
            Load += TelaVenda_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProdutos).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).EndInit();
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroDeVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelEstoqueInsumos;
        private DataGridView DataGridViewListaProdutos;
        private Panel PanelHeader;
        private PictureBox PictureBoxPesquisar;
        private Label LabelPesquisar;
        private PictureBox PictureBoxHome;
        private TextBox TextBoxPesquisar;
        private Label LabelHome;
        private Label LabelPesquisarProdutoEstoque;
        private PictureBox PictureBoxAtualizar;
        private Label LabelAtualizar;
        private PictureBox PictureBoxIncluir;
        private Label LabelIncluir;
        private PictureBox PictureBoxRelatorio;
        private Label LabelRelatorio;
        private Panel PanelFooter;
        private Label label3;
        private MaskedTextBox MaskedTextBoxPeriodo2;
        private Label LabelA;
        private MaskedTextBox MaskedTextBoxPeriodo1;
        private Label LabelPeriodo;
        private TextBox TextBoxProdutosVendidos;
        private Label LabelPesquisarVendas;
        private Label LabelEstoqueInsumo;
        private Label LabelRegistroDeVendas;
        private DataGridView DataGridViewRegistroDeVendas;
        private PictureBox PictureBoxRelatorio2;
        private Label LabelRelatorio2;
    }
}
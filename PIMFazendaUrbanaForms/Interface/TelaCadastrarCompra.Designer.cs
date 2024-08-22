namespace PIMFazendaUrbanaForms
{
    partial class TelaCadastrarCompra
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
            PanelHeader = new Panel();
            LabelCadastrarCompra = new Label();
            LabelCategoria = new Label();
            ComboBoxProduto = new ComboBox();
            LabelProduto = new Label();
            LabelFornecedor = new Label();
            BotaoCancelar = new Button();
            BotaoConfirmar = new Button();
            ComboBoxFornecedor = new ComboBox();
            LabelQuantidade = new Label();
            TextBoxQuantidade = new TextBox();
            LabelValorUnitario = new Label();
            TextBoxValorUnitario = new TextBox();
            LabelValorTotal = new Label();
            TextBoxValorTotal = new TextBox();
            LabelUnidade = new Label();
            TextBoxUnidade = new TextBox();
            TextBoxCategoria = new TextBox();
            DataGridItensPedidoCompra = new DataGridView();
            PictureBoxEditar = new PictureBox();
            PictureBoxDeletar = new PictureBox();
            PictureBoxAdicionar = new PictureBox();
            LabelDeletar = new Label();
            LabelAdicionar = new Label();
            LabelEditar = new Label();
            LabelValorTotalPedido = new Label();
            TextBoxValorTotalPedido = new TextBox();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridItensPedidoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAdicionar).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelCadastrarCompra);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(929, 41);
            PanelHeader.TabIndex = 61;
            // 
            // LabelCadastrarCompra
            // 
            LabelCadastrarCompra.AutoSize = true;
            LabelCadastrarCompra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarCompra.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarCompra.Location = new Point(386, 9);
            LabelCadastrarCompra.Name = "LabelCadastrarCompra";
            LabelCadastrarCompra.Size = new Size(173, 25);
            LabelCadastrarCompra.TabIndex = 55;
            LabelCadastrarCompra.Text = "Cadastrar Compra";
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(31, 125);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(61, 15);
            LabelCategoria.TabIndex = 71;
            LabelCategoria.Text = "Categoria:";
            // 
            // ComboBoxProduto
            // 
            ComboBoxProduto.FormattingEnabled = true;
            ComboBoxProduto.Location = new Point(98, 89);
            ComboBoxProduto.Name = "ComboBoxProduto";
            ComboBoxProduto.Size = new Size(234, 23);
            ComboBoxProduto.TabIndex = 1;
            ComboBoxProduto.SelectedIndexChanged += ComboBoxProduto_SelectedIndexChanged;
            // 
            // LabelProduto
            // 
            LabelProduto.AutoSize = true;
            LabelProduto.Location = new Point(39, 92);
            LabelProduto.Name = "LabelProduto";
            LabelProduto.Size = new Size(53, 15);
            LabelProduto.TabIndex = 70;
            LabelProduto.Text = "Produto:";
            // 
            // LabelFornecedor
            // 
            LabelFornecedor.AutoSize = true;
            LabelFornecedor.Location = new Point(23, 59);
            LabelFornecedor.Name = "LabelFornecedor";
            LabelFornecedor.Size = new Size(70, 15);
            LabelFornecedor.TabIndex = 69;
            LabelFornecedor.Text = "Fornecedor:";
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(837, 299);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(80, 30);
            BotaoCancelar.TabIndex = 8;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoConfirmar.ForeColor = Color.White;
            BotaoConfirmar.Location = new Point(729, 299);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 7;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = false;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // ComboBoxFornecedor
            // 
            ComboBoxFornecedor.FormattingEnabled = true;
            ComboBoxFornecedor.Location = new Point(98, 56);
            ComboBoxFornecedor.Name = "ComboBoxFornecedor";
            ComboBoxFornecedor.Size = new Size(234, 23);
            ComboBoxFornecedor.TabIndex = 0;
            // 
            // LabelQuantidade
            // 
            LabelQuantidade.AutoSize = true;
            LabelQuantidade.Location = new Point(20, 190);
            LabelQuantidade.Name = "LabelQuantidade";
            LabelQuantidade.Size = new Size(72, 15);
            LabelQuantidade.TabIndex = 76;
            LabelQuantidade.Text = "Quantidade:";
            // 
            // TextBoxQuantidade
            // 
            TextBoxQuantidade.Location = new Point(98, 187);
            TextBoxQuantidade.Name = "TextBoxQuantidade";
            TextBoxQuantidade.Size = new Size(130, 23);
            TextBoxQuantidade.TabIndex = 4;
            TextBoxQuantidade.TextChanged += TextBoxQuantidade_TextChanged;
            TextBoxQuantidade.KeyPress += TextBoxQuantidade_KeyPress;
            // 
            // LabelValorUnitario
            // 
            LabelValorUnitario.AutoSize = true;
            LabelValorUnitario.Location = new Point(13, 223);
            LabelValorUnitario.Name = "LabelValorUnitario";
            LabelValorUnitario.Size = new Size(80, 15);
            LabelValorUnitario.TabIndex = 78;
            LabelValorUnitario.Text = "Valor unitário:";
            // 
            // TextBoxValorUnitario
            // 
            TextBoxValorUnitario.Location = new Point(98, 220);
            TextBoxValorUnitario.Name = "TextBoxValorUnitario";
            TextBoxValorUnitario.Size = new Size(130, 23);
            TextBoxValorUnitario.TabIndex = 5;
            TextBoxValorUnitario.TextChanged += TextBoxValorUnitario_TextChanged;
            TextBoxValorUnitario.KeyPress += TextBoxValorUnitario_KeyPress;
            TextBoxValorUnitario.Validating += TextBoxValorUnitario_Validating;
            // 
            // LabelValorTotal
            // 
            LabelValorTotal.AutoSize = true;
            LabelValorTotal.Location = new Point(30, 255);
            LabelValorTotal.Name = "LabelValorTotal";
            LabelValorTotal.Size = new Size(64, 15);
            LabelValorTotal.TabIndex = 80;
            LabelValorTotal.Text = "Valor Total:";
            // 
            // TextBoxValorTotal
            // 
            TextBoxValorTotal.BackColor = SystemColors.ControlLightLight;
            TextBoxValorTotal.Enabled = false;
            TextBoxValorTotal.Location = new Point(98, 252);
            TextBoxValorTotal.Name = "TextBoxValorTotal";
            TextBoxValorTotal.ReadOnly = true;
            TextBoxValorTotal.Size = new Size(130, 23);
            TextBoxValorTotal.TabIndex = 6;
            // 
            // LabelUnidade
            // 
            LabelUnidade.AutoSize = true;
            LabelUnidade.Location = new Point(38, 158);
            LabelUnidade.Name = "LabelUnidade";
            LabelUnidade.Size = new Size(54, 15);
            LabelUnidade.TabIndex = 82;
            LabelUnidade.Text = "Unidade:";
            // 
            // TextBoxUnidade
            // 
            TextBoxUnidade.BackColor = SystemColors.ControlLightLight;
            TextBoxUnidade.Enabled = false;
            TextBoxUnidade.Location = new Point(98, 154);
            TextBoxUnidade.Name = "TextBoxUnidade";
            TextBoxUnidade.ReadOnly = true;
            TextBoxUnidade.Size = new Size(130, 23);
            TextBoxUnidade.TabIndex = 3;
            TextBoxUnidade.TextChanged += TextBoxUnidade_TextChanged;
            // 
            // TextBoxCategoria
            // 
            TextBoxCategoria.BackColor = SystemColors.ControlLightLight;
            TextBoxCategoria.Enabled = false;
            TextBoxCategoria.Location = new Point(98, 122);
            TextBoxCategoria.Name = "TextBoxCategoria";
            TextBoxCategoria.ReadOnly = true;
            TextBoxCategoria.Size = new Size(130, 23);
            TextBoxCategoria.TabIndex = 2;
            // 
            // DataGridItensPedidoCompra
            // 
            DataGridItensPedidoCompra.AllowUserToAddRows = false;
            DataGridItensPedidoCompra.AllowUserToDeleteRows = false;
            DataGridItensPedidoCompra.BackgroundColor = SystemColors.Menu;
            DataGridItensPedidoCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridItensPedidoCompra.Location = new Point(357, 56);
            DataGridItensPedidoCompra.Name = "DataGridItensPedidoCompra";
            DataGridItensPedidoCompra.ReadOnly = true;
            DataGridItensPedidoCompra.RowHeadersWidth = 27;
            DataGridItensPedidoCompra.Size = new Size(560, 234);
            DataGridItensPedidoCompra.TabIndex = 83;
            DataGridItensPedidoCompra.VirtualMode = true;
            // 
            // PictureBoxEditar
            // 
            PictureBoxEditar.Image = Properties.Resources.editar;
            PictureBoxEditar.Location = new Point(151, 287);
            PictureBoxEditar.Name = "PictureBoxEditar";
            PictureBoxEditar.Size = new Size(29, 25);
            PictureBoxEditar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxEditar.TabIndex = 84;
            PictureBoxEditar.TabStop = false;
            PictureBoxEditar.Click += PictureBoxEditar_Click;
            // 
            // PictureBoxDeletar
            // 
            PictureBoxDeletar.Image = Properties.Resources.Deletar;
            PictureBoxDeletar.Location = new Point(223, 287);
            PictureBoxDeletar.Name = "PictureBoxDeletar";
            PictureBoxDeletar.Size = new Size(29, 25);
            PictureBoxDeletar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxDeletar.TabIndex = 85;
            PictureBoxDeletar.TabStop = false;
            PictureBoxDeletar.Click += PictureBoxDeletar_Click;
            // 
            // PictureBoxAdicionar
            // 
            PictureBoxAdicionar.Image = Properties.Resources.Incluir;
            PictureBoxAdicionar.Location = new Point(80, 287);
            PictureBoxAdicionar.Name = "PictureBoxAdicionar";
            PictureBoxAdicionar.Size = new Size(29, 25);
            PictureBoxAdicionar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAdicionar.TabIndex = 86;
            PictureBoxAdicionar.TabStop = false;
            PictureBoxAdicionar.Click += PictureBoxAdicionar_Click;
            // 
            // LabelDeletar
            // 
            LabelDeletar.AutoSize = true;
            LabelDeletar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelDeletar.ForeColor = Color.Black;
            LabelDeletar.Location = new Point(214, 312);
            LabelDeletar.Name = "LabelDeletar";
            LabelDeletar.Size = new Size(51, 17);
            LabelDeletar.TabIndex = 89;
            LabelDeletar.Text = "Deletar";
            // 
            // LabelAdicionar
            // 
            LabelAdicionar.AutoSize = true;
            LabelAdicionar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAdicionar.ForeColor = Color.Black;
            LabelAdicionar.Location = new Point(61, 312);
            LabelAdicionar.Name = "LabelAdicionar";
            LabelAdicionar.Size = new Size(65, 17);
            LabelAdicionar.TabIndex = 87;
            LabelAdicionar.Text = "Adicionar";
            // 
            // LabelEditar
            // 
            LabelEditar.AutoSize = true;
            LabelEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelEditar.ForeColor = Color.Black;
            LabelEditar.Location = new Point(146, 312);
            LabelEditar.Name = "LabelEditar";
            LabelEditar.Size = new Size(43, 17);
            LabelEditar.TabIndex = 88;
            LabelEditar.Text = "Editar";
            // 
            // LabelValorTotalPedido
            // 
            LabelValorTotalPedido.AutoSize = true;
            LabelValorTotalPedido.Location = new Point(356, 305);
            LabelValorTotalPedido.Name = "LabelValorTotalPedido";
            LabelValorTotalPedido.Size = new Size(121, 15);
            LabelValorTotalPedido.TabIndex = 91;
            LabelValorTotalPedido.Text = "Valor Total do Pedido:";
            // 
            // TextBoxValorTotalPedido
            // 
            TextBoxValorTotalPedido.BackColor = SystemColors.ControlLightLight;
            TextBoxValorTotalPedido.Enabled = false;
            TextBoxValorTotalPedido.Location = new Point(482, 302);
            TextBoxValorTotalPedido.Name = "TextBoxValorTotalPedido";
            TextBoxValorTotalPedido.ReadOnly = true;
            TextBoxValorTotalPedido.Size = new Size(228, 23);
            TextBoxValorTotalPedido.TabIndex = 90;
            // 
            // TelaCadastrarCompra
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(929, 338);
            Controls.Add(LabelValorTotalPedido);
            Controls.Add(TextBoxValorTotalPedido);
            Controls.Add(PictureBoxEditar);
            Controls.Add(PictureBoxDeletar);
            Controls.Add(PictureBoxAdicionar);
            Controls.Add(LabelDeletar);
            Controls.Add(LabelAdicionar);
            Controls.Add(LabelEditar);
            Controls.Add(DataGridItensPedidoCompra);
            Controls.Add(TextBoxCategoria);
            Controls.Add(TextBoxUnidade);
            Controls.Add(LabelUnidade);
            Controls.Add(LabelValorTotal);
            Controls.Add(TextBoxValorTotal);
            Controls.Add(LabelValorUnitario);
            Controls.Add(TextBoxValorUnitario);
            Controls.Add(LabelQuantidade);
            Controls.Add(TextBoxQuantidade);
            Controls.Add(ComboBoxFornecedor);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(PanelHeader);
            Controls.Add(LabelCategoria);
            Controls.Add(ComboBoxProduto);
            Controls.Add(LabelProduto);
            Controls.Add(LabelFornecedor);
            Name = "TelaCadastrarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Compra";
            Load += TelaCadastrarCompra_Load;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridItensPedidoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAdicionar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LabelCadastrarCompra;
        private Label LabelCategoria;
        private ComboBox ComboBoxProduto;
        private Label LabelProduto;
        private Label LabelFornecedor;
        private Button BotaoCancelar;
        private Button BotaoConfirmar;
        private ComboBox ComboBoxFornecedor;
        private Label LabelQuantidade;
        private TextBox TextBoxQuantidade;
        private Label LabelValorUnitario;
        private TextBox TextBoxValorUnitario;
        private Label LabelValorTotal;
        private TextBox TextBoxValorTotal;
        private Label LabelUnidade;
        private TextBox TextBoxUnidade;
        private TextBox TextBoxCategoria;
        private DataGridView DataGridItensPedidoCompra;
        private PictureBox PictureBoxEditar;
        private PictureBox PictureBoxDeletar;
        private PictureBox PictureBoxAdicionar;
        private Label LabelDeletar;
        private Label LabelAdicionar;
        private Label LabelEditar;
        private Label LabelValorTotalPedido;
        private TextBox TextBoxValorTotalPedido;
    }
}

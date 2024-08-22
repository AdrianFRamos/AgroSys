namespace PIMFazendaUrbanaForms
{
    partial class TelaCadastrarVenda
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
            LabelCadastrarVenda = new Label();
            LabelCategoria = new Label();
            ComboBoxProduto = new ComboBox();
            LabelProduto = new Label();
            LabelCliente = new Label();
            BotaoCancelar = new Button();
            BotaoConfirmar = new Button();
            ComboBoxCliente = new ComboBox();
            LabelQuantidade = new Label();
            TextBoxQuantidade = new TextBox();
            LabelValorUnitario = new Label();
            TextBoxValorUnitario = new TextBox();
            LabelValorTotal = new Label();
            TextBoxValorTotal = new TextBox();
            LabelUnidade = new Label();
            TextBoxUnidade = new TextBox();
            TextBoxCategoria = new TextBox();
            DataGridItensPedidoVenda = new DataGridView();
            PictureBoxEditar = new PictureBox();
            PictureBoxDeletar = new PictureBox();
            PictureBoxAdicionar = new PictureBox();
            LabelDeletar = new Label();
            LabelAdicionar = new Label();
            LabelEditar = new Label();
            LabelValorTotalPedido = new Label();
            TextBoxValorTotalPedido = new TextBox();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridItensPedidoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAdicionar).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelCadastrarVenda);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(929, 41);
            PanelHeader.TabIndex = 61;
            // 
            // LabelCadastrarVenda
            // 
            LabelCadastrarVenda.AutoSize = true;
            LabelCadastrarVenda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarVenda.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarVenda.Location = new Point(386, 9);
            LabelCadastrarVenda.Name = "LabelCadastrarVenda";
            LabelCadastrarVenda.Size = new Size(158, 25);
            LabelCadastrarVenda.TabIndex = 55;
            LabelCadastrarVenda.Text = "Cadastrar Venda";
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
            // LabelCliente
            // 
            LabelCliente.AutoSize = true;
            LabelCliente.Location = new Point(45, 59);
            LabelCliente.Name = "LabelCliente";
            LabelCliente.Size = new Size(47, 15);
            LabelCliente.TabIndex = 69;
            LabelCliente.Text = "Cliente:";
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
            // ComboBoxCliente
            // 
            ComboBoxCliente.FormattingEnabled = true;
            ComboBoxCliente.Location = new Point(98, 56);
            ComboBoxCliente.Name = "ComboBoxCliente";
            ComboBoxCliente.Size = new Size(234, 23);
            ComboBoxCliente.TabIndex = 0;
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
            // DataGridItensPedidoVenda
            // 
            DataGridItensPedidoVenda.AllowUserToAddRows = false;
            DataGridItensPedidoVenda.AllowUserToDeleteRows = false;
            DataGridItensPedidoVenda.BackgroundColor = SystemColors.Menu;
            DataGridItensPedidoVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridItensPedidoVenda.Location = new Point(357, 56);
            DataGridItensPedidoVenda.Name = "DataGridItensPedidoVenda";
            DataGridItensPedidoVenda.ReadOnly = true;
            DataGridItensPedidoVenda.RowHeadersWidth = 27;
            DataGridItensPedidoVenda.Size = new Size(560, 234);
            DataGridItensPedidoVenda.TabIndex = 83;
            DataGridItensPedidoVenda.VirtualMode = true;
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
            // TelaCadastrarVenda
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
            Controls.Add(DataGridItensPedidoVenda);
            Controls.Add(TextBoxCategoria);
            Controls.Add(TextBoxUnidade);
            Controls.Add(LabelUnidade);
            Controls.Add(LabelValorTotal);
            Controls.Add(TextBoxValorTotal);
            Controls.Add(LabelValorUnitario);
            Controls.Add(TextBoxValorUnitario);
            Controls.Add(LabelQuantidade);
            Controls.Add(TextBoxQuantidade);
            Controls.Add(ComboBoxCliente);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(PanelHeader);
            Controls.Add(LabelCategoria);
            Controls.Add(ComboBoxProduto);
            Controls.Add(LabelProduto);
            Controls.Add(LabelCliente);
            Name = "TelaCadastrarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Venda";
            Load += TelaCadastrarVenda_Load;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridItensPedidoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAdicionar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LabelCadastrarVenda;
        private Label LabelCategoria;
        private ComboBox ComboBoxProduto;
        private Label LabelProduto;
        private Label LabelCliente;
        private Button BotaoCancelar;
        private Button BotaoConfirmar;
        private ComboBox ComboBoxCliente;
        private Label LabelQuantidade;
        private TextBox TextBoxQuantidade;
        private Label LabelValorUnitario;
        private TextBox TextBoxValorUnitario;
        private Label LabelValorTotal;
        private TextBox TextBoxValorTotal;
        private Label LabelUnidade;
        private TextBox TextBoxUnidade;
        private TextBox TextBoxCategoria;
        private DataGridView DataGridItensPedidoVenda;
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

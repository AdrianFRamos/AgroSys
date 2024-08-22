using PIMFazendaUrbanaLib;

namespace PIMFazendaUrbanaForms
{
    partial class TelaClientes
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
            components = new System.ComponentModel.Container();
            DataGridViewListaClientes = new DataGridView();
            clienteServiceBindingSource = new BindingSource(components);
            PictureBoxAtualizar = new PictureBox();
            LabelAtualizar = new Label();
            LabelDeletar = new Label();
            LabelEditar = new Label();
            LabelIncluir = new Label();
            PictureBoxIncluir = new PictureBox();
            PictureBoxDeletar = new PictureBox();
            PictureBoxEditar = new PictureBox();
            PanelHeader = new Panel();
            PictureBoxRelatorio = new PictureBox();
            LabelRelatorio = new Label();
            TextBoxPesquisar = new TextBox();
            PictureBoxHome = new PictureBox();
            LabelHome = new Label();
            LabelPesquisarClientes = new Label();
            PanelFooter = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).BeginInit();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).BeginInit();
            PanelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewListaClientes
            // 
            DataGridViewListaClientes.AllowUserToAddRows = false;
            DataGridViewListaClientes.AllowUserToDeleteRows = false;
            DataGridViewListaClientes.BackgroundColor = SystemColors.Menu;
            DataGridViewListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewListaClientes.Location = new Point(60, 80);
            DataGridViewListaClientes.Name = "DataGridViewListaClientes";
            DataGridViewListaClientes.ReadOnly = true;
            DataGridViewListaClientes.RowHeadersWidth = 27;
            DataGridViewListaClientes.Size = new Size(1410, 666);
            DataGridViewListaClientes.TabIndex = 0;
            DataGridViewListaClientes.VirtualMode = true;
            // 
            // clienteServiceBindingSource
            // 
            clienteServiceBindingSource.DataSource = typeof(ClienteService);
            // 
            // PictureBoxAtualizar
            // 
            PictureBoxAtualizar.Image = Properties.Resources.Atualizar;
            PictureBoxAtualizar.Location = new Point(809, 12);
            PictureBoxAtualizar.Name = "PictureBoxAtualizar";
            PictureBoxAtualizar.Size = new Size(29, 25);
            PictureBoxAtualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAtualizar.TabIndex = 51;
            PictureBoxAtualizar.TabStop = false;
            PictureBoxAtualizar.Click += PictureBoxAtualizar_Click;
            // 
            // LabelAtualizar
            // 
            LabelAtualizar.AutoSize = true;
            LabelAtualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelAtualizar.ForeColor = Color.White;
            LabelAtualizar.Location = new Point(795, 37);
            LabelAtualizar.Name = "LabelAtualizar";
            LabelAtualizar.Size = new Size(61, 17);
            LabelAtualizar.TabIndex = 50;
            LabelAtualizar.Text = "Atualizar";
            // 
            // LabelDeletar
            // 
            LabelDeletar.AutoSize = true;
            LabelDeletar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelDeletar.ForeColor = Color.White;
            LabelDeletar.Location = new Point(742, 37);
            LabelDeletar.Name = "LabelDeletar";
            LabelDeletar.Size = new Size(51, 17);
            LabelDeletar.TabIndex = 49;
            LabelDeletar.Text = "Deletar";
            // 
            // LabelEditar
            // 
            LabelEditar.AutoSize = true;
            LabelEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelEditar.ForeColor = Color.White;
            LabelEditar.Location = new Point(688, 37);
            LabelEditar.Name = "LabelEditar";
            LabelEditar.Size = new Size(43, 17);
            LabelEditar.TabIndex = 48;
            LabelEditar.Text = "Editar";
            // 
            // LabelIncluir
            // 
            LabelIncluir.AutoSize = true;
            LabelIncluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIncluir.ForeColor = Color.White;
            LabelIncluir.Location = new Point(630, 37);
            LabelIncluir.Name = "LabelIncluir";
            LabelIncluir.Size = new Size(45, 17);
            LabelIncluir.TabIndex = 47;
            LabelIncluir.Text = "Incluir";
            // 
            // PictureBoxIncluir
            // 
            PictureBoxIncluir.Image = Properties.Resources.Incluir;
            PictureBoxIncluir.Location = new Point(637, 12);
            PictureBoxIncluir.Name = "PictureBoxIncluir";
            PictureBoxIncluir.Size = new Size(29, 25);
            PictureBoxIncluir.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxIncluir.TabIndex = 46;
            PictureBoxIncluir.TabStop = false;
            PictureBoxIncluir.Click += PictureBoxIncluir_Click;
            // 
            // PictureBoxDeletar
            // 
            PictureBoxDeletar.Image = Properties.Resources.Deletar;
            PictureBoxDeletar.Location = new Point(751, 12);
            PictureBoxDeletar.Name = "PictureBoxDeletar";
            PictureBoxDeletar.Size = new Size(29, 25);
            PictureBoxDeletar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxDeletar.TabIndex = 45;
            PictureBoxDeletar.TabStop = false;
            PictureBoxDeletar.Click += PictureBoxDeletar_Click;
            // 
            // PictureBoxEditar
            // 
            PictureBoxEditar.Image = Properties.Resources.editar;
            PictureBoxEditar.Location = new Point(693, 12);
            PictureBoxEditar.Name = "PictureBoxEditar";
            PictureBoxEditar.Size = new Size(29, 25);
            PictureBoxEditar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxEditar.TabIndex = 44;
            PictureBoxEditar.TabStop = false;
            PictureBoxEditar.Click += PictureBoxEditar_Click;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(PictureBoxRelatorio);
            PanelHeader.Controls.Add(LabelRelatorio);
            PanelHeader.Controls.Add(TextBoxPesquisar);
            PanelHeader.Controls.Add(PictureBoxHome);
            PanelHeader.Controls.Add(LabelHome);
            PanelHeader.Controls.Add(LabelPesquisarClientes);
            PanelHeader.Controls.Add(PictureBoxAtualizar);
            PanelHeader.Controls.Add(PictureBoxEditar);
            PanelHeader.Controls.Add(PictureBoxDeletar);
            PanelHeader.Controls.Add(LabelAtualizar);
            PanelHeader.Controls.Add(PictureBoxIncluir);
            PanelHeader.Controls.Add(LabelDeletar);
            PanelHeader.Controls.Add(LabelIncluir);
            PanelHeader.Controls.Add(LabelEditar);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1350, 60);
            PanelHeader.TabIndex = 52;
            // 
            // PictureBoxRelatorio
            // 
            PictureBoxRelatorio.Image = Properties.Resources.ExportarRelatorio;
            PictureBoxRelatorio.Location = new Point(873, 12);
            PictureBoxRelatorio.Name = "PictureBoxRelatorio";
            PictureBoxRelatorio.Size = new Size(29, 25);
            PictureBoxRelatorio.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRelatorio.TabIndex = 68;
            PictureBoxRelatorio.TabStop = false;
            PictureBoxRelatorio.Click += PictureBoxRelatorio_Click;
            // 
            // LabelRelatorio
            // 
            LabelRelatorio.AutoSize = true;
            LabelRelatorio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRelatorio.ForeColor = Color.White;
            LabelRelatorio.Location = new Point(859, 37);
            LabelRelatorio.Name = "LabelRelatorio";
            LabelRelatorio.Size = new Size(62, 17);
            LabelRelatorio.TabIndex = 69;
            LabelRelatorio.Text = "Relatório";
            // 
            // TextBoxPesquisar
            // 
            TextBoxPesquisar.Location = new Point(205, 20);
            TextBoxPesquisar.Name = "TextBoxPesquisar";
            TextBoxPesquisar.PlaceholderText = "Digite o nome do cliente";
            TextBoxPesquisar.Size = new Size(419, 23);
            TextBoxPesquisar.TabIndex = 55;
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
            LabelHome.TabIndex = 19;
            LabelHome.Text = "Home";
            // 
            // LabelPesquisarClientes
            // 
            LabelPesquisarClientes.AutoSize = true;
            LabelPesquisarClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPesquisarClientes.ForeColor = Color.White;
            LabelPesquisarClientes.Location = new Point(75, 21);
            LabelPesquisarClientes.Name = "LabelPesquisarClientes";
            LabelPesquisarClientes.Size = new Size(124, 17);
            LabelPesquisarClientes.TabIndex = 53;
            LabelPesquisarClientes.Text = "Pesquisar Clientes:";
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
            PanelFooter.Size = new Size(1350, 35);
            PanelFooter.TabIndex = 55;
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
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1350, 729);
            Controls.Add(PanelFooter);
            Controls.Add(PanelHeader);
            Controls.Add(DataGridViewListaClientes);
            Name = "TelaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += TelaListarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).EndInit();
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewListaClientes;
        private BindingSource clienteServiceBindingSource;
        private PictureBox PictureBoxAtualizar;
        private Label LabelAtualizar;
        private Label LabelDeletar;
        private Label LabelEditar;
        private Label LabelIncluir;
        private PictureBox PictureBoxIncluir;
        private PictureBox PictureBoxDeletar;
        private PictureBox PictureBoxEditar;
        private Panel PanelHeader;
        private PictureBox PictureBoxHome;
        private Label LabelHome;
        private Label LabelPesquisarClientes;
        private Panel PanelFooter;
        private Label label1;
        private TextBox TextBoxPesquisar;
        private PictureBox PictureBoxRelatorio;
        private Label LabelRelatorio;
    }
}
namespace PIMFazendaUrbanaForms
{
    partial class TelaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionarios));
            PanelFooter = new Panel();
            label1 = new Label();
            LabelPesquisarUsuarios = new Label();
            DataGridViewListaFuncionarios = new DataGridView();
            PictureBoxEditar = new PictureBox();
            PictureBoxDeletar = new PictureBox();
            PictureBoxIncluir = new PictureBox();
            LabelIncluir = new Label();
            LabelEditar = new Label();
            LabelDeletar = new Label();
            PanelHeader = new Panel();
            PictureBoxRelatorio = new PictureBox();
            LabelRelatorio = new Label();
            TextBoxPesquisar = new TextBox();
            PictureBoxAtualizar = new PictureBox();
            LabelAtualizar = new Label();
            PictureBoxHome = new PictureBox();
            LabelHome = new Label();
            PanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).BeginInit();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // PanelFooter
            // 
            PanelFooter.BackColor = Color.FromArgb(120, 220, 120);
            PanelFooter.Controls.Add(label1);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.ForeColor = Color.White;
            PanelFooter.Location = new Point(0, 714);
            PanelFooter.Margin = new Padding(5);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(1370, 35);
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
            // LabelPesquisarUsuarios
            // 
            LabelPesquisarUsuarios.AutoSize = true;
            LabelPesquisarUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            LabelPesquisarUsuarios.ForeColor = Color.White;
            LabelPesquisarUsuarios.Location = new Point(71, 21);
            LabelPesquisarUsuarios.Name = "LabelPesquisarUsuarios";
            LabelPesquisarUsuarios.Size = new Size(128, 17);
            LabelPesquisarUsuarios.TabIndex = 30;
            LabelPesquisarUsuarios.Text = "Pesquisar Usuários:";
            // 
            // DataGridViewListaFuncionarios
            // 
            DataGridViewListaFuncionarios.AllowUserToAddRows = false;
            DataGridViewListaFuncionarios.AllowUserToDeleteRows = false;
            DataGridViewListaFuncionarios.BackgroundColor = SystemColors.Menu;
            DataGridViewListaFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewListaFuncionarios.Location = new Point(60, 80);
            DataGridViewListaFuncionarios.Name = "DataGridViewListaFuncionarios";
            DataGridViewListaFuncionarios.RowHeadersWidth = 27;
            DataGridViewListaFuncionarios.Size = new Size(1410, 666);
            DataGridViewListaFuncionarios.TabIndex = 0;
            // 
            // PictureBoxEditar
            // 
            PictureBoxEditar.Image = Properties.Resources.editar;
            PictureBoxEditar.Location = new Point(693, 12);
            PictureBoxEditar.Name = "PictureBoxEditar";
            PictureBoxEditar.Size = new Size(29, 25);
            PictureBoxEditar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxEditar.TabIndex = 35;
            PictureBoxEditar.TabStop = false;
            PictureBoxEditar.Click += PictureBoxEditar_Click;
            // 
            // PictureBoxDeletar
            // 
            PictureBoxDeletar.Image = (Image)resources.GetObject("PictureBoxDeletar.Image");
            PictureBoxDeletar.Location = new Point(751, 12);
            PictureBoxDeletar.Name = "PictureBoxDeletar";
            PictureBoxDeletar.Size = new Size(29, 25);
            PictureBoxDeletar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxDeletar.TabIndex = 36;
            PictureBoxDeletar.TabStop = false;
            PictureBoxDeletar.Click += PictureBoxDeletar_Click;
            // 
            // PictureBoxIncluir
            // 
            PictureBoxIncluir.Image = (Image)resources.GetObject("PictureBoxIncluir.Image");
            PictureBoxIncluir.Location = new Point(637, 12);
            PictureBoxIncluir.Name = "PictureBoxIncluir";
            PictureBoxIncluir.Size = new Size(29, 25);
            PictureBoxIncluir.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxIncluir.TabIndex = 37;
            PictureBoxIncluir.TabStop = false;
            PictureBoxIncluir.Click += PictureBoxIncluir_Click;
            // 
            // LabelIncluir
            // 
            LabelIncluir.AutoSize = true;
            LabelIncluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelIncluir.ForeColor = Color.White;
            LabelIncluir.Location = new Point(630, 37);
            LabelIncluir.Name = "LabelIncluir";
            LabelIncluir.Size = new Size(45, 17);
            LabelIncluir.TabIndex = 38;
            LabelIncluir.Text = "Incluir";
            // 
            // LabelEditar
            // 
            LabelEditar.AutoSize = true;
            LabelEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelEditar.ForeColor = Color.White;
            LabelEditar.Location = new Point(688, 37);
            LabelEditar.Name = "LabelEditar";
            LabelEditar.Size = new Size(43, 17);
            LabelEditar.TabIndex = 39;
            LabelEditar.Text = "Editar";
            // 
            // LabelDeletar
            // 
            LabelDeletar.AutoSize = true;
            LabelDeletar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelDeletar.ForeColor = Color.White;
            LabelDeletar.Location = new Point(742, 37);
            LabelDeletar.Name = "LabelDeletar";
            LabelDeletar.Size = new Size(51, 17);
            LabelDeletar.TabIndex = 40;
            LabelDeletar.Text = "Deletar";
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(PictureBoxRelatorio);
            PanelHeader.Controls.Add(LabelRelatorio);
            PanelHeader.Controls.Add(TextBoxPesquisar);
            PanelHeader.Controls.Add(PictureBoxAtualizar);
            PanelHeader.Controls.Add(LabelAtualizar);
            PanelHeader.Controls.Add(PictureBoxHome);
            PanelHeader.Controls.Add(LabelHome);
            PanelHeader.Controls.Add(LabelDeletar);
            PanelHeader.Controls.Add(LabelPesquisarUsuarios);
            PanelHeader.Controls.Add(LabelEditar);
            PanelHeader.Controls.Add(LabelIncluir);
            PanelHeader.Controls.Add(PictureBoxEditar);
            PanelHeader.Controls.Add(PictureBoxIncluir);
            PanelHeader.Controls.Add(PictureBoxDeletar);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1370, 60);
            PanelHeader.TabIndex = 52;
            // 
            // PictureBoxRelatorio
            // 
            PictureBoxRelatorio.Image = Properties.Resources.ExportarRelatorio;
            PictureBoxRelatorio.Location = new Point(873, 12);
            PictureBoxRelatorio.Name = "PictureBoxRelatorio";
            PictureBoxRelatorio.Size = new Size(29, 25);
            PictureBoxRelatorio.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxRelatorio.TabIndex = 72;
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
            LabelRelatorio.TabIndex = 73;
            LabelRelatorio.Text = "Relatório";
            // 
            // TextBoxPesquisar
            // 
            TextBoxPesquisar.Location = new Point(205, 20);
            TextBoxPesquisar.Name = "TextBoxPesquisar";
            TextBoxPesquisar.PlaceholderText = "Digite o nome do funcionário";
            TextBoxPesquisar.Size = new Size(419, 23);
            TextBoxPesquisar.TabIndex = 56;
            TextBoxPesquisar.TextChanged += TextBoxPesquisar_TextChanged;
            // 
            // PictureBoxAtualizar
            // 
            PictureBoxAtualizar.Image = (Image)resources.GetObject("PictureBoxAtualizar.Image");
            PictureBoxAtualizar.Location = new Point(809, 12);
            PictureBoxAtualizar.Name = "PictureBoxAtualizar";
            PictureBoxAtualizar.Size = new Size(29, 25);
            PictureBoxAtualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAtualizar.TabIndex = 43;
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
            LabelAtualizar.TabIndex = 42;
            LabelAtualizar.Text = "Atualizar";
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
            // TelaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1370, 749);
            Controls.Add(PanelHeader);
            Controls.Add(PanelFooter);
            Controls.Add(DataGridViewListaFuncionarios);
            Name = "TelaFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários";
            WindowState = FormWindowState.Maximized;
            Load += TelaFuncionarios_Load;
            PanelFooter.ResumeLayout(false);
            PanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDeletar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIncluir).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelFooter;
        private Label label1;
        private Label LabelPesquisarUsuarios;
        private DataGridView DataGridViewListaFuncionarios;
        private PictureBox PictureBoxEditar;
        private PictureBox PictureBoxDeletar;
        private PictureBox PictureBoxIncluir;
        private Label LabelIncluir;
        private Label LabelEditar;
        private Label LabelDeletar;
        private Panel PanelHeader;
        private PictureBox PictureBoxHome;
        private Label LabelHome;
        private Label LabelAtualizar;
        private PictureBox PictureBoxAtualizar;
        private TextBox TextBoxPesquisar;
        private PictureBox PictureBoxRelatorio;
        private Label LabelRelatorio;
    }
}
namespace PIMFazendaUrbanaForms
{
    partial class TelaCadastrarInsumo
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
            LabelCadastrarProdutos = new Label();
            LabelNome = new Label();
            TextBoxNome = new TextBox();
            ComboBoxCategoria = new ComboBox();
            LabelCategoria = new Label();
            LabelUnidade = new Label();
            ComboBoxUnidade = new ComboBox();
            BotaoCancelar = new Button();
            BotaoConfirmar = new Button();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelCadastrarProdutos);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(345, 41);
            PanelHeader.TabIndex = 51;
            // 
            // LabelCadastrarProdutos
            // 
            LabelCadastrarProdutos.AutoSize = true;
            LabelCadastrarProdutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarProdutos.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarProdutos.Location = new Point(85, 8);
            LabelCadastrarProdutos.Name = "LabelCadastrarProdutos";
            LabelCadastrarProdutos.Size = new Size(169, 25);
            LabelCadastrarProdutos.TabIndex = 52;
            LabelCadastrarProdutos.Text = "Cadastrar Insumo";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(61, 62);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(43, 15);
            LabelNome.TabIndex = 53;
            LabelNome.Text = "Nome:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(110, 60);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(182, 23);
            TextBoxNome.TabIndex = 0;
            // 
            // ComboBoxCategoria
            // 
            ComboBoxCategoria.FormattingEnabled = true;
            ComboBoxCategoria.Items.AddRange(new object[] { "Sementes", "Fertilizantes" });
            ComboBoxCategoria.Location = new Point(110, 93);
            ComboBoxCategoria.Name = "ComboBoxCategoria";
            ComboBoxCategoria.Size = new Size(86, 23);
            ComboBoxCategoria.TabIndex = 1;
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(40, 96);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(61, 15);
            LabelCategoria.TabIndex = 55;
            LabelCategoria.Text = "Categoria:";
            // 
            // LabelUnidade
            // 
            LabelUnidade.AutoSize = true;
            LabelUnidade.Location = new Point(48, 129);
            LabelUnidade.Name = "LabelUnidade";
            LabelUnidade.Size = new Size(54, 15);
            LabelUnidade.TabIndex = 56;
            LabelUnidade.Text = "Unidade:";
            // 
            // ComboBoxUnidade
            // 
            ComboBoxUnidade.FormattingEnabled = true;
            ComboBoxUnidade.Items.AddRange(new object[] { "kg", "g", "l", "ml", "m", "cm", "mm", "unidade", "caixa", "tambor" });
            ComboBoxUnidade.Location = new Point(110, 126);
            ComboBoxUnidade.Name = "ComboBoxUnidade";
            ComboBoxUnidade.Size = new Size(86, 23);
            ComboBoxUnidade.TabIndex = 3;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(212, 170);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(80, 30);
            BotaoCancelar.TabIndex = 5;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoConfirmar.ForeColor = Color.White;
            BotaoConfirmar.Location = new Point(52, 169);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 4;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = false;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // TelaCadastrarInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 212);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(ComboBoxUnidade);
            Controls.Add(LabelUnidade);
            Controls.Add(ComboBoxCategoria);
            Controls.Add(LabelCategoria);
            Controls.Add(LabelNome);
            Controls.Add(TextBoxNome);
            Controls.Add(PanelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaCadastrarInsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Insumo";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LabelCadastrarProdutos;
        private Label LabelNome;
        private TextBox TextBoxNome;
        private ComboBox ComboBoxCategoria;
        private Label LabelCategoria;
        private Label LabelUnidade;
        private ComboBox ComboBoxUnidade;
        private Button BotaoCancelar;
        private Button BotaoConfirmar;
    }
}
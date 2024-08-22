namespace PIMFazendaUrbanaForms
{
    partial class TelaCadastrarProducao
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
            ComboBoxUnidade = new ComboBox();
            LabelTempoProducaoTradicional = new Label();
            LabelCategoria = new Label();
            LabelVariedade = new Label();
            LabelNome = new Label();
            MaskedTextBoxTempoProducao = new MaskedTextBox();
            TextBoxVariedade = new TextBox();
            TextBoxNome = new TextBox();
            BotaoCancelar = new Button();
            BotaoConfirmar = new Button();
            PanelHeader = new Panel();
            LabelCadastrarCultivo = new Label();
            LabelDias = new Label();
            checkBox1 = new CheckBox();
            LabelData = new Label();
            TextBoxData = new TextBox();
            LabelQuantidade = new Label();
            TextBoxQuantidade = new TextBox();
            TextBoxCategoria = new TextBox();
            LabelUnidade = new Label();
            LabelDataColheita = new Label();
            TextBoxDataColheita = new TextBox();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxUnidade
            // 
            ComboBoxUnidade.FormattingEnabled = true;
            ComboBoxUnidade.Items.AddRange(new object[] { "kg", "g", "unidade" });
            ComboBoxUnidade.Location = new Point(177, 173);
            ComboBoxUnidade.Name = "ComboBoxUnidade";
            ComboBoxUnidade.Size = new Size(137, 23);
            ComboBoxUnidade.TabIndex = 4;
            // 
            // LabelTempoProducaoTradicional
            // 
            LabelTempoProducaoTradicional.AutoSize = true;
            LabelTempoProducaoTradicional.Location = new Point(84, 258);
            LabelTempoProducaoTradicional.Name = "LabelTempoProducaoTradicional";
            LabelTempoProducaoTradicional.Size = new Size(90, 15);
            LabelTempoProducaoTradicional.TabIndex = 79;
            LabelTempoProducaoTradicional.Text = "Tempo de Prod:";
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(113, 117);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(61, 15);
            LabelCategoria.TabIndex = 78;
            LabelCategoria.Text = "Categoria:";
            // 
            // LabelVariedade
            // 
            LabelVariedade.AutoSize = true;
            LabelVariedade.Location = new Point(111, 89);
            LabelVariedade.Name = "LabelVariedade";
            LabelVariedade.Size = new Size(61, 15);
            LabelVariedade.TabIndex = 77;
            LabelVariedade.Text = "Variedade:";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(132, 59);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(43, 15);
            LabelNome.TabIndex = 76;
            LabelNome.Text = "Nome:";
            // 
            // MaskedTextBoxTempoProducao
            // 
            MaskedTextBoxTempoProducao.BackColor = SystemColors.ControlLightLight;
            MaskedTextBoxTempoProducao.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxTempoProducao.Enabled = false;
            MaskedTextBoxTempoProducao.Location = new Point(178, 254);
            MaskedTextBoxTempoProducao.Mask = "000";
            MaskedTextBoxTempoProducao.Name = "MaskedTextBoxTempoProducao";
            MaskedTextBoxTempoProducao.Size = new Size(70, 23);
            MaskedTextBoxTempoProducao.TabIndex = 7;
            // 
            // TextBoxVariedade
            // 
            TextBoxVariedade.BackColor = SystemColors.ControlLightLight;
            TextBoxVariedade.Enabled = false;
            TextBoxVariedade.Location = new Point(178, 85);
            TextBoxVariedade.Name = "TextBoxVariedade";
            TextBoxVariedade.Size = new Size(137, 23);
            TextBoxVariedade.TabIndex = 1;
            // 
            // TextBoxNome
            // 
            TextBoxNome.BackColor = SystemColors.ControlLightLight;
            TextBoxNome.Enabled = false;
            TextBoxNome.Location = new Point(178, 56);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(137, 23);
            TextBoxNome.TabIndex = 0;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(235, 320);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(80, 30);
            BotaoCancelar.TabIndex = 10;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoConfirmar.ForeColor = Color.White;
            BotaoConfirmar.Location = new Point(68, 320);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 9;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = false;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelCadastrarCultivo);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(401, 41);
            PanelHeader.TabIndex = 69;
            // 
            // LabelCadastrarCultivo
            // 
            LabelCadastrarCultivo.AutoSize = true;
            LabelCadastrarCultivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarCultivo.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarCultivo.Location = new Point(116, 9);
            LabelCadastrarCultivo.Name = "LabelCadastrarCultivo";
            LabelCadastrarCultivo.Size = new Size(189, 25);
            LabelCadastrarCultivo.TabIndex = 55;
            LabelCadastrarCultivo.Text = "Cadastrar Produção";
            // 
            // LabelDias
            // 
            LabelDias.AutoSize = true;
            LabelDias.ForeColor = SystemColors.ControlDarkDark;
            LabelDias.Location = new Point(251, 258);
            LabelDias.Name = "LabelDias";
            LabelDias.Size = new Size(29, 15);
            LabelDias.TabIndex = 81;
            LabelDias.Text = "Dias";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(178, 230);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(142, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Ambiente climatizado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LabelData
            // 
            LabelData.AutoSize = true;
            LabelData.Location = new Point(139, 205);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(34, 15);
            LabelData.TabIndex = 85;
            LabelData.Text = "Data:";
            // 
            // TextBoxData
            // 
            TextBoxData.BackColor = SystemColors.ControlLightLight;
            TextBoxData.Enabled = false;
            TextBoxData.Location = new Point(178, 202);
            TextBoxData.Name = "TextBoxData";
            TextBoxData.Size = new Size(137, 23);
            TextBoxData.TabIndex = 5;
            // 
            // LabelQuantidade
            // 
            LabelQuantidade.AutoSize = true;
            LabelQuantidade.Location = new Point(102, 146);
            LabelQuantidade.Name = "LabelQuantidade";
            LabelQuantidade.Size = new Size(72, 15);
            LabelQuantidade.TabIndex = 87;
            LabelQuantidade.Text = "Quantidade:";
            // 
            // TextBoxQuantidade
            // 
            TextBoxQuantidade.Location = new Point(178, 143);
            TextBoxQuantidade.Name = "TextBoxQuantidade";
            TextBoxQuantidade.Size = new Size(138, 23);
            TextBoxQuantidade.TabIndex = 3;
            // 
            // TextBoxCategoria
            // 
            TextBoxCategoria.BackColor = SystemColors.ControlLightLight;
            TextBoxCategoria.Enabled = false;
            TextBoxCategoria.Location = new Point(177, 114);
            TextBoxCategoria.Name = "TextBoxCategoria";
            TextBoxCategoria.Size = new Size(138, 23);
            TextBoxCategoria.TabIndex = 2;
            // 
            // LabelUnidade
            // 
            LabelUnidade.AutoSize = true;
            LabelUnidade.Location = new Point(119, 175);
            LabelUnidade.Name = "LabelUnidade";
            LabelUnidade.Size = new Size(54, 15);
            LabelUnidade.TabIndex = 88;
            LabelUnidade.Text = "Unidade:";
            // 
            // LabelDataColheita
            // 
            LabelDataColheita.AutoSize = true;
            LabelDataColheita.Location = new Point(33, 286);
            LabelDataColheita.Name = "LabelDataColheita";
            LabelDataColheita.Size = new Size(139, 15);
            LabelDataColheita.TabIndex = 91;
            LabelDataColheita.Text = "Data prevista de colheita:";
            // 
            // TextBoxDataColheita
            // 
            TextBoxDataColheita.BackColor = SystemColors.ControlLightLight;
            TextBoxDataColheita.Enabled = false;
            TextBoxDataColheita.Location = new Point(178, 283);
            TextBoxDataColheita.Name = "TextBoxDataColheita";
            TextBoxDataColheita.Size = new Size(137, 23);
            TextBoxDataColheita.TabIndex = 8;
            // 
            // TelaCadastrarProducao
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(401, 359);
            Controls.Add(LabelDataColheita);
            Controls.Add(TextBoxDataColheita);
            Controls.Add(TextBoxCategoria);
            Controls.Add(LabelUnidade);
            Controls.Add(LabelQuantidade);
            Controls.Add(TextBoxQuantidade);
            Controls.Add(LabelData);
            Controls.Add(TextBoxData);
            Controls.Add(checkBox1);
            Controls.Add(LabelDias);
            Controls.Add(ComboBoxUnidade);
            Controls.Add(LabelTempoProducaoTradicional);
            Controls.Add(LabelCategoria);
            Controls.Add(LabelVariedade);
            Controls.Add(LabelNome);
            Controls.Add(MaskedTextBoxTempoProducao);
            Controls.Add(TextBoxVariedade);
            Controls.Add(TextBoxNome);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(PanelHeader);
            Name = "TelaCadastrarProducao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produção";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox ComboBoxUnidade;
        private Label LabelTempoProducaoTradicional;
        private Label LabelCategoria;
        private Label LabelVariedade;
        private Label LabelNome;
        private MaskedTextBox MaskedTextBoxTempoProducao;
        private TextBox TextBoxVariedade;
        private TextBox TextBoxNome;
        private Button BotaoCancelar;
        private Button BotaoConfirmar;
        private Panel PanelHeader;
        private Label LabelCadastrarCultivo;
        private Label LabelDias;
        private CheckBox checkBox1;
        private Label LabelData;
        private TextBox TextBoxData;
        private Label LabelQuantidade;
        private TextBox TextBoxQuantidade;
        private TextBox TextBoxCategoria;
        private Label LabelUnidade;
        private Label LabelDataColheita;
        private TextBox TextBoxDataColheita;
    }
}
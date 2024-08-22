namespace PIMFazendaUrbanaForms
{
    partial class TelaRecomendacao
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
            LabelEstacao = new Label();
            PanelHeader = new Panel();
            LabelRecomendacoes = new Label();
            BotaoGerar = new Button();
            LabelPreencha = new Label();
            BotaoFechar = new Button();
            ComboBoxRegiao = new ComboBox();
            LabelRegiao = new Label();
            PanelMargem = new Panel();
            checkBox1 = new CheckBox();
            ComboBoxEstacao = new ComboBox();
            PanelHeader.SuspendLayout();
            PanelMargem.SuspendLayout();
            SuspendLayout();
            // 
            // LabelEstacao
            // 
            LabelEstacao.AutoSize = true;
            LabelEstacao.Location = new Point(8, 74);
            LabelEstacao.Name = "LabelEstacao";
            LabelEstacao.Size = new Size(107, 15);
            LabelEstacao.TabIndex = 56;
            LabelEstacao.Text = "Estação do plantio:";
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelRecomendacoes);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(349, 49);
            PanelHeader.TabIndex = 55;
            // 
            // LabelRecomendacoes
            // 
            LabelRecomendacoes.Anchor = AnchorStyles.None;
            LabelRecomendacoes.AutoSize = true;
            LabelRecomendacoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRecomendacoes.ForeColor = Color.White;
            LabelRecomendacoes.Location = new Point(38, 11);
            LabelRecomendacoes.Name = "LabelRecomendacoes";
            LabelRecomendacoes.Size = new Size(250, 25);
            LabelRecomendacoes.TabIndex = 23;
            LabelRecomendacoes.Text = "Recomendações de Plantio";
            LabelRecomendacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BotaoGerar
            // 
            BotaoGerar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoGerar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoGerar.ForeColor = Color.White;
            BotaoGerar.Location = new Point(8, 145);
            BotaoGerar.Name = "BotaoGerar";
            BotaoGerar.Size = new Size(104, 30);
            BotaoGerar.TabIndex = 3;
            BotaoGerar.Text = "Gerar";
            BotaoGerar.UseVisualStyleBackColor = false;
            BotaoGerar.Click += BotaoGerar_Click;
            // 
            // LabelPreencha
            // 
            LabelPreencha.AutoSize = true;
            LabelPreencha.Location = new Point(50, 9);
            LabelPreencha.Name = "LabelPreencha";
            LabelPreencha.Size = new Size(177, 15);
            LabelPreencha.TabIndex = 55;
            LabelPreencha.Text = "Preencha as informações abaixo";
            // 
            // BotaoFechar
            // 
            BotaoFechar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoFechar.ForeColor = Color.White;
            BotaoFechar.Location = new Point(164, 145);
            BotaoFechar.Name = "BotaoFechar";
            BotaoFechar.Size = new Size(104, 30);
            BotaoFechar.TabIndex = 4;
            BotaoFechar.Text = "Fechar";
            BotaoFechar.UseVisualStyleBackColor = false;
            BotaoFechar.Click += BotaoFechar_Click;
            // 
            // ComboBoxRegiao
            // 
            ComboBoxRegiao.FormattingEnabled = true;
            ComboBoxRegiao.Items.AddRange(new object[] { "Norte", "Nordeste", "Sul", "Sudeste", "Centro-Oeste" });
            ComboBoxRegiao.Location = new Point(132, 36);
            ComboBoxRegiao.Name = "ComboBoxRegiao";
            ComboBoxRegiao.Size = new Size(137, 23);
            ComboBoxRegiao.TabIndex = 2;
            ComboBoxRegiao.SelectedIndexChanged += ComboBoxRegiao_SelectedIndexChanged;
            // 
            // LabelRegiao
            // 
            LabelRegiao.AutoSize = true;
            LabelRegiao.Location = new Point(75, 38);
            LabelRegiao.Name = "LabelRegiao";
            LabelRegiao.Size = new Size(46, 15);
            LabelRegiao.TabIndex = 60;
            LabelRegiao.Text = "Região:";
            // 
            // PanelMargem
            // 
            PanelMargem.Controls.Add(checkBox1);
            PanelMargem.Controls.Add(ComboBoxEstacao);
            PanelMargem.Controls.Add(LabelRegiao);
            PanelMargem.Controls.Add(LabelEstacao);
            PanelMargem.Controls.Add(ComboBoxRegiao);
            PanelMargem.Controls.Add(BotaoFechar);
            PanelMargem.Controls.Add(LabelPreencha);
            PanelMargem.Controls.Add(BotaoGerar);
            PanelMargem.Location = new Point(30, 53);
            PanelMargem.Name = "PanelMargem";
            PanelMargem.Size = new Size(288, 178);
            PanelMargem.TabIndex = 62;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 110);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(247, 19);
            checkBox1.TabIndex = 63;
            checkBox1.Text = "Possuo ambiente climatizado para plantio";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ComboBoxEstacao
            // 
            ComboBoxEstacao.FormattingEnabled = true;
            ComboBoxEstacao.Items.AddRange(new object[] { "Verão", "Outono", "Inverno", "Primavera" });
            ComboBoxEstacao.Location = new Point(132, 71);
            ComboBoxEstacao.Name = "ComboBoxEstacao";
            ComboBoxEstacao.Size = new Size(137, 23);
            ComboBoxEstacao.TabIndex = 61;
            ComboBoxEstacao.SelectedIndexChanged += ComboBoxEstacao_SelectedIndexChanged;
            // 
            // TelaRecomendacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 241);
            Controls.Add(PanelHeader);
            Controls.Add(PanelMargem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaRecomendacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar Recomendações";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            PanelMargem.ResumeLayout(false);
            PanelMargem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LabelEstacao;
        private Panel PanelHeader;
        private Label LabelRecomendacoes;
        private Button BotaoGerar;
        private Label LabelPreencha;
        private Button BotaoFechar;
        private ComboBox ComboBoxRegiao;
        private Label LabelRegiao;
        private Panel PanelMargem;
        private ComboBox ComboBoxEstacao;
        private CheckBox checkBox1;
    }
}
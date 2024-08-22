namespace PIMFazendaUrbanaForms
{
    partial class TelaEditarCultivo
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
            MaskedTextBoxTempoControlado = new MaskedTextBox();
            LabelTempoProducaoControlado = new Label();
            ComboBoxCategoria = new ComboBox();
            LabelTempoProducaoTradicional = new Label();
            LabelCategoria = new Label();
            LabelVariedade = new Label();
            LabelNome = new Label();
            MaskedTextBoxTempoTradicional = new MaskedTextBox();
            TextBoxVariedade = new TextBox();
            TextBoxNome = new TextBox();
            BotaoCancelar = new Button();
            BotaoConfirmar = new Button();
            PanelHeader = new Panel();
            LabelCadastrarCultivo = new Label();
            LabelDias = new Label();
            LabelDias2 = new Label();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // MaskedTextBoxTempoControlado
            // 
            MaskedTextBoxTempoControlado.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxTempoControlado.Location = new Point(188, 171);
            MaskedTextBoxTempoControlado.Mask = "000";
            MaskedTextBoxTempoControlado.Name = "MaskedTextBoxTempoControlado";
            MaskedTextBoxTempoControlado.Size = new Size(70, 23);
            MaskedTextBoxTempoControlado.TabIndex = 4;
            // 
            // LabelTempoProducaoControlado
            // 
            LabelTempoProducaoControlado.AutoSize = true;
            LabelTempoProducaoControlado.Location = new Point(28, 175);
            LabelTempoProducaoControlado.Name = "label1";
            LabelTempoProducaoControlado.Size = new Size(156, 15);
            LabelTempoProducaoControlado.TabIndex = 80;
            LabelTempoProducaoControlado.Text = "Tempo de Prod. Controlado:";
            // 
            // ComboBoxCategoria
            // 
            ComboBoxCategoria.FormattingEnabled = true;
            ComboBoxCategoria.Items.AddRange(new object[] { "Verdura", "Legume", "Fruta", "Outro" });
            ComboBoxCategoria.Location = new Point(188, 113);
            ComboBoxCategoria.Name = "ComboBoxCategoria";
            ComboBoxCategoria.Size = new Size(137, 23);
            ComboBoxCategoria.TabIndex = 2;
            // 
            // LabelTempoProducaoTradicional
            // 
            LabelTempoProducaoTradicional.AutoSize = true;
            LabelTempoProducaoTradicional.Location = new Point(30, 146);
            LabelTempoProducaoTradicional.Name = "LabelTempoProducaoTradicional";
            LabelTempoProducaoTradicional.Size = new Size(153, 15);
            LabelTempoProducaoTradicional.TabIndex = 79;
            LabelTempoProducaoTradicional.Text = "Tempo de Prod. Tradicional:";
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(123, 117);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(61, 15);
            LabelCategoria.TabIndex = 78;
            LabelCategoria.Text = "Categoria:";
            // 
            // LabelVariedade
            // 
            LabelVariedade.AutoSize = true;
            LabelVariedade.Location = new Point(122, 88);
            LabelVariedade.Name = "LabelVariedade";
            LabelVariedade.Size = new Size(61, 15);
            LabelVariedade.TabIndex = 77;
            LabelVariedade.Text = "Variedade:";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(142, 58);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(43, 15);
            LabelNome.TabIndex = 76;
            LabelNome.Text = "Nome:";
            // 
            // MaskedTextBoxTempoTradicional
            // 
            MaskedTextBoxTempoTradicional.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxTempoTradicional.Location = new Point(188, 142);
            MaskedTextBoxTempoTradicional.Mask = "000";
            MaskedTextBoxTempoTradicional.Name = "MaskedTextBoxTempoTradicional";
            MaskedTextBoxTempoTradicional.Size = new Size(70, 23);
            MaskedTextBoxTempoTradicional.TabIndex = 3;
            // 
            // TextBoxVariedade
            // 
            TextBoxVariedade.Location = new Point(188, 84);
            TextBoxVariedade.Name = "TextBoxVariedade";
            TextBoxVariedade.Size = new Size(137, 23);
            TextBoxVariedade.TabIndex = 1;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(188, 55);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(137, 23);
            TextBoxNome.TabIndex = 0;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(245, 216);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(80, 30);
            BotaoCancelar.TabIndex = 6;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoConfirmar.ForeColor = Color.White;
            BotaoConfirmar.Location = new Point(78, 216);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 5;
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
            PanelHeader.Size = new Size(418, 41);
            PanelHeader.TabIndex = 69;
            // 
            // LabelCadastrarCultivo
            // 
            LabelCadastrarCultivo.AutoSize = true;
            LabelCadastrarCultivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarCultivo.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarCultivo.Location = new Point(141, 9);
            LabelCadastrarCultivo.Name = "LabelCadastrarCultivo";
            LabelCadastrarCultivo.Size = new Size(132, 25);
            LabelCadastrarCultivo.TabIndex = 55;
            LabelCadastrarCultivo.Text = "Editar Cultivo";
            // 
            // LabelDias
            // 
            LabelDias.AutoSize = true;
            LabelDias.ForeColor = SystemColors.ControlDarkDark;
            LabelDias.Location = new Point(261, 146);
            LabelDias.Name = "LabelDias";
            LabelDias.Size = new Size(29, 15);
            LabelDias.TabIndex = 81;
            LabelDias.Text = "Dias";
            // 
            // LabelDias2
            // 
            LabelDias2.AutoSize = true;
            LabelDias2.ForeColor = SystemColors.ControlDarkDark;
            LabelDias2.Location = new Point(261, 175);
            LabelDias2.Name = "LabelDias2";
            LabelDias2.Size = new Size(29, 15);
            LabelDias2.TabIndex = 82;
            LabelDias2.Text = "Dias";
            // 
            // TelaEditarCultivo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(418, 258);
            Controls.Add(LabelDias2);
            Controls.Add(LabelDias);
            Controls.Add(MaskedTextBoxTempoControlado);
            Controls.Add(LabelTempoProducaoControlado);
            Controls.Add(ComboBoxCategoria);
            Controls.Add(LabelTempoProducaoTradicional);
            Controls.Add(LabelCategoria);
            Controls.Add(LabelVariedade);
            Controls.Add(LabelNome);
            Controls.Add(MaskedTextBoxTempoTradicional);
            Controls.Add(TextBoxVariedade);
            Controls.Add(TextBoxNome);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(PanelHeader);
            Name = "TelaEditarCultivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cultivo";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MaskedTextBoxTempoControlado;
        private Label LabelTempoProducaoControlado;
        private ComboBox ComboBoxCategoria;
        private Label LabelTempoProducaoTradicional;
        private Label LabelCategoria;
        private Label LabelVariedade;
        private Label LabelNome;
        private MaskedTextBox MaskedTextBoxTempoTradicional;
        private TextBox TextBoxVariedade;
        private TextBox TextBoxNome;
        private Button BotaoCancelar;
        private Button BotaoConfirmar;
        private Panel PanelHeader;
        private Label LabelCadastrarCultivo;
        private Label LabelDias;
        private Label LabelDias2;
    }
}
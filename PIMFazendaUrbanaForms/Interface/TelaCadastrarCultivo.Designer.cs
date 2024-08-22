namespace PIMFazendaUrbanaForms
{
    partial class TelaCadastrarCultivo
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
            LabelCadastrarCultivo = new Label();
            ComboBoxCategoria = new ComboBox();
            LabelTempoTradicional = new Label();
            LabelCategoria = new Label();
            LabelVariedade = new Label();
            LabelNome = new Label();
            MaskedTextBoxTempoTradicional = new MaskedTextBox();
            TextBoxVariedade = new TextBox();
            TextBoxNome = new TextBox();
            BotaoCancelar = new Button();
            BotaoConfirmar = new Button();
            LabelTempoControlado = new Label();
            MaskedTextBoxTempoControlado = new MaskedTextBox();
            label2 = new Label();
            lbDias = new Label();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelCadastrarCultivo);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(404, 41);
            PanelHeader.TabIndex = 51;
            // 
            // LabelCadastrarCultivo
            // 
            LabelCadastrarCultivo.AutoSize = true;
            LabelCadastrarCultivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarCultivo.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarCultivo.Location = new Point(116, 9);
            LabelCadastrarCultivo.Name = "LabelCadastrarCultivo";
            LabelCadastrarCultivo.Size = new Size(165, 25);
            LabelCadastrarCultivo.TabIndex = 55;
            LabelCadastrarCultivo.Text = "Cadastrar Cultivo";
            // 
            // ComboBoxCategoria
            // 
            ComboBoxCategoria.FormattingEnabled = true;
            ComboBoxCategoria.Items.AddRange(new object[] { "Verdura", "Legume", "Fruta", "Outro" });
            ComboBoxCategoria.Location = new Point(191, 116);
            ComboBoxCategoria.Name = "ComboBoxCategoria";
            ComboBoxCategoria.Size = new Size(138, 23);
            ComboBoxCategoria.TabIndex = 2;
            // 
            // LabelTempoTradicional
            // 
            LabelTempoTradicional.AutoSize = true;
            LabelTempoTradicional.Location = new Point(34, 149);
            LabelTempoTradicional.Name = "LabelTempoTradicional";
            LabelTempoTradicional.Size = new Size(153, 15);
            LabelTempoTradicional.TabIndex = 63;
            LabelTempoTradicional.Text = "Tempo de Prod. Tradicional:";
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(127, 120);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(61, 15);
            LabelCategoria.TabIndex = 62;
            LabelCategoria.Text = "Categoria:";
            // 
            // LabelVariedade
            // 
            LabelVariedade.AutoSize = true;
            LabelVariedade.Location = new Point(126, 91);
            LabelVariedade.Name = "LabelVariedade";
            LabelVariedade.Size = new Size(61, 15);
            LabelVariedade.TabIndex = 61;
            LabelVariedade.Text = "Variedade:";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(145, 62);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(43, 15);
            LabelNome.TabIndex = 60;
            LabelNome.Text = "Nome:";
            // 
            // MaskedTextBoxTempoTradicional
            // 
            MaskedTextBoxTempoTradicional.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxTempoTradicional.Location = new Point(191, 145);
            MaskedTextBoxTempoTradicional.Mask = "000";
            MaskedTextBoxTempoTradicional.Name = "MaskedTextBoxTempoTradicional";
            MaskedTextBoxTempoTradicional.Size = new Size(70, 23);
            MaskedTextBoxTempoTradicional.TabIndex = 3;
            // 
            // TextBoxVariedade
            // 
            TextBoxVariedade.Location = new Point(191, 87);
            TextBoxVariedade.Name = "TextBoxVariedade";
            TextBoxVariedade.Size = new Size(138, 23);
            TextBoxVariedade.TabIndex = 1;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(191, 58);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(138, 23);
            TextBoxNome.TabIndex = 0;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(238, 210);
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
            BotaoConfirmar.Location = new Point(69, 210);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 5;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = false;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // LabelTempoControlado
            // 
            LabelTempoControlado.AutoSize = true;
            LabelTempoControlado.Location = new Point(32, 178);
            LabelTempoControlado.Name = "LabelTempoControlado";
            LabelTempoControlado.Size = new Size(156, 15);
            LabelTempoControlado.TabIndex = 67;
            LabelTempoControlado.Text = "Tempo de Prod. Controlado:";
            // 
            // MaskedTextBoxTempoControlado
            // 
            MaskedTextBoxTempoControlado.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxTempoControlado.Location = new Point(191, 174);
            MaskedTextBoxTempoControlado.Mask = "000";
            MaskedTextBoxTempoControlado.Name = "MaskedTextBoxTempoControlado";
            MaskedTextBoxTempoControlado.Size = new Size(70, 23);
            MaskedTextBoxTempoControlado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(262, 178);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 84;
            label2.Text = "Dias";
            // 
            // lbDias
            // 
            lbDias.AutoSize = true;
            lbDias.ForeColor = SystemColors.ControlDarkDark;
            lbDias.Location = new Point(262, 149);
            lbDias.Name = "lbDias";
            lbDias.Size = new Size(29, 15);
            lbDias.TabIndex = 83;
            lbDias.Text = "Dias";
            // 
            // TelaCadastrarCultivo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(404, 252);
            Controls.Add(label2);
            Controls.Add(lbDias);
            Controls.Add(MaskedTextBoxTempoControlado);
            Controls.Add(LabelTempoControlado);
            Controls.Add(ComboBoxCategoria);
            Controls.Add(LabelTempoTradicional);
            Controls.Add(LabelCategoria);
            Controls.Add(LabelVariedade);
            Controls.Add(LabelNome);
            Controls.Add(MaskedTextBoxTempoTradicional);
            Controls.Add(TextBoxVariedade);
            Controls.Add(TextBoxNome);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(PanelHeader);
            Name = "TelaCadastrarCultivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Cultivo";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LabelCadastrarCultivo;
        private ComboBox ComboBoxCategoria;
        private Label LabelTempoTradicional;
        private Label LabelCategoria;
        private Label LabelVariedade;
        private Label LabelNome;
        private MaskedTextBox MaskedTextBoxTempoTradicional;
        private TextBox TextBoxVariedade;
        private TextBox TextBoxNome;
        private Button BotaoCancelar;
        private Button BotaoConfirmar;
        private Label LabelTempoControlado;
        private MaskedTextBox MaskedTextBoxTempoControlado;
        private Label label2;
        private Label lbDias;
    }
}
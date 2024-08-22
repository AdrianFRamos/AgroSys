namespace PIMFazendaUrbanaForms
{
    partial class TelaCadastrarCliente
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
            TextBoxNome = new TextBox();
            TextBoxEmail = new TextBox();
            LabelNome = new Label();
            LabelCNPJ = new Label();
            LabelEmail = new Label();
            BotaoConfirmar = new Button();
            BotaoCancelar = new Button();
            TextBoxCNPJ = new MaskedTextBox();
            TextBoxDDD = new MaskedTextBox();
            TextBoxTelefone = new TextBox();
            LabelDDD = new Label();
            LabelTelefone = new Label();
            TextBoxLogradouro = new TextBox();
            TextBoxNumero = new TextBox();
            TextBoxComplemento = new TextBox();
            TextBoxBairro = new TextBox();
            TextBoxCidade = new TextBox();
            TextBoxCEP = new MaskedTextBox();
            LabelLogradouro = new Label();
            LabelNumero = new Label();
            LabelComplemento = new Label();
            LabelBairro = new Label();
            LabelCidade = new Label();
            LabelUF = new Label();
            LabelCEP = new Label();
            ComboBoxUF = new ComboBox();
            LabelCadastrarUsuarios = new Label();
            PanelHeader = new Panel();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(104, 58);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(258, 23);
            TextBoxNome.TabIndex = 0;
            TextBoxNome.Validating += TextBoxNome_Validating;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(104, 123);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(258, 23);
            TextBoxEmail.TabIndex = 3;
            TextBoxEmail.Validating += TextBoxEmail_Validating;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(55, 60);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(43, 15);
            LabelNome.TabIndex = 3;
            LabelNome.Text = "Nome:";
            // 
            // LabelCNPJ
            // 
            LabelCNPJ.AutoSize = true;
            LabelCNPJ.Location = new Point(63, 95);
            LabelCNPJ.Name = "LabelCNPJ";
            LabelCNPJ.Size = new Size(37, 15);
            LabelCNPJ.TabIndex = 4;
            LabelCNPJ.Text = "CNPJ:";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(53, 128);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(44, 15);
            LabelEmail.TabIndex = 5;
            LabelEmail.Text = "E-mail:";
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoConfirmar.ForeColor = Color.White;
            BotaoConfirmar.Location = new Point(76, 404);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 13;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = false;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(282, 404);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(80, 30);
            BotaoCancelar.TabIndex = 14;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // TextBoxCNPJ
            // 
            TextBoxCNPJ.Culture = new System.Globalization.CultureInfo("");
            TextBoxCNPJ.Location = new Point(104, 90);
            TextBoxCNPJ.Mask = "00.000.000/0000-00";
            TextBoxCNPJ.Name = "TextBoxCNPJ";
            TextBoxCNPJ.Size = new Size(127, 23);
            TextBoxCNPJ.TabIndex = 2;
            TextBoxCNPJ.Validating += TextBoxCNPJ_Validating;
            // 
            // TextBoxDDD
            // 
            TextBoxDDD.Location = new Point(104, 158);
            TextBoxDDD.Mask = "00";
            TextBoxDDD.Name = "TextBoxDDD";
            TextBoxDDD.Size = new Size(31, 23);
            TextBoxDDD.TabIndex = 4;
            TextBoxDDD.Validating += TextBoxDDD_Validating;
            // 
            // TextBoxTelefone
            // 
            TextBoxTelefone.Location = new Point(206, 158);
            TextBoxTelefone.Name = "TextBoxTelefone";
            TextBoxTelefone.Size = new Size(156, 23);
            TextBoxTelefone.TabIndex = 5;
            TextBoxTelefone.KeyPress += TextBoxTelefone_KeyPress;
            TextBoxTelefone.Validating += TextBoxTelefone_Validating;
            // 
            // LabelDDD
            // 
            LabelDDD.AutoSize = true;
            LabelDDD.Location = new Point(62, 160);
            LabelDDD.Name = "LabelDDD";
            LabelDDD.Size = new Size(34, 15);
            LabelDDD.TabIndex = 10;
            LabelDDD.Text = "DDD:";
            // 
            // LabelTelefone
            // 
            LabelTelefone.AutoSize = true;
            LabelTelefone.Location = new Point(140, 160);
            LabelTelefone.Name = "LabelTelefone";
            LabelTelefone.Size = new Size(54, 15);
            LabelTelefone.TabIndex = 11;
            LabelTelefone.Text = "Telefone:";
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Location = new Point(104, 190);
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(258, 23);
            TextBoxLogradouro.TabIndex = 6;
            TextBoxLogradouro.Validating += TextBoxLogradouro_Validating;
            // 
            // TextBoxNumero
            // 
            TextBoxNumero.Location = new Point(104, 224);
            TextBoxNumero.Name = "TextBoxNumero";
            TextBoxNumero.Size = new Size(55, 23);
            TextBoxNumero.TabIndex = 7;
            TextBoxNumero.Validating += TextBoxNumero_Validating;
            // 
            // TextBoxComplemento
            // 
            TextBoxComplemento.Location = new Point(104, 256);
            TextBoxComplemento.Name = "TextBoxComplemento";
            TextBoxComplemento.Size = new Size(258, 23);
            TextBoxComplemento.TabIndex = 8;
            // 
            // TextBoxBairro
            // 
            TextBoxBairro.Location = new Point(104, 290);
            TextBoxBairro.Name = "TextBoxBairro";
            TextBoxBairro.Size = new Size(258, 23);
            TextBoxBairro.TabIndex = 9;
            TextBoxBairro.Validating += TextBoxBairro_Validating;
            // 
            // TextBoxCidade
            // 
            TextBoxCidade.Location = new Point(104, 322);
            TextBoxCidade.Name = "TextBoxCidade";
            TextBoxCidade.Size = new Size(258, 23);
            TextBoxCidade.TabIndex = 10;
            TextBoxCidade.Validating += TextBoxCidade_Validating;
            // 
            // TextBoxCEP
            // 
            TextBoxCEP.Culture = new System.Globalization.CultureInfo("");
            TextBoxCEP.Location = new Point(206, 356);
            TextBoxCEP.Mask = "00000-000";
            TextBoxCEP.Name = "TextBoxCEP";
            TextBoxCEP.Size = new Size(96, 23);
            TextBoxCEP.TabIndex = 12;
            TextBoxCEP.Validating += TextBoxCEP_Validating;
            // 
            // LabelLogradouro
            // 
            LabelLogradouro.AutoSize = true;
            LabelLogradouro.Location = new Point(23, 193);
            LabelLogradouro.Name = "LabelLogradouro";
            LabelLogradouro.Size = new Size(72, 15);
            LabelLogradouro.TabIndex = 19;
            LabelLogradouro.Text = "Logradouro:";
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(44, 226);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(54, 15);
            LabelNumero.TabIndex = 20;
            LabelNumero.Text = "Número:";
            // 
            // LabelComplemento
            // 
            LabelComplemento.AutoSize = true;
            LabelComplemento.Location = new Point(8, 259);
            LabelComplemento.Name = "LabelComplemento";
            LabelComplemento.Size = new Size(87, 15);
            LabelComplemento.TabIndex = 21;
            LabelComplemento.Text = "Complemento:";
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Location = new Point(56, 292);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(41, 15);
            LabelBairro.TabIndex = 22;
            LabelBairro.Text = "Bairro:";
            // 
            // LabelCidade
            // 
            LabelCidade.AutoSize = true;
            LabelCidade.Location = new Point(50, 325);
            LabelCidade.Name = "LabelCidade";
            LabelCidade.Size = new Size(47, 15);
            LabelCidade.TabIndex = 23;
            LabelCidade.Text = "Cidade:";
            // 
            // LabelUF
            // 
            LabelUF.AutoSize = true;
            LabelUF.Location = new Point(76, 358);
            LabelUF.Name = "LabelUF";
            LabelUF.Size = new Size(24, 15);
            LabelUF.TabIndex = 24;
            LabelUF.Text = "UF:";
            // 
            // LabelCEP
            // 
            LabelCEP.AutoSize = true;
            LabelCEP.Location = new Point(169, 359);
            LabelCEP.Name = "LabelCEP";
            LabelCEP.Size = new Size(31, 15);
            LabelCEP.TabIndex = 25;
            LabelCEP.Text = "CEP:";
            // 
            // ComboBoxUF
            // 
            ComboBoxUF.FormattingEnabled = true;
            ComboBoxUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            ComboBoxUF.Location = new Point(104, 356);
            ComboBoxUF.Name = "ComboBoxUF";
            ComboBoxUF.Size = new Size(55, 23);
            ComboBoxUF.TabIndex = 11;
            ComboBoxUF.Validating += ComboBoxUF_Validating;
            // 
            // LabelCadastrarUsuarios
            // 
            LabelCadastrarUsuarios.AutoSize = true;
            LabelCadastrarUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCadastrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            LabelCadastrarUsuarios.Location = new Point(127, 7);
            LabelCadastrarUsuarios.Name = "LabelCadastrarUsuarios";
            LabelCadastrarUsuarios.Size = new Size(163, 25);
            LabelCadastrarUsuarios.TabIndex = 0;
            LabelCadastrarUsuarios.Text = "Cadastrar Cliente";
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelCadastrarUsuarios);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(434, 41);
            PanelHeader.TabIndex = 50;
            // 
            // TelaCadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 446);
            Controls.Add(PanelHeader);
            Controls.Add(ComboBoxUF);
            Controls.Add(LabelCEP);
            Controls.Add(LabelUF);
            Controls.Add(LabelCidade);
            Controls.Add(LabelBairro);
            Controls.Add(LabelComplemento);
            Controls.Add(LabelNumero);
            Controls.Add(LabelLogradouro);
            Controls.Add(TextBoxCEP);
            Controls.Add(TextBoxCidade);
            Controls.Add(TextBoxBairro);
            Controls.Add(TextBoxComplemento);
            Controls.Add(TextBoxNumero);
            Controls.Add(TextBoxLogradouro);
            Controls.Add(LabelTelefone);
            Controls.Add(LabelDDD);
            Controls.Add(TextBoxTelefone);
            Controls.Add(TextBoxDDD);
            Controls.Add(TextBoxCNPJ);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(LabelNome);
            Controls.Add(LabelCNPJ);
            Controls.Add(LabelEmail);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNome);
            Name = "TelaCadastrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Cliente";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxNome;
        private TextBox TextBoxEmail;
        private Label LabelNome;
        private Label LabelCNPJ;
        private Label LabelEmail;
        private Button BotaoConfirmar;
        private Button BotaoCancelar;
        private MaskedTextBox TextBoxCNPJ;
        private MaskedTextBox TextBoxDDD;
        private TextBox TextBoxTelefone;
        private Label LabelDDD;
        private Label LabelTelefone;
        private TextBox TextBoxLogradouro;
        private TextBox TextBoxNumero;
        private TextBox TextBoxComplemento;
        private TextBox TextBoxBairro;
        private TextBox TextBoxCidade;
        private MaskedTextBox TextBoxCEP;
        private Label LabelLogradouro;
        private Label LabelNumero;
        private Label LabelComplemento;
        private Label LabelBairro;
        private Label LabelCidade;
        private Label LabelUF;
        private Label LabelCEP;
        private ComboBox ComboBoxUF;
        private Label LabelCadastrarUsuarios;
        private Panel PanelHeader;
    }
}
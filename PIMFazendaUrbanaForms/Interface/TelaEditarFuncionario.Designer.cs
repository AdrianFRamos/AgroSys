namespace PIMFazendaUrbanaForms
{
    partial class TelaEditarFuncionario
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
            LabelEditarUsuarios = new Label();
            LabelNome = new Label();
            LabelEmail = new Label();
            TextBoxUsuario = new TextBox();
            LabelUsuario = new Label();
            LabelContato = new Label();
            LabelUF = new Label();
            TextBoxCodigo = new TextBox();
            LabelCodigo = new Label();
            LabelCidade = new Label();
            LabelLogradouro = new Label();
            LabelNumero = new Label();
            LabelComplemento = new Label();
            LabelSexo = new Label();
            ComboBoxSexo = new ComboBox();
            ComboBoxCargo = new ComboBox();
            LabelCargo = new Label();
            LabelBairro = new Label();
            LabelCEP = new Label();
            LabelDDD = new Label();
            BotaoConfirmar = new Button();
            BotaoCancelar = new Button();
            TextBoxNome = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxDDD = new MaskedTextBox();
            TextBoxTelefone = new TextBox();
            TextBoxLogradouro = new TextBox();
            TextBoxNumero = new TextBox();
            TextBoxComplemento = new TextBox();
            TextBoxBairro = new TextBox();
            TextBoxCidade = new TextBox();
            TextBoxCEP = new MaskedTextBox();
            ComboBoxUF = new ComboBox();
            LabelCPF = new Label();
            MaskedTextBoxCPF = new MaskedTextBox();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelEditarUsuarios);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(434, 41);
            PanelHeader.TabIndex = 0;
            // 
            // LabelEditarUsuarios
            // 
            LabelEditarUsuarios.AutoSize = true;
            LabelEditarUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEditarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            LabelEditarUsuarios.Location = new Point(153, 7);
            LabelEditarUsuarios.Name = "LabelEditarUsuarios";
            LabelEditarUsuarios.Size = new Size(138, 25);
            LabelEditarUsuarios.TabIndex = 0;
            LabelEditarUsuarios.Text = "Editar Usuário";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(76, 86);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(46, 15);
            LabelNome.TabIndex = 1;
            LabelNome.Text = "Nome: ";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(74, 115);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(47, 15);
            LabelEmail.TabIndex = 3;
            LabelEmail.Text = "E-mail: ";
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(127, 172);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(200, 23);
            TextBoxUsuario.TabIndex = 4;
            TextBoxUsuario.Validating += TextBoxUsuario_Validating;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Location = new Point(68, 176);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(53, 15);
            LabelUsuario.TabIndex = 5;
            LabelUsuario.Text = "Usuário: ";
            // 
            // LabelContato
            // 
            LabelContato.AutoSize = true;
            LabelContato.Location = new Point(166, 263);
            LabelContato.Name = "LabelContato";
            LabelContato.Size = new Size(54, 15);
            LabelContato.TabIndex = 9;
            LabelContato.Text = "Telefone:";
            // 
            // LabelUF
            // 
            LabelUF.AutoSize = true;
            LabelUF.Location = new Point(97, 435);
            LabelUF.Name = "LabelUF";
            LabelUF.Size = new Size(27, 15);
            LabelUF.TabIndex = 11;
            LabelUF.Text = "UF: ";
            // 
            // TextBoxCodigo
            // 
            TextBoxCodigo.Enabled = false;
            TextBoxCodigo.Location = new Point(127, 53);
            TextBoxCodigo.Name = "TextBoxCodigo";
            TextBoxCodigo.Size = new Size(55, 23);
            TextBoxCodigo.TabIndex = 0;
            // 
            // LabelCodigo
            // 
            LabelCodigo.AutoSize = true;
            LabelCodigo.Location = new Point(69, 57);
            LabelCodigo.Name = "LabelCodigo";
            LabelCodigo.Size = new Size(52, 15);
            LabelCodigo.TabIndex = 13;
            LabelCodigo.Text = "Código: ";
            // 
            // LabelCidade
            // 
            LabelCidade.AutoSize = true;
            LabelCidade.Location = new Point(71, 406);
            LabelCidade.Name = "LabelCidade";
            LabelCidade.Size = new Size(50, 15);
            LabelCidade.TabIndex = 15;
            LabelCidade.Text = "Cidade: ";
            // 
            // LabelLogradouro
            // 
            LabelLogradouro.AutoSize = true;
            LabelLogradouro.Location = new Point(44, 291);
            LabelLogradouro.Name = "LabelLogradouro";
            LabelLogradouro.Size = new Size(75, 15);
            LabelLogradouro.TabIndex = 17;
            LabelLogradouro.Text = "Logradouro: ";
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(65, 320);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(57, 15);
            LabelNumero.TabIndex = 19;
            LabelNumero.Text = "Número: ";
            // 
            // LabelComplemento
            // 
            LabelComplemento.AutoSize = true;
            LabelComplemento.Location = new Point(29, 349);
            LabelComplemento.Name = "LabelComplemento";
            LabelComplemento.Size = new Size(90, 15);
            LabelComplemento.TabIndex = 21;
            LabelComplemento.Text = "Complemento: ";
            // 
            // LabelSexo
            // 
            LabelSexo.AutoSize = true;
            LabelSexo.Location = new Point(84, 204);
            LabelSexo.Name = "LabelSexo";
            LabelSexo.Size = new Size(38, 15);
            LabelSexo.TabIndex = 23;
            LabelSexo.Text = "Sexo: ";
            // 
            // ComboBoxSexo
            // 
            ComboBoxSexo.FormattingEnabled = true;
            ComboBoxSexo.Items.AddRange(new object[] { "M", "F", "-" });
            ComboBoxSexo.Location = new Point(127, 201);
            ComboBoxSexo.Name = "ComboBoxSexo";
            ComboBoxSexo.Size = new Size(55, 23);
            ComboBoxSexo.TabIndex = 7;
            ComboBoxSexo.Validating += ComboBoxSexo_Validating;
            // 
            // ComboBoxCargo
            // 
            ComboBoxCargo.FormattingEnabled = true;
            ComboBoxCargo.Items.AddRange(new object[] { "Funcionário", "Gerente" });
            ComboBoxCargo.Location = new Point(127, 230);
            ComboBoxCargo.Name = "ComboBoxCargo";
            ComboBoxCargo.Size = new Size(121, 23);
            ComboBoxCargo.TabIndex = 8;
            ComboBoxCargo.Validating += ComboBoxCargo_Validating;
            // 
            // LabelCargo
            // 
            LabelCargo.AutoSize = true;
            LabelCargo.Location = new Point(30, 234);
            LabelCargo.Name = "LabelCargo";
            LabelCargo.Size = new Size(88, 15);
            LabelCargo.TabIndex = 25;
            LabelCargo.Text = "Cargo Usuário: ";
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Location = new Point(77, 377);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(44, 15);
            LabelBairro.TabIndex = 40;
            LabelBairro.Text = "Bairro: ";
            // 
            // LabelCEP
            // 
            LabelCEP.AutoSize = true;
            LabelCEP.Location = new Point(90, 465);
            LabelCEP.Name = "LabelCEP";
            LabelCEP.Size = new Size(34, 15);
            LabelCEP.TabIndex = 42;
            LabelCEP.Text = "CEP: ";
            // 
            // LabelDDD
            // 
            LabelDDD.AutoSize = true;
            LabelDDD.Location = new Point(83, 264);
            LabelDDD.Name = "LabelDDD";
            LabelDDD.Size = new Size(37, 15);
            LabelDDD.TabIndex = 45;
            LabelDDD.Text = "DDD: ";
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoConfirmar.ForeColor = Color.White;
            BotaoConfirmar.Location = new Point(74, 497);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(90, 30);
            BotaoConfirmar.TabIndex = 18;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = false;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(280, 497);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(80, 30);
            BotaoCancelar.TabIndex = 19;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(127, 82);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(263, 23);
            TextBoxNome.TabIndex = 1;
            TextBoxNome.Validating += TextBoxNome_Validating;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(127, 112);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(262, 23);
            TextBoxEmail.TabIndex = 2;
            TextBoxEmail.Validating += TextBoxEmail_Validating;
            // 
            // TextBoxDDD
            // 
            TextBoxDDD.Location = new Point(127, 260);
            TextBoxDDD.Mask = "00";
            TextBoxDDD.Name = "TextBoxDDD";
            TextBoxDDD.Size = new Size(31, 23);
            TextBoxDDD.TabIndex = 9;
            TextBoxDDD.Validating += TextBoxDDD_Validating;
            // 
            // TextBoxTelefone
            // 
            TextBoxTelefone.Location = new Point(230, 260);
            TextBoxTelefone.Name = "TextBoxTelefone";
            TextBoxTelefone.Size = new Size(111, 23);
            TextBoxTelefone.TabIndex = 10;
            TextBoxTelefone.KeyPress += TextBoxTelefone_KeyPress;
            TextBoxTelefone.Validating += TextBoxTelefone_Validating;
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Location = new Point(127, 288);
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(262, 23);
            TextBoxLogradouro.TabIndex = 11;
            TextBoxLogradouro.Validating += TextBoxLogradouro_Validating;
            // 
            // TextBoxNumero
            // 
            TextBoxNumero.Location = new Point(127, 317);
            TextBoxNumero.Name = "TextBoxNumero";
            TextBoxNumero.Size = new Size(55, 23);
            TextBoxNumero.TabIndex = 12;
            TextBoxNumero.Validating += TextBoxNumero_Validating;
            // 
            // TextBoxComplemento
            // 
            TextBoxComplemento.Location = new Point(127, 346);
            TextBoxComplemento.Name = "TextBoxComplemento";
            TextBoxComplemento.Size = new Size(139, 23);
            TextBoxComplemento.TabIndex = 13;
            // 
            // TextBoxBairro
            // 
            TextBoxBairro.Location = new Point(127, 374);
            TextBoxBairro.Name = "TextBoxBairro";
            TextBoxBairro.Size = new Size(139, 23);
            TextBoxBairro.TabIndex = 14;
            TextBoxBairro.Validating += TextBoxBairro_Validating;
            // 
            // TextBoxCidade
            // 
            TextBoxCidade.Location = new Point(127, 403);
            TextBoxCidade.Name = "TextBoxCidade";
            TextBoxCidade.Size = new Size(262, 23);
            TextBoxCidade.TabIndex = 15;
            TextBoxCidade.Validating += TextBoxCidade_Validating;
            // 
            // TextBoxCEP
            // 
            TextBoxCEP.Culture = new System.Globalization.CultureInfo("");
            TextBoxCEP.Location = new Point(127, 462);
            TextBoxCEP.Mask = "00000-000";
            TextBoxCEP.Name = "TextBoxCEP";
            TextBoxCEP.Size = new Size(96, 23);
            TextBoxCEP.TabIndex = 17;
            TextBoxCEP.Validating += TextBoxCEP_Validating;
            // 
            // ComboBoxUF
            // 
            ComboBoxUF.FormattingEnabled = true;
            ComboBoxUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            ComboBoxUF.Location = new Point(127, 432);
            ComboBoxUF.Name = "ComboBoxUF";
            ComboBoxUF.Size = new Size(55, 23);
            ComboBoxUF.TabIndex = 16;
            ComboBoxUF.Validating += ComboBoxUF_Validating;
            // 
            // LabelCPF
            // 
            LabelCPF.AutoSize = true;
            LabelCPF.Location = new Point(91, 146);
            LabelCPF.Name = "LabelCPF";
            LabelCPF.Size = new Size(31, 15);
            LabelCPF.TabIndex = 46;
            LabelCPF.Text = "CPF:";
            // 
            // MaskedTextBoxCPF
            // 
            MaskedTextBoxCPF.Culture = new System.Globalization.CultureInfo("");
            MaskedTextBoxCPF.Location = new Point(127, 142);
            MaskedTextBoxCPF.Mask = "000.000.000-00";
            MaskedTextBoxCPF.Name = "MaskedTextBoxCPF";
            MaskedTextBoxCPF.Size = new Size(200, 23);
            MaskedTextBoxCPF.TabIndex = 3;
            MaskedTextBoxCPF.Validating += MaskedTextBoxCPF_Validating;
            // 
            // TelaEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 537);
            Controls.Add(MaskedTextBoxCPF);
            Controls.Add(LabelCPF);
            Controls.Add(ComboBoxUF);
            Controls.Add(TextBoxCEP);
            Controls.Add(TextBoxCidade);
            Controls.Add(TextBoxBairro);
            Controls.Add(TextBoxComplemento);
            Controls.Add(TextBoxNumero);
            Controls.Add(TextBoxLogradouro);
            Controls.Add(TextBoxTelefone);
            Controls.Add(TextBoxDDD);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNome);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoConfirmar);
            Controls.Add(LabelDDD);
            Controls.Add(LabelCEP);
            Controls.Add(LabelBairro);
            Controls.Add(ComboBoxCargo);
            Controls.Add(LabelCargo);
            Controls.Add(ComboBoxSexo);
            Controls.Add(LabelSexo);
            Controls.Add(LabelComplemento);
            Controls.Add(LabelNumero);
            Controls.Add(LabelLogradouro);
            Controls.Add(LabelCidade);
            Controls.Add(TextBoxCodigo);
            Controls.Add(LabelCodigo);
            Controls.Add(LabelUF);
            Controls.Add(LabelContato);
            Controls.Add(TextBoxUsuario);
            Controls.Add(LabelUsuario);
            Controls.Add(LabelEmail);
            Controls.Add(LabelNome);
            Controls.Add(PanelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaEditarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuário";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LabelEditarUsuarios;
        private Label LabelNome;
        private Label LabelEmail;
        private TextBox TextBoxUsuario;
        private Label LabelUsuario;
        private Label LabelContato;
        private Label LabelUF;
        private TextBox TextBoxCodigo;
        private Label LabelCodigo;
        private Label LabelCidade;
        private Label LabelLogradouro;
        private Label LabelNumero;
        private Label LabelComplemento;
        private Label LabelSexo;
        private ComboBox ComboBoxSexo;
        private ComboBox ComboBoxCargo;
        private Label LabelCargo;
        private Label LabelBairro;
        private Label LabelCEP;
        private Label LabelDDD;
        private Button BotaoConfirmar;
        private Button BotaoCancelar;
        private TextBox TextBoxNome;
        private TextBox TextBoxEmail;
        private MaskedTextBox TextBoxDDD;
        private TextBox TextBoxTelefone;
        private TextBox TextBoxLogradouro;
        private TextBox TextBoxNumero;
        private TextBox TextBoxComplemento;
        private TextBox TextBoxBairro;
        private TextBox TextBoxCidade;
        private MaskedTextBox TextBoxCEP;
        private ComboBox ComboBoxUF;
        private Label LabelCPF;
        private MaskedTextBox MaskedTextBoxCPF;
    }
}
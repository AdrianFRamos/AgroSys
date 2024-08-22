namespace PIMFazendaUrbanaForms
{
    partial class TelaLogin
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
            LabelLogin = new Label();
            LabelUsuario = new Label();
            TextBoxUsuario = new TextBox();
            TextBoxSenha = new TextBox();
            LabelSenha = new Label();
            BotaoCancelar = new Button();
            BotaoEntrar = new Button();
            PictureBoxMostrarSenha = new PictureBox();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMostrarSenha).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelLogin);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(476, 55);
            PanelHeader.TabIndex = 56;
            // 
            // LabelLogin
            // 
            LabelLogin.Anchor = AnchorStyles.None;
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelLogin.ForeColor = SystemColors.ButtonHighlight;
            LabelLogin.Location = new Point(209, 13);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(63, 25);
            LabelLogin.TabIndex = 23;
            LabelLogin.Text = "Login";
            LabelLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.Location = new Point(209, 71);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(69, 21);
            LabelUsuario.TabIndex = 57;
            LabelUsuario.Text = "Usuário";
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(193, 95);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(100, 23);
            TextBoxUsuario.TabIndex = 1;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(193, 150);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(100, 23);
            TextBoxSenha.TabIndex = 2;
            TextBoxSenha.TextChanged += TextBoxSenha_TextChanged;
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSenha.Location = new Point(215, 126);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(57, 21);
            LabelSenha.TabIndex = 59;
            LabelSenha.Text = "Senha";
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoCancelar.ForeColor = Color.White;
            BotaoCancelar.Location = new Point(249, 192);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(104, 30);
            BotaoCancelar.TabIndex = 4;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = false;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // BotaoEntrar
            // 
            BotaoEntrar.BackColor = Color.FromArgb(80, 200, 85);
            BotaoEntrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoEntrar.ForeColor = Color.White;
            BotaoEntrar.Location = new Point(135, 192);
            BotaoEntrar.Name = "BotaoEntrar";
            BotaoEntrar.Size = new Size(104, 30);
            BotaoEntrar.TabIndex = 3;
            BotaoEntrar.Text = "Entrar";
            BotaoEntrar.UseVisualStyleBackColor = false;
            BotaoEntrar.Click += BotaoEntrar_Click;
            // 
            // PictureBoxMostrarSenha
            // 
            PictureBoxMostrarSenha.Image = Properties.Resources.mostrarSenha;
            PictureBoxMostrarSenha.Location = new Point(299, 150);
            PictureBoxMostrarSenha.Name = "PictureBoxMostrarSenha";
            PictureBoxMostrarSenha.Size = new Size(26, 23);
            PictureBoxMostrarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxMostrarSenha.TabIndex = 25;
            PictureBoxMostrarSenha.TabStop = false;
            PictureBoxMostrarSenha.Click += PictureBoxMostrarSenha_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 240);
            Controls.Add(PictureBoxMostrarSenha);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoEntrar);
            Controls.Add(TextBoxSenha);
            Controls.Add(LabelSenha);
            Controls.Add(TextBoxUsuario);
            Controls.Add(LabelUsuario);
            Controls.Add(PanelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            TopMost = true;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMostrarSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LabelLogin;
        private Label LabelUsuario;
        private TextBox TextBoxUsuario;
        private TextBox TextBoxSenha;
        private Label LabelSenha;
        private Button BotaoCancelar;
        private Button BotaoEntrar;
        private PictureBox PictureBoxMostrarSenha;
    }
}
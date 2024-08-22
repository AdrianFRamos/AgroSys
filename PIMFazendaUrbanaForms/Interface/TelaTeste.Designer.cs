namespace PIMFazendaUrbanaForms
{
    partial class TelaTeste
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
            BotaoAutenticarFuncionario = new Button();
            BotaoAutenticarGerente = new Button();
            BotaoAlterarSenhaFuncionario = new Button();
            BotaoConsultarFuncionarioNome = new Button();
            BotaoConsultarFuncionarioUsuario = new Button();
            SuspendLayout();
            // 
            // BotaoAutenticarFuncionario
            // 
            BotaoAutenticarFuncionario.Location = new Point(67, 53);
            BotaoAutenticarFuncionario.Name = "BotaoAutenticarFuncionario";
            BotaoAutenticarFuncionario.Size = new Size(138, 23);
            BotaoAutenticarFuncionario.TabIndex = 15;
            BotaoAutenticarFuncionario.Text = "Autenticar Funcionario";
            BotaoAutenticarFuncionario.UseVisualStyleBackColor = true;
            BotaoAutenticarFuncionario.Click += BotaoAutenticarFuncionario_Click;
            // 
            // BotaoAutenticarGerente
            // 
            BotaoAutenticarGerente.Location = new Point(67, 116);
            BotaoAutenticarGerente.Name = "BotaoAutenticarGerente";
            BotaoAutenticarGerente.Size = new Size(138, 23);
            BotaoAutenticarGerente.TabIndex = 16;
            BotaoAutenticarGerente.Text = "Autenticar Gerente";
            BotaoAutenticarGerente.UseVisualStyleBackColor = true;
            BotaoAutenticarGerente.Click += BotaoAutenticarGerente_Click;
            // 
            // BotaoAlterarSenhaFuncionario
            // 
            BotaoAlterarSenhaFuncionario.Location = new Point(67, 185);
            BotaoAlterarSenhaFuncionario.Name = "BotaoAlterarSenhaFuncionario";
            BotaoAlterarSenhaFuncionario.Size = new Size(155, 23);
            BotaoAlterarSenhaFuncionario.TabIndex = 18;
            BotaoAlterarSenhaFuncionario.Text = "AlterarSenhaFuncionario";
            BotaoAlterarSenhaFuncionario.UseVisualStyleBackColor = true;
            BotaoAlterarSenhaFuncionario.Click += BotaoAlterarSenhaFuncionario_Click;
            // 
            // BotaoConsultarFuncionarioNome
            // 
            BotaoConsultarFuncionarioNome.Location = new Point(467, 60);
            BotaoConsultarFuncionarioNome.Name = "BotaoConsultarFuncionarioNome";
            BotaoConsultarFuncionarioNome.Size = new Size(168, 23);
            BotaoConsultarFuncionarioNome.TabIndex = 21;
            BotaoConsultarFuncionarioNome.Text = "ConsultarFuncionarioNome";
            BotaoConsultarFuncionarioNome.UseVisualStyleBackColor = true;
            BotaoConsultarFuncionarioNome.Click += BotaoConsultarFuncionarioNome_Click;
            // 
            // BotaoConsultarFuncionarioUsuario
            // 
            BotaoConsultarFuncionarioUsuario.Location = new Point(467, 107);
            BotaoConsultarFuncionarioUsuario.Name = "BotaoConsultarFuncionarioUsuario";
            BotaoConsultarFuncionarioUsuario.Size = new Size(179, 23);
            BotaoConsultarFuncionarioUsuario.TabIndex = 22;
            BotaoConsultarFuncionarioUsuario.Text = "ConsultarFuncionarioUsuario";
            BotaoConsultarFuncionarioUsuario.UseVisualStyleBackColor = true;
            BotaoConsultarFuncionarioUsuario.Click += BotaoConsultarFuncionarioUsuario_Click;
            // 
            // TelaTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotaoConsultarFuncionarioUsuario);
            Controls.Add(BotaoConsultarFuncionarioNome);
            Controls.Add(BotaoAlterarSenhaFuncionario);
            Controls.Add(BotaoAutenticarGerente);
            Controls.Add(BotaoAutenticarFuncionario);
            Name = "TelaTeste";
            Text = "TelaTeste";
            ResumeLayout(false);
        }

        #endregion

        private Button BotaoAutenticarFuncionario;
        private Button BotaoAutenticarGerente;
        private Button BotaoAlterarSenhaFuncionario;
        private Button BotaoConsultarFuncionarioNome;
        private Button BotaoConsultarFuncionarioUsuario;
    }
}
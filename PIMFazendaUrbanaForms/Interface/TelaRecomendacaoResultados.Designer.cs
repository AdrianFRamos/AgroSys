namespace PIMFazendaUrbanaForms
{
    partial class TelaRecomendacaoResultados
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
            DataGridViewResultados = new DataGridView();
            BotaoFechar = new Button();
            LabelResultados = new Label();
            PanelHeader = new Panel();
            TextBoxRecomenda = new TextBox();
            BotaoExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResultados).BeginInit();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewResultados
            // 
            DataGridViewResultados.BackgroundColor = Color.LightGray;
            DataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewResultados.GridColor = Color.Gainsboro;
            DataGridViewResultados.Location = new Point(24, 121);
            DataGridViewResultados.Margin = new Padding(3, 2, 3, 2);
            DataGridViewResultados.Name = "DataGridViewResultados";
            DataGridViewResultados.RowHeadersWidth = 51;
            DataGridViewResultados.Size = new Size(575, 260);
            DataGridViewResultados.TabIndex = 0;
            // 
            // BotaoFechar
            // 
            BotaoFechar.BackColor = Color.FromArgb(255, 100, 100);
            BotaoFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoFechar.ForeColor = Color.White;
            BotaoFechar.Location = new Point(332, 391);
            BotaoFechar.Name = "BotaoFechar";
            BotaoFechar.Size = new Size(104, 30);
            BotaoFechar.TabIndex = 56;
            BotaoFechar.Text = "Fechar";
            BotaoFechar.UseVisualStyleBackColor = false;
            BotaoFechar.Click += BotaoFechar_Click;
            // 
            // LabelResultados
            // 
            LabelResultados.Anchor = AnchorStyles.None;
            LabelResultados.AutoSize = true;
            LabelResultados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelResultados.ForeColor = Color.White;
            LabelResultados.Location = new Point(253, 11);
            LabelResultados.Name = "LabelResultados";
            LabelResultados.Size = new Size(108, 25);
            LabelResultados.TabIndex = 23;
            LabelResultados.Text = "Resultados";
            LabelResultados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(55, 185, 65);
            PanelHeader.Controls.Add(LabelResultados);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(625, 49);
            PanelHeader.TabIndex = 57;
            // 
            // TextBoxRecomenda
            // 
            TextBoxRecomenda.BackColor = Color.FromArgb(55, 185, 65);
            TextBoxRecomenda.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxRecomenda.ForeColor = Color.White;
            TextBoxRecomenda.Location = new Point(24, 61);
            TextBoxRecomenda.Margin = new Padding(3, 2, 3, 2);
            TextBoxRecomenda.Multiline = true;
            TextBoxRecomenda.Name = "TextBoxRecomenda";
            TextBoxRecomenda.ReadOnly = true;
            TextBoxRecomenda.Size = new Size(576, 48);
            TextBoxRecomenda.TabIndex = 58;
            TextBoxRecomenda.TextAlign = HorizontalAlignment.Center;
            // 
            // BotaoExportar
            // 
            BotaoExportar.BackColor = Color.FromArgb(55, 185, 65);
            BotaoExportar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoExportar.ForeColor = Color.White;
            BotaoExportar.Location = new Point(189, 391);
            BotaoExportar.Name = "BotaoExportar";
            BotaoExportar.Size = new Size(104, 30);
            BotaoExportar.TabIndex = 59;
            BotaoExportar.Text = "Exportar";
            BotaoExportar.UseVisualStyleBackColor = false;
            BotaoExportar.Click += BotaoExportar_Click;
            // 
            // TelaRecomendacaoResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 430);
            Controls.Add(BotaoExportar);
            Controls.Add(TextBoxRecomenda);
            Controls.Add(PanelHeader);
            Controls.Add(BotaoFechar);
            Controls.Add(DataGridViewResultados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaRecomendacaoResultados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados de Recomendação";
            ((System.ComponentModel.ISupportInitialize)DataGridViewResultados).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewResultados;
        private Button BotaoFechar;
        private Label LabelResultados;
        private Panel PanelHeader;
        private TextBox TextBoxRecomenda;
        private Button BotaoExportar;
    }
}
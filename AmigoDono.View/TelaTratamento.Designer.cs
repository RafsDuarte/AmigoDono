namespace AmigoDono.View
{
    partial class TelaTratamento
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
            this.LblTipoCuidado = new System.Windows.Forms.Label();
            this.LblHistoricoPet = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.TxtIdResponsavel = new System.Windows.Forms.TextBox();
            this.LblResponsavel = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.DteTimePickerDataTratamento = new System.Windows.Forms.DateTimePicker();
            this.TxtNomePet = new System.Windows.Forms.TextBox();
            this.TxtIdPet = new System.Windows.Forms.TextBox();
            this.LblPet = new System.Windows.Forms.Label();
            this.LblDataTratamento = new System.Windows.Forms.Label();
            this.GrdHistoricoTratamento = new System.Windows.Forms.DataGridView();
            this.CboTipoCuidado = new System.Windows.Forms.ComboBox();
            this.BtnBuscarPet = new System.Windows.Forms.Button();
            this.BtnBuscarResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdHistoricoTratamento)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTipoCuidado
            // 
            this.LblTipoCuidado.AutoSize = true;
            this.LblTipoCuidado.Location = new System.Drawing.Point(41, 108);
            this.LblTipoCuidado.Name = "LblTipoCuidado";
            this.LblTipoCuidado.Size = new System.Drawing.Size(84, 13);
            this.LblTipoCuidado.TabIndex = 6;
            this.LblTipoCuidado.Text = "Tipo de cuidado";
            // 
            // LblHistoricoPet
            // 
            this.LblHistoricoPet.AutoSize = true;
            this.LblHistoricoPet.Location = new System.Drawing.Point(16, 288);
            this.LblHistoricoPet.Name = "LblHistoricoPet";
            this.LblHistoricoPet.Size = new System.Drawing.Size(109, 13);
            this.LblHistoricoPet.TabIndex = 17;
            this.LblHistoricoPet.Text = "HISTORICO DO PET";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(375, 256);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(153, 256);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncluir.TabIndex = 14;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(260, 256);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 15;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // TxtNomeResponsavel
            // 
            this.TxtNomeResponsavel.Location = new System.Drawing.Point(155, 140);
            this.TxtNomeResponsavel.Name = "TxtNomeResponsavel";
            this.TxtNomeResponsavel.Size = new System.Drawing.Size(365, 20);
            this.TxtNomeResponsavel.TabIndex = 9;
            // 
            // TxtIdResponsavel
            // 
            this.TxtIdResponsavel.Location = new System.Drawing.Point(584, 141);
            this.TxtIdResponsavel.Name = "TxtIdResponsavel";
            this.TxtIdResponsavel.Size = new System.Drawing.Size(57, 20);
            this.TxtIdResponsavel.TabIndex = 13;
            // 
            // LblResponsavel
            // 
            this.LblResponsavel.AutoSize = true;
            this.LblResponsavel.Location = new System.Drawing.Point(56, 144);
            this.LblResponsavel.Name = "LblResponsavel";
            this.LblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.LblResponsavel.TabIndex = 8;
            this.LblResponsavel.Text = "Responsavel";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(154, 181);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(521, 58);
            this.TxtDescricao.TabIndex = 11;
            this.TxtDescricao.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(64, 184);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(55, 13);
            this.LblDescricao.TabIndex = 10;
            this.LblDescricao.Text = "Descrição";
            // 
            // DteTimePickerDataTratamento
            // 
            this.DteTimePickerDataTratamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerDataTratamento.Location = new System.Drawing.Point(154, 30);
            this.DteTimePickerDataTratamento.Name = "DteTimePickerDataTratamento";
            this.DteTimePickerDataTratamento.Size = new System.Drawing.Size(101, 20);
            this.DteTimePickerDataTratamento.TabIndex = 1;
            this.DteTimePickerDataTratamento.ValueChanged += new System.EventHandler(this.dateTimePickerTratamento_ValueChanged);
            // 
            // TxtNomePet
            // 
            this.TxtNomePet.Location = new System.Drawing.Point(155, 65);
            this.TxtNomePet.Name = "TxtNomePet";
            this.TxtNomePet.Size = new System.Drawing.Size(365, 20);
            this.TxtNomePet.TabIndex = 3;
            // 
            // TxtIdPet
            // 
            this.TxtIdPet.Location = new System.Drawing.Point(584, 66);
            this.TxtIdPet.Name = "TxtIdPet";
            this.TxtIdPet.Size = new System.Drawing.Size(57, 20);
            this.TxtIdPet.TabIndex = 5;
            // 
            // LblPet
            // 
            this.LblPet.AutoSize = true;
            this.LblPet.Location = new System.Drawing.Point(102, 72);
            this.LblPet.Name = "LblPet";
            this.LblPet.Size = new System.Drawing.Size(23, 13);
            this.LblPet.TabIndex = 2;
            this.LblPet.Text = "Pet";
            // 
            // LblDataTratamento
            // 
            this.LblDataTratamento.AutoSize = true;
            this.LblDataTratamento.Location = new System.Drawing.Point(27, 37);
            this.LblDataTratamento.Name = "LblDataTratamento";
            this.LblDataTratamento.Size = new System.Drawing.Size(98, 13);
            this.LblDataTratamento.TabIndex = 0;
            this.LblDataTratamento.Text = "Data da tratamento";
            // 
            // GrdHistoricoTratamento
            // 
            this.GrdHistoricoTratamento.AllowUserToAddRows = false;
            this.GrdHistoricoTratamento.AllowUserToDeleteRows = false;
            this.GrdHistoricoTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdHistoricoTratamento.Location = new System.Drawing.Point(12, 318);
            this.GrdHistoricoTratamento.Name = "GrdHistoricoTratamento";
            this.GrdHistoricoTratamento.Size = new System.Drawing.Size(776, 140);
            this.GrdHistoricoTratamento.TabIndex = 18;
            // 
            // CboTipoCuidado
            // 
            this.CboTipoCuidado.AutoCompleteCustomSource.AddRange(new string[] {
            "Vacinas de Raiva",
            "Curativo",
            "Medicamento"});
            this.CboTipoCuidado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboTipoCuidado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoCuidado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCuidado.FormattingEnabled = true;
            this.CboTipoCuidado.Items.AddRange(new object[] {
            "Vacinas de Raiva",
            "Curativo",
            "Medicamento"});
            this.CboTipoCuidado.Location = new System.Drawing.Point(155, 100);
            this.CboTipoCuidado.Name = "CboTipoCuidado";
            this.CboTipoCuidado.Size = new System.Drawing.Size(239, 21);
            this.CboTipoCuidado.TabIndex = 7;
            // 
            // BtnBuscarPet
            // 
            this.BtnBuscarPet.Location = new System.Drawing.Point(526, 63);
            this.BtnBuscarPet.Name = "BtnBuscarPet";
            this.BtnBuscarPet.Size = new System.Drawing.Size(52, 23);
            this.BtnBuscarPet.TabIndex = 4;
            this.BtnBuscarPet.Text = "Buscar";
            this.BtnBuscarPet.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarResp
            // 
            this.BtnBuscarResp.Location = new System.Drawing.Point(526, 138);
            this.BtnBuscarResp.Name = "BtnBuscarResp";
            this.BtnBuscarResp.Size = new System.Drawing.Size(52, 23);
            this.BtnBuscarResp.TabIndex = 12;
            this.BtnBuscarResp.Text = "Buscar";
            this.BtnBuscarResp.UseVisualStyleBackColor = true;
            // 
            // TelaTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.BtnBuscarResp);
            this.Controls.Add(this.BtnBuscarPet);
            this.Controls.Add(this.CboTipoCuidado);
            this.Controls.Add(this.GrdHistoricoTratamento);
            this.Controls.Add(this.LblTipoCuidado);
            this.Controls.Add(this.LblHistoricoPet);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TxtNomeResponsavel);
            this.Controls.Add(this.TxtIdResponsavel);
            this.Controls.Add(this.LblResponsavel);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.DteTimePickerDataTratamento);
            this.Controls.Add(this.TxtNomePet);
            this.Controls.Add(this.TxtIdPet);
            this.Controls.Add(this.LblPet);
            this.Controls.Add(this.LblDataTratamento);
            this.Name = "TelaTratamento";
            this.Text = "Tratamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaTratamento_FormClosed_1);
            this.Load += new System.EventHandler(this.TelaTratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdHistoricoTratamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTipoCuidado;
        private System.Windows.Forms.Label LblHistoricoPet;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtNomeResponsavel;
        private System.Windows.Forms.TextBox TxtIdResponsavel;
        private System.Windows.Forms.Label LblResponsavel;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.DateTimePicker DteTimePickerDataTratamento;
        private System.Windows.Forms.TextBox TxtNomePet;
        private System.Windows.Forms.TextBox TxtIdPet;
        private System.Windows.Forms.Label LblPet;
        private System.Windows.Forms.Label LblDataTratamento;
        private System.Windows.Forms.DataGridView GrdHistoricoTratamento;
        private System.Windows.Forms.ComboBox CboTipoCuidado;
        private System.Windows.Forms.Button BtnBuscarPet;
        private System.Windows.Forms.Button BtnBuscarResp;
    }
}
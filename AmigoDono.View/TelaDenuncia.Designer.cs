namespace AmigoDono.View
{
    partial class TelaDenuncia
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
            this.components = new System.ComponentModel.Container();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DteTimePickerResposta = new System.Windows.Forms.DateTimePicker();
            this.DteTimePickerDenuncia = new System.Windows.Forms.DateTimePicker();
            this.LblDataResposta = new System.Windows.Forms.Label();
            this.TxtDenunciante = new System.Windows.Forms.TextBox();
            this.LblDenunciante = new System.Windows.Forms.Label();
            this.TxtTestoDenuncia = new System.Windows.Forms.TextBox();
            this.LblTextoDenuncia = new System.Windows.Forms.Label();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.LblComplemento = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TxtCep = new System.Windows.Forms.TextBox();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.TxtUF = new System.Windows.Forms.TextBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNomeLogradouro = new System.Windows.Forms.Label();
            this.LblTipoLogradouro = new System.Windows.Forms.Label();
            this.LblDenuncia = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.dENUNCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.TxtIDD = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dENUNCIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(345, 435);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 30;
            this.BtnSair.Text = "sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DteTimePickerResposta
            // 
            this.DteTimePickerResposta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerResposta.Location = new System.Drawing.Point(362, 59);
            this.DteTimePickerResposta.Name = "DteTimePickerResposta";
            this.DteTimePickerResposta.Size = new System.Drawing.Size(97, 20);
            this.DteTimePickerResposta.TabIndex = 5;
            // 
            // DteTimePickerDenuncia
            // 
            this.DteTimePickerDenuncia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerDenuncia.Location = new System.Drawing.Point(139, 57);
            this.DteTimePickerDenuncia.Name = "DteTimePickerDenuncia";
            this.DteTimePickerDenuncia.Size = new System.Drawing.Size(100, 20);
            this.DteTimePickerDenuncia.TabIndex = 3;
            // 
            // LblDataResposta
            // 
            this.LblDataResposta.AutoSize = true;
            this.LblDataResposta.Location = new System.Drawing.Point(257, 63);
            this.LblDataResposta.Name = "LblDataResposta";
            this.LblDataResposta.Size = new System.Drawing.Size(93, 13);
            this.LblDataResposta.TabIndex = 4;
            this.LblDataResposta.Text = "Data da Resposta";
            // 
            // TxtDenunciante
            // 
            this.TxtDenunciante.Location = new System.Drawing.Point(139, 97);
            this.TxtDenunciante.Name = "TxtDenunciante";
            this.TxtDenunciante.Size = new System.Drawing.Size(354, 20);
            this.TxtDenunciante.TabIndex = 7;
            // 
            // LblDenunciante
            // 
            this.LblDenunciante.AutoSize = true;
            this.LblDenunciante.Location = new System.Drawing.Point(54, 104);
            this.LblDenunciante.Name = "LblDenunciante";
            this.LblDenunciante.Size = new System.Drawing.Size(68, 13);
            this.LblDenunciante.TabIndex = 6;
            this.LblDenunciante.Text = "Denunciante";
            // 
            // TxtTestoDenuncia
            // 
            this.TxtTestoDenuncia.Location = new System.Drawing.Point(139, 343);
            this.TxtTestoDenuncia.Multiline = true;
            this.TxtTestoDenuncia.Name = "TxtTestoDenuncia";
            this.TxtTestoDenuncia.Size = new System.Drawing.Size(519, 67);
            this.TxtTestoDenuncia.TabIndex = 27;
            // 
            // LblTextoDenuncia
            // 
            this.LblTextoDenuncia.AutoSize = true;
            this.LblTextoDenuncia.Location = new System.Drawing.Point(69, 346);
            this.LblTextoDenuncia.Name = "LblTextoDenuncia";
            this.LblTextoDenuncia.Size = new System.Drawing.Size(53, 13);
            this.LblTextoDenuncia.TabIndex = 26;
            this.LblTextoDenuncia.Text = "Denuncia";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(139, 239);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(521, 20);
            this.TxtComplemento.TabIndex = 17;
            // 
            // LblComplemento
            // 
            this.LblComplemento.AutoSize = true;
            this.LblComplemento.Location = new System.Drawing.Point(51, 246);
            this.LblComplemento.Name = "LblComplemento";
            this.LblComplemento.Size = new System.Drawing.Size(71, 13);
            this.LblComplemento.TabIndex = 16;
            this.LblComplemento.Text = "Complemento";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(139, 135);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(521, 20);
            this.TxtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(90, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(560, 308);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(100, 20);
            this.TxtCep.TabIndex = 25;
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(514, 315);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(28, 13);
            this.LblCEP.TabIndex = 24;
            this.LblCEP.Text = "CEP";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(139, 274);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(521, 20);
            this.TxtBairro.TabIndex = 19;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(82, 281);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(34, 13);
            this.LblBairro.TabIndex = 18;
            this.LblBairro.Text = "Bairro";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(139, 305);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(200, 20);
            this.TxtCidade.TabIndex = 21;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(612, 209);
            this.TxtNumero.MaxLength = 3;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(27, 20);
            this.TxtNumero.TabIndex = 15;
            // 
            // TxtNomeLogradouro
            // 
            this.TxtNomeLogradouro.Location = new System.Drawing.Point(139, 209);
            this.TxtNomeLogradouro.Name = "TxtNomeLogradouro";
            this.TxtNomeLogradouro.Size = new System.Drawing.Size(403, 20);
            this.TxtNomeLogradouro.TabIndex = 13;
            // 
            // TxtUF
            // 
            this.TxtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUF.Location = new System.Drawing.Point(397, 305);
            this.TxtUF.MaxLength = 2;
            this.TxtUF.Name = "TxtUF";
            this.TxtUF.Size = new System.Drawing.Size(23, 20);
            this.TxtUF.TabIndex = 23;
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Location = new System.Drawing.Point(359, 312);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(21, 13);
            this.LblUF.TabIndex = 22;
            this.LblUF.Text = "UF";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(82, 315);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(40, 13);
            this.LblCidade.TabIndex = 20;
            this.LblCidade.Text = "Cidade";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(557, 216);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(44, 13);
            this.LblNumero.TabIndex = 14;
            this.LblNumero.Text = "Numero";
            // 
            // LblNomeLogradouro
            // 
            this.LblNomeLogradouro.AutoSize = true;
            this.LblNomeLogradouro.Location = new System.Drawing.Point(15, 216);
            this.LblNomeLogradouro.Name = "LblNomeLogradouro";
            this.LblNomeLogradouro.Size = new System.Drawing.Size(107, 13);
            this.LblNomeLogradouro.TabIndex = 12;
            this.LblNomeLogradouro.Text = "Nome do Logradouro";
            // 
            // LblTipoLogradouro
            // 
            this.LblTipoLogradouro.AutoSize = true;
            this.LblTipoLogradouro.Location = new System.Drawing.Point(22, 174);
            this.LblTipoLogradouro.Name = "LblTipoLogradouro";
            this.LblTipoLogradouro.Size = new System.Drawing.Size(100, 13);
            this.LblTipoLogradouro.TabIndex = 10;
            this.LblTipoLogradouro.Text = "Tipo de Logradouro";
            // 
            // LblDenuncia
            // 
            this.LblDenuncia.AutoSize = true;
            this.LblDenuncia.Location = new System.Drawing.Point(28, 64);
            this.LblDenuncia.Name = "LblDenuncia";
            this.LblDenuncia.Size = new System.Drawing.Size(94, 13);
            this.LblDenuncia.TabIndex = 2;
            this.LblDenuncia.Text = "Data da Denuncia";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(145, 435);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 28;
            this.BtnSalvar.Text = "salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(245, 435);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 29;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // dENUNCIABindingSource
            // 
            this.dENUNCIABindingSource.DataMember = "DENUNCIA";
            // 
            // CboTipoLogradouro
            // 
            this.CboTipoLogradouro.AutoCompleteCustomSource.AddRange(new string[] {
            "Vila ",
            "Largo ",
            "Travessa ",
            "Viela ",
            "Loteamento ",
            "Pátio",
            "Viaduto ",
            "Área",
            "Via ",
            "Aeroporto ",
            "Vereda",
            "Distrito ",
            "Vale ",
            "Núcleo ",
            "Trevo ",
            "Fazenda ",
            "Trecho ",
            "Estrada ",
            "Sítio",
            "Feira ",
            "Setor ",
            "Morro ",
            "Rua",
            "Chácara ",
            "Rodovia ",
            "Residencial ",
            "Avenida",
            "Colônia ",
            "Recanto ",
            "Quadra ",
            "Praça ",
            "Condomínio ",
            "Passarela ",
            "Parque ",
            "Esplanada ",
            "Lagoa",
            "Favela ",
            "Ladeira ",
            "Lago ",
            "Conjunto ",
            "Jardim",
            "Estação ",
            "Campo",
            "Alameda"});
            this.CboTipoLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboTipoLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoLogradouro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoLogradouro.FormattingEnabled = true;
            this.CboTipoLogradouro.Items.AddRange(new object[] {
            "Vila ",
            "Largo ",
            "Travessa ",
            "Viela ",
            "Loteamento ",
            "Pátio",
            "Viaduto ",
            "Área",
            "Via ",
            "Aeroporto ",
            "Vereda",
            "Distrito ",
            "Vale ",
            "Núcleo ",
            "Trevo ",
            "Fazenda ",
            "Trecho ",
            "Estrada ",
            "Sítio",
            "Feira ",
            "Setor ",
            "Morro ",
            "Rua",
            "Chácara ",
            "Rodovia ",
            "Residencial ",
            "Avenida",
            "Colônia ",
            "Recanto ",
            "Quadra ",
            "Praça ",
            "Condomínio ",
            "Passarela ",
            "Parque ",
            "Esplanada ",
            "Lagoa",
            "Favela ",
            "Ladeira ",
            "Lago ",
            "Conjunto ",
            "Jardim",
            "Estação ",
            "Campo",
            "Alameda"});
            this.CboTipoLogradouro.Location = new System.Drawing.Point(139, 170);
            this.CboTipoLogradouro.Name = "CboTipoLogradouro";
            this.CboTipoLogradouro.Size = new System.Drawing.Size(101, 21);
            this.CboTipoLogradouro.TabIndex = 11;
            // 
            // TxtIDD
            // 
            this.TxtIDD.Location = new System.Drawing.Point(139, 18);
            this.TxtIDD.Name = "TxtIDD";
            this.TxtIDD.Size = new System.Drawing.Size(87, 20);
            this.TxtIDD.TabIndex = 1;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(104, 25);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            // 
            // TelaDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 481);
            this.Controls.Add(this.TxtIDD);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.CboTipoLogradouro);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.DteTimePickerResposta);
            this.Controls.Add(this.DteTimePickerDenuncia);
            this.Controls.Add(this.LblDataResposta);
            this.Controls.Add(this.TxtDenunciante);
            this.Controls.Add(this.LblDenunciante);
            this.Controls.Add(this.TxtTestoDenuncia);
            this.Controls.Add(this.LblTextoDenuncia);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.LblComplemento);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.LblCEP);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtNomeLogradouro);
            this.Controls.Add(this.TxtUF);
            this.Controls.Add(this.LblUF);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblNomeLogradouro);
            this.Controls.Add(this.LblTipoLogradouro);
            this.Controls.Add(this.LblDenuncia);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Name = "TelaDenuncia";
            this.Text = "Denuncia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaDenuncia_FormClosed);
            this.Load += new System.EventHandler(this.TelaDenuncia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dENUNCIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DateTimePicker DteTimePickerResposta;
        private System.Windows.Forms.DateTimePicker DteTimePickerDenuncia;
        private System.Windows.Forms.Label LblDataResposta;
        private System.Windows.Forms.TextBox TxtDenunciante;
        private System.Windows.Forms.Label LblDenunciante;
        private System.Windows.Forms.TextBox TxtTestoDenuncia;
        private System.Windows.Forms.Label LblTextoDenuncia;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label LblComplemento;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TxtCep;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNomeLogradouro;
        private System.Windows.Forms.TextBox TxtUF;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNomeLogradouro;
        private System.Windows.Forms.Label LblTipoLogradouro;
        private System.Windows.Forms.Label LblDenuncia;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.BindingSource dENUNCIABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denuncianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDenunciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLogradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRespostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CboTipoLogradouro;
        private System.Windows.Forms.TextBox TxtIDD;
        private System.Windows.Forms.Label LblID;
    }
}
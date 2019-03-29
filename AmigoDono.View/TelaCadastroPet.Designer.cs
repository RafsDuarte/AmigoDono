namespace AmigoDono.View
{
    partial class TelaCadastroPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroPet));
            this.CboTipoPet = new System.Windows.Forms.ComboBox();
            this.CboIdade = new System.Windows.Forms.ComboBox();
            this.CboCastrado = new System.Windows.Forms.ComboBox();
            this.CboPorte = new System.Windows.Forms.ComboBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.LblTipoPet = new System.Windows.Forms.Label();
            this.LblCastrado = new System.Windows.Forms.Label();
            this.LblPorte = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblIdade = new System.Windows.Forms.Label();
            this.DteTimePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.LblNascimento = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtIDPet = new System.Windows.Forms.TextBox();
            this.LblIDPet = new System.Windows.Forms.Label();
            this.TxtOBS = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.LblRaca = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEscolherFoto = new System.Windows.Forms.Button();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.CboSituacao = new System.Windows.Forms.ComboBox();
            this.LblSituacao = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.DteTimePickerCadastro = new System.Windows.Forms.DateTimePicker();
            this.CboRaca = new System.Windows.Forms.ComboBox();
            this.rAÇABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rAÇABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CboTipoPet
            // 
            this.CboTipoPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPet.FormattingEnabled = true;
            this.CboTipoPet.Items.AddRange(new object[] {
            "Cão",
            "Gato"});
            this.CboTipoPet.Location = new System.Drawing.Point(510, 146);
            this.CboTipoPet.Name = "CboTipoPet";
            this.CboTipoPet.Size = new System.Drawing.Size(55, 21);
            this.CboTipoPet.TabIndex = 237;
            // 
            // CboIdade
            // 
            this.CboIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboIdade.FormattingEnabled = true;
            this.CboIdade.Items.AddRange(new object[] {
            "Filhote",
            "Jovem",
            "Adulto"});
            this.CboIdade.Location = new System.Drawing.Point(311, 146);
            this.CboIdade.Name = "CboIdade";
            this.CboIdade.Size = new System.Drawing.Size(121, 21);
            this.CboIdade.TabIndex = 236;
            // 
            // CboCastrado
            // 
            this.CboCastrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCastrado.FormattingEnabled = true;
            this.CboCastrado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.CboCastrado.Location = new System.Drawing.Point(333, 224);
            this.CboCastrado.Name = "CboCastrado";
            this.CboCastrado.Size = new System.Drawing.Size(53, 21);
            this.CboCastrado.TabIndex = 235;
            // 
            // CboPorte
            // 
            this.CboPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPorte.FormattingEnabled = true;
            this.CboPorte.Items.AddRange(new object[] {
            "Mini",
            "Pequeno",
            "Medio",
            "Grande"});
            this.CboPorte.Location = new System.Drawing.Point(154, 224);
            this.CboPorte.Name = "CboPorte";
            this.CboPorte.Size = new System.Drawing.Size(100, 21);
            this.CboPorte.TabIndex = 234;
            // 
            // CboSexo
            // 
            this.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CboSexo.Location = new System.Drawing.Point(422, 190);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(80, 21);
            this.CboSexo.TabIndex = 233;
            // 
            // LblTipoPet
            // 
            this.LblTipoPet.AutoSize = true;
            this.LblTipoPet.Location = new System.Drawing.Point(438, 150);
            this.LblTipoPet.Name = "LblTipoPet";
            this.LblTipoPet.Size = new System.Drawing.Size(47, 13);
            this.LblTipoPet.TabIndex = 230;
            this.LblTipoPet.Text = "Tipo Pet";
            // 
            // LblCastrado
            // 
            this.LblCastrado.AutoSize = true;
            this.LblCastrado.Location = new System.Drawing.Point(278, 232);
            this.LblCastrado.Name = "LblCastrado";
            this.LblCastrado.Size = new System.Drawing.Size(49, 13);
            this.LblCastrado.TabIndex = 229;
            this.LblCastrado.Text = "Castrado";
            // 
            // LblPorte
            // 
            this.LblPorte.AutoSize = true;
            this.LblPorte.Location = new System.Drawing.Point(81, 232);
            this.LblPorte.Name = "LblPorte";
            this.LblPorte.Size = new System.Drawing.Size(32, 13);
            this.LblPorte.TabIndex = 228;
            this.LblPorte.Text = "Porte";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(371, 192);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 227;
            this.LblSexo.Text = "Sexo";
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Location = new System.Drawing.Point(260, 154);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(34, 13);
            this.LblIdade.TabIndex = 222;
            this.LblIdade.Text = "Idade";
            // 
            // DteTimePickerNasc
            // 
            this.DteTimePickerNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerNasc.Location = new System.Drawing.Point(154, 151);
            this.DteTimePickerNasc.Name = "DteTimePickerNasc";
            this.DteTimePickerNasc.Size = new System.Drawing.Size(99, 20);
            this.DteTimePickerNasc.TabIndex = 221;
            // 
            // LblNascimento
            // 
            this.LblNascimento.AutoSize = true;
            this.LblNascimento.Location = new System.Drawing.Point(24, 158);
            this.LblNascimento.Name = "LblNascimento";
            this.LblNascimento.Size = new System.Drawing.Size(89, 13);
            this.LblNascimento.TabIndex = 220;
            this.LblNascimento.Text = "Data Nascimento";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(357, 355);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 215;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(154, 114);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(365, 20);
            this.TxtNome.TabIndex = 214;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(78, 121);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 213;
            this.LblNome.Text = "Nome";
            // 
            // TxtIDPet
            // 
            this.TxtIDPet.Location = new System.Drawing.Point(153, 52);
            this.TxtIDPet.Name = "TxtIDPet";
            this.TxtIDPet.Size = new System.Drawing.Size(87, 20);
            this.TxtIDPet.TabIndex = 212;
            // 
            // LblIDPet
            // 
            this.LblIDPet.AutoSize = true;
            this.LblIDPet.Location = new System.Drawing.Point(76, 59);
            this.LblIDPet.Name = "LblIDPet";
            this.LblIDPet.Size = new System.Drawing.Size(37, 13);
            this.LblIDPet.TabIndex = 211;
            this.LblIDPet.Text = "ID Pet";
            // 
            // TxtOBS
            // 
            this.TxtOBS.Location = new System.Drawing.Point(153, 259);
            this.TxtOBS.Multiline = true;
            this.TxtOBS.Name = "TxtOBS";
            this.TxtOBS.Size = new System.Drawing.Size(519, 80);
            this.TxtOBS.TabIndex = 210;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Location = new System.Drawing.Point(48, 266);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(65, 13);
            this.LblObs.TabIndex = 209;
            this.LblObs.Text = "Observação";
            // 
            // LblRaca
            // 
            this.LblRaca.AutoSize = true;
            this.LblRaca.Location = new System.Drawing.Point(80, 193);
            this.LblRaca.Name = "LblRaca";
            this.LblRaca.Size = new System.Drawing.Size(33, 13);
            this.LblRaca.TabIndex = 207;
            this.LblRaca.Text = "Raça";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(153, 355);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 206;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(253, 355);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 203;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEscolherFoto
            // 
            this.BtnEscolherFoto.Location = new System.Drawing.Point(678, 257);
            this.BtnEscolherFoto.Name = "BtnEscolherFoto";
            this.BtnEscolherFoto.Size = new System.Drawing.Size(100, 23);
            this.BtnEscolherFoto.TabIndex = 245;
            this.BtnEscolherFoto.Text = "Escolher Foto";
            this.BtnEscolherFoto.UseVisualStyleBackColor = true;
            this.BtnEscolherFoto.Click += new System.EventHandler(this.BtnEscolherFoto_Click);
            // 
            // PbFoto
            // 
            this.PbFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbFoto.Image")));
            this.PbFoto.Location = new System.Drawing.Point(619, 65);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(201, 180);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 244;
            this.PbFoto.TabStop = false;
            // 
            // CboSituacao
            // 
            this.CboSituacao.AutoCompleteCustomSource.AddRange(new string[] {
            "Adotado",
            "Disposiçao",
            "Tratamento"});
            this.CboSituacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboSituacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSituacao.FormattingEnabled = true;
            this.CboSituacao.Items.AddRange(new object[] {
            "Adotado",
            "Disposiçao",
            "Tratamento"});
            this.CboSituacao.Location = new System.Drawing.Point(364, 84);
            this.CboSituacao.Name = "CboSituacao";
            this.CboSituacao.Size = new System.Drawing.Size(121, 21);
            this.CboSituacao.TabIndex = 246;
            // 
            // LblSituacao
            // 
            this.LblSituacao.AutoSize = true;
            this.LblSituacao.Location = new System.Drawing.Point(311, 91);
            this.LblSituacao.Name = "LblSituacao";
            this.LblSituacao.Size = new System.Drawing.Size(49, 13);
            this.LblSituacao.TabIndex = 247;
            this.LblSituacao.Text = "Situação";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Location = new System.Drawing.Point(64, 92);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(49, 13);
            this.LblCadastro.TabIndex = 248;
            this.LblCadastro.Text = "Cadastro";
            // 
            // DteTimePickerCadastro
            // 
            this.DteTimePickerCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerCadastro.Location = new System.Drawing.Point(153, 85);
            this.DteTimePickerCadastro.Name = "DteTimePickerCadastro";
            this.DteTimePickerCadastro.Size = new System.Drawing.Size(99, 20);
            this.DteTimePickerCadastro.TabIndex = 249;
            // 
            // CboRaca
            // 
            this.CboRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRaca.FormattingEnabled = true;
            this.CboRaca.Location = new System.Drawing.Point(153, 190);
            this.CboRaca.Name = "CboRaca";
            this.CboRaca.Size = new System.Drawing.Size(198, 21);
            this.CboRaca.TabIndex = 250;
            this.CboRaca.SelectedIndexChanged += new System.EventHandler(this.CboRaca_SelectedIndexChanged);
            // 
            // rAÇABindingSource1
            // 
            this.rAÇABindingSource1.DataMember = "RAÇA";
            // 
            // rAÇABindingSource
            // 
            this.rAÇABindingSource.DataMember = "RAÇA";
            // 
            // TelaCadastroPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 405);
            this.Controls.Add(this.CboRaca);
            this.Controls.Add(this.DteTimePickerCadastro);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.LblSituacao);
            this.Controls.Add(this.CboSituacao);
            this.Controls.Add(this.BtnEscolherFoto);
            this.Controls.Add(this.PbFoto);
            this.Controls.Add(this.CboTipoPet);
            this.Controls.Add(this.CboIdade);
            this.Controls.Add(this.CboCastrado);
            this.Controls.Add(this.CboPorte);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.LblTipoPet);
            this.Controls.Add(this.LblCastrado);
            this.Controls.Add(this.LblPorte);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblIdade);
            this.Controls.Add(this.DteTimePickerNasc);
            this.Controls.Add(this.LblNascimento);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtIDPet);
            this.Controls.Add(this.LblIDPet);
            this.Controls.Add(this.TxtOBS);
            this.Controls.Add(this.LblObs);
            this.Controls.Add(this.LblRaca);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Name = "TelaCadastroPet";
            this.Text = "Cadastro de Pets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroPet_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTipoPet;
        private System.Windows.Forms.ComboBox CboIdade;
        private System.Windows.Forms.ComboBox CboCastrado;
        private System.Windows.Forms.ComboBox CboPorte;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.Label LblTipoPet;
        private System.Windows.Forms.Label LblCastrado;
        private System.Windows.Forms.Label LblPorte;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.DateTimePicker DteTimePickerNasc;
        private System.Windows.Forms.Label LblNascimento;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtIDPet;
        private System.Windows.Forms.Label LblIDPet;
        private System.Windows.Forms.TextBox TxtOBS;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.Label LblRaca;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEscolherFoto;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.ComboBox CboSituacao;
        private System.Windows.Forms.Label LblSituacao;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.DateTimePicker DteTimePickerCadastro;
        private System.Windows.Forms.ComboBox CboRaca;
        private System.Windows.Forms.BindingSource rAÇABindingSource;
        private System.Windows.Forms.BindingSource rAÇABindingSource1;
    }
}
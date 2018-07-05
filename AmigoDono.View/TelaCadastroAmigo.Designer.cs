namespace AmigoDono.View
{
    partial class TelaCadastroAmigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroAmigo));
            this.CboTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.BtnEscolherFoto = new System.Windows.Forms.Button();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.MskCelular = new System.Windows.Forms.MaskedTextBox();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CboFuncao = new System.Windows.Forms.ComboBox();
            this.LblFuncao = new System.Windows.Forms.Label();
            this.TxtAjuda = new System.Windows.Forms.TextBox();
            this.LblAjuda = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.DteTimePickerCadastro = new System.Windows.Forms.DateTimePicker();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.LblComplemento = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.DteTimePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.TxtUF = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblNomeLogradouro = new System.Windows.Forms.Label();
            this.LblTipoLogradouro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblIDAmigo = new System.Windows.Forms.Label();
            this.TxtIDAmigo = new System.Windows.Forms.TextBox();
            this.LblCNPJ = new System.Windows.Forms.Label();
            this.MskCPF = new System.Windows.Forms.MaskedTextBox();
            this.MskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.MskCEP = new System.Windows.Forms.MaskedTextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            this.SuspendLayout();
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
            this.CboTipoLogradouro.Location = new System.Drawing.Point(108, 206);
            this.CboTipoLogradouro.Name = "CboTipoLogradouro";
            this.CboTipoLogradouro.Size = new System.Drawing.Size(101, 21);
            this.CboTipoLogradouro.TabIndex = 22;
            // 
            // BtnEscolherFoto
            // 
            this.BtnEscolherFoto.Location = new System.Drawing.Point(693, 236);
            this.BtnEscolherFoto.Name = "BtnEscolherFoto";
            this.BtnEscolherFoto.Size = new System.Drawing.Size(106, 23);
            this.BtnEscolherFoto.TabIndex = 14;
            this.BtnEscolherFoto.Text = "Escolher Foto";
            this.BtnEscolherFoto.UseVisualStyleBackColor = true;
            this.BtnEscolherFoto.Click += new System.EventHandler(this.BtnEscolherFoto_Click);
            // 
            // PbFoto
            // 
            this.PbFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbFoto.Image")));
            this.PbFoto.Location = new System.Drawing.Point(646, 67);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(192, 153);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 242;
            this.PbFoto.TabStop = false;
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Location = new System.Drawing.Point(432, 288);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(21, 13);
            this.LblUF.TabIndex = 33;
            this.LblUF.Text = "UF";
            // 
            // MskCelular
            // 
            this.MskCelular.Location = new System.Drawing.Point(249, 316);
            this.MskCelular.Mask = "(99)00000-0000";
            this.MskCelular.Name = "MskCelular";
            this.MskCelular.Size = new System.Drawing.Size(85, 20);
            this.MskCelular.TabIndex = 38;
            // 
            // MskTelefone
            // 
            this.MskTelefone.Location = new System.Drawing.Point(108, 315);
            this.MskTelefone.Mask = "(99)0000-0000";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(83, 20);
            this.MskTelefone.TabIndex = 36;
            // 
            // CboFuncao
            // 
            this.CboFuncao.AutoCompleteCustomSource.AddRange(new string[] {
            "Amigo (Usuário)",
            "Proprietario",
            "Cuidador",
            "Veterinario",
            "Patrocinador",
            "Clínica",
            "Empresa Patrocinadora"});
            this.CboFuncao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboFuncao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFuncao.FormattingEnabled = true;
            this.CboFuncao.Items.AddRange(new object[] {
            "Amigo (Usuário)",
            "Proprietario",
            "Cuidador",
            "Veterinario",
            "Patrocinador",
            "Clínica",
            "Empresa Patrocinadora"});
            this.CboFuncao.Location = new System.Drawing.Point(108, 71);
            this.CboFuncao.Name = "CboFuncao";
            this.CboFuncao.Size = new System.Drawing.Size(222, 21);
            this.CboFuncao.TabIndex = 3;
            this.CboFuncao.SelectedIndexChanged += new System.EventHandler(this.CboFuncao_SelectedIndexChanged);
            // 
            // LblFuncao
            // 
            this.LblFuncao.AutoSize = true;
            this.LblFuncao.Location = new System.Drawing.Point(60, 71);
            this.LblFuncao.Name = "LblFuncao";
            this.LblFuncao.Size = new System.Drawing.Size(43, 13);
            this.LblFuncao.TabIndex = 2;
            this.LblFuncao.Text = "Função";
            // 
            // TxtAjuda
            // 
            this.TxtAjuda.Location = new System.Drawing.Point(293, 102);
            this.TxtAjuda.Name = "TxtAjuda";
            this.TxtAjuda.Size = new System.Drawing.Size(233, 20);
            this.TxtAjuda.TabIndex = 7;
            this.TxtAjuda.Visible = false;
            // 
            // LblAjuda
            // 
            this.LblAjuda.AutoSize = true;
            this.LblAjuda.Location = new System.Drawing.Point(253, 105);
            this.LblAjuda.Name = "LblAjuda";
            this.LblAjuda.Size = new System.Drawing.Size(34, 13);
            this.LblAjuda.TabIndex = 6;
            this.LblAjuda.Text = "Ajuda";
            this.LblAjuda.Visible = false;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(108, 102);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '#';
            this.TxtSenha.Size = new System.Drawing.Size(139, 20);
            this.TxtSenha.TabIndex = 5;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(65, 102);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(38, 13);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // DteTimePickerCadastro
            // 
            this.DteTimePickerCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerCadastro.Location = new System.Drawing.Point(109, 45);
            this.DteTimePickerCadastro.Name = "DteTimePickerCadastro";
            this.DteTimePickerCadastro.Size = new System.Drawing.Size(100, 20);
            this.DteTimePickerCadastro.TabIndex = 1;
            this.DteTimePickerCadastro.Value = new System.DateTime(2018, 6, 6, 0, 0, 0, 0);
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Location = new System.Drawing.Point(51, 45);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(52, 13);
            this.LblCadastro.TabIndex = 0;
            this.LblCadastro.Text = " Cadastro";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(240, 233);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(378, 20);
            this.TxtComplemento.TabIndex = 28;
            // 
            // LblComplemento
            // 
            this.LblComplemento.AutoSize = true;
            this.LblComplemento.Location = new System.Drawing.Point(163, 236);
            this.LblComplemento.Name = "LblComplemento";
            this.LblComplemento.Size = new System.Drawing.Size(71, 13);
            this.LblComplemento.TabIndex = 27;
            this.LblComplemento.Text = "Complemento";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(109, 233);
            this.TxtNumero.MaxLength = 3;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(28, 20);
            this.TxtNumero.TabIndex = 26;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(59, 233);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(44, 13);
            this.LblNumero.TabIndex = 25;
            this.LblNumero.Text = "Número";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(408, 352);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 40;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(204, 319);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(39, 13);
            this.LblCelular.TabIndex = 37;
            this.LblCelular.Text = "Celular";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(54, 316);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(49, 13);
            this.LblTelefone.TabIndex = 35;
            this.LblTelefone.Text = "Telefone";
            // 
            // DteTimePickerNasc
            // 
            this.DteTimePickerNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerNasc.Location = new System.Drawing.Point(109, 128);
            this.DteTimePickerNasc.Name = "DteTimePickerNasc";
            this.DteTimePickerNasc.Size = new System.Drawing.Size(98, 20);
            this.DteTimePickerNasc.TabIndex = 9;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(109, 155);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(509, 20);
            this.TxtNome.TabIndex = 16;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(68, 159);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 15;
            this.LblNome.Text = "Nome";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(108, 181);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(202, 20);
            this.TxtEmail.TabIndex = 18;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(71, 185);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 17;
            this.LblEmail.Text = "Email";
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(319, 184);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(28, 13);
            this.LblCEP.TabIndex = 19;
            this.LblCEP.Text = "CEP";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(109, 260);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(509, 20);
            this.TxtBairro.TabIndex = 30;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(69, 260);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(34, 13);
            this.LblBairro.TabIndex = 29;
            this.LblBairro.Text = "Bairro";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(108, 285);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(302, 20);
            this.TxtCidade.TabIndex = 32;
            // 
            // TxtNomeLogradouro
            // 
            this.TxtNomeLogradouro.Location = new System.Drawing.Point(328, 207);
            this.TxtNomeLogradouro.Name = "TxtNomeLogradouro";
            this.TxtNomeLogradouro.Size = new System.Drawing.Size(290, 20);
            this.TxtNomeLogradouro.TabIndex = 24;
            // 
            // TxtUF
            // 
            this.TxtUF.Location = new System.Drawing.Point(459, 286);
            this.TxtUF.Name = "TxtUF";
            this.TxtUF.Size = new System.Drawing.Size(24, 20);
            this.TxtUF.TabIndex = 34;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(63, 285);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(40, 13);
            this.LblCidade.TabIndex = 31;
            this.LblCidade.Text = "Cidade";
            // 
            // LblNomeLogradouro
            // 
            this.LblNomeLogradouro.AutoSize = true;
            this.LblNomeLogradouro.Location = new System.Drawing.Point(215, 210);
            this.LblNomeLogradouro.Name = "LblNomeLogradouro";
            this.LblNomeLogradouro.Size = new System.Drawing.Size(107, 13);
            this.LblNomeLogradouro.TabIndex = 23;
            this.LblNomeLogradouro.Text = "Nome do Logradouro";
            // 
            // LblTipoLogradouro
            // 
            this.LblTipoLogradouro.AutoSize = true;
            this.LblTipoLogradouro.Location = new System.Drawing.Point(3, 207);
            this.LblTipoLogradouro.Name = "LblTipoLogradouro";
            this.LblTipoLogradouro.Size = new System.Drawing.Size(100, 13);
            this.LblTipoLogradouro.TabIndex = 21;
            this.LblTipoLogradouro.Text = "Tipo de Logradouro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nascimento";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(200, 352);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 39;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(220, 131);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(27, 13);
            this.LblCPF.TabIndex = 10;
            this.LblCPF.Text = "CPF";
            this.LblCPF.Visible = false;
            // 
            // LblIDAmigo
            // 
            this.LblIDAmigo.AutoSize = true;
            this.LblIDAmigo.Location = new System.Drawing.Point(85, 19);
            this.LblIDAmigo.Name = "LblIDAmigo";
            this.LblIDAmigo.Size = new System.Drawing.Size(18, 13);
            this.LblIDAmigo.TabIndex = 0;
            this.LblIDAmigo.Text = "ID";
            // 
            // TxtIDAmigo
            // 
            this.TxtIDAmigo.Location = new System.Drawing.Point(109, 16);
            this.TxtIDAmigo.Name = "TxtIDAmigo";
            this.TxtIDAmigo.Size = new System.Drawing.Size(100, 20);
            this.TxtIDAmigo.TabIndex = 1;
            // 
            // LblCNPJ
            // 
            this.LblCNPJ.AutoSize = true;
            this.LblCNPJ.Location = new System.Drawing.Point(215, 132);
            this.LblCNPJ.Name = "LblCNPJ";
            this.LblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.LblCNPJ.TabIndex = 12;
            this.LblCNPJ.Text = "CNPJ";
            this.LblCNPJ.Visible = false;
            // 
            // MskCPF
            // 
            this.MskCPF.Location = new System.Drawing.Point(254, 129);
            this.MskCPF.Mask = "999.999.999-99";
            this.MskCPF.Name = "MskCPF";
            this.MskCPF.Size = new System.Drawing.Size(82, 20);
            this.MskCPF.TabIndex = 11;
            this.MskCPF.Visible = false;
            // 
            // MskCNPJ
            // 
            this.MskCNPJ.Location = new System.Drawing.Point(255, 129);
            this.MskCNPJ.Mask = "99.999.999/9999-99";
            this.MskCNPJ.Name = "MskCNPJ";
            this.MskCNPJ.Size = new System.Drawing.Size(111, 20);
            this.MskCNPJ.TabIndex = 13;
            this.MskCNPJ.Visible = false;
            // 
            // MskCEP
            // 
            this.MskCEP.Location = new System.Drawing.Point(354, 181);
            this.MskCEP.Mask = "99999-999";
            this.MskCEP.Name = "MskCEP";
            this.MskCEP.Size = new System.Drawing.Size(56, 20);
            this.MskCEP.TabIndex = 20;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(301, 352);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 243;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TelaCadastroAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 427);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.MskCEP);
            this.Controls.Add(this.MskCNPJ);
            this.Controls.Add(this.MskCPF);
            this.Controls.Add(this.LblCNPJ);
            this.Controls.Add(this.TxtIDAmigo);
            this.Controls.Add(this.LblIDAmigo);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.CboTipoLogradouro);
            this.Controls.Add(this.BtnEscolherFoto);
            this.Controls.Add(this.PbFoto);
            this.Controls.Add(this.LblUF);
            this.Controls.Add(this.MskCelular);
            this.Controls.Add(this.MskTelefone);
            this.Controls.Add(this.CboFuncao);
            this.Controls.Add(this.LblFuncao);
            this.Controls.Add(this.TxtAjuda);
            this.Controls.Add(this.LblAjuda);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.DteTimePickerCadastro);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.LblComplemento);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.DteTimePickerNasc);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCEP);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtNomeLogradouro);
            this.Controls.Add(this.TxtUF);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblNomeLogradouro);
            this.Controls.Add(this.LblTipoLogradouro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "TelaCadastroAmigo";
            this.Text = "Cadastro de Amigos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroAmigo_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroAmigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTipoLogradouro;
        private System.Windows.Forms.Button BtnEscolherFoto;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.MaskedTextBox MskCelular;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.ComboBox CboFuncao;
        private System.Windows.Forms.Label LblFuncao;
        private System.Windows.Forms.TextBox TxtAjuda;
        private System.Windows.Forms.Label LblAjuda;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.DateTimePicker DteTimePickerCadastro;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label LblComplemento;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.DateTimePicker DteTimePickerNasc;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtNomeLogradouro;
        private System.Windows.Forms.TextBox TxtUF;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblNomeLogradouro;
        private System.Windows.Forms.Label LblTipoLogradouro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblCPF;
        public System.Windows.Forms.Label LblIDAmigo;
        private System.Windows.Forms.TextBox TxtIDAmigo;
        private System.Windows.Forms.Label LblCNPJ;
        private System.Windows.Forms.MaskedTextBox MskCPF;
        private System.Windows.Forms.MaskedTextBox MskCNPJ;
        private System.Windows.Forms.MaskedTextBox MskCEP;
        private System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.TextBox TxtNome;
    }
}
namespace AmigoDono.View
{
    partial class TelaControle
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
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtNomeProprietario = new System.Windows.Forms.TextBox();
            this.TxtIdProprietario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.dateTimePickerAdocao = new System.Windows.Forms.DateTimePicker();
            this.TxtNomePet = new System.Windows.Forms.TextBox();
            this.TxtIdPet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet6 = new AmigoDono.View.Amigos_do_DonoDataSet6();
            this.aMIGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet7 = new AmigoDono.View.Amigos_do_DonoDataSet7();
            this.pETTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet6TableAdapters.PETTableAdapter();
            this.aMIGOTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet7TableAdapters.AMIGOTableAdapter();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEscolherA = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGWBuscaProp = new System.Windows.Forms.DataGridView();
            this.LblConsultaProp = new System.Windows.Forms.Label();
            this.tipoPetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGWBuscaPet = new System.Windows.Forms.DataGridView();
            this.Lblconsultapet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGWBuscaProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGWBuscaPet)).BeginInit();
            this.SuspendLayout();
            // 
            // CboStatus
            // 
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "Adotado",
            "com Cuidador",
            "Para ser adotado"});
            this.CboStatus.Location = new System.Drawing.Point(149, 168);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(306, 21);
            this.CboStatus.TabIndex = 11;
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(149, 215);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(667, 58);
            this.TxtObs.TabIndex = 13;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Location = new System.Drawing.Point(77, 222);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(29, 13);
            this.LblObs.TabIndex = 12;
            this.LblObs.Text = "Obs ";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(741, 279);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(537, 279);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 14;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(637, 279);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 15;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TxtNomeProprietario
            // 
            this.TxtNomeProprietario.Location = new System.Drawing.Point(147, 113);
            this.TxtNomeProprietario.Name = "TxtNomeProprietario";
            this.TxtNomeProprietario.Size = new System.Drawing.Size(365, 20);
            this.TxtNomeProprietario.TabIndex = 7;
            // 
            // TxtIdProprietario
            // 
            this.TxtIdProprietario.Location = new System.Drawing.Point(532, 113);
            this.TxtIdProprietario.Name = "TxtIdProprietario";
            this.TxtIdProprietario.Size = new System.Drawing.Size(87, 20);
            this.TxtIdProprietario.TabIndex = 9;
            this.TxtIdProprietario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proprietario";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(69, 176);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 10;
            this.LblStatus.Text = "Status";
            // 
            // dateTimePickerAdocao
            // 
            this.dateTimePickerAdocao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdocao.Location = new System.Drawing.Point(150, 25);
            this.dateTimePickerAdocao.Name = "dateTimePickerAdocao";
            this.dateTimePickerAdocao.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAdocao.TabIndex = 1;
            // 
            // TxtNomePet
            // 
            this.TxtNomePet.Location = new System.Drawing.Point(148, 66);
            this.TxtNomePet.Name = "TxtNomePet";
            this.TxtNomePet.Size = new System.Drawing.Size(365, 20);
            this.TxtNomePet.TabIndex = 3;
            // 
            // TxtIdPet
            // 
            this.TxtIdPet.Location = new System.Drawing.Point(532, 68);
            this.TxtIdPet.Name = "TxtIdPet";
            this.TxtIdPet.Size = new System.Drawing.Size(87, 20);
            this.TxtIdPet.TabIndex = 5;
            this.TxtIdPet.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Pet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data da adoção";
            // 
            // pETBindingSource
            // 
            this.pETBindingSource.DataMember = "PET";
            this.pETBindingSource.DataSource = this.amigos_do_DonoDataSet6;
            // 
            // amigos_do_DonoDataSet6
            // 
            this.amigos_do_DonoDataSet6.DataSetName = "Amigos_do_DonoDataSet6";
            this.amigos_do_DonoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMIGOBindingSource
            // 
            this.aMIGOBindingSource.DataMember = "AMIGO";
            this.aMIGOBindingSource.DataSource = this.amigos_do_DonoDataSet7;
            // 
            // amigos_do_DonoDataSet7
            // 
            this.amigos_do_DonoDataSet7.DataSetName = "Amigos_do_DonoDataSet7";
            this.amigos_do_DonoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pETTableAdapter
            // 
            this.pETTableAdapter.ClearBeforeFill = true;
            // 
            // aMIGOTableAdapter
            // 
            this.aMIGOTableAdapter.ClearBeforeFill = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDADataGridViewTextBoxColumn
            // 
            this.iDADataGridViewTextBoxColumn.DataPropertyName = "IDA";
            this.iDADataGridViewTextBoxColumn.HeaderText = "IDA";
            this.iDADataGridViewTextBoxColumn.Name = "iDADataGridViewTextBoxColumn";
            this.iDADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDADataGridViewTextBoxColumn.Width = 60;
            // 
            // BtnEscolherA
            // 
            this.BtnEscolherA.HeaderText = "Escolher";
            this.BtnEscolherA.Name = "BtnEscolherA";
            this.BtnEscolherA.Width = 60;
            // 
            // DGWBuscaProp
            // 
            this.DGWBuscaProp.AllowUserToAddRows = false;
            this.DGWBuscaProp.AllowUserToDeleteRows = false;
            this.DGWBuscaProp.AutoGenerateColumns = false;
            this.DGWBuscaProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWBuscaProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolherA,
            this.iDADataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.DGWBuscaProp.DataSource = this.aMIGOBindingSource;
            this.DGWBuscaProp.Location = new System.Drawing.Point(444, 351);
            this.DGWBuscaProp.Name = "DGWBuscaProp";
            this.DGWBuscaProp.Size = new System.Drawing.Size(419, 237);
            this.DGWBuscaProp.TabIndex = 20;
            this.DGWBuscaProp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWBuscaProp_CellClick);
            this.DGWBuscaProp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWBuscaProp_CellContentClick);
            // 
            // LblConsultaProp
            // 
            this.LblConsultaProp.AutoSize = true;
            this.LblConsultaProp.Location = new System.Drawing.Point(584, 323);
            this.LblConsultaProp.Name = "LblConsultaProp";
            this.LblConsultaProp.Size = new System.Drawing.Size(104, 13);
            this.LblConsultaProp.TabIndex = 18;
            this.LblConsultaProp.Text = "Consulta Proprietario";
            // 
            // tipoPetDataGridViewTextBoxColumn
            // 
            this.tipoPetDataGridViewTextBoxColumn.DataPropertyName = "TipoPet";
            this.tipoPetDataGridViewTextBoxColumn.HeaderText = "TipoPet";
            this.tipoPetDataGridViewTextBoxColumn.Name = "tipoPetDataGridViewTextBoxColumn";
            // 
            // nomePetDataGridViewTextBoxColumn
            // 
            this.nomePetDataGridViewTextBoxColumn.DataPropertyName = "NomePet";
            this.nomePetDataGridViewTextBoxColumn.HeaderText = "NomePet";
            this.nomePetDataGridViewTextBoxColumn.Name = "nomePetDataGridViewTextBoxColumn";
            this.nomePetDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPDataGridViewTextBoxColumn
            // 
            this.iDPDataGridViewTextBoxColumn.DataPropertyName = "IDP";
            this.iDPDataGridViewTextBoxColumn.HeaderText = "IDP";
            this.iDPDataGridViewTextBoxColumn.Name = "iDPDataGridViewTextBoxColumn";
            this.iDPDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPDataGridViewTextBoxColumn.Width = 60;
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Width = 60;
            // 
            // DGWBuscaPet
            // 
            this.DGWBuscaPet.AllowUserToAddRows = false;
            this.DGWBuscaPet.AllowUserToDeleteRows = false;
            this.DGWBuscaPet.AutoGenerateColumns = false;
            this.DGWBuscaPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWBuscaPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolher,
            this.iDPDataGridViewTextBoxColumn,
            this.nomePetDataGridViewTextBoxColumn,
            this.tipoPetDataGridViewTextBoxColumn});
            this.DGWBuscaPet.DataSource = this.pETBindingSource;
            this.DGWBuscaPet.Location = new System.Drawing.Point(6, 351);
            this.DGWBuscaPet.Name = "DGWBuscaPet";
            this.DGWBuscaPet.Size = new System.Drawing.Size(432, 237);
            this.DGWBuscaPet.TabIndex = 19;
            this.DGWBuscaPet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWBuscaPet_CellClick);
            this.DGWBuscaPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWBuscaPet_CellContentClick);
            // 
            // Lblconsultapet
            // 
            this.Lblconsultapet.AutoSize = true;
            this.Lblconsultapet.Location = new System.Drawing.Point(192, 323);
            this.Lblconsultapet.Name = "Lblconsultapet";
            this.Lblconsultapet.Size = new System.Drawing.Size(67, 13);
            this.Lblconsultapet.TabIndex = 17;
            this.Lblconsultapet.Text = "Consulta Pet";
            // 
            // TelaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 600);
            this.Controls.Add(this.LblConsultaProp);
            this.Controls.Add(this.Lblconsultapet);
            this.Controls.Add(this.DGWBuscaProp);
            this.Controls.Add(this.DGWBuscaPet);
            this.Controls.Add(this.CboStatus);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.LblObs);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TxtNomeProprietario);
            this.Controls.Add(this.TxtIdProprietario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.dateTimePickerAdocao);
            this.Controls.Add(this.TxtNomePet);
            this.Controls.Add(this.TxtIdPet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Controle";
            this.Load += new System.EventHandler(this.TelaControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGWBuscaProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGWBuscaPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdocao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtNomeProprietario;
        public System.Windows.Forms.TextBox TxtNomePet;
        public System.Windows.Forms.ComboBox CboStatus;
        public System.Windows.Forms.TextBox TxtObs;
        public System.Windows.Forms.TextBox TxtIdProprietario;
        public System.Windows.Forms.TextBox TxtIdPet;
        private Amigos_do_DonoDataSet6 amigos_do_DonoDataSet6;
        private System.Windows.Forms.BindingSource pETBindingSource;
        private Amigos_do_DonoDataSet6TableAdapters.PETTableAdapter pETTableAdapter;
        private Amigos_do_DonoDataSet7 amigos_do_DonoDataSet7;
        private System.Windows.Forms.BindingSource aMIGOBindingSource;
        private Amigos_do_DonoDataSet7TableAdapters.AMIGOTableAdapter aMIGOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolherA;
        public System.Windows.Forms.DataGridView DGWBuscaProp;
        private System.Windows.Forms.Label LblConsultaProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        public System.Windows.Forms.DataGridView DGWBuscaPet;
        private System.Windows.Forms.Label Lblconsultapet;
    }
}
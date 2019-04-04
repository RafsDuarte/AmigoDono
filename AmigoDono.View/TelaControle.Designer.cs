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
            this.CBODoador = new System.Windows.Forms.ComboBox();
            this.aMIGOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet15 = new AmigoDono.View.Amigos_do_DonoDataSet15();
            this.aMIGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet12 = new AmigoDono.View.Amigos_do_DonoDataSet12();
            this.LblDoador = new System.Windows.Forms.Label();
            this.CBOProp = new System.Windows.Forms.ComboBox();
            this.CBOPet = new System.Windows.Forms.ComboBox();
            this.pETBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet19 = new AmigoDono.View.Amigos_do_DonoDataSet19();
            this.pETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet11 = new AmigoDono.View.Amigos_do_DonoDataSet11();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblProprietario = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.dateTimePickerAdocao = new System.Windows.Forms.DateTimePicker();
            this.LblPet = new System.Windows.Forms.Label();
            this.LblDataAdoçao = new System.Windows.Forms.Label();
            this.pETTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet11TableAdapters.PETTableAdapter();
            this.aMIGOTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet12TableAdapters.AMIGOTableAdapter();
            this.aMIGOTableAdapter1 = new AmigoDono.View.Amigos_do_DonoDataSet15TableAdapters.AMIGOTableAdapter();
            this.pETTableAdapter1 = new AmigoDono.View.Amigos_do_DonoDataSet19TableAdapters.PETTableAdapter();
            this.TxtPetAdotados = new System.Windows.Forms.Label();
            this.TxtPetsDisposicao = new System.Windows.Forms.Label();
            this.TxtQtdAdotados = new System.Windows.Forms.Label();
            this.TxtQtdDisposicao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // CBODoador
            // 
            this.CBODoador.FormattingEnabled = true;
            this.CBODoador.Location = new System.Drawing.Point(143, 216);
            this.CBODoador.Name = "CBODoador";
            this.CBODoador.Size = new System.Drawing.Size(367, 21);
            this.CBODoador.TabIndex = 27;
            this.CBODoador.SelectedIndexChanged += new System.EventHandler(this.CBODoador_SelectedIndexChanged);
            // 
            // aMIGOBindingSource1
            // 
            this.aMIGOBindingSource1.DataMember = "AMIGO";
            this.aMIGOBindingSource1.DataSource = this.amigos_do_DonoDataSet15;
            // 
            // amigos_do_DonoDataSet15
            // 
            this.amigos_do_DonoDataSet15.DataSetName = "Amigos_do_DonoDataSet15";
            this.amigos_do_DonoDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMIGOBindingSource
            // 
            this.aMIGOBindingSource.DataMember = "AMIGO";
            this.aMIGOBindingSource.DataSource = this.amigos_do_DonoDataSet12;
            // 
            // amigos_do_DonoDataSet12
            // 
            this.amigos_do_DonoDataSet12.DataSetName = "Amigos_do_DonoDataSet12";
            this.amigos_do_DonoDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblDoador
            // 
            this.LblDoador.AutoSize = true;
            this.LblDoador.Location = new System.Drawing.Point(59, 224);
            this.LblDoador.Name = "LblDoador";
            this.LblDoador.Size = new System.Drawing.Size(42, 13);
            this.LblDoador.TabIndex = 26;
            this.LblDoador.Text = "Doador";
            // 
            // CBOProp
            // 
            this.CBOProp.FormattingEnabled = true;
            this.CBOProp.Location = new System.Drawing.Point(143, 171);
            this.CBOProp.Name = "CBOProp";
            this.CBOProp.Size = new System.Drawing.Size(367, 21);
            this.CBOProp.TabIndex = 24;
            this.CBOProp.SelectedIndexChanged += new System.EventHandler(this.CBOProp_SelectedIndexChanged);
            // 
            // CBOPet
            // 
            this.CBOPet.FormattingEnabled = true;
            this.CBOPet.Location = new System.Drawing.Point(143, 128);
            this.CBOPet.Name = "CBOPet";
            this.CBOPet.Size = new System.Drawing.Size(367, 21);
            this.CBOPet.TabIndex = 21;
            this.CBOPet.SelectedIndexChanged += new System.EventHandler(this.CBOPet_SelectedIndexChanged_1);
            // 
            // pETBindingSource1
            // 
            this.pETBindingSource1.DataMember = "PET";
            this.pETBindingSource1.DataSource = this.amigos_do_DonoDataSet19;
            // 
            // amigos_do_DonoDataSet19
            // 
            this.amigos_do_DonoDataSet19.DataSetName = "Amigos_do_DonoDataSet19";
            this.amigos_do_DonoDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pETBindingSource
            // 
            this.pETBindingSource.DataMember = "PET";
            this.pETBindingSource.DataSource = this.amigos_do_DonoDataSet11;
            // 
            // amigos_do_DonoDataSet11
            // 
            this.amigos_do_DonoDataSet11.DataSetName = "Amigos_do_DonoDataSet11";
            this.amigos_do_DonoDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CboStatus
            // 
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "Adotado",
            "Disposicao",
            "Tratamento"});
            this.CboStatus.Location = new System.Drawing.Point(143, 269);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(306, 21);
            this.CboStatus.TabIndex = 30;
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(143, 316);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(667, 58);
            this.TxtObs.TabIndex = 32;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Location = new System.Drawing.Point(72, 323);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(29, 13);
            this.LblObs.TabIndex = 31;
            this.LblObs.Text = "Obs ";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(735, 390);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 35;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(629, 390);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 33;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblProprietario
            // 
            this.LblProprietario.AutoSize = true;
            this.LblProprietario.Location = new System.Drawing.Point(41, 179);
            this.LblProprietario.Name = "LblProprietario";
            this.LblProprietario.Size = new System.Drawing.Size(60, 13);
            this.LblProprietario.TabIndex = 23;
            this.LblProprietario.Text = "Proprietario";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(64, 277);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 29;
            this.LblStatus.Text = "Status";
            // 
            // dateTimePickerAdocao
            // 
            this.dateTimePickerAdocao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdocao.Location = new System.Drawing.Point(143, 88);
            this.dateTimePickerAdocao.Name = "dateTimePickerAdocao";
            this.dateTimePickerAdocao.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAdocao.TabIndex = 19;
            // 
            // LblPet
            // 
            this.LblPet.AutoSize = true;
            this.LblPet.Location = new System.Drawing.Point(78, 136);
            this.LblPet.Name = "LblPet";
            this.LblPet.Size = new System.Drawing.Size(23, 13);
            this.LblPet.TabIndex = 20;
            this.LblPet.Text = "Pet";
            // 
            // LblDataAdoçao
            // 
            this.LblDataAdoçao.AutoSize = true;
            this.LblDataAdoçao.Location = new System.Drawing.Point(17, 94);
            this.LblDataAdoçao.Name = "LblDataAdoçao";
            this.LblDataAdoçao.Size = new System.Drawing.Size(84, 13);
            this.LblDataAdoçao.TabIndex = 18;
            this.LblDataAdoçao.Text = "Data da adoção";
            // 
            // pETTableAdapter
            // 
            this.pETTableAdapter.ClearBeforeFill = true;
            // 
            // aMIGOTableAdapter
            // 
            this.aMIGOTableAdapter.ClearBeforeFill = true;
            // 
            // aMIGOTableAdapter1
            // 
            this.aMIGOTableAdapter1.ClearBeforeFill = true;
            // 
            // pETTableAdapter1
            // 
            this.pETTableAdapter1.ClearBeforeFill = true;
            // 
            // TxtPetAdotados
            // 
            this.TxtPetAdotados.AutoSize = true;
            this.TxtPetAdotados.Location = new System.Drawing.Point(25, 20);
            this.TxtPetAdotados.Name = "TxtPetAdotados";
            this.TxtPetAdotados.Size = new System.Drawing.Size(76, 13);
            this.TxtPetAdotados.TabIndex = 36;
            this.TxtPetAdotados.Text = "Pets Adotados";
            this.TxtPetAdotados.BindingContextChanged += new System.EventHandler(this.nu);
            // 
            // TxtPetsDisposicao
            // 
            this.TxtPetsDisposicao.AutoSize = true;
            this.TxtPetsDisposicao.Location = new System.Drawing.Point(9, 47);
            this.TxtPetsDisposicao.Name = "TxtPetsDisposicao";
            this.TxtPetsDisposicao.Size = new System.Drawing.Size(92, 13);
            this.TxtPetsDisposicao.TabIndex = 37;
            this.TxtPetsDisposicao.Text = "Pets a Disposicao";
            // 
            // TxtQtdAdotados
            // 
            this.TxtQtdAdotados.AutoSize = true;
            this.TxtQtdAdotados.Location = new System.Drawing.Point(140, 20);
            this.TxtQtdAdotados.Name = "TxtQtdAdotados";
            this.TxtQtdAdotados.Size = new System.Drawing.Size(37, 13);
            this.TxtQtdAdotados.TabIndex = 38;
            this.TxtQtdAdotados.Text = "00000";
            // 
            // TxtQtdDisposicao
            // 
            this.TxtQtdDisposicao.AutoSize = true;
            this.TxtQtdDisposicao.Location = new System.Drawing.Point(140, 47);
            this.TxtQtdDisposicao.Name = "TxtQtdDisposicao";
            this.TxtQtdDisposicao.Size = new System.Drawing.Size(37, 13);
            this.TxtQtdDisposicao.TabIndex = 39;
            this.TxtQtdDisposicao.Text = "00000";
            // 
            // TelaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.TxtQtdDisposicao);
            this.Controls.Add(this.TxtQtdAdotados);
            this.Controls.Add(this.TxtPetsDisposicao);
            this.Controls.Add(this.TxtPetAdotados);
            this.Controls.Add(this.CBODoador);
            this.Controls.Add(this.LblDoador);
            this.Controls.Add(this.CBOProp);
            this.Controls.Add(this.CBOPet);
            this.Controls.Add(this.CboStatus);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.LblObs);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.LblProprietario);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.dateTimePickerAdocao);
            this.Controls.Add(this.LblPet);
            this.Controls.Add(this.LblDataAdoçao);
            this.MaximizeBox = false;
            this.Name = "TelaControle";
            this.Text = "TelaControle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaControle_FormClosed_1);
            this.Load += new System.EventHandler(this.TelaControle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBODoador;
        private System.Windows.Forms.Label LblDoador;
        private System.Windows.Forms.ComboBox CBOProp;
        private System.Windows.Forms.ComboBox CBOPet;
        public System.Windows.Forms.ComboBox CboStatus;
        public System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblProprietario;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdocao;
        private System.Windows.Forms.Label LblPet;
        private System.Windows.Forms.Label LblDataAdoçao;
        private Amigos_do_DonoDataSet11 amigos_do_DonoDataSet11;
        private System.Windows.Forms.BindingSource pETBindingSource;
        private Amigos_do_DonoDataSet11TableAdapters.PETTableAdapter pETTableAdapter;
        private Amigos_do_DonoDataSet12 amigos_do_DonoDataSet12;
        private System.Windows.Forms.BindingSource aMIGOBindingSource;
        private Amigos_do_DonoDataSet12TableAdapters.AMIGOTableAdapter aMIGOTableAdapter;
        private Amigos_do_DonoDataSet15 amigos_do_DonoDataSet15;
        private System.Windows.Forms.BindingSource aMIGOBindingSource1;
        private Amigos_do_DonoDataSet15TableAdapters.AMIGOTableAdapter aMIGOTableAdapter1;
        private Amigos_do_DonoDataSet19 amigos_do_DonoDataSet19;
        private System.Windows.Forms.BindingSource pETBindingSource1;
        private Amigos_do_DonoDataSet19TableAdapters.PETTableAdapter pETTableAdapter1;
        private System.Windows.Forms.Label TxtPetAdotados;
        private System.Windows.Forms.Label TxtPetsDisposicao;
        private System.Windows.Forms.Label TxtQtdAdotados;
        private System.Windows.Forms.Label TxtQtdDisposicao;
    }
}
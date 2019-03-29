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
            this.components = new System.ComponentModel.Container();
            this.LblTipoCuidado = new System.Windows.Forms.Label();
            this.LblHistoricoPet = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblResponsavel = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblOBs = new System.Windows.Forms.Label();
            this.DteTimePickerDataTratamento = new System.Windows.Forms.DateTimePicker();
            this.LblPet = new System.Windows.Forms.Label();
            this.LblDataTratamento = new System.Windows.Forms.Label();
            this.GrdHistoricoTratamento = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwTRATAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet21 = new AmigoDono.View.Amigos_do_DonoDataSet21();
            this.CboTipoCuidado = new System.Windows.Forms.ComboBox();
            this.tIPOTRATAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet20 = new AmigoDono.View.Amigos_do_DonoDataSet20();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.pETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoPetTratamento = new AmigoDono.View.Amigos_do_DonoPetTratamento();
            this.CboResponsavel = new System.Windows.Forms.ComboBox();
            this.aMIGOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoResponsavel = new AmigoDono.View.Amigos_do_DonoResponsavel();
            this.aMIGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_Dono_Tratamento_Responsavel = new AmigoDono.View.Amigos_do_Dono_Tratamento_Responsavel();
            this.pETTableAdapter = new AmigoDono.View.Amigos_do_DonoPetTratamentoTableAdapters.PETTableAdapter();
            this.tIPOTRATAMENTOTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet20TableAdapters.TIPOTRATAMENTOTableAdapter();
            this.aMIGOTableAdapter = new AmigoDono.View.Amigos_do_Dono_Tratamento_ResponsavelTableAdapters.AMIGOTableAdapter();
            this.amigos_do_Dono_HistoricoTratamento = new AmigoDono.View.Amigos_do_Dono_HistoricoTratamento();
            this.tRATAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRATAMENTOTableAdapter = new AmigoDono.View.Amigos_do_Dono_HistoricoTratamentoTableAdapters.TRATAMENTOTableAdapter();
            this.vw_TRATAMENTOTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet21TableAdapters.vw_TRATAMENTOTableAdapter();
            this.amigos_do_DonoDoador = new AmigoDono.View.Amigos_do_DonoDoador();
            this.aMIGOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aMIGOTableAdapter1 = new AmigoDono.View.Amigos_do_DonoDoadorTableAdapters.AMIGOTableAdapter();
            this.aMIGOTableAdapter2 = new AmigoDono.View.Amigos_do_DonoResponsavelTableAdapters.AMIGOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrdHistoricoTratamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTRATAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTRATAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoPetTratamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_Dono_Tratamento_Responsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_Dono_HistoricoTratamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRATAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDoador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTipoCuidado
            // 
            this.LblTipoCuidado.AutoSize = true;
            this.LblTipoCuidado.Location = new System.Drawing.Point(41, 108);
            this.LblTipoCuidado.Name = "LblTipoCuidado";
            this.LblTipoCuidado.Size = new System.Drawing.Size(84, 13);
            this.LblTipoCuidado.TabIndex = 5;
            this.LblTipoCuidado.Text = "Tipo de cuidado";
            // 
            // LblHistoricoPet
            // 
            this.LblHistoricoPet.AutoSize = true;
            this.LblHistoricoPet.Location = new System.Drawing.Point(16, 288);
            this.LblHistoricoPet.Name = "LblHistoricoPet";
            this.LblHistoricoPet.Size = new System.Drawing.Size(109, 13);
            this.LblHistoricoPet.TabIndex = 15;
            this.LblHistoricoPet.Text = "HISTORICO DO PET";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(922, 267);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(813, 267);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 13;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(154, 181);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(521, 58);
            this.TxtObs.TabIndex = 12;
            this.TxtObs.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // LblOBs
            // 
            this.LblOBs.AutoSize = true;
            this.LblOBs.Location = new System.Drawing.Point(64, 184);
            this.LblOBs.Name = "LblOBs";
            this.LblOBs.Size = new System.Drawing.Size(65, 13);
            this.LblOBs.TabIndex = 11;
            this.LblOBs.Text = "Observaçao";
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
            this.GrdHistoricoTratamento.AutoGenerateColumns = false;
            this.GrdHistoricoTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdHistoricoTratamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnExcluir,
            this.dataGridViewTextBoxColumn13,
            this.dataTratamentoDataGridViewTextBoxColumn,
            this.Nome,
            this.Descricao,
            this.dataGridViewTextBoxColumn14});
            this.GrdHistoricoTratamento.DataSource = this.vwTRATAMENTOBindingSource;
            this.GrdHistoricoTratamento.Location = new System.Drawing.Point(30, 318);
            this.GrdHistoricoTratamento.Name = "GrdHistoricoTratamento";
            this.GrdHistoricoTratamento.ReadOnly = true;
            this.GrdHistoricoTratamento.Size = new System.Drawing.Size(967, 140);
            this.GrdHistoricoTratamento.TabIndex = 16;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "Nome";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            this.BtnExcluir.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataTratamentoDataGridViewTextBoxColumn
            // 
            this.dataTratamentoDataGridViewTextBoxColumn.DataPropertyName = "DataTratamento";
            this.dataTratamentoDataGridViewTextBoxColumn.HeaderText = "DataTratamento";
            this.dataTratamentoDataGridViewTextBoxColumn.Name = "dataTratamentoDataGridViewTextBoxColumn";
            this.dataTratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OBS";
            this.dataGridViewTextBoxColumn14.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 250;
            // 
            // vwTRATAMENTOBindingSource
            // 
            this.vwTRATAMENTOBindingSource.DataMember = "vw_TRATAMENTO";
            this.vwTRATAMENTOBindingSource.DataSource = this.amigos_do_DonoDataSet21;
            // 
            // amigos_do_DonoDataSet21
            // 
            this.amigos_do_DonoDataSet21.DataSetName = "Amigos_do_DonoDataSet21";
            this.amigos_do_DonoDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CboTipoCuidado
            // 
            this.CboTipoCuidado.AutoCompleteCustomSource.AddRange(new string[] {
            "Vacinas de Raiva",
            "Curativo",
            "Medicamento"});
            this.CboTipoCuidado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboTipoCuidado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoCuidado.DataSource = this.tIPOTRATAMENTOBindingSource;
            this.CboTipoCuidado.DisplayMember = "Descricao";
            this.CboTipoCuidado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCuidado.FormattingEnabled = true;
            this.CboTipoCuidado.Location = new System.Drawing.Point(155, 100);
            this.CboTipoCuidado.Name = "CboTipoCuidado";
            this.CboTipoCuidado.Size = new System.Drawing.Size(239, 21);
            this.CboTipoCuidado.TabIndex = 6;
            this.CboTipoCuidado.ValueMember = "IDTT";
            // 
            // tIPOTRATAMENTOBindingSource
            // 
            this.tIPOTRATAMENTOBindingSource.DataMember = "TIPOTRATAMENTO";
            this.tIPOTRATAMENTOBindingSource.DataSource = this.amigos_do_DonoDataSet20;
            // 
            // amigos_do_DonoDataSet20
            // 
            this.amigos_do_DonoDataSet20.DataSetName = "Amigos_do_DonoDataSet20";
            this.amigos_do_DonoDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboPet
            // 
            this.cboPet.DataSource = this.pETBindingSource;
            this.cboPet.DisplayMember = "NomePet";
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(153, 63);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(367, 21);
            this.cboPet.TabIndex = 3;
            this.cboPet.ValueMember = "NomePet";
            this.cboPet.SelectedIndexChanged += new System.EventHandler(this.cboPet_SelectedIndexChanged);
            // 
            // pETBindingSource
            // 
            this.pETBindingSource.DataMember = "PET";
            this.pETBindingSource.DataSource = this.amigos_do_DonoPetTratamento;
            // 
            // amigos_do_DonoPetTratamento
            // 
            this.amigos_do_DonoPetTratamento.DataSetName = "Amigos_do_DonoPetTratamento";
            this.amigos_do_DonoPetTratamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CboResponsavel
            // 
            this.CboResponsavel.DataSource = this.aMIGOBindingSource2;
            this.CboResponsavel.DisplayMember = "Nome";
            this.CboResponsavel.FormattingEnabled = true;
            this.CboResponsavel.Location = new System.Drawing.Point(153, 136);
            this.CboResponsavel.Name = "CboResponsavel";
            this.CboResponsavel.Size = new System.Drawing.Size(367, 21);
            this.CboResponsavel.TabIndex = 9;
            this.CboResponsavel.ValueMember = "IDA";
            // 
            // aMIGOBindingSource2
            // 
            this.aMIGOBindingSource2.DataMember = "AMIGO";
            this.aMIGOBindingSource2.DataSource = this.amigos_do_DonoResponsavel;
            // 
            // amigos_do_DonoResponsavel
            // 
            this.amigos_do_DonoResponsavel.DataSetName = "Amigos_do_DonoResponsavel";
            this.amigos_do_DonoResponsavel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMIGOBindingSource
            // 
            this.aMIGOBindingSource.DataMember = "AMIGO";
            this.aMIGOBindingSource.DataSource = this.amigos_do_Dono_Tratamento_Responsavel;
            // 
            // amigos_do_Dono_Tratamento_Responsavel
            // 
            this.amigos_do_Dono_Tratamento_Responsavel.DataSetName = "Amigos_do_Dono_Tratamento_Responsavel";
            this.amigos_do_Dono_Tratamento_Responsavel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pETTableAdapter
            // 
            this.pETTableAdapter.ClearBeforeFill = true;
            // 
            // tIPOTRATAMENTOTableAdapter
            // 
            this.tIPOTRATAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // aMIGOTableAdapter
            // 
            this.aMIGOTableAdapter.ClearBeforeFill = true;
            // 
            // amigos_do_Dono_HistoricoTratamento
            // 
            this.amigos_do_Dono_HistoricoTratamento.DataSetName = "Amigos_do_Dono_HistoricoTratamento";
            this.amigos_do_Dono_HistoricoTratamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRATAMENTOBindingSource
            // 
            this.tRATAMENTOBindingSource.DataMember = "TRATAMENTO";
            this.tRATAMENTOBindingSource.DataSource = this.amigos_do_Dono_HistoricoTratamento;
            // 
            // tRATAMENTOTableAdapter
            // 
            this.tRATAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // vw_TRATAMENTOTableAdapter
            // 
            this.vw_TRATAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // amigos_do_DonoDoador
            // 
            this.amigos_do_DonoDoador.DataSetName = "Amigos_do_DonoDoador";
            this.amigos_do_DonoDoador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMIGOBindingSource1
            // 
            this.aMIGOBindingSource1.DataMember = "AMIGO";
            this.aMIGOBindingSource1.DataSource = this.amigos_do_DonoDoador;
            // 
            // aMIGOTableAdapter1
            // 
            this.aMIGOTableAdapter1.ClearBeforeFill = true;
            // 
            // aMIGOTableAdapter2
            // 
            this.aMIGOTableAdapter2.ClearBeforeFill = true;
            // 
            // TelaTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 470);
            this.Controls.Add(this.CboResponsavel);
            this.Controls.Add(this.cboPet);
            this.Controls.Add(this.CboTipoCuidado);
            this.Controls.Add(this.GrdHistoricoTratamento);
            this.Controls.Add(this.LblTipoCuidado);
            this.Controls.Add(this.LblHistoricoPet);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.LblResponsavel);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.LblOBs);
            this.Controls.Add(this.DteTimePickerDataTratamento);
            this.Controls.Add(this.LblPet);
            this.Controls.Add(this.LblDataTratamento);
            this.Name = "TelaTratamento";
            this.Text = "Tratamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaTratamento_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.GrdHistoricoTratamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTRATAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTRATAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoPetTratamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_Dono_Tratamento_Responsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_Dono_HistoricoTratamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRATAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDoador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTipoCuidado;
        private System.Windows.Forms.Label LblHistoricoPet;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblResponsavel;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblOBs;
        private System.Windows.Forms.DateTimePicker DteTimePickerDataTratamento;
        private System.Windows.Forms.Label LblPet;
        private System.Windows.Forms.Label LblDataTratamento;
        private System.Windows.Forms.DataGridView GrdHistoricoTratamento;
        private System.Windows.Forms.ComboBox CboTipoCuidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ComboBox cboPet;
        private System.Windows.Forms.ComboBox CboResponsavel;
        private Amigos_do_DonoPetTratamento amigos_do_DonoPetTratamento;
        private System.Windows.Forms.BindingSource pETBindingSource;
        private Amigos_do_DonoPetTratamentoTableAdapters.PETTableAdapter pETTableAdapter;
        private Amigos_do_DonoDataSet20 amigos_do_DonoDataSet20;
        private System.Windows.Forms.BindingSource tIPOTRATAMENTOBindingSource;
        private Amigos_do_DonoDataSet20TableAdapters.TIPOTRATAMENTOTableAdapter tIPOTRATAMENTOTableAdapter;
        private Amigos_do_Dono_Tratamento_Responsavel amigos_do_Dono_Tratamento_Responsavel;
        private System.Windows.Forms.BindingSource aMIGOBindingSource;
        private Amigos_do_Dono_Tratamento_ResponsavelTableAdapters.AMIGOTableAdapter aMIGOTableAdapter;
        private Amigos_do_Dono_HistoricoTratamento amigos_do_Dono_HistoricoTratamento;
        private System.Windows.Forms.BindingSource tRATAMENTOBindingSource;
        private Amigos_do_Dono_HistoricoTratamentoTableAdapters.TRATAMENTOTableAdapter tRATAMENTOTableAdapter;
        private Amigos_do_DonoDataSet21 amigos_do_DonoDataSet21;
        private System.Windows.Forms.BindingSource vwTRATAMENTOBindingSource;
        private Amigos_do_DonoDataSet21TableAdapters.vw_TRATAMENTOTableAdapter vw_TRATAMENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private Amigos_do_DonoDoador amigos_do_DonoDoador;
        private System.Windows.Forms.BindingSource aMIGOBindingSource1;
        private Amigos_do_DonoDoadorTableAdapters.AMIGOTableAdapter aMIGOTableAdapter1;
        private Amigos_do_DonoResponsavel amigos_do_DonoResponsavel;
        private System.Windows.Forms.BindingSource aMIGOBindingSource2;
        private Amigos_do_DonoResponsavelTableAdapters.AMIGOTableAdapter aMIGOTableAdapter2;
    }
}
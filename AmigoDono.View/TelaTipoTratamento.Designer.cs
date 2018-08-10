namespace AmigoDono.View
{
    partial class TelaTipoTratamento
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
            this.TxtTestoDenuncia = new System.Windows.Forms.TextBox();
            this.LblTextoDenuncia = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtIDD = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.DGVTipoTratamento = new System.Windows.Forms.DataGridView();
            this.amigos_do_DonoDataSet8 = new AmigoDono.View.Amigos_do_DonoDataSet8();
            this.tIPOTRATAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOTRATAMENTOTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet8TableAdapters.TIPOTRATAMENTOTableAdapter();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoTratamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTRATAMENTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(666, 124);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // TxtTestoDenuncia
            // 
            this.TxtTestoDenuncia.Location = new System.Drawing.Point(74, 63);
            this.TxtTestoDenuncia.Multiline = true;
            this.TxtTestoDenuncia.Name = "TxtTestoDenuncia";
            this.TxtTestoDenuncia.Size = new System.Drawing.Size(667, 46);
            this.TxtTestoDenuncia.TabIndex = 3;
            // 
            // LblTextoDenuncia
            // 
            this.LblTextoDenuncia.AutoSize = true;
            this.LblTextoDenuncia.Location = new System.Drawing.Point(4, 66);
            this.LblTextoDenuncia.Name = "LblTextoDenuncia";
            this.LblTextoDenuncia.Size = new System.Drawing.Size(58, 13);
            this.LblTextoDenuncia.TabIndex = 2;
            this.LblTextoDenuncia.Text = "Descricao ";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(460, 124);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(566, 124);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // TxtIDD
            // 
            this.TxtIDD.Location = new System.Drawing.Point(74, 22);
            this.TxtIDD.Name = "TxtIDD";
            this.TxtIDD.Size = new System.Drawing.Size(87, 20);
            this.TxtIDD.TabIndex = 1;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(39, 29);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            // 
            // DGVTipoTratamento
            // 
            this.DGVTipoTratamento.AutoGenerateColumns = false;
            this.DGVTipoTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTipoTratamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolher,
            this.iDTTDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DGVTipoTratamento.DataSource = this.tIPOTRATAMENTOBindingSource;
            this.DGVTipoTratamento.Location = new System.Drawing.Point(12, 170);
            this.DGVTipoTratamento.Name = "DGVTipoTratamento";
            this.DGVTipoTratamento.Size = new System.Drawing.Size(776, 268);
            this.DGVTipoTratamento.TabIndex = 7;
            // 
            // amigos_do_DonoDataSet8
            // 
            this.amigos_do_DonoDataSet8.DataSetName = "Amigos_do_DonoDataSet8";
            this.amigos_do_DonoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOTRATAMENTOBindingSource
            // 
            this.tIPOTRATAMENTOBindingSource.DataMember = "TIPOTRATAMENTO";
            this.tIPOTRATAMENTOBindingSource.DataSource = this.amigos_do_DonoDataSet8;
            // 
            // tIPOTRATAMENTOTableAdapter
            // 
            this.tIPOTRATAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.DataPropertyName = "IDTT";
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Width = 60;
            // 
            // iDTTDataGridViewTextBoxColumn
            // 
            this.iDTTDataGridViewTextBoxColumn.DataPropertyName = "IDTT";
            this.iDTTDataGridViewTextBoxColumn.HeaderText = "IDTT";
            this.iDTTDataGridViewTextBoxColumn.Name = "iDTTDataGridViewTextBoxColumn";
            this.iDTTDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 600;
            // 
            // TelaTipoTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVTipoTratamento);
            this.Controls.Add(this.TxtIDD);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtTestoDenuncia);
            this.Controls.Add(this.LblTextoDenuncia);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Name = "TelaTipoTratamento";
            this.Text = "TelaTipoTratamento";
            this.Load += new System.EventHandler(this.TelaTipoTratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoTratamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTRATAMENTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtTestoDenuncia;
        private System.Windows.Forms.Label LblTextoDenuncia;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtIDD;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.DataGridView DGVTipoTratamento;
        private Amigos_do_DonoDataSet8 amigos_do_DonoDataSet8;
        private System.Windows.Forms.BindingSource tIPOTRATAMENTOBindingSource;
        private Amigos_do_DonoDataSet8TableAdapters.TIPOTRATAMENTOTableAdapter tIPOTRATAMENTOTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}
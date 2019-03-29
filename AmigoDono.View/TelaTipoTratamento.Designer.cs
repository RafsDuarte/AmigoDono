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
            this.TxtTextoDescricao = new System.Windows.Forms.TextBox();
            this.LblTextoDenuncia = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GrdTipoTratamento = new System.Windows.Forms.DataGridView();
            this.tIPOTRATAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet8 = new AmigoDono.View.Amigos_do_DonoDataSet8();
            this.tIPOTRATAMENTOTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet8TableAdapters.TIPOTRATAMENTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTipoTratamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTRATAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet8)).BeginInit();
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
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtTextoDescricao
            // 
            this.TxtTextoDescricao.Location = new System.Drawing.Point(74, 63);
            this.TxtTextoDescricao.Multiline = true;
            this.TxtTextoDescricao.Name = "TxtTextoDescricao";
            this.TxtTextoDescricao.Size = new System.Drawing.Size(667, 46);
            this.TxtTextoDescricao.TabIndex = 3;
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
            this.BtnSalvar.Location = new System.Drawing.Point(562, 124);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // GrdTipoTratamento
            // 
            this.GrdTipoTratamento.AllowUserToAddRows = false;
            this.GrdTipoTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdTipoTratamento.Location = new System.Drawing.Point(12, 170);
            this.GrdTipoTratamento.Name = "GrdTipoTratamento";
            this.GrdTipoTratamento.ReadOnly = true;
            this.GrdTipoTratamento.Size = new System.Drawing.Size(776, 268);
            this.GrdTipoTratamento.TabIndex = 7;
            this.GrdTipoTratamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTipoTratamento_CellContentClick);
            // 
            // tIPOTRATAMENTOBindingSource
            // 
            this.tIPOTRATAMENTOBindingSource.DataMember = "TIPOTRATAMENTO";
            this.tIPOTRATAMENTOBindingSource.DataSource = this.amigos_do_DonoDataSet8;
            // 
            // amigos_do_DonoDataSet8
            // 
            this.amigos_do_DonoDataSet8.DataSetName = "Amigos_do_DonoDataSet8";
            this.amigos_do_DonoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOTRATAMENTOTableAdapter
            // 
            this.tIPOTRATAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // TelaTipoTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdTipoTratamento);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtTextoDescricao);
            this.Controls.Add(this.LblTextoDenuncia);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "TelaTipoTratamento";
            this.Text = "TelaTipoTratamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaTipoTratamento_FormClosed);
            this.Load += new System.EventHandler(this.TelaTipoTratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTipoTratamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTRATAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtTextoDescricao;
        private System.Windows.Forms.Label LblTextoDenuncia;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView GrdTipoTratamento;
        private Amigos_do_DonoDataSet8 amigos_do_DonoDataSet8;
        private System.Windows.Forms.BindingSource tIPOTRATAMENTOBindingSource;
        private Amigos_do_DonoDataSet8TableAdapters.TIPOTRATAMENTOTableAdapter tIPOTRATAMENTOTableAdapter;
    }
}
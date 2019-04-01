namespace AmigoDono.View
{
    partial class RelatorioDenuncia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataDenunciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denuncianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoDenunciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwDENUNCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwRelatorioDenuncia = new AmigoDono.View.vwRelatorioDenuncia();
            this.vw_DENUNCIATableAdapter = new AmigoDono.View.vwRelatorioDenunciaTableAdapters.vw_DENUNCIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDENUNCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRelatorioDenuncia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(704, 415);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSair_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDenunciaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.denuncianteDataGridViewTextBoxColumn,
            this.textoDenunciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwDENUNCIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(761, 380);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataDenunciaDataGridViewTextBoxColumn
            // 
            this.dataDenunciaDataGridViewTextBoxColumn.DataPropertyName = "DataDenuncia";
            this.dataDenunciaDataGridViewTextBoxColumn.HeaderText = "DataDenuncia";
            this.dataDenunciaDataGridViewTextBoxColumn.Name = "dataDenunciaDataGridViewTextBoxColumn";
            this.dataDenunciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // denuncianteDataGridViewTextBoxColumn
            // 
            this.denuncianteDataGridViewTextBoxColumn.DataPropertyName = "Denunciante";
            this.denuncianteDataGridViewTextBoxColumn.HeaderText = "Denunciante";
            this.denuncianteDataGridViewTextBoxColumn.Name = "denuncianteDataGridViewTextBoxColumn";
            this.denuncianteDataGridViewTextBoxColumn.ReadOnly = true;
            this.denuncianteDataGridViewTextBoxColumn.Width = 200;
            // 
            // textoDenunciaDataGridViewTextBoxColumn
            // 
            this.textoDenunciaDataGridViewTextBoxColumn.DataPropertyName = "TextoDenuncia";
            this.textoDenunciaDataGridViewTextBoxColumn.HeaderText = "TextoDenuncia";
            this.textoDenunciaDataGridViewTextBoxColumn.Name = "textoDenunciaDataGridViewTextBoxColumn";
            this.textoDenunciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.textoDenunciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // vwDENUNCIABindingSource
            // 
            this.vwDENUNCIABindingSource.DataMember = "vw_DENUNCIA";
            this.vwDENUNCIABindingSource.DataSource = this.vwRelatorioDenuncia;
            // 
            // vwRelatorioDenuncia
            // 
            this.vwRelatorioDenuncia.DataSetName = "vwRelatorioDenuncia";
            this.vwRelatorioDenuncia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DENUNCIATableAdapter
            // 
            this.vw_DENUNCIATableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSair);
            this.Name = "RelatorioDenuncia";
            this.Text = "RelatorioDenuncia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RelatorioDenuncia_FormClosed);
            this.Load += new System.EventHandler(this.RelatorioDenuncia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDENUNCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRelatorioDenuncia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private vwRelatorioDenuncia vwRelatorioDenuncia;
        private System.Windows.Forms.BindingSource vwDENUNCIABindingSource;
        private vwRelatorioDenunciaTableAdapters.vw_DENUNCIATableAdapter vw_DENUNCIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDenunciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denuncianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDenunciaDataGridViewTextBoxColumn;
    }
}
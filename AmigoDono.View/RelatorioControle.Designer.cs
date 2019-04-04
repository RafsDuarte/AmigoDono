namespace AmigoDono.View
{
    partial class RelatorioControle
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
            this.GrdRelatorioControle = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCONTROLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet18 = new AmigoDono.View.Amigos_do_DonoDataSet18();
            this.vwCONTROLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSair = new System.Windows.Forms.Button();
            this.vw_CONTROLETableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet18TableAdapters.vw_CONTROLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRelatorioControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCONTROLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCONTROLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdRelatorioControle
            // 
            this.GrdRelatorioControle.AutoGenerateColumns = false;
            this.GrdRelatorioControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdRelatorioControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.GrdRelatorioControle.DataSource = this.vwCONTROLEBindingSource1;
            this.GrdRelatorioControle.Location = new System.Drawing.Point(12, 77);
            this.GrdRelatorioControle.Name = "GrdRelatorioControle";
            this.GrdRelatorioControle.Size = new System.Drawing.Size(926, 328);
            this.GrdRelatorioControle.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataAdocao";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataAdocao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Statu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Statu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomePet";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomePet";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doador";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // vwCONTROLEBindingSource1
            // 
            this.vwCONTROLEBindingSource1.DataMember = "vw_CONTROLE";
            this.vwCONTROLEBindingSource1.DataSource = this.amigos_do_DonoDataSet18;
            // 
            // amigos_do_DonoDataSet18
            // 
            this.amigos_do_DonoDataSet18.DataSetName = "Amigos_do_DonoDataSet18";
            this.amigos_do_DonoDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCONTROLEBindingSource
            // 
            this.vwCONTROLEBindingSource.DataMember = "vw_CONTROLE";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(863, 426);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // vw_CONTROLETableAdapter
            // 
            this.vw_CONTROLETableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 472);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GrdRelatorioControle);
            this.Name = "RelatorioControle";
            this.Text = "RelatorioControle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RelatorioControle_FormClosed);
            this.Load += new System.EventHandler(this.RelatorioControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRelatorioControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCONTROLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCONTROLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdRelatorioControle;
        private System.Windows.Forms.BindingSource vwCONTROLEBindingSource;
        private System.Windows.Forms.Button BtnSair;
        private Amigos_do_DonoDataSet18 amigos_do_DonoDataSet18;
        private System.Windows.Forms.BindingSource vwCONTROLEBindingSource1;
        private Amigos_do_DonoDataSet18TableAdapters.vw_CONTROLETableAdapter vw_CONTROLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
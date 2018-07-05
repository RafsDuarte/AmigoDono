namespace AmigoDono.View
{
    partial class TelaPesquisaDenuncia
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtPesquisaNome = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.GrdDenuncia = new System.Windows.Forms.DataGridView();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dENUNCIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet1 = new AmigoDono.View.Amigos_do_DonoDataSet1();
            this.dENUNCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dENUNCIATableAdapter = new AmigoDono.View.Amigos_do_DonoDataSet1TableAdapters.DENUNCIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDenuncia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENUNCIABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENUNCIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(419, 25);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtPesquisaNome
            // 
            this.TxtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisaNome.Location = new System.Drawing.Point(81, 22);
            this.TxtPesquisaNome.Name = "TxtPesquisaNome";
            this.TxtPesquisaNome.Size = new System.Drawing.Size(332, 26);
            this.TxtPesquisaNome.TabIndex = 1;
            this.TxtPesquisaNome.TextChanged += new System.EventHandler(this.TxtPesquisaNome_TextChanged);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(508, 25);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(29, 30);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // GrdDenuncia
            // 
            this.GrdDenuncia.AllowUserToAddRows = false;
            this.GrdDenuncia.AllowUserToDeleteRows = false;
            this.GrdDenuncia.AllowUserToResizeColumns = false;
            this.GrdDenuncia.AllowUserToResizeRows = false;
            this.GrdDenuncia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdDenuncia.AutoGenerateColumns = false;
            this.GrdDenuncia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDenuncia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolher,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.emailDataGridViewTextBoxColumn});
            this.GrdDenuncia.DataSource = this.dENUNCIABindingSource1;
            this.GrdDenuncia.Location = new System.Drawing.Point(12, 54);
            this.GrdDenuncia.Name = "GrdDenuncia";
            this.GrdDenuncia.Size = new System.Drawing.Size(891, 413);
            this.GrdDenuncia.TabIndex = 4;
            this.GrdDenuncia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDenuncia_CellContentClick);
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.DataPropertyName = "IDD";
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.ReadOnly = true;
            this.BtnEscolher.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Denunciante";
            this.dataGridViewTextBoxColumn1.HeaderText = "Denunciante";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TextoDenuncia";
            this.dataGridViewTextBoxColumn2.HeaderText = "TextoDenuncia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 250;
            // 
            // dENUNCIABindingSource1
            // 
            this.dENUNCIABindingSource1.DataMember = "DENUNCIA";
            this.dENUNCIABindingSource1.DataSource = this.amigos_do_DonoDataSet1;
            // 
            // amigos_do_DonoDataSet1
            // 
            this.amigos_do_DonoDataSet1.DataSetName = "Amigos_do_DonoDataSet1";
            this.amigos_do_DonoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dENUNCIABindingSource
            // 
            this.dENUNCIABindingSource.DataMember = "DENUNCIA";
            // 
            // dENUNCIATableAdapter
            // 
            this.dENUNCIATableAdapter.ClearBeforeFill = true;
            // 
            // TelaPesquisaDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 479);
            this.Controls.Add(this.GrdDenuncia);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtPesquisaNome);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPesquisaDenuncia";
            this.Text = "Tela Pesquisa Denuncia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaPesquisaDenuncia_FormClosed);
            this.Load += new System.EventHandler(this.TelaPesquisaDenuncia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDenuncia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENUNCIABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENUNCIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtPesquisaNome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DataGridView GrdDenuncia;
        private System.Windows.Forms.BindingSource dENUNCIABindingSource;
        private Amigos_do_DonoDataSet1 amigos_do_DonoDataSet1;
        private System.Windows.Forms.BindingSource dENUNCIABindingSource1;
        private Amigos_do_DonoDataSet1TableAdapters.DENUNCIATableAdapter dENUNCIATableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}
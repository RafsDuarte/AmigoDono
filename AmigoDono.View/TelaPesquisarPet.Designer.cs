namespace AmigoDono.View
{
    partial class TelaPesquisarPet
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
            this.GrdPet = new System.Windows.Forms.DataGridView();
            this.pETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigos_do_DonoDataSet = new AmigoDono.View.Amigos_do_DonoDataSet();
            this.pETTableAdapter = new AmigoDono.View.Amigos_do_DonoDataSetTableAdapters.PETTableAdapter();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.Location = new System.Drawing.Point(418, 12);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(76, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtPesquisaNome
            // 
            this.TxtPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisaNome.Location = new System.Drawing.Point(80, 9);
            this.TxtPesquisaNome.Name = "TxtPesquisaNome";
            this.TxtPesquisaNome.Size = new System.Drawing.Size(333, 26);
            this.TxtPesquisaNome.TabIndex = 1;
            this.TxtPesquisaNome.TextChanged += new System.EventHandler(this.TxtPesquisaNome_TextChanged);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.Location = new System.Drawing.Point(506, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(76, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblNome
            // 
            this.LblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(28, 17);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // GrdPet
            // 
            this.GrdPet.AllowUserToAddRows = false;
            this.GrdPet.AllowUserToDeleteRows = false;
            this.GrdPet.AllowUserToResizeColumns = false;
            this.GrdPet.AllowUserToResizeRows = false;
            this.GrdPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPet.AutoGenerateColumns = false;
            this.GrdPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolher,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GrdPet.DataSource = this.pETBindingSource;
            this.GrdPet.Location = new System.Drawing.Point(80, 53);
            this.GrdPet.Name = "GrdPet";
            this.GrdPet.Size = new System.Drawing.Size(502, 346);
            this.GrdPet.TabIndex = 4;
            this.GrdPet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPet_CellClick);
            this.GrdPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPet_CellContentClick);
            // 
            // pETBindingSource
            // 
            this.pETBindingSource.DataMember = "PET";
            this.pETBindingSource.DataSource = this.amigos_do_DonoDataSet;
            // 
            // amigos_do_DonoDataSet
            // 
            this.amigos_do_DonoDataSet.DataSetName = "Amigos_do_DonoDataSet";
            this.amigos_do_DonoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pETTableAdapter
            // 
            this.pETTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomePet";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Pet";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoPet";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo do Pet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // TelaPesquisarPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 432);
            this.Controls.Add(this.GrdPet);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtPesquisaNome);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPesquisarPet";
            this.Text = "TelaPesquisarPet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaPesquisarPet_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtPesquisaNome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DataGridView GrdPet;
        private Amigos_do_DonoDataSet amigos_do_DonoDataSet;
        private System.Windows.Forms.BindingSource pETBindingSource;
        private Amigos_do_DonoDataSetTableAdapters.PETTableAdapter pETTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
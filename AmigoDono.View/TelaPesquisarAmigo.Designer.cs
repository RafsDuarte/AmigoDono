namespace AmigoDono.View
{
    partial class TelaPesquisarAmigo
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
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtPesquisaNome = new System.Windows.Forms.TextBox();
            this.GrdAmigos = new System.Windows.Forms.DataGridView();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMIGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAmigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(44, 40);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(523, 35);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtPesquisaNome
            // 
            this.TxtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisaNome.Location = new System.Drawing.Point(96, 32);
            this.TxtPesquisaNome.Name = "TxtPesquisaNome";
            this.TxtPesquisaNome.Size = new System.Drawing.Size(332, 26);
            this.TxtPesquisaNome.TabIndex = 1;
            this.TxtPesquisaNome.TextChanged += new System.EventHandler(this.TxtPesquisaNome_TextChanged);
            // 
            // GrdAmigos
            // 
            this.GrdAmigos.AllowUserToAddRows = false;
            this.GrdAmigos.AllowUserToDeleteRows = false;
            this.GrdAmigos.AllowUserToResizeColumns = false;
            this.GrdAmigos.AllowUserToResizeRows = false;
            this.GrdAmigos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdAmigos.AutoGenerateColumns = false;
            this.GrdAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAmigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolher,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GrdAmigos.DataSource = this.aMIGOBindingSource;
            this.GrdAmigos.Location = new System.Drawing.Point(96, 77);
            this.GrdAmigos.Name = "GrdAmigos";
            this.GrdAmigos.Size = new System.Drawing.Size(502, 279);
            this.GrdAmigos.TabIndex = 4;
            this.GrdAmigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAmigos_CellClick);
            this.GrdAmigos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAmigos_CellContentClick);
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.DataPropertyName = "IDP";
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Funcao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Funcao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // aMIGOBindingSource
            // 
            this.aMIGOBindingSource.DataMember = "AMIGO";
            this.BtnOK.Location = new System.Drawing.Point(434, 35);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TelaPesquisarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 359);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrdAmigos);
            this.Controls.Add(this.TxtPesquisaNome);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPesquisarAmigo";
            this.Text = "Pesquisar Amigo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaPesquisarAmigo_FormClosed);
            this.Load += new System.EventHandler(this.TelaPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAmigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMIGOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtPesquisaNome;
        private System.Windows.Forms.DataGridView GrdAmigos;
        private System.Windows.Forms.BindingSource aMIGOBindingSource;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
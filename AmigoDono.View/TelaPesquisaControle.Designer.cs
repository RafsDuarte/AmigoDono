namespace AmigoDono.View
{
    partial class TelaPesquisaControle
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
            this.TxtPesquisaNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GrdPet = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPesquisaNome
            // 
            this.TxtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisaNome.Location = new System.Drawing.Point(86, 13);
            this.TxtPesquisaNome.Name = "TxtPesquisaNome";
            this.TxtPesquisaNome.Size = new System.Drawing.Size(332, 26);
            this.TxtPesquisaNome.TabIndex = 260;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 259;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
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
            this.GrdPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdPet.Location = new System.Drawing.Point(0, 70);
            this.GrdPet.Name = "GrdPet";
            this.GrdPet.Size = new System.Drawing.Size(927, 367);
            this.GrdPet.TabIndex = 258;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "IDP";
            this.BtnAlterar.HeaderText = "Alt";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Width = 30;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "IDP";
            this.BtnExcluir.HeaderText = "Exc";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Width = 30;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(442, 16);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 257;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(45, 26);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 256;
            this.LblNome.Text = "Nome";
            // 
            // TelaPesquisaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.TxtPesquisaNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrdPet);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblNome);
            this.Name = "TelaPesquisaControle";
            this.Text = "TelaPesquisaControle";
            this.Load += new System.EventHandler(this.TelaPesquisaControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPesquisaNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GrdPet;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAmigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSDataGridViewTextBoxColumn;
    }
}
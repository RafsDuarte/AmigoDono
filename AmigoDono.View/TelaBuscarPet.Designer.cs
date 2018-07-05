namespace AmigoDono.View
{
    partial class TelaBuscarPet
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
            this.GrdPet = new System.Windows.Forms.DataGridView();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtPesquisaNome = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPet)).BeginInit();
            this.SuspendLayout();
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
            this.BtnEscolher});
            this.GrdPet.Location = new System.Drawing.Point(76, 62);
            this.GrdPet.Name = "GrdPet";
            this.GrdPet.Size = new System.Drawing.Size(502, 346);
            this.GrdPet.TabIndex = 9;
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.Width = 60;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.Location = new System.Drawing.Point(414, 21);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(76, 23);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // TxtPesquisaNome
            // 
            this.TxtPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisaNome.Location = new System.Drawing.Point(76, 18);
            this.TxtPesquisaNome.Name = "TxtPesquisaNome";
            this.TxtPesquisaNome.Size = new System.Drawing.Size(333, 26);
            this.TxtPesquisaNome.TabIndex = 6;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.Location = new System.Drawing.Point(502, 21);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(76, 23);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // LblNome
            // 
            this.LblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(24, 26);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome";
            // 
            // TelaBuscarPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdPet);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtPesquisaNome);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNome);
            this.Name = "TelaBuscarPet";
            this.Text = "TelaBuscarPet";
            ((System.ComponentModel.ISupportInitialize)(this.GrdPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdPet;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtPesquisaNome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblNome;
    }
}
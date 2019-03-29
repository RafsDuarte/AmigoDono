namespace AmigoDono.View
{
    partial class TelaRaça
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
            this.DGVRaca = new System.Windows.Forms.DataGridView();
            this.BtnEscolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rAÇABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtRaca = new System.Windows.Forms.TextBox();
            this.LblRaça = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.amigos_do_DonoRaça = new AmigoDono.View.Amigos_do_DonoRaça();
            this.rAÇABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rAÇATableAdapter = new AmigoDono.View.Amigos_do_DonoRaçaTableAdapters.RAÇATableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoRaça)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRaca
            // 
            this.DGVRaca.AllowUserToAddRows = false;
            this.DGVRaca.AutoGenerateColumns = false;
            this.DGVRaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEscolher,
            this.BtnAlterar,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DGVRaca.DataSource = this.rAÇABindingSource1;
            this.DGVRaca.Location = new System.Drawing.Point(12, 170);
            this.DGVRaca.Name = "DGVRaca";
            this.DGVRaca.ReadOnly = true;
            this.DGVRaca.Size = new System.Drawing.Size(566, 268);
            this.DGVRaca.TabIndex = 6;
            this.DGVRaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRaca_CellContentClick);
            // 
            // BtnEscolher
            // 
            this.BtnEscolher.DataPropertyName = "IDTT";
            this.BtnEscolher.HeaderText = "Escolher";
            this.BtnEscolher.Name = "BtnEscolher";
            this.BtnEscolher.ReadOnly = true;
            this.BtnEscolher.Width = 60;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "IDTT";
            this.BtnAlterar.HeaderText = "Excluir";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Width = 60;
            // 
            // rAÇABindingSource
            // 
            this.rAÇABindingSource.DataMember = "RAÇA";
            // 
            // TxtRaca
            // 
            this.TxtRaca.Location = new System.Drawing.Point(78, 58);
            this.TxtRaca.Multiline = true;
            this.TxtRaca.Name = "TxtRaca";
            this.TxtRaca.Size = new System.Drawing.Size(481, 27);
            this.TxtRaca.TabIndex = 3;
            // 
            // LblRaça
            // 
            this.LblRaça.AutoSize = true;
            this.LblRaça.Location = new System.Drawing.Point(8, 61);
            this.LblRaça.Name = "LblRaça";
            this.LblRaça.Size = new System.Drawing.Size(58, 13);
            this.LblRaça.TabIndex = 2;
            this.LblRaça.Text = "Descricao ";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(483, 112);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(379, 112);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // amigos_do_DonoRaça
            // 
            this.amigos_do_DonoRaça.DataSetName = "Amigos_do_DonoRaça";
            this.amigos_do_DonoRaça.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAÇABindingSource1
            // 
            this.rAÇABindingSource1.DataMember = "RAÇA";
            this.rAÇABindingSource1.DataSource = this.amigos_do_DonoRaça;
            // 
            // rAÇATableAdapter
            // 
            this.rAÇATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDR";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeRaça";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeRaça";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TelaRaça
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DGVRaca);
            this.Controls.Add(this.TxtRaca);
            this.Controls.Add(this.LblRaça);
            this.Name = "TelaRaça";
            this.Text = "TelaRaça";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaRaça_FormClosed);
            this.Load += new System.EventHandler(this.TelaRaça_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigos_do_DonoRaça)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAÇABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRaca;
        private System.Windows.Forms.TextBox TxtRaca;
        private System.Windows.Forms.Label LblRaça;
        private System.Windows.Forms.BindingSource rAÇABindingSource;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEscolher;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRaçaDataGridViewTextBoxColumn;
        private Amigos_do_DonoRaça amigos_do_DonoRaça;
        private System.Windows.Forms.BindingSource rAÇABindingSource1;
        private Amigos_do_DonoRaçaTableAdapters.RAÇATableAdapter rAÇATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
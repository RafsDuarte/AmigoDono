namespace AmigoDono.View
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAmigo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPet = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPesquisarAmigo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPesquisarPet = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPesquisarTratamento = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPesquisarDenuncia = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPesqusaControle = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTratamento = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDenuncia = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denúnciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeTratamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadastro,
            this.pesquisarToolStripMenuItem,
            this.MnuControle,
            this.MnuTratamento,
            this.MnuDenuncia,
            this.relatórioToolStripMenuItem,
            this.MnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuCadastro
            // 
            this.MnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAmigo,
            this.MnuPet,
            this.tipoDeTratamentoToolStripMenuItem,
            this.tToolStripMenuItem});
            this.MnuCadastro.Name = "MnuCadastro";
            this.MnuCadastro.Size = new System.Drawing.Size(71, 20);
            this.MnuCadastro.Text = "Cadastros";
            this.MnuCadastro.Click += new System.EventHandler(this.MnuCadastro_Click);
            // 
            // MnuAmigo
            // 
            this.MnuAmigo.Name = "MnuAmigo";
            this.MnuAmigo.Size = new System.Drawing.Size(180, 22);
            this.MnuAmigo.Text = "Amigo";
            this.MnuAmigo.Click += new System.EventHandler(this.MnuAmigo_Click);
            // 
            // MnuPet
            // 
            this.MnuPet.Name = "MnuPet";
            this.MnuPet.Size = new System.Drawing.Size(180, 22);
            this.MnuPet.Text = "Pet";
            this.MnuPet.Click += new System.EventHandler(this.MnuPet_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPesquisarAmigo,
            this.MnuPesquisarPet,
            this.MnuPesquisarTratamento,
            this.MnuPesquisarDenuncia,
            this.MnuPesqusaControle});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // MnuPesquisarAmigo
            // 
            this.MnuPesquisarAmigo.Name = "MnuPesquisarAmigo";
            this.MnuPesquisarAmigo.Size = new System.Drawing.Size(135, 22);
            this.MnuPesquisarAmigo.Text = "Amigo";
            this.MnuPesquisarAmigo.Click += new System.EventHandler(this.MnuPesquisarAmigo_Click);
            // 
            // MnuPesquisarPet
            // 
            this.MnuPesquisarPet.Name = "MnuPesquisarPet";
            this.MnuPesquisarPet.Size = new System.Drawing.Size(135, 22);
            this.MnuPesquisarPet.Text = "Pet";
            this.MnuPesquisarPet.Click += new System.EventHandler(this.MnuPesquisarPet_Click);
            // 
            // MnuPesquisarTratamento
            // 
            this.MnuPesquisarTratamento.Name = "MnuPesquisarTratamento";
            this.MnuPesquisarTratamento.Size = new System.Drawing.Size(135, 22);
            this.MnuPesquisarTratamento.Text = "Tratamento";
            // 
            // MnuPesquisarDenuncia
            // 
            this.MnuPesquisarDenuncia.Name = "MnuPesquisarDenuncia";
            this.MnuPesquisarDenuncia.Size = new System.Drawing.Size(135, 22);
            this.MnuPesquisarDenuncia.Text = "Denuncia";
            this.MnuPesquisarDenuncia.Click += new System.EventHandler(this.MnuPesquisarDenuncia_Click);
            // 
            // MnuPesqusaControle
            // 
            this.MnuPesqusaControle.Name = "MnuPesqusaControle";
            this.MnuPesqusaControle.Size = new System.Drawing.Size(135, 22);
            this.MnuPesqusaControle.Text = "Controle";
            // 
            // MnuControle
            // 
            this.MnuControle.Name = "MnuControle";
            this.MnuControle.Size = new System.Drawing.Size(65, 20);
            this.MnuControle.Text = "Controle";
            this.MnuControle.Click += new System.EventHandler(this.MnuControle_Click);
            // 
            // MnuTratamento
            // 
            this.MnuTratamento.Name = "MnuTratamento";
            this.MnuTratamento.Size = new System.Drawing.Size(85, 20);
            this.MnuTratamento.Text = "Tratamentos";
            this.MnuTratamento.Click += new System.EventHandler(this.MnuTratamento_Click);
            // 
            // MnuDenuncia
            // 
            this.MnuDenuncia.Name = "MnuDenuncia";
            this.MnuDenuncia.Size = new System.Drawing.Size(74, 20);
            this.MnuDenuncia.Text = "Denúncias";
            this.MnuDenuncia.Click += new System.EventHandler(this.MnuDenuncia_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.controleToolStripMenuItem,
            this.tratamentoToolStripMenuItem,
            this.denúnciasToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amigoToolStripMenuItem,
            this.petToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // amigoToolStripMenuItem
            // 
            this.amigoToolStripMenuItem.Name = "amigoToolStripMenuItem";
            this.amigoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.amigoToolStripMenuItem.Text = "Amigo";
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.petToolStripMenuItem.Text = "Pet";
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.controleToolStripMenuItem.Text = "Controle";
            // 
            // tratamentoToolStripMenuItem
            // 
            this.tratamentoToolStripMenuItem.Name = "tratamentoToolStripMenuItem";
            this.tratamentoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tratamentoToolStripMenuItem.Text = "Tratamentos";
            // 
            // denúnciasToolStripMenuItem
            // 
            this.denúnciasToolStripMenuItem.Name = "denúnciasToolStripMenuItem";
            this.denúnciasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.denúnciasToolStripMenuItem.Text = "Denúncias";
            // 
            // MnuSair
            // 
            this.MnuSair.Name = "MnuSair";
            this.MnuSair.Size = new System.Drawing.Size(38, 20);
            this.MnuSair.Text = "Sair";
            this.MnuSair.Click += new System.EventHandler(this.MnuSair_Click);
            // 
            // tipoDeTratamentoToolStripMenuItem
            // 
            this.tipoDeTratamentoToolStripMenuItem.Name = "tipoDeTratamentoToolStripMenuItem";
            this.tipoDeTratamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeTratamentoToolStripMenuItem.Text = "Tipo de Tratamento";
            this.tipoDeTratamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeTratamentoToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tToolStripMenuItem.Text = "Tipo de Raça";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Friend of the Owner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MnuSair;
        public System.Windows.Forms.ToolStripMenuItem MnuAmigo;
        public System.Windows.Forms.ToolStripMenuItem MnuPet;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denúnciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuDenuncia;
        public System.Windows.Forms.ToolStripMenuItem MnuControle;
        public System.Windows.Forms.ToolStripMenuItem MnuTratamento;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuPesquisarAmigo;
        public System.Windows.Forms.ToolStripMenuItem MnuPesquisarPet;
        private System.Windows.Forms.ToolStripMenuItem MnuPesquisarTratamento;
        private System.Windows.Forms.ToolStripMenuItem MnuPesqusaControle;
        public System.Windows.Forms.ToolStripMenuItem MnuPesquisarDenuncia;
        private System.Windows.Forms.ToolStripMenuItem tipoDeTratamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
    }
}


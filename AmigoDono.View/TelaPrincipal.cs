using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoDono.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void MnuAmigo_Click(object sender, EventArgs e)
        {
            TelaCadastroAmigo oFrm = new TelaCadastroAmigo();
            oFrm.MdiParent = this;
          
            oFrm.Show();
            MnuAmigo.Enabled = false;
        }

       

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MnuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void MnuControle_Click(object sender, EventArgs e)
        {
            TelaControle oFrm = new TelaControle();
            oFrm.MdiParent = this;
            oFrm.WindowState = FormWindowState.Maximized;
            oFrm.Show();
            MnuControle.Enabled = false;

        }

        private void MnuTratamento_Click(object sender, EventArgs e)
        {
            TelaTratamento oFrm = new TelaTratamento();
            oFrm.MdiParent = this;
            oFrm.WindowState = FormWindowState.Maximized;
            oFrm.Show();
            MnuTratamento.Enabled = false;

        }

        private void MnuDenuncia_Click(object sender, EventArgs e)
        {
            TelaDenuncia oFrm = new TelaDenuncia();
            oFrm.MdiParent = this;
            oFrm.WindowState = FormWindowState.Maximized;
            oFrm.Show();
            MnuDenuncia.Enabled = false;

        }

        private void MnuPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void MnuPesquisarAmigo_Click(object sender, EventArgs e)
        {
            TelaPesquisarAmigo oFrm = new TelaPesquisarAmigo();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuPesquisarAmigo.Enabled = false;
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuPesquisarPet_Click(object sender, EventArgs e)
        {
            TelaPesquisarPet oFrm = new TelaPesquisarPet();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuPesquisarPet.Enabled = false;
        }

        private void MnuPet_Click(object sender, EventArgs e)
        {
            TelaCadastroPet oFrm = new TelaCadastroPet();
            oFrm.MdiParent = this;
            //oFrm.WindowState = FormWindowState.Maximized;
            oFrm.Show();
            MnuPet.Enabled = false;

        }

        private void MnuPesquisarDenuncia_Click(object sender, EventArgs e)
        {
            TelaPesquisaDenuncia oFrm = new TelaPesquisaDenuncia();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuPesquisarDenuncia.Enabled = false;

        }
    }
}

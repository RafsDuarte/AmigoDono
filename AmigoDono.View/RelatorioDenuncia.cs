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
    public partial class RelatorioDenuncia : Form
    {
        public RelatorioDenuncia()
        {
            InitializeComponent();
        }

        private void RelatorioDenuncia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vwRelatorioDenuncia.vw_DENUNCIA'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_DENUNCIATableAdapter.Fill(this.vwRelatorioDenuncia.vw_DENUNCIA);

        }

        private void BtnSair_MouseClick(object sender, MouseEventArgs e)
        {
            Close();

        }

        private void RelatorioDenuncia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuDenuncia.Enabled = true;
        }
    }
}

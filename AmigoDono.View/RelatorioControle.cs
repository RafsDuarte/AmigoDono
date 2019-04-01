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
    
    public partial class RelatorioControle : Form
    {
        public RelatorioControle()
        {
            InitializeComponent();
        }

        private void RelatorioControle_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoDataSet18.vw_CONTROLE'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_CONTROLETableAdapter.Fill(this.amigos_do_DonoDataSet18.vw_CONTROLE);
            // TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoDataSet17.vw_CONTROLE'. Você pode movê-la ou removê-la conforme necessário.
            // this.vw_CONTROLETableAdapter.Fill(this.amigos_do_DonoDataSet17.vw_CONTROLE);

        }

        private void LblDataAdoçao_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAdocao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RelatorioControle_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuRelatorioControle.Enabled = true;
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

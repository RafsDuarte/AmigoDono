using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigoDono.Control;
using AmigoDono.Model;
namespace AmigoDono.View
{
    public partial class TelaPesquisaDenuncia : Form
    {
        private Control.CDenuncia _Control = new CDenuncia();
        public string denuncia = null;
        DENUNCIA denunciaPesquisado = new DENUNCIA();
        public TelaPesquisaDenuncia() { InitializeComponent(); }
        private void CarregaGrid(string denuncia = ""){ GrdDenuncia.DataSource = _Control.SelecionarTodos(denuncia);}
        private void TelaPesquisar_Load(object sender, EventArgs e){}
        private void CboNome_SelectedIndexChanged(object sender, EventArgs e){}        
        private void TxtPesquisaNome_TextChanged(object sender, EventArgs e){}
        private void GrdDenuncia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DENUNCIA oDenuncia = ((DENUNCIA)GrdDenuncia.Rows[e.RowIndex].DataBoundItem);
            if (GrdDenuncia.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdDenuncia.Columns[e.ColumnIndex].Name == "BtnEscolher")
                {
                    TelaDenuncia frmDenuncia = new TelaDenuncia(oDenuncia);
                    frmDenuncia.MdiParent = this.MdiParent;
                    frmDenuncia.Show();
                    this.Close();
                }
            }
        }
        private void BtnSair_Click(object sender, EventArgs e) {Close();}
        
        private void TelaPesquisaDenuncia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuPesquisarDenuncia.Enabled = true;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            string procura = TxtPesquisaNome.Text;
            if (TxtPesquisaNome.Text == "")
            {
                GrdDenuncia.DataSource = _Control.SelecionarTodos("");
            }
            else
            {
                CarregaGrid(procura);

                if (GrdDenuncia.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }

        private void TelaPesquisaDenuncia_Load(object sender, EventArgs e)
        {

        }
    }
}

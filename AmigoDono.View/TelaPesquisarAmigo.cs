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
    public partial class TelaPesquisarAmigo : Form
    {
        private Control.CAmigo _Control = new CAmigo();
        public string amigo = null;
        AMIGO amigoPesquisado = new AMIGO();
        public TelaPesquisarAmigo() {InitializeComponent();}
        private void CarregaGrid(string amigo="")
        {
            GrdAmigos.DataSource = _Control.SelecionarTodos(amigo);
        }
        private void TelaPesquisar_Load(object sender, EventArgs e)   { }
        private void CboNome_SelectedIndexChanged(object sender, EventArgs e)   { }
        private void TxtPesquisaNome_TextChanged(object sender, EventArgs e) { }
        private void GrdAmigos_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
        private void BtnSair_Click(object sender, EventArgs e){ Close(); }
        private void GrdAmigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AMIGO oAmigo = ((AMIGO)GrdAmigos.Rows[e.RowIndex].DataBoundItem);
            if (GrdAmigos.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdAmigos.Columns[e.ColumnIndex].Name == "BtnEscolher")
                {                  
                    TelaCadastroAmigo frmAmigo = new TelaCadastroAmigo(oAmigo);
                    frmAmigo.MdiParent = this.MdiParent;
                    frmAmigo.Show();
                    this.Close();
                }
            }
        }
        private void TelaPesquisarAmigo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuPesquisarAmigo.Enabled = true;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            string procura = TxtPesquisaNome.Text;
            if (TxtPesquisaNome.Text == "")
            {
                GrdAmigos.DataSource = _Control.SelecionarTodos("");
            }
            else
            {
                CarregaGrid(procura);

                if (GrdAmigos.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }
    }
}

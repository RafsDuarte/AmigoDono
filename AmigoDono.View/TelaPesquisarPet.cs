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
    public partial class TelaPesquisarPet : Form
    {
        private Control.CPet _Control = new CPet();
        public string pet = null;
        PET PetPesquisado = new PET();
        public TelaPesquisarPet(){InitializeComponent();}
        private void CarregaGrid(string pet = ""){GrdPet.DataSource = _Control.SelecionarTodos(pet);}
        private void TelaPesquisar_Load(object sender, EventArgs e){}
        private void TelaPesquisarPet_Load(object sender, EventArgs e) { }
        private void CboNome_SelectedIndexChanged(object sender, EventArgs e) {}
        private void TxtPesquisaNome_TextChanged(object sender, EventArgs e){}
        private void GrdPet_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void BtnSair_Click(object sender, EventArgs e){Close();}
        private void TelaPesquisarPet_FormClosed(object sender, FormClosedEventArgs e) { ((TelaPrincipal)this.MdiParent).MnuPesquisarPet.Enabled = true; }
        private void GrdPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PET oPet = ((PET)GrdPet.Rows[e.RowIndex].DataBoundItem);
            if (GrdPet.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdPet.Columns[e.ColumnIndex].Name == "BtnEscolher")
                {
                    TelaCadastroPet frmPet = new TelaCadastroPet(oPet);
                    frmPet.MdiParent = this.MdiParent;
                    frmPet.Show();
                    this.Close();
                }
            }
        }        
        private void BtnOK_Click(object sender, EventArgs e)
        {
            string procura = TxtPesquisaNome.Text;
            if (TxtPesquisaNome.Text == "")
            {
                GrdPet.DataSource = _Control.SelecionarTodos("");
            }
            else
            {
                CarregaGrid(procura);

                if (GrdPet.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }

    }
}

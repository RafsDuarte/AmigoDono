using System;
using System.Windows.Forms;
using AmigoDono.Control;
using AmigoDono.Model;

namespace AmigoDono.View
{
    public partial class TelaControle : Form
    {
        private Control.CPet _Control_p = new CPet();
        private Control.CAmigo _Control_a = new CAmigo();
        private Control.CControle _Control_c = new CControle();

        CONTROLE _controle = null;
        CONTROLE oControle = new CONTROLE();
        AMIGO _proprietario = null;
        AMIGO oProprietario = new AMIGO();
        PET _pet = null;
        PET oPet = new PET();
       
        public TelaControle()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            TxtIdPet.Enabled = false;
            TxtNomePet.Enabled = false;
            TxtIdProprietario.Enabled = false;
            TxtNomeProprietario.Enabled = false;
            CboStatus.Enabled = false;
            TxtObs.Enabled = false;
        }

        private bool ValidaControles()
        {
            return true;
        }
        private void DesabilitaCampos()
        {
            dateTimePickerAdocao.Enabled = false;
            TxtIdPet.Enabled = false;
            TxtNomePet.Enabled = false;
            TxtIdProprietario.Enabled = false;
            TxtNomeProprietario.Enabled = false;
            CboStatus.Enabled = false;
            TxtObs.Enabled = false;
            BtnSalvar.Enabled = false;
        }
      
        private void PopulaCampos()
        {
            //dateTimePickerAdocao.Enabled = true;

            TxtIdPet.Text = _pet.IDP.ToString();
            TxtNomePet.Text = _pet.NomePet;
            TxtIdProprietario.Text = _proprietario.IDA.ToString();
            TxtNomeProprietario.Text = _proprietario.Nome;
            CboStatus.Text = _controle.Statu;
            TxtObs.Text = _controle.OBS;
            BtnExcluir.Enabled = true;
        }
        private void LimpaDados()
        {
            TxtIdPet.Text = "";
            TxtNomePet.Text = "";
            TxtIdProprietario.Text = "";
            TxtNomeProprietario.Text = "";
            CboStatus.Text = "";
            TxtObs.Text = "";
        }
        private bool ValidaCampos()
        {            
            if (TxtNomePet.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNomePet.Select();
                return false;
            }
            if (TxtNomeProprietario.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Ownero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNomeProprietario.Select();
                return false;
            }
            if (CboStatus.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Ownero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboStatus.Select();
                return false;
            }
            return true;
        }
        private void TelaControle_Load(object sender, EventArgs e)
        {// TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoDataSet7.AMIGO'. Você pode movê-la ou removê-la conforme necessário.
            this.aMIGOTableAdapter.Fill(this.amigos_do_DonoDataSet7.AMIGO);
            // TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoDataSet6.PET'. Você pode movê-la ou removê-la conforme necessário.
            this.pETTableAdapter.Fill(this.amigos_do_DonoDataSet6.PET);
        }
        private void BtnSair_Click(object sender, EventArgs e) {  Close();  }
        private void Telacontrole_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuControle.Enabled = true;
        }
        private void LblNomePet_Click(object sender, EventArgs e) { }
        private void BtnBuscarPet_Click(object sender, EventArgs e)
        {
        }
        private void LblNomeProp_Click(object sender, EventArgs e) { }
        private void BtnBuscarProp_Click(object sender, EventArgs e)
        {
        }
        private void TxtNomePet_TextChanged(object sender, EventArgs e)
        {
            string nomep = TxtNomePet.Text;
            _Control_p.SelecionarNome(nomep);
        }
        private void TxtNomePet_Leave(object sender, EventArgs e) {  }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
        
           // oControle = _controle.(Convert.ToInt32(TxtIDControle.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
               // _controle.Excluir(oControle);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_controle != null)
                    {
                        //Alterar Amigo

                        _controle.IDPet = Convert.ToInt16(TxtIdPet);
                        _controle.IDDono = Convert.ToInt16(TxtIdProprietario);
                        _controle.Statu = CboStatus.Text;
                        _controle.OBS = TxtObs.Text;
                        _Control_c.Alterar(_controle);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {
                        //Incluir Amigo 
                        oControle.IDPet = Convert.ToInt16(TxtIdPet);
                        oControle.IDDono = Convert.ToInt16(TxtIdProprietario);
                        oControle.Statu = CboStatus.Text;
                        oControle.OBS = TxtObs.Text;                        
                        _Control_c.Incluir(oControle);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        TxtNomePet.Focus();
                    }
                }
            }

        }
        private void DGWBuscaPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGWBuscaPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      //      PET oPet = ((PET)DGWBuscaPet.Rows[e.RowIndex].DataBoundItem);
            if (DGWBuscaPet.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (DGWBuscaPet.Columns[e.ColumnIndex].Name == "BtnEscolher")
                {
                   // _controle.IDPet = _pet.IDP;
                    TxtIdPet.Text = _pet.IDP.ToString();
                    TxtNomePet.Text = _pet.NomePet;
                }
            }
        }

        private void DGWBuscaProp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGWBuscaProp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      //      AMIGO oAmigo = ((AMIGO)DGWBuscaProp.Rows[e.RowIndex].DataBoundItem);
            if (DGWBuscaProp.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (DGWBuscaProp.Columns[e.ColumnIndex].Name == "BtnEscolher")
                {
                 //   _controle.IDAmigo =_proprietario.IDA;
                    TxtNomeProprietario.Text = _proprietario.Nome;
                    TxtIdProprietario.Text = _proprietario.IDA.ToString();
                }
            }

        }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigoDono.Model;
using AmigoDono.Control;
using System.Threading;

namespace AmigoDono.View
{
    public partial class TelaTratamento : Form
    {

        private Control.CTratamento _Control = new CTratamento();
        private Control.CPet _Pet = new CPet();
        private Control.CAmigo _Amigo = new CAmigo();

        public string teste;

        TRATAMENTO _tratamento = null;
        TRATAMENTO tratamenentoalterar = new TRATAMENTO();
        TRATAMENTO oTratamento = new TRATAMENTO();
      
        AMIGO oProprietario = new AMIGO();
        AMIGO retornoA = new AMIGO();


        public TelaTratamento()
        {
            InitializeComponent();
        }
        public TelaTratamento(TRATAMENTO tratamento)
        {
            InitializeComponent();
            _tratamento = tratamento;
            PopulaCampos();
        }

        public TelaTratamento(PET oPet) { }
        private void PopulaCampos()
        {
            //TxtIdPet.Text = retornoP.IDP.ToString();
            //TxtNomePet.Text = retornoP.NomePet;
            CboTipoCuidado.Text = _tratamento.Tipo;
            TxtIdResponsavel.Text = retornoA.IDA.ToString();
            TxtNomeResponsavel.Text = retornoA.Nome;
            TxtDescricao.Text = _tratamento.Descricao;
            BtnExcluir.Enabled = true;
        }
        private void TelaTratamento_Load(object sender, EventArgs e) { }
        private void BtnSair_Click(object sender, EventArgs e) { Close(); }
        private void dateTimePickerTratamento_ValueChanged(object sender, EventArgs e) { }
        private void TxtDescricao_TextChanged(object sender, EventArgs e) { }
        private void TelaTratamento_FormClosed_1(object sender, FormClosedEventArgs e) { ((TelaPrincipal)this.MdiParent).MnuTratamento.Enabled = true; }
        //DIRECIONA TELA PET
        private void BtnBuscarPet_Click(object sender, EventArgs e)
        {
            //TelaTratamentoBuscarPet frmControle = new TelaTratamentoBuscarPet();
            //frmControle.MdiParent = this.MdiParent;
            //frmControle.Show();

        }
        //DIRECIONA TELA PROPRIETARIO
        private void BtnBuscarResp_Click(object sender, EventArgs e)
        {
            //TelaTratamentoBuscarProp frmControle = new TelaTratamentoBuscarProp();
            //frmControle.MdiParent = this.MdiParent;
            //frmControle.Show();
        }
        //CARREGA COMBOBOX
        private void CboTipoCuidado_SelectedIndexChanged(object sender, EventArgs e) { this.CboTipoCuidado.Items.Add(oTratamento.Tipo); }
        //VALIDAR CAMPOS PRA INCLUIR
        //private bool ValidaCampos()
        //{
        //    if (CboTipoCuidado.Text == string.Empty)
        //    {
        //        MessageBox.Show("Selecione o tipo de cuidado", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        CboTipoCuidado.Select();
        //        return false;

        //        if (TxtDescricao.Text == "")
        //        {
        //            MessageBox.Show("Descrição deve ser preenchida", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            TxtDescricao.Select();
        //            TxtDescricao.Focus();
        //            return false;

        //            if (TxtNomePet.Text == "")
        //            {
        //                MessageBox.Show("Nome do Pet deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                TxtDescricao.Select();
        //                TxtDescricao.Focus();
        //                return false;

        //                if (TxtNomeResponsavel.Text == "")
        //                {
        //                    MessageBox.Show("Nome do Responsável deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    TxtDescricao.Select();
        //                    TxtDescricao.Focus();
        //                    return false;

        //                    if (DteTimePickerDataTratamento.Text == "")
        //                    {
        //                        MessageBox.Show("A data deve ser preenchida", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        TxtDescricao.Select();
        //                        TxtDescricao.Focus();
        //                        return false;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return true;
        //    }


        //}
        //BOTAO INCLUIR

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            //    if (ValidaCampos() == true)
            //    {
            //        _tratamento.IDPet = Convert.ToInt32(TxtNomePet.Text);
            //        _tratamento.IDResponsavel = Convert.ToInt32(TxtIdResponsavel.Text);
            //        _tratamento.Descricao = TxtDescricao.Text;
            //        _tratamento.Tipo = CboTipoCuidado.Text;
            //        _tratamento.Data = DteTimePickerDataTratamento.MaxDate;

            //        _Control.Incluir(_tratamento);
            //        Mensagens.MsgIncluido();
            //    }
            //    else
            //    {
            //        MessageBox.Show("validacampos == false");
            //    }

        }
        //BOTAO EXCLUIR
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            TRATAMENTO oTrat;
            oTrat = _Control.SelecionarID(Convert.ToInt32(TxtIdPet.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oTrat);
                Mensagens.MsgExcluido();
                this.Close();
            }
        }
    }
}

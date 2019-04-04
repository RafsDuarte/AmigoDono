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

        TIPOTRATAMENTO _TipoTratamento = null;
        TIPOTRATAMENTO oTipoTratamento = new TIPOTRATAMENTO();
        TRATAMENTO _tratamento = null;
        TRATAMENTO oTratamento = new TRATAMENTO();
        AMIGO _proprietario = null;
        AMIGO oProprietario = new AMIGO();
        PET _pet = null;
        PET oPet = new PET(); 
        
        public TelaTratamento()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            DteTimePickerDataTratamento.Enabled = false;
            cboPet.Enabled = false;
            CboTipoCuidado.Enabled = false;
            CboResponsavel.Enabled = false;
            CboTipoCuidado.Enabled = false;
            TxtObs.Enabled = false;
        }
        private bool ValidaControles()
        {
            return true;
        }
        private void DesabiitaCampos()
        {
            DteTimePickerDataTratamento.Enabled = false;
            cboPet.Enabled = false;
            CboTipoCuidado.Enabled = false;
            CboResponsavel.Enabled = false;
            TxtObs.Enabled = false;
            BtnSalvar.Enabled = false;
        }
        private void PopulaCampos()
        {
            cboPet.Text = _pet.NomePet;
            CboTipoCuidado.Text = _TipoTratamento.Descricao;
            CboResponsavel.Text = _proprietario.Nome;
            TxtObs.Text = _tratamento.OBS;
        }
        private void LimpaDados()
        {
            cboPet.Text ="";
            CboTipoCuidado.Text ="";
            CboResponsavel.Text = "";
            TxtObs.Text = "";
        }
        private bool ValidaCampos()
        {
            return true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CarregaGrid(string NomePet = "")
        {
            GrdHistoricoTratamento.DataSource = _Control.NomePet(NomePet);
        }

        private void TelaTratamento_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuTratamento.Enabled = true;
        }


        //BOTAO INCLUIR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_Control!=null)
                    {
                        _tratamento.OBS = TxtObs.Text;

                        Mensagens.MsgAlterado();
                        LimpaDados();
                        cboPet.Focus();
                    }
                    else
                    {
                        List<PET> Cachorros = _Control.Pets();
                        foreach (var x in Cachorros)
                        {
                            if (cboPet.Text == x.NomePet)
                            {
                                oTratamento.IDPet = x.IDP;
                            }
                        }


                        List<AMIGO> Proprietario = _Control.Amigos();
                        foreach (var x in Proprietario)
                        {
                            if (CboResponsavel.Text == x.Nome)
                            {
                                oTratamento.IDResponsavel = x.IDA;
                            }
                        }

                        oTratamento.OBS = TxtObs.Text;
                        _Control.Incluir(oTratamento);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        cboPet.Focus();
                    }
                }
            }
           
        }
        //BOTAO EXCLUIR
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
        }
        public TelaTratamento(TRATAMENTO tratamento)
        {
            InitializeComponent();
            _tratamento = tratamento;
            PopulaCampos();
        }

        ////public TelaTratamento(TRATAMENTO oTratamento) { }

        ////private void TelaTratamento_Load(object sender, EventArgs e)
        ////{
        ////    List<TRATAMENTO> Tratamentos = _Control.Nome();
        ////    foreach (var x in Nome)
        ////    {
        ////        cboPet.Items.Add(x.NomePet);
        ////    }
        ////    List<AMIGO> Responsavel = _Control.Amigos();
        ////    foreach (var x in Responsavel)
        ////    {
        ////        CboResponsavel.Items.Add(x.Nome);
        ////    }
        ////}
        private void dateTimePickerTratamento_ValueChanged(object sender, EventArgs e) { }
        private void TxtDescricao_TextChanged(object sender, EventArgs e) { }
        //DIRECIONA TELA PET
        private void BtnBuscarPet_Click(object sender, EventArgs e)
        {

        }
        //DIRECIONA TELA PROPRIETARIO
        private void BtnBuscarResp_Click(object sender, EventArgs e)
        {
        }
        //CARREGA COMBOBOX
        private void CboTipoCuidado_SelectedIndexChanged(object sender, EventArgs e) { this.CboTipoCuidado.Items.Add(oTratamento.Tipo); }

        private void cboPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string procura = cboPet.Text;
            if (cboPet.Text == "")
            {
                GrdHistoricoTratamento.DataSource = _Control.NomePet("");
            }
            else
            {
                CarregaGrid(procura);

                if (GrdHistoricoTratamento.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }
        //VALIDAR CAMPOS PRA INCLUIR

    }
}

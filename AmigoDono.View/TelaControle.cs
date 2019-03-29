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
    public partial class TelaControle : Form
    {
        private Control.CPet _Control_p = new CPet();
        private Control.CAmigo _Control_a = new CAmigo();
        private Control.CControle _Control_c = new CControle();

        CONTROLE _controle = null;
        CONTROLE oControle = new CONTROLE();
        AMIGO _proprietario = null;
        AMIGO oProprietario = new AMIGO();
        AMIGO _Doador = null;
        AMIGO oDoador = new AMIGO();
        PET _pet = null;
        PET oPet = new PET();
        
        public TelaControle()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            CBOPet.Enabled = false;
            CBOProp.Enabled = false;
            CBODoador.Enabled = false;
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
            CBOPet.Enabled = false;
            CBOProp.Enabled = false;
            CBODoador.Enabled = false;
            CboStatus.Enabled = false;
            TxtObs.Enabled = false;
            BtnSalvar.Enabled = false;
        }

        private void PopulaCampos()
        {
            CBOPet.Text = _pet.NomePet;
            CBOProp.Text = _proprietario.Nome;
            CBODoador.Text = _Doador.Nome;
            CboStatus.Text = _controle.Statu;
            TxtObs.Text = _controle.OBS;
        }
        private void LimpaDados()
        {
            CBOPet.Text = "";
            CBOProp.Text = "";
            CBODoador.Text = "";
            CboStatus.Text = "";
            TxtObs.Text = "";
        }
        private bool ValidaCampos()
        {
            return true;
        }
        
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
        private void TelaControle_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuControle.Enabled = true;
        }

        
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_controle != null)
                    {
                        _controle.Statu = CboStatus.Text;
                        _controle.OBS = TxtObs.Text;
                        _Control_c.Alterar(_controle);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {

                        List<PET> Cachorros= _Control_c.Pets();
                        foreach(var x in Cachorros)
                        {
                            if(CBOPet.Text==x.NomePet)
                            {
                                oControle.IDPet = x.IDP;
                            }
                        }
                        

                        List<AMIGO> Proprietario = _Control_c.Amigos();
                        foreach (var x in Proprietario )
                        {
                            if (CBOProp.Text == x.Nome)
                            {
                                oControle.IDDono = x.IDA;
                            }
                        }
                        List<AMIGO> Doador = _Control_c.Amigos();
                        foreach (var x in Doador)
                        {
                            if (CBODoador.Text == x.Nome)
                            {
                                oControle.IDDoador = x.IDA;
                            }
                        }
                        oControle.Statu = CboStatus.Text;
                        oControle.OBS = TxtObs.Text;
                        _Control_c.Incluir(oControle);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        CBOProp.Focus();
                    }
                }
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CONTROLE oControle;
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }

        }
        private void CBOPet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelaControle_Load_1(object sender, EventArgs e)
        {
            List<PET> Pets = _Control_c.Pets();
            foreach(var x in Pets)
            {
                CBOPet.Items.Add(x.NomePet);
            }
            List<AMIGO> Proprietario = _Control_c.Amigos();
            foreach (var x in Proprietario)
            {
                CBOProp.Items.Add(x.Nome);
            }

            List<AMIGO> Doador = _Control_c.Amigos();
            foreach (var x in Doador)
            {
                CBODoador.Items.Add(x.Nome);
            }

            int? petAdotados = _Control_c.BuscaQtdAnimal();
            TxtQtdAdotados.Text = petAdotados.ToString();

            int? petDisposicao  = _Control_c.BuscaQtdAnimalDisposicao();
            TxtQtdDisposicao.Text = petDisposicao.ToString();

        }

        private void CBOProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void CBOPet_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TelaControle_FormClosed_1(object sender, FormClosedEventArgs e)
        {

            ((TelaPrincipal)this.MdiParent).MnuControle.Enabled = true;
        }

        private void nu(object sender, EventArgs e)
        {

        }
    }
}

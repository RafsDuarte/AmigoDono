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
        public TelaTratamento()
        {
            InitializeComponent();
        }
        public TelaTratamento(TRATAMENTO tratamento)
        {
            InitializeComponent();
            _tratamento = tratamento;
            //_pet = pet;

            PopulaCampos();
        }
        private void PopulaCampos()
        {
            //DteDataTratamento = _tratamento.Data.Date;
            //TxtIdPet.Text = _tratamento.IDPet;
            //TxtNomePet = _Pet.SelecionarNome;
            //TxtIDPet.Text = _pet.IDP.ToString();
            //CboSituacao.Text = _pet.Situacao;
            //TxtNome.Text = _pet.NomePet;
            //// data cadastro
            //// data nascimento
            //CboIdade.Text = _pet.Idade;
            //CboTipoPet.Text = _pet.TipoPet;
            //TxtRaca.Text = _pet.Raca;
            //CboSexo.Text = _pet.Sexo;
            //CboPorte.Text = _pet.Porte;
            //CboCastrado.Text = _pet.Castrado;
            BtnExcluir.Enabled = true;
        }



        private void TelaTratamento_Load(object sender, EventArgs e)
            {

            }

            private void BtnSair_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void dateTimePickerTratamento_ValueChanged(object sender, EventArgs e)
            {

            }

            private void TxtDescricao_TextChanged(object sender, EventArgs e)
            {

            }

            private void TelaTratamento_FormClosed_1(object sender, FormClosedEventArgs e)
            {
                ((TelaPrincipal)this.MdiParent).MnuTratamento.Enabled = true;

            }
    }
}

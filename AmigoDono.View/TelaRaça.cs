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
    public partial class TelaRaça : Form
    {
        private Control.CRaça _Control = new CRaça();
        public string teste;
        RAÇA _raça = null;
        RAÇA raçaAlterar = new RAÇA();
        RAÇA oRaça = new RAÇA();
        public TelaRaça()
        {
            InitializeComponent();
        }
        public TelaRaça(RAÇA raça)
        {
            InitializeComponent();
            _raça = raça;
            PopulaCampos();
        }
        private void PopulaCampos()
        {
            TxtRaca.Text = _raça.NomeRaça;            
            //BtnExcluir.Enabled = true;
        }
        private void LimpaDados()
        {
            TxtRaca.Text = "";
        }
        public void LiberaCampos()
        {
            TxtRaca.Enabled = true;           
            BtnSalvar.Enabled = true;
        }
        private void DesabilitaCampos()
        {
            TxtRaca.Enabled = false;           
            BtnSalvar.Enabled = false;
        }
        private bool ValidaCampos()
        {
            if (TxtRaca.Text == string.Empty)
            {
                MessageBox.Show("O campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRaca.Select();
                return false;
            }
            return true;
        }
        private bool ValidaControles()
        {
            return true;
        }
        private void TelaRaça_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoRaça.RAÇA'. Você pode movê-la ou removê-la conforme necessário.
            this.rAÇATableAdapter.Fill(this.amigos_do_DonoRaça.RAÇA);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_raça != null)
                    {
                        //Alterar Amigo
                        //_raça.NomeRaça = TxtRaca.Text;                   
                        //MemoryStream ms = new MemoryStream();
                        //_Control.Alterar(_raça);
                        //Mensagens.MsgAlterado();
                        //this.Close();
                    }
                    else
                    {
                        //Incluir Raça 
                        oRaça.NomeRaça = TxtRaca.Text;
                        MemoryStream ms = new MemoryStream();
                        _Control.Incluir(oRaça);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        TxtRaca.Focus();
                    }
                }
            }
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DGVRaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void TelaRaça_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuTipoRaça.Enabled = true;
        }
    }
}

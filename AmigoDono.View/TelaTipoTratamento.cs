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
    public partial class TelaTipoTratamento : Form
    {
        private Control.CTipoTratamento _Control = new CTipoTratamento();
        TIPOTRATAMENTO _TipoTratamento = null;
        TIPOTRATAMENTO TipoTratamentoAlterar = new TIPOTRATAMENTO();
        TIPOTRATAMENTO oTipoTratamento = new TIPOTRATAMENTO();
        public TelaTipoTratamento() { InitializeComponent(); }
        private bool ValidaControles() { return true; }
        private void CarregaGrid() {
            //GrdTipoTratamento.DataSource = _Control.SelecionarTodos(TIPOTRATAMENTO);
        }
        public TelaTipoTratamento(TIPOTRATAMENTO tipotratamento)
        {
            InitializeComponent();
            _TipoTratamento = tipotratamento;
            PopulaCampos();
        }
        private void DesabilitaCampos()
        {
            TxtTextoDescricao.Enabled = false;
            BtnSalvar.Enabled = false;
        }
        public void LiberaCampos()
        {
            TxtTextoDescricao.Enabled = true;
            BtnSalvar.Enabled = true;
        }
        private void LimpaDados()
        {
            TxtTextoDescricao.Text = "";
        }
        private void PopulaCampos()
        {
            TxtTextoDescricao.Text = _TipoTratamento.Descricao;
        }
        private bool ValidaCampos()
        {
            if (TxtTextoDescricao.Text == string.Empty)
            {
                MessageBox.Show("o campo Descricao deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTextoDescricao.Select();
                return false;
            }
                    

            return true;
        }

        private void TipoTratamento_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    //Incluir Raça 
                    oTipoTratamento.Descricao = TxtTextoDescricao.Text;
                    MemoryStream ms = new MemoryStream();
                    _Control.Incluir(oTipoTratamento);
                    Mensagens.MsgIncluido();
                    LimpaDados();
                    TxtTextoDescricao.Focus();                   
                }
            }

        }

        private void NovoForm()
        {
            Application.Run(new TelaTipoTratamento());
        }
       
      
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
        }
        private void TxtIDD_TextChanged(object sender, EventArgs e)
        {
        }
        private void TelaTipoTratamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoDataSet8.TIPOTRATAMENTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOTRATAMENTOTableAdapter.Fill(this.amigos_do_DonoDataSet8.TIPOTRATAMENTO);
            GrdTipoTratamento.DataSource = _Control.SelecionarTodos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaTipoTratamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuTipoTratamento.Enabled = true;
        }
        private void DGVTipotratamento()
        {
        }

        private void DGVTipoTratamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
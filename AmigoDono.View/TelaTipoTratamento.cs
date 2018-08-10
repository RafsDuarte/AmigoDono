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
        public string teste;
        DENUNCIA _denuncia = null;
        DENUNCIA denunciaAlterar = new DENUNCIA();
        DENUNCIA oDenuncia = new DENUNCIA();
        public TelaTipoTratamento() { InitializeComponent(); }
        private bool ValidaControles() { return true; }
        public TelaTipoTratamento(DENUNCIA denuncia)
        {
            InitializeComponent();
            _denuncia = denuncia;
            PopulaCampos();
        }
        private void DesabilitaCampos()
        {
            //TxtIDTT.Enabled = false;
            TxtTestoDenuncia.Enabled = false;
            BtnSalvar.Enabled = false;
        }
        public void LiberaCampos()
        {
            TxtIDD.Enabled = true;
            //TxtDenunciante.Enabled = true;
            BtnSalvar.Enabled = true;
        }
        private void LimpaDados()
        {
            TxtIDD.Text = "";
            //TxtDenunciante.Text = "";
        }
        private void PopulaCampos()
        {
            TxtIDD.Text = _denuncia.IDD.ToString();
            //TxtDenunciante.Text = _denuncia.Denunciante;
            BtnExcluir.Enabled = true;
        }
        private bool ValidaCampos()
        {
            //if (TxtDenunciante.Text == string.Empty)
            //{
            //    MessageBox.Show("o campo Denunciante deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtDenunciante.Select();
            //    return false;
            //}
            //if (TxtNomeLogradouro.Text == string.Empty)
            //{
            //    MessageBox.Show("o campo logradouro deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtNomeLogradouro.Select();
            //    return false;
            //}
            //if (TxtEmail.Text == string.Empty)
            //{
            //    MessageBox.Show("o campo Email deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtEmail.Select();
            //    return false;
            //}
            //if (TxtTestoDenuncia.Text == string.Empty)
            //{
            //    MessageBox.Show("o campo Denuncia deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtTestoDenuncia.Select();
            //    return false;
            //}
            //if (TxtBairro.Text == string.Empty)
            //{
            //    MessageBox.Show("o campo Bairro deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtBairro.Select();
            //    return false;
            //}
            //if (TxtCidade.Text == string.Empty)
            //{
            //    MessageBox.Show("o campo Cidade deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtCidade.Select();
            //    return false;
            //}

            return true;
        }

        private void TelaDenuncia_Load(object sender, EventArgs e)
        {
            LblID.Visible = false;
            TxtIDD.Visible = false;
            //DteTimePickerDenuncia.MinDate = DateTime.Now;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void NovoForm()
        {
            Application.Run(new TelaPesquisaDenuncia());
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TelaCadastroAmigo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuAmigo.Enabled = true;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void TxtIDD_TextChanged(object sender, EventArgs e) { }

        private void TelaDenuncia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuDenuncia.Enabled = true;
        }

        private void TelaTipoTratamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigos_do_DonoDataSet8.TIPOTRATAMENTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOTRATAMENTOTableAdapter.Fill(this.amigos_do_DonoDataSet8.TIPOTRATAMENTO);

        }
    }
}

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
    public partial class TelaDenuncia : Form
    {
        private Control.CDenuncia _Control = new CDenuncia();
        public string teste;
        DENUNCIA _denuncia = null;
        DENUNCIA denunciaAlterar = new DENUNCIA();
        DENUNCIA oDenuncia = new DENUNCIA();
        public TelaDenuncia() { InitializeComponent(); }
        private bool ValidaControles(){ return true; }
        public TelaDenuncia(DENUNCIA denuncia)
        {
            InitializeComponent();
            _denuncia = denuncia;
            PopulaCampos();
        }
        private void DesabilitaCampos()
        {
            TxtIDD.Enabled = false;
            DteTimePickerDenuncia.Enabled = false;
            DteTimePickerResposta.Enabled = false;
            TxtDenunciante.Enabled = false;
            TxtEmail.Enabled = false;
            CboTipoLogradouro.Enabled = false;
            TxtNomeLogradouro.Enabled = false;
            TxtNumero.Enabled = false;
            TxtComplemento.Enabled = false;
            TxtBairro.Enabled = false;
            TxtCidade.Enabled = false;
            TxtUF.Enabled = false;
            TxtCep.Enabled = false;
            TxtTestoDenuncia.Enabled = false;
            BtnSalvar.Enabled = false;
        }
        public void LiberaCampos()
        {
            TxtIDD.Enabled = true;
            DteTimePickerDenuncia.Enabled = true;
            DteTimePickerResposta.Enabled = true;
            TxtDenunciante.Enabled = true;
            TxtEmail.Enabled = true;
            CboTipoLogradouro.Enabled = true;
            TxtNomeLogradouro.Enabled = true;
            TxtNumero.Enabled = true;
            TxtComplemento.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCidade.Enabled = true;
            TxtUF.Enabled = true;
            TxtCep.Enabled = true;
            TxtTestoDenuncia.Enabled = true;
            BtnSalvar.Enabled = true;
        }
        private void LimpaDados()
        {
            TxtIDD.Text = "";
            TxtDenunciante.Text = "";
            TxtEmail.Text = "";
            CboTipoLogradouro.Text = "";
            TxtNomeLogradouro.Text = "";
            TxtNumero.Text = "";
            TxtComplemento.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtUF.Text = "";
            TxtCep.Text = "";
            TxtTestoDenuncia.Text = "";
        }
        private void PopulaCampos()
        {
            TxtIDD.Text = _denuncia.IDD.ToString();
            TxtDenunciante.Text = _denuncia.Denunciante;
            TxtTestoDenuncia.Text = _denuncia.TextoDenuncia;
            TxtEmail.Text = _denuncia.Email;
            TxtCep.Text = _denuncia.CEP;
            CboTipoLogradouro.Text = _denuncia.TipoLogradouro;
            TxtNomeLogradouro.Text = _denuncia.NomeLogradouro;
            TxtNumero.Text = _denuncia.Numero;
            TxtComplemento.Text = _denuncia.Complemento;
            TxtBairro.Text = _denuncia.Bairro;
            TxtCidade.Text = _denuncia.Cidade;
            TxtUF.Text = _denuncia.UF;
            BtnExcluir.Enabled = true;
        }
        private bool ValidaCampos()
        {          
            if (TxtDenunciante.Text == string.Empty)
            {
                MessageBox.Show("o campo Denunciante deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDenunciante.Select();
                return false;
            }
            if (TxtNomeLogradouro.Text == string.Empty)
            {
                MessageBox.Show("o campo logradouro deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNomeLogradouro.Select();
                return false;
            }
            if (TxtEmail.Text == string.Empty)
            {
                MessageBox.Show("o campo Email deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Select();
                return false;
            }
            if (TxtTestoDenuncia.Text == string.Empty)
            {
                MessageBox.Show("o campo Denuncia deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTestoDenuncia.Select();
                return false;
            }
            if (TxtBairro.Text == string.Empty)
            {
                MessageBox.Show("o campo Bairro deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBairro.Select();
                return false;
            }
            if (TxtCidade.Text == string.Empty)
            {
                MessageBox.Show("o campo Cidade deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCidade.Select();
                return false;
            }

            return true;
        }

        private void TelaDenuncia_Load(object sender, EventArgs e)
        {
            LblID.Visible = false;
            TxtIDD.Visible = false;
            DteTimePickerDenuncia.MinDate = DateTime.Now;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_denuncia != null)
                    {
                        //Alterar Amigo
                        _denuncia.DataDenuncia = DteTimePickerDenuncia.MinDate;
                        _denuncia.DataResposta = DteTimePickerResposta.MinDate;
                        _denuncia.Denunciante = TxtDenunciante.Text;
                        _denuncia.TextoDenuncia = TxtTestoDenuncia.Text;
                        _denuncia.Email = TxtEmail.Text;
                        _denuncia.TipoLogradouro = CboTipoLogradouro.Text;
                        _denuncia.NomeLogradouro = TxtNomeLogradouro.Text;
                        _denuncia.Numero = TxtNumero.Text;
                        _denuncia.Complemento = TxtComplemento.Text;
                        _denuncia.Bairro = TxtBairro.Text;
                        _denuncia.Cidade = TxtCidade.Text;
                        _denuncia.UF = TxtUF.Text;
                        _denuncia.CEP = TxtCep.Text;
                                               
                        _Control.Alterar(_denuncia);
                        Mensagens.MsgAlterado();
                        this.Close();                        
                    }
                    else
                    {
                        //Incluir Amigo 
                        oDenuncia.DataDenuncia = DteTimePickerDenuncia.MinDate;
                        oDenuncia.DataResposta = DteTimePickerResposta.MinDate;
                        oDenuncia.Denunciante = TxtDenunciante.Text;
                        oDenuncia.TextoDenuncia = TxtTestoDenuncia.Text;
                        oDenuncia.Email = TxtEmail.Text;
                        oDenuncia.TipoLogradouro = CboTipoLogradouro.Text;
                        oDenuncia.NomeLogradouro = TxtNomeLogradouro.Text;
                        oDenuncia.Numero = TxtNumero.Text;
                        oDenuncia.Complemento = TxtComplemento.Text;
                        oDenuncia.Bairro = TxtBairro.Text;
                        oDenuncia.Cidade = TxtCidade.Text;
                        oDenuncia.UF = TxtUF.Text;
                        oDenuncia.CEP = TxtCep.Text;


                        _Control.Incluir(oDenuncia);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        DteTimePickerDenuncia.Focus();
                    }

                }

            }
            
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
            DENUNCIA oDenuncia;
            oDenuncia = _Control.SelecionarID(Convert.ToInt32(TxtIDD.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oDenuncia);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }
        private void TxtIDD_TextChanged(object sender, EventArgs e){ }

        private void TelaDenuncia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuDenuncia.Enabled = true;
        }
    }
}
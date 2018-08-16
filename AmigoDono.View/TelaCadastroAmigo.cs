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
using System.Web;

namespace AmigoDono.View
{
    public partial class TelaCadastroAmigo : Form
    {
        private Control.CAmigo _Control = new CAmigo();
        //Bitmap bmp;
        //Thread nt;
        public string teste;
        AMIGO _amigo=null;
        AMIGO amigoAlterar = new AMIGO();
        AMIGO oAmigo = new AMIGO();
        public TelaCadastroAmigo()
        {
            InitializeComponent();
        }

        public TelaCadastroAmigo(AMIGO amigo)
        {
            InitializeComponent();
            _amigo = amigo;
            PopulaCampos();           
        }
        private void DesabilitaCampos()
        {
            TxtNomeLogradouro.Enabled = false;
            TxtBairro.Enabled = false;
            DteTimePickerCadastro.Enabled = false;
            DteTimePickerNasc.Enabled = false;
            MskCelular.Enabled = false;
            MskCEP.Enabled = false;
            MskCPF.Enabled = false;
            MskTelefone.Enabled = false;
            TxtEmail.Enabled = false;
            TxtCidade.Enabled = false;
            MskCNPJ.Enabled = false;
            TxtComplemento.Enabled = false;
            CboFuncao.Enabled = false;
            CboTipoLogradouro.Enabled = false;
            TxtNome.Enabled = false;
            TxtNumero.Enabled = false;
            TxtUF.Enabled = false;
            TxtSenha.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnEscolherFoto.Enabled = false;
        }
        private bool ValidaCampos()
        {
            if (CboFuncao.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboFuncao.Select();
                return false;
            }
            if (TxtSenha.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenha.Select();
                return false;
            }
            if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Select();
                return false;
            }
            if (TxtEmail.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Ownero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Select();
                return false;
            }
            //if (MskCelular.MaskCompleted)
            //{
            //    MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    MskCelular.Select();
            //    return false;
            //}
            return true;
        }
        public void LiberaCampos()
        {
            BtnEscolherFoto.Enabled = true;
            DteTimePickerCadastro.Enabled = true;
            CboFuncao.Enabled = true;
            MskCPF.Enabled = true;
            MskCNPJ.Enabled = true;
            TxtSenha.Enabled = true;
            DteTimePickerNasc.Enabled = true;
            TxtNome.Enabled = true;
            TxtEmail.Enabled = true;
            MskCEP.Enabled = true;
            CboTipoLogradouro.Enabled = true;
            TxtNomeLogradouro.Enabled = true;
            TxtNumero.Enabled = true;
            TxtComplemento.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCidade.Enabled = true;
            TxtUF.Enabled = true;
            MskTelefone.Enabled = true;
            MskCelular.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void BtnEscolherFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string nome = ofd.FileName;
                    PbFoto.Load(nome);
                }
            }
        }

        private void CboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboFuncao.Text == "Cuidador")
            {
                LblAjuda.Visible = true;
                TxtAjuda.Visible = true;
            }
            else
            {
                LblAjuda.Visible = false;
                TxtAjuda.Visible = false;
            }
            if (CboFuncao.Text == "Clínica" || CboFuncao.Text == "Empresa Patrocinadora")
            {
                LblCNPJ.Visible = true;
                MskCNPJ.Visible = true;
                LblCPF.Visible = false;
                MskCPF.Visible = false;
            }
            else
            {
                LblCPF.Visible = true;
                MskCPF.Visible = true;
                LblCNPJ.Visible = false;
                MskCNPJ.Visible = false;
            }
        }
        private void LimpaDados()
        {
            TxtNome.Text = "";
            CboFuncao.Text = "";
            TxtSenha.Text = "";
            MskCPF.Text = "";
            MskCNPJ.Text = "";
            TxtEmail.Text = "";
            MskCEP.Text = "";
            CboTipoLogradouro.Text = "";
            TxtNomeLogradouro.Text = "";
            TxtNumero.Text = "";
            TxtComplemento.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtUF.Text = "";
            MskTelefone.Text = "";
            MskCelular.Text = "";
            TxtAjuda.Text = "";
            //PbFoto.Load(".\\imagem\\Caricatura.jpg");
            PbFoto.Load("C:\\Amigo_do_Dono\\AmigoDono-master\\AmigoDono.Model\\imagem\\Caricatura.jpg");
        }
        private bool ValidaControles()
        {
            return true;
        }
        private void PopulaCampos()
        {
            TxtIDAmigo.Text = _amigo.IDA.ToString();
            TxtNome.Text = _amigo.Nome;
            CboFuncao.Text = _amigo.Funcao;
            TxtSenha.Text = _amigo.Senha;
            MskCPF.Text = _amigo.CPF;
            MskCNPJ.Text = _amigo.CNPJ;
            TxtEmail.Text = _amigo.Email;
            MskCEP.Text = _amigo.CEP;
            CboTipoLogradouro.Text = _amigo.Logradouro;
            TxtNomeLogradouro.Text = _amigo.NomeLogradouro;
            TxtNumero.Text = _amigo.Numero;
            TxtComplemento.Text = _amigo.Complemento;
            TxtBairro.Text = _amigo.Bairro;
            TxtCidade.Text = _amigo.Cidade;
            TxtUF.Text = _amigo.UF;
            MskTelefone.Text = _amigo.Telefone;
            MskCelular.Text = _amigo.Celular;
            BtnExcluir.Enabled = true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_amigo != null)
                    {
                        //Alterar Amigo
                        _amigo.Nome = TxtNome.Text;
                        _amigo.DataCadastro = DteTimePickerCadastro.MinDate;
                        _amigo.Funcao = CboFuncao.Text;
                        _amigo.Senha = TxtSenha.Text;
                        _amigo.DataNascimento = DteTimePickerNasc.MinDate;
                        _amigo.CPF = MskCPF.Text;
                        _amigo.CNPJ = MskCNPJ.Text;
                        _amigo.Email = TxtEmail.Text;
                        _amigo.CEP = MskCEP.Text;
                        _amigo.Logradouro = CboTipoLogradouro.Text;
                        _amigo.NomeLogradouro = TxtNomeLogradouro.Text;
                        _amigo.Numero = TxtNumero.Text;
                        _amigo.Complemento = TxtComplemento.Text;
                        _amigo.Bairro = TxtBairro.Text;
                        _amigo.Cidade = TxtCidade.Text;
                        _amigo.UF = TxtUF.Text;
                        _amigo.Telefone = MskTelefone.Text;
                        _amigo.Celular = MskCelular.Text;
                        _amigo.Ajuda = TxtAjuda.Text;

                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);
                        byte[] imagem = ms.ToArray();
                        _amigo.Imagem = imagem;
                        _Control.Alterar(_amigo);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {
                        //Incluir Amigo 

                        oAmigo.Nome = TxtNome.Text;
                        oAmigo.DataCadastro = DteTimePickerCadastro.MinDate;
                        oAmigo.Funcao = CboFuncao.Text;
                        oAmigo.Senha = TxtSenha.Text;
                        oAmigo.DataNascimento = DteTimePickerNasc.MinDate;
                        oAmigo.CPF = MskCPF.Text;
                        oAmigo.CNPJ = MskCNPJ.Text;
                        oAmigo.Email = TxtEmail.Text;
                        oAmigo.CEP = MskCEP.Text;
                        oAmigo.Logradouro = CboTipoLogradouro.Text;
                        oAmigo.NomeLogradouro = TxtNomeLogradouro.Text;
                        oAmigo.Numero = TxtNumero.Text;
                        oAmigo.Complemento = TxtComplemento.Text;
                        oAmigo.Bairro = TxtBairro.Text;
                        oAmigo.Cidade = TxtCidade.Text;
                        oAmigo.UF = TxtUF.Text;
                        oAmigo.Telefone = MskTelefone.Text;
                        oAmigo.Celular = MskCelular.Text;
                        oAmigo.Ajuda = TxtAjuda.Text;

                            MemoryStream ms = new MemoryStream();
                            Bitmap BP = new Bitmap(PbFoto.Image);
                            BP.Save(ms, ImageFormat.Bmp);

                            byte[] imagem = ms.ToArray();
                            oAmigo.Imagem = imagem;
 
                        _Control.Incluir(oAmigo);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        DteTimePickerCadastro.Focus();
                    }
                }
            }
            
        }
        private void TelaCadastroAmigo_Load(object sender, EventArgs e)
        {
            LblIDAmigo.Visible = false;
            TxtIDAmigo.Visible = false;
            DteTimePickerCadastro.MinDate = DateTime.Now;   
            
            if(_amigo!=null)
            {
                MemoryStream ms =new MemoryStream(_amigo.Imagem);
                Image Imagem = Image.FromStream(ms);
                PbFoto.Image = Imagem;
            }
        }
        private void NovoForm()
        {
            Application.Run(new TelaPesquisarAmigo());
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
            AMIGO oAmigo;
            oAmigo = _Control.SelecionarID(Convert.ToInt32(TxtIDAmigo.Text)); 
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oAmigo);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }
    }
}


﻿using System;
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
    
    public partial class TelaCadastroPet : Form
    {
        private Control.CPet _Control = new CPet();
        public string teste;
        PET _pet = null;
        PET petalterar = new PET();
        PET oPet = new PET();
        public TelaCadastroPet()
        {
            InitializeComponent();
        }
        public TelaCadastroPet(PET pet)
        {
            InitializeComponent();
            _pet = pet;
            PopulaCampos();
        }
        private void DesabilitaCampos()
        {
            
            TxtIDPet.Enabled = false;
            CboSituacao.Enabled = false;
            TxtNome.Enabled = false;
            DteTimePickerNasc.Enabled = false;
            DteTimePickerCadastro.Enabled = false;
            CboIdade.Enabled = false;
            CboTipoPet.Enabled = false;
            TxtRaca.Enabled = false;
            CboSexo.Enabled = false;
            CboPorte.Enabled = false;
            CboCastrado.Enabled = false;
            TxtOBS.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnEscolherFoto.Enabled = false;
        }
        private bool ValidaCampos()
        {
            if (CboSituacao.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboSituacao.Select();
                return false;
            }            
            if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Select();
                return false;
            }
            if (CboIdade.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboIdade.Select();
                return false;
            }
            if (CboTipoPet.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboTipoPet.Select();
                return false;
            }
            if (TxtRaca.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRaca.Select();
                return false;
            }
            if (CboSexo.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboSexo.Select();
                return false;
            }
            if (CboPorte.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboPorte.Select();
                return false;
            }
            if (CboCastrado.Text == string.Empty)
            {
                MessageBox.Show("o campo deve ser preenchido", "Sistema Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboCastrado.Select();
                return false;
            }
            return true;
        }
        public void LiberaCampos()
        {
            BtnEscolherFoto.Enabled = true;
            TxtIDPet.Enabled = true;
            CboSituacao.Enabled = true;
            TxtNome.Enabled = true;
            DteTimePickerNasc.Enabled = true;
            DteTimePickerCadastro.Enabled = true;
            CboIdade.Enabled = true;
            CboTipoPet.Enabled = true;
            TxtRaca.Enabled = true;
            CboSexo.Enabled = true;
            CboPorte.Enabled = true;
            CboCastrado.Enabled = true;
            TxtOBS.Enabled = true;
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
        private void LimpaDados()
        {
            TxtIDPet.Text = "";
            CboSituacao.Text = "";
            TxtNome.Text = "";
            DteTimePickerNasc.Text = "";
            DteTimePickerCadastro.Text = "";
            CboIdade.Text = "";
            CboTipoPet.Text = "";
            TxtRaca.Text = "";
            CboSexo.Text = "";
            CboPorte.Text = "";
            CboCastrado.Text = "";
            TxtOBS.Text = "";
            PbFoto.Load("C:\\Amigo_do_Dono\\Atual2\\Atual1\\Atual1\\Atual\\AmigoDono\\AmigoDono.Model\\imagem\\pata.jpg");
        }
        private bool ValidaControles()
        {
            return true;
        }
        private void PopulaCampos()
        {
            TxtIDPet.Text = _pet.IDP.ToString();            
            CboSituacao.Text = _pet.Situacao;
            TxtNome.Text = _pet.NomePet;
            // data cadastro
            // data nascimento
            CboIdade.Text = _pet.Idade;
            CboTipoPet.Text = _pet.TipoPet;
            //TxtRaca.Text = _pet.Raca;
            CboSexo.Text = _pet.Sexo;
            CboPorte.Text = _pet.Porte;
            CboCastrado.Text = _pet.Castrado;
            BtnExcluir.Enabled = true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_pet != null)
                    {
                        // alterar pet
                        _pet.Cadastro = DteTimePickerCadastro.MinDate;
                        _pet.Situacao = CboSituacao.Text;
                        _pet.NomePet = TxtNome.Text;
                        _pet.DataNascimento = DteTimePickerNasc.MinDate;
                        _pet.Idade = CboIdade.Text;
                        _pet.TipoPet = CboTipoPet.Text;
                        //_pet.Raca = TxtRaca.Text;
                        _pet.Sexo = CboSexo.Text;
                        _pet.Porte = CboPorte.Text;
                        _pet.Castrado = CboCastrado.Text;
                        _pet.OBS = TxtOBS.Text;

                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);
                        byte[] imagem = ms.ToArray();
                        _pet.Imagem = imagem;
                        _Control.Alterar(_pet);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {
                        // Incluir pet
                        oPet.Situacao = CboSituacao.Text;
                        oPet.NomePet = TxtNome.Text;
                        oPet.DataNascimento = DteTimePickerNasc.MinDate;
                        oPet.Cadastro = DteTimePickerCadastro.MinDate;
                        oPet.Idade = CboIdade.Text;
                        oPet.TipoPet = CboTipoPet.Text;
                        //oPet.Raca = TxtRaca.Text;
                        oPet.Sexo = CboSexo.Text;
                        oPet.Porte = CboPorte.Text;
                        oPet.Castrado = CboCastrado.Text;
                        oPet.OBS = TxtOBS.Text;

                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);

                        byte[] imagem = ms.ToArray();
                        oPet.Imagem = imagem;

                        _Control.Incluir(oPet);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        DteTimePickerCadastro.Focus();
                    }
                }
            }           
        }
        private void TelaCadastroPet_Load(object sender, EventArgs e)
        {
            LblIDPet.Visible = false;
            TxtIDPet.Visible = false;
            DteTimePickerCadastro.MinDate = DateTime.Now;
            if (_pet != null)
            {
                MemoryStream ms = new MemoryStream(_pet.Imagem);
                Image Imagem = Image.FromStream(ms);
                PbFoto.Image = Imagem;
            }
        }
        private void NovoForm()
        {
            Application.Run(new TelaPesquisarPet());
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TelaCadastroPet_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuPet.Enabled = true;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            PET oPet;
            oPet = _Control.SelecionarID(Convert.ToInt32(TxtIDPet.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oPet);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }
        private void TxtIDPet_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

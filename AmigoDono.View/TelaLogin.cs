using AmigoDono.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoDono.View
{
    public partial class TelaLogin : Form
    {
        Thread nt;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void NovoForm()
        {
            Application.Run(new TelaPrincipal());

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
      
            if ((TxtLogin.Text == "Cassiano" && TxtSenha.Text == "1234") || (TxtLogin.Text == "Rafael" && TxtSenha.Text == "1234") || (TxtLogin.Text == "Thales" && TxtSenha.Text == "1234"))
            {
                this.Close();
                nt = new Thread(NovoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                Mensagens.MsgLoginInvalidos();
                TxtLogin.Text = "";
                TxtSenha.Text = "";
                TxtLogin.Focus();
            }
        }
    }
}

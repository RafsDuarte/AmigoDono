using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoDono.View
{
    public partial class TelaControle : Form
    {
        public TelaControle()
        {
            InitializeComponent();
        }

        private void TelaControle_Load(object sender, EventArgs e)
        {
         

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Telacontrole_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TelaPrincipal)this.MdiParent).MnuControle.Enabled = true;
        }

 //       private void cONTROLEBindingSource_CurrentChanged(object sender, EventArgs e)
 //       {

 //       }
    }
}

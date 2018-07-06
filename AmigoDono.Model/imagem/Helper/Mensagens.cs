using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoDono.Model
{
    public partial class Mensagens
    {
        public static void MsgExcluido()
        {
            MessageBox.Show(Constantes.MsgExcluido, "Friend of the Onwer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgAlterado()
        {
            MessageBox.Show(Constantes.MsgAlteracao, "Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgIncluido()
        {
            MessageBox.Show(Constantes.MsgInclusao, "Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgLoginInvalidos()
        {
            MessageBox.Show("Login ou Senha invalidos ! Por favor, tente novamente.", "Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult MsgPerguntaExclusao()
        {
            return MessageBox.Show(Constantes.MsgExclusao, "Friend of the Owner", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MsgRegInexistente()
        {
            MessageBox.Show("Registro Inexistente!", "Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgAmigoNomeDigitado()
        {
            MessageBox.Show(Constantes.MsgNomeDigitado, "Friend of the Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
} 


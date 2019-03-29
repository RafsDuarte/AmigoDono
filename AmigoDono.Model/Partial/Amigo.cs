using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AmigoDono.Model
{
    [MetadataType(typeof(MD_AMIGO))]
    public partial class AMIGO
    {
        internal class MD_AMIGO
        {

            [DisplayName("ID")]
            public object IDA { get; set; }
            [DisplayName("Data Cadastro")]
            public DateTime DataCadastro { get; set; }
            [DisplayName("Função")]
            public object Funcao { get; set; }
            [DisplayName("Senha")]
            public object Senha { get; set; }
            [DisplayName("Ajuda")]
            public object Ajuda { get; set; }
            [DisplayName("Data Nascimento")]
            public DateTime DataNascimento { get; set; }
            [DisplayName("CPF")]
            public object CPF { get; set; }
            [DisplayName("CNPJ")]
            public object CNPJ { get; set; }
            [DisplayName("Nome")]
            public object Nome { get; set; }
            [DisplayName("Email")]
            public object Email { get; set; }
            [DisplayName("CEP")]
            public object CEP { get; set; }
            [DisplayName("Logradouro")]
            public object Logradouro { get; set; }
            [DisplayName("Nome do Logradouro ")]
            public object NomeLogradouro { get; set; }
            [DisplayName("Numero")]
            public object Numero { get; set; }
            [DisplayName("Complemento")]
            public object Complemento { get; set; }
            [DisplayName("Bairro")]
            public object Bairro { get; set; }
            [DisplayName("Cidade")]
            public object Cidade { get; set; }
            [DisplayName("UF")]
            public object UF { get; set; }
            [DisplayName("Telefone")]
            public object Telefone { get; set; }
            [DisplayName("Celular")]
            public object Celular { get; set; }
            [DisplayName("Imagem")]
            public object Imagem { get; set; }
        }
    }
}

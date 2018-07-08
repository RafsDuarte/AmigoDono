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
            [Required(ErrorMessage = "Inserira uma função válida.")]
            public object Funcao { get; set; }

            [DisplayName("Senha")]
            [Required(ErrorMessage = "É obrigatório inserir uma senha.")]
            public object Senha { get; set; }

            [DisplayName("Ajuda")]
            public object Ajuda { get; set; }

            [DisplayName("Data de Nascimento")]
            [Required(ErrorMessage = "É obrigatório inserir uma data de nascimento válida.")]
            public DateTime DataNascimento { get; set; }

            [DisplayName("CPF")]         
            [Required(ErrorMessage = "É obrigatório inserir um CPF válido.")]
            public object CPF { get; set; }
            
            [DisplayName("CNPJ")]
            [Required(ErrorMessage = "É obrigatório inserir um CNPJ válido.")]
            public object CNPJ { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage = "É obrigatório inserir um nome válido.")]         
            public object Nome { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage = "Por favor, insira um endereço de email válido.")]
            public object Email { get; set; }

            [DisplayName("CEP")]
            [Required(ErrorMessage = "É obrigatório inserir um CEP válido.")]
            public object CEP { get; set; }

            [DisplayName("Logradouro")]
            [Required(ErrorMessage = "É obrigatório inserir um logradouro.")]
            public object Logradouro { get; set; }

            [DisplayName("Nome do Logradouro ")]
            [Required(ErrorMessage = "É obrigatório inserir um nome de logradouro.")]
            public object NomeLogradouro { get; set; }

            [DisplayName("Número")]
            public object Numero { get; set; }

            [DisplayName("Complemento")]
            public object Complemento { get; set; }

            [DisplayName("Bairro")]
            public object Bairro { get; set; }

            [DisplayName("Cidade")]
            [Required(ErrorMessage = "Por favor, escolha uma cidade.")]
            public object Cidade { get; set; }

            [DisplayName("Telefone")]
            [Required(ErrorMessage = "Insira um telefone de contato.")]
            public object Telefone { get; set; }

            [DisplayName("Celular")]
            public object Celular { get; set; }
            [DisplayName("Imagem")]
            public object Imagem { get; set; }
        }
    }
}

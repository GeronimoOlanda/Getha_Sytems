using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geta_Systems.API.Entities
{
    internal class DadosPessoais
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DocumentoIdentidade { get; set; }
        public string OrgaoEmissor { get; set; }


        public int Idade { get; set; }
        public int NumeroCPF { get; set; }

        public string Data_de_nascimento { get; set; }
        public string Sexo { get; set; }
        //public string  Sexo: Feminino() Masculino();
        public string ENDEREÇO_PESSOAL { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone_Celular { get; set; }
        public string Telefone_Residencial { get; set; }
        public string Telefone { get; set; }

    }
}

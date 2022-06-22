using Geta_Systems.API.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geta_Systems.API.Entities
{
    public class DadosDeCadastro
    {
        
        public int Id { get; set; }

        public int CodigoTU { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public TipoUsuarios TipoUsuario { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Senha { get; set; }

        [Required]
        [Compare("Senha")]
        public string ConfirmarSenha { get; set; }

        public DateTime DataDeCriacao { get; set; }
        

    }
}

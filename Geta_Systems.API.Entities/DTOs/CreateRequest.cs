using Getha.API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geta_Systems.API.Entities.DTOs
{
    public class CreateRequest
    {
        //required fala que é obrigatoro
        [Required]
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        // [EnumDataType(typeof(Role))] validates that the role property matches one of the api roles (Admin or User)
        [Required]
        [EnumDataType(typeof(Role))]
        public string Role { get; set; }

        // [EmailAddress] validates that the email property contains a valid email address
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // [MinLength(6)] validates that the password contains at least six characters
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        //[Compare("Password")] validates that the confirm password property matches the password property
        [Required]
        [Compare("Password")]
        public string confirmPassword { get; set; }

    }
}

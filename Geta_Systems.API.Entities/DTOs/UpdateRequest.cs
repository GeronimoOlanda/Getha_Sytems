using Getha.API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geta_Systems.API.Entities.DTOs
{
    public class UpdateRequest
    {

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // [EnumDataType(typeof(Role))] validates that the role property matches one of the api roles (Admin or User)
        [EnumDataType(typeof(Role))]
        public string Role { get; set; }

        // [EmailAddress] validates that the email property contains a valid email address
        [EmailAddress]
        public string Email { get; set; }

        private string _password;
        // [MinLength(6)] validates that the password contains at least six characters
        [MinLength(6)]
        public string Password
        {
            get => _password;
            set => _password = replaceEmptyWithNull(value);
        }

        private string _confirmPassword;
        //[Compare("Password")] validates that the confirm password property matches the password property
        [Compare("Password")]
        public string confirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = replaceEmptyWithNull(value);
        }

        private string replaceEmptyWithNull(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}

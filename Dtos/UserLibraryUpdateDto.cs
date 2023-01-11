using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Dtos
{
    public class UserLibraryUpdateDto
    {

        public int IdUser { get; set; }

        public string? Email { get; set; }


        public string? Username { get; set; }

        public string? PasswordHash { get; set; }

        public DateTime? Dateuserexpire { get; set; }

        public bool? Connectstate { get; set; }

        public string? Role { get; set; }

        public string? TokenUser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Dtos
{
    public class RegisterLibraryCreateDto
    {

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? ConfPassword { get; set; }

        public string? Role { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public bool? Connectstate { get; set; }

        public string? SubDomaine { get; set; }

        public string? DesignationComp { get; set; } // This is just for the compoany creation at the begining

        public string? SuperAdminPW { get; set; } // To Get the Super Admin Password
    }
}

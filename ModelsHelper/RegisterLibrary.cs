using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectivityLibrary.ModelsHelper
{
    public class RegisterLibrary
    {
        [Required (ErrorMessage = "Username is required")]
        [MinLength(8)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")] 
        public string? Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required")]
        public string? ConfPassword { get; set; }


        //For Client and Braider
        [MaxLength(30)]
        public string? Role { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }

        public bool? Connectstate { get; set; }

        public string? SubDomaine { get; set; }

        public string? DesignationComp { get; set; } // This is just for the compoany creation at the begining

        public string? SuperAdminPW { get; set; } // To Get the Super Admin Password
    }
}

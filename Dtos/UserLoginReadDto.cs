using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Dtos
{
    public class UserLoginReadDto
    {
        public string? Username { get; set; }

        
        public string? Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectivityLibrary.ModelsHelper
{
    public class UserAuthentResponse
    {
        public int IdUser { get; set; }

        public string? Role { get; set; }
        public int IdClientBraider { get; set; }

        public string? FirstNClientBraider { get; set; }
        public string? MiddleNClientBraider { get; set; }

        public string? LastNClientBraider { get; set; }

        public string? AccessTocken { get; set; }

        public int IdCompany { get; set; }
    }
}

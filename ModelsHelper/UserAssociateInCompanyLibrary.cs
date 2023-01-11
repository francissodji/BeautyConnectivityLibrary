using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.ModelsHelper
{
    public class UserAssociateInCompanyLibrary
    {
        public int IdUser { get; set; }

        public string? Username { get; set; }

        public int IdAssociate { get; set; }

        public string? EmailAssociate { get; set; }

        public string? FnameAssociate { get; set; }

        public string? MnameAssociate { get; set; }

        public string? LnameAssociate { get; set; }

        public int IdComp { get; set; }

        public string? SubDomaine { get; set; }
    }
}

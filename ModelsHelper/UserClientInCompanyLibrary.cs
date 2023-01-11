using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.ModelsHelper
{
    public class UserClientInCompanyLibrary
    {
        public int IdUser { get; set; }

        public string? Username { get; set; }

        public int IdClient { get; set; }

        public string? EmailClient { get; set; }

        public string? FnameClient{ get; set; }

        public string? MnameClient { get; set; }

        public string? LnameClient { get; set; }

        public int IdComp { get; set; }

        public string? SubDomaine { get; set; }
    }
}

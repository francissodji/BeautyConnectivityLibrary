using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class CompanyClientLibrary
    {
        [Key]
        public int IdCompanyClient { get; set; }

        public int IdCompany { get; set; }


        public int IdClient { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }


        //public ClientLibrary Client { get; set; }

        //public CompanyLibrary Company { get; set; }
    }
}

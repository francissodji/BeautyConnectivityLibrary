using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class CompanyAssociateLibrary
    {
        [Key]
        public int IdCompanyBraider { get; set; }

        public int IdCompany { get; set; }


        public int IdAssociate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }


        //public AssociateLibrary Associate { get; set; }

        //public CompanyLibrary Company { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Dtos
{
    public class AssociateLibraryUpdateDto
    {
        public int IdAssociate { get; set; }
        public string? FnameAssociate { get; set; }

        public string? MnameAssociate { get; set; }

        public string? LnameAssociate { get; set; }

        public DateTime? DOBAssociate { get; set; }

        public string? PhoneAssociate { get; set; }

        public string? CelAssociate { get; set; }

        public string? EmailAssociate { get; set; }

        public bool? OwnerStatus { get; set; }
        public bool? IsAssociateUseRegister { get; set; }

        public bool? IdRegisterAssociate { get; set; }

        public string? StreetAssociate { get; set; }

        public string? CountyAssociate { get; set; }

        public string? ZipCodeAssociate { get; set; }

        public string? StateAssociate { get; set; }

        public bool? DisplayAccontHeaderA { get; set; }

        public int IdUser { get; set; }

        public int IdCompany { get; set; }
    }
}

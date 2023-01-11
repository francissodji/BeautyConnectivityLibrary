using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Dtos
{
    public class CompanyLibraryCreateDto
    {
        public string? AcronymComp { get; set; }

        public string? DesignationComp { get; set; }

        public string? PhoneOffice { get; set; }

        public string? PhoneOwner { get; set; }

        public int? IdOwnerBraider { get; set; }
        public float? PartPayeBraid { get; set; }

        public decimal? CostHairDeduct { get; set; }

        public decimal? CostTakeDown { get; set; }
        public int? IdMainRegister { get; set; }
        public float? StateTaxOnSale { get; set; }
        public float? StateTaxOnBraiding { get; set; }

        public string? StreetComp { get; set; }

        public string? CountyComp { get; set; }

        public string? ZipcodeComp { get; set; }

        public string? StateComp { get; set; }

        public string? EmailComp { get; set; }

        public string? WebsiteComp { get; set; }

        public string? SubDomaine { get; set; }

        public DateTime? CreationDate { get; set; }

        public bool? DateWorkMond { get; set; }
        public bool? DateWorkTues { get; set; }
        public bool? DateWorkWed { get; set; }
        public bool? DateWorkThur { get; set; }
        public bool? DateWorkFrid { get; set; }
        public bool? DateWorkSatu { get; set; }
        public bool? DateWorkSund { get; set; }

        public string? TimeWorkBegin { get; set; }

        public string? TimeWorkEnd { get; set; }

        public bool? AcceptPartialPay { get; set; }

        public float? PercentPayPartialPay { get; set; }

        public decimal? AmountPayPartialPay { get; set; }

        public int? MaxBraider { get; set; }

        public string? GalleryImageRepos { get; set; }
    }
}

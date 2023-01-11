using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class CompanyLibrary
    {
        [Key]
        public int IdComp { get; set; }

        [MaxLength(20)]
        public string? AcronymComp { get; set; }

        [MaxLength(200)]
        public string? DesignationComp { get; set; }

        [MaxLength(14)]
        public string? PhoneOffice { get; set; }

        [MaxLength(14)]
        public string? PhoneOwner { get; set; }

        public int? IdOwnerBraider { get; set; }
        public float? PartPayeBraid { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostHairDeduct { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostTakeDown { get; set; }
        public int? IdMainRegister { get; set; }
        public float? StateTaxOnSale { get; set; }
        public float? StateTaxOnBraiding { get; set; }

        [MaxLength(100)]
        public string? StreetComp { get; set; }

        [MaxLength(75)]
        public string? CountyComp { get; set; }

        [MaxLength(11)]
        public string? ZipcodeComp { get; set; }

        [MaxLength(2)]
        public string? StateComp { get; set; }

        [MaxLength(100)]
        public string? EmailComp { get; set; }

        [MaxLength(150)]
        public string? WebsiteComp { get; set; }

        [MaxLength(50)]
        public string? SubDomaine { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreationDate { get; set; }

        public bool? DateWorkMond { get; set; }
        public bool? DateWorkTues { get; set; }
        public bool? DateWorkWed { get; set; }
        public bool? DateWorkThur { get; set; }
        public bool? DateWorkFrid { get; set; }
        public bool? DateWorkSatu { get; set; }
        public bool? DateWorkSund { get; set; }

        [MaxLength(11)]
        public string? TimeWorkBegin { get; set; }

        [MaxLength(11)]
        public string? TimeWorkEnd { get; set; }

        public bool? AcceptPartialPay { get; set; }

        public float? PercentPayPartialPay { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? AmountPayPartialPay { get; set; }

        public int? MaxBraider { get; set; }

        public string? GalleryImageRepos { get; set; }

    }
}

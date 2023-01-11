using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class ClientLibrary
    {
        [Key]
        public int IdClient { get; set; }

        [Required]
        [MaxLength(150)]
        public string? FnameClient { get; set; }

        [MaxLength(50)]
        public string? MnameClient { get; set; }


        [MaxLength(100)]
        public string? LnameClient { get; set; }


        [MaxLength(14)]
        public string? PhoneClient { get; set; }


        [MaxLength(1)]
        public string? SexClient { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DOBClient { get; set; }

        [Required]
        [Phone]
        [MaxLength(14)]
        public string? CelClient { get; set; }


        [MaxLength(150)]
        public string? StreetClient { get; set; }

        [MaxLength(75)]
        public string? CountyClient { get; set; }

        [MaxLength(10)]
        public string? ZipCodeClient { get; set; }

        [MaxLength(100)]
        public string? EmailClient { get; set; }

        [MaxLength(2)]
        public string? StateClient { get; set; }

        public int IdUser { get; set; }

        public int IdCompany { get; set; } //Not necessary - Here just to get value for some procedure

    }
}

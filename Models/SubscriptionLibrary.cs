using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class SubscriptionLibrary
    {
        [Key]
        public int IdSuscript { get; set; }

        public int IdAccount { get; set; }

        [MaxLength(20)]
        public String TypeSuscript { get; set; } // FreeTrial, Premium, Gold, Diamond

        [DataType(DataType.DateTime)]
        public DateTime? DateBeginSouscrip { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateEndSouscrip { get; set; }

        public int PeriodSouscrip { get; set; } // 1= Monthly, 3 = Trimestre, 6 Semestrial; 12 annual

        public bool FreeTrial { get; set; }

        //public AccountLibrary Account { get; set; } //One to Many Relation with Souscription
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class CompanyAccountLibrary
    {
        [Key]
        public int IdCompanyAccount { get; set; }

        public int IdCompany { get; set; }

        public int IdAccount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOpened { get; set; }

        public bool AutoRenew { get; set; }

        [MaxLength(20)]
        public string StateUsed { get; set; } // ACTIVE, SUSPENDED, CLOSED

        //public CompanyLibrary Company { get; set; } // Relation ship with CompanyAccount


        //public AccountLibrary Account { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class AccountLibrary
    {
        [Key]
        public int IdAccount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAddedAccount { get; set; }

    }
}

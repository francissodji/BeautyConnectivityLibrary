using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Dtos
{
    public class CompanyClientLibraryReadDto
    {
        public int IdCompanyClient { get; set; }

        public int IdCompany { get; set; }

        public int IdClient { get; set; }

        public DateTime DateAdded { get; set; }
    }
}

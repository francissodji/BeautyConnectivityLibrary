using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityLibrary.Models
{
    public class UserLibrary
    {
		[Key]
		public int IdUser { get; set; }


		[Required]
		[EmailAddress]
		[MaxLength(100)]
		public string? Email { get; set; }


		[Required]
		[MinLength(5)]
		[MaxLength(100)]
		public string? Username { get; set; }


		[Required]
		public string? PasswordHash { get; set; }


		public DateTime? Dateuserexpire { get; set; }


		public bool? Connectstate { get; set; }

		//[MaxLength(30)]
		public string? Role { get; set; }


		public string? TokenUser { get; set; }


		//public ICollection<ClientLibrary> Clients { get; set; } // Many to One Relation with Client

		//public ICollection<AssociateLibrary> Associates { get; set; } // Many to One Relation with Associate
	}
}

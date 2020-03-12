using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sklad.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string Phone { get; set; }

		public List<Address> Addresses { get; set; }

		[InverseProperty("Client")]
		public List<Order> ClientOrders { get; set; }
		[InverseProperty("Driver")]
		public List<Order> DriverOrders { get; set; }
	}
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sklad.Models
{
	public class Address
	{
		public int Id { get; set; }
		public string Street { get; set; }
		[Required]
		public string BuildingNo { get; set; }
		public string UnitNo { get; set; }
		[Required]
		public string PostalCode { get; set; }
		[Required]
		public string City { get; set; }

		[Required]
		public string ApplicationUserId { get; set; }
		[Required]
		public ApplicationUser ApplicationUser { get; set; }
	}
}

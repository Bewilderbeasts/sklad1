﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sklad.Models
{
	public class Order
	{
		public int Id { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime OrderDate { get; set; }
		public DateTime? RealizationDate { get; set; }

		[ForeignKey("Client")]
		public string ClientId { get; set; }
		public ApplicationUser Client { get; set; }

		[ForeignKey("Driver")]
		public string DriverId { get; set; }
		public ApplicationUser Driver { get; set; }

		public List<OrderItem> OrderItems { get; set; }
	}
}

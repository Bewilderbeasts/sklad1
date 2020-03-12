using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sklad.Models
{
	public class OrderItem
	{
		public int Id { get; set; }

		[Required]
		public int OrderId { get; set; }
		[Required]
		public Order Order { get; set; }

		[Required]
		public int ItemId { get; set; }
		[Required]
		public Item Item { get; set; }

		[Required]
		public int Amount { get; set; }
		[Required]
		public double Price { get; set; }
	}
}

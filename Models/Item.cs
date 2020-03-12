using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sklad.Models
{
	public class Item
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public double Price { get; set; }
		[Required]
		public PriceType PriceFor { get; set; }
		[Required]
		public int Quantity { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public enum PriceType { unit, kilogram}
	}
}

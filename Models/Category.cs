﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sklad.Models
{
	public class Category
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public List<Item> Items { get; set; }

		public Category ParentCategory { get; set; }
	}
}

﻿using System;
using DEMOFORMVC.Models;

namespace DEMOFORMVC
{
	public interface IProductRepo
	{
		public IEnumerable<Product> GetAllProducts();
		public Product GetProduct(int id);
	}
}


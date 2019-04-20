using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settlement_Generator
{
	public class Resource
	{
		protected string Category;
		protected double Worth;
		protected int Quantity;

		public string GetCategory() => Category;
		public double GetWorth() => Worth;
		public int GetQuantity() => Quantity;
	}
}

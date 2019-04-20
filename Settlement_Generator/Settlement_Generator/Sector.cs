using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settlement_Generator
{
	public class Sector
	{
		protected int Population;
		protected Sector[] Neighbors;

		public int GetPopulation() => Population;
		public Sector[] GetNeighbors => Neighbors;
	}
}

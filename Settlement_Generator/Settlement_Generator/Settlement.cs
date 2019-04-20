using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settlement_Generator
{
	public abstract class Settlement
	{
		protected string[] GeneralSizes;
		protected int MinPopulation;
		protected int MaxPopulation;
		protected int ResourceMultiplier;
		protected int Population;
		private Resource[] _resources;
		private Sector[] _sectors;

		protected Resource[] Resources { get => _resources; set => _resources = value; }
		protected Sector[] Sectors { get => _sectors; set => _sectors = value; }

		public Settlement()
		{
		}

		public string[] GetGeneralSizes() => GeneralSizes;
		public int GetMinPopulation() => MinPopulation;
		public int GetMaxPopulation() => MaxPopulation;
		public int GetResourceMultiplier() => ResourceMultiplier;
		public int GetPopulation() => Population;
		public Resource[] GetResources() => Resources;
		public Sector[] GetSectors() => Sectors;
	}
}

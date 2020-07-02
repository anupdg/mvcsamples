using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSamples.Models
{
	public class Tuner
	{
		public string Tick1 { get; set; }
		public string Tick2 { get; set; }
		public List<Sections> Sections { get; set; }
	}

	public class Sections
	{
		public string Section { get; set; }
		public string LI { get; set; }

	}
}

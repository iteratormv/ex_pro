using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model
{
	public class stor
	{
		public List<ExhibitionVisitors> s { get; set; }

		public stor()
		{
			ex_mod con = new ex_mod();
			s = con.ExhibitionVisitors.Select(s => s).ToList();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.DisplaySettingModel
{
	public class ColStor
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int DeskSetId { get; set; }
		public virtual DeskSet DeskSet { get; set; }

		public virtual List<ColSet> ColSets { get; set; }
	}
}

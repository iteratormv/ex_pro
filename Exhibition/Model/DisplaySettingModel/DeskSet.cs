using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.DisplaySettingModel
{
	public class DeskSet
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool isSelected { get; set; }

		public virtual List<ColStor> ColStors { get; set; }
	}
}

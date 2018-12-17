using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.DisplaySettingModel
{
	public class ColSet
	{
		public int Id { get; set; }
		public string Alias { get; set; }
		public bool Visible { get; set; }
		public int Width { get; set; }

		public int ColStorId { get; set; }
		public virtual ColStor ColStor { get; set; }

	}
}

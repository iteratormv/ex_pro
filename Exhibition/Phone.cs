using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exhibition
{
	public class Phone
	{
		public string Title { get; set; }
		public string Company { get; set; }
		public int Price { get; set; }

		public static List<Phone> phonesList = new List<Phone>
{
	new Phone { Title="iPhone 6S", Company="Apple", Price=54990 },
	new Phone {Title="Lumia 950", Company="Microsoft", Price=39990 },
	new Phone {Title="Nexus 5X", Company="Google", Price=29990 }
};
	}
}
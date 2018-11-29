using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.VisitorModels
{
	public class Description : INotifyPropertyChanged
	{
		int id;
		string name;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}

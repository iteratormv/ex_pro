using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Exhibition.Model.VisitorModels
{
	public class AddComboField1 : INotifyPropertyChanged
	{
		int id;
		string name;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
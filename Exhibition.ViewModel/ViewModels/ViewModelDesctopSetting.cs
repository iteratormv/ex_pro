using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exhibition.ViewModel.ViewModels
{
	class ViewModelDesctopSetting : INotifyPropertyChanged
	{


		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
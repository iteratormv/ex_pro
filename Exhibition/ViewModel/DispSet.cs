using Exhibition.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.ViewModel
{
	public class DeskSets:INotifyPropertyChanged
	{
		int id;
		string name;
		ObservableCollection<Col1> columnSetting;

		public int Id { get { return id; } set { id = value; OnPropertyChanged(nameof(Id)); } }
		public string Name { get { return name; } set { name = value; OnPropertyChanged(nameof(Name)); } }
		public ObservableCollection<Col1> CollumnSetting { get { return columnSetting; } set { columnSetting = value; OnPropertyChanged(nameof(CollumnSetting)); } }

		private void OnPropertyChanged(string propertyName)
		{
			VerifyPropertyName(propertyName);
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public DeskSets()
		{
			Id = 1;
			Name = "default";
			CollumnSetting = new ObservableCollection<Col1>()
			{
				new Col1() { Parameter = "FirstName", Alias = "Имя", Visible = true, Width = 100 },
				new Col1() { Parameter = "LastName", Alias = "Фамилия", Visible = true, Width = 100 },
				new Col1() { Parameter = "Company", Alias = "Компания", Visible = true, Width = 100 }
			};
		}

		[Conditional("DEBUG")]
		private void VerifyPropertyName(string propertyName)
		{
			if (TypeDescriptor.GetProperties(this)[propertyName] == null)
				throw new ArgumentNullException(GetType().Name + " does not contain property: " + propertyName);
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}

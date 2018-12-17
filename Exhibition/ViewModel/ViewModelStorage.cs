using Exhibition.Model;
using Exhibition.Model.VisitorModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Exhibition.ViewModel.ViewModels
{
	public class ViewModelStorage : INotifyPropertyChanged
	{
		private bool _firstColumnChecked;
		ObservableCollection<ExhibitionVisitorPro> m_collection;

		

		public ObservableCollection<ExhibitionVisitorPro> collection { get { return m_collection; } set { m_collection = value; } }

		public ViewModelStorage()
		{
			//context = new exhb_mod();
			stor a = new stor();
			m_collection = new ObservableCollection<ExhibitionVisitorPro>();
			List<ExhibitionVisitors> d = a.s;
			foreach (var i in d)
			{
				m_collection.Add(new ExhibitionVisitorPro
				{
					FirstName = i.FirstName,
					LastName = i.LastName,
					Company = i.CompanyId.ToString()
				});
			}



		}





		public bool FirstColumnChecked
		{
			get { return _firstColumnChecked; }
			set
			{
				_firstColumnChecked = value;
				OnPropertyChanged(nameof(FirstColumnChecked));
			}
		}

		private void OnPropertyChanged(string propertyName)
		{
			VerifyPropertyName(propertyName);
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
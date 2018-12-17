using Exhibition.Model.DisplaySettingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.ViewModel.SettingData
{
	public class VMDeskSet : INotifyPropertyChanged
	{
		DeskSettSor storage;
		DeskSet selected_setting;
		ColStor selected_column;
		ColSet selected_column_setting;

		public DeskSet SelectedSetting { get { return selected_setting; } set { selected_setting = value; OnPropertyChanged(nameof(SelectedSetting)); } }
		public ColStor SelectedColumn { get { SelectedColumnSetting = storage.ColSets.Where(s => s.ColStorId == selected_column.Id).FirstOrDefault(); return selected_column; } set { selected_column = value; OnPropertyChanged(nameof(SelectedColumn)); } }
		public ColSet SelectedColumnSetting { get { return selected_column_setting; } set { selected_column_setting = value; OnPropertyChanged(nameof(SelectedColumnSetting)); } } 
		public List<DeskSet> collection_setting { get; set; }
		public List<ColStor> collection_column { get; set; }

		public VMDeskSet()
		{
			storage = new DeskSettSor();
			collection_setting = storage.DeskSets;
			collection_column = storage.ColStors;
			selected_column = collection_column.FirstOrDefault();
			selected_setting = collection_setting.Where(s => s.isSelected = true).FirstOrDefault();
			selected_column_setting = storage.ColSets.Where(s => s.ColStorId == selected_column.Id).FirstOrDefault();
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

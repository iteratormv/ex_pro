using Exhibition.Model.DisplaySettingModel;
using Exhibition.ViewModel.Infrostructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		public ObservableCollection<DeskSet> collection_setting { get; set; }
		public ObservableCollection<ColStor> collection_column { get; set; }


        RelayCommand addCollumn;
        public RelayCommand AddCollumn { get { return addCollumn; }}

        RelayCommand removeCollumn;
        public RelayCommand RemoveCollumn { get { return removeCollumn; } }

        RelayCommand saveColumn;
        public RelayCommand SeveCollumn { get { return saveColumn; } }

        RelayCommand addSetting;
        public RelayCommand AddSetting { get { return addSetting; } }

        RelayCommand delSetting;
        public RelayCommand DelSetting { get { return delSetting; } }

        RelayCommand selectedSettingChanged;
        public RelayCommand SelectedSettingChanged { get { return selectedSettingChanged; } }

        RelayCommand saveChanges;
        public RelayCommand SaveChanges { get { return saveChanges; } }



        public VMDeskSet()
		{
			storage = new DeskSettSor();
			collection_setting = storage.DeskSets;
			collection_column = storage.ColStors;
			selected_column = collection_column.FirstOrDefault();
			selected_setting = collection_setting.Where(s => s.isSelected == true).FirstOrDefault();
			selected_column_setting = storage.ColSets.Where(s => s.ColStorId == selected_column.Id).FirstOrDefault();

            addCollumn = new RelayCommand(c => {

                storage.addColStor();
                collection_setting = storage.DeskSets;
                collection_column = storage.ColStors;
                SelectedColumn = storage.SelectedCollumn;
                SelectedColumnSetting = storage.SelectedSetting;
                SelectedSetting = storage.SelectedDeskSet;
            });

            removeCollumn = new RelayCommand(c =>
            {
                storage.delStor(SelectedColumn);
                collection_setting = storage.DeskSets;
                collection_column = storage.ColStors;
                SelectedColumn = storage.SelectedCollumn;
                SelectedColumnSetting = storage.SelectedSetting;
                SelectedSetting = storage.SelectedDeskSet;
            });

            saveColumn = new RelayCommand(c =>
            {

            });

            addSetting = new RelayCommand(c =>
            {
                storage.addSet();
                collection_setting = storage.DeskSets;
                collection_column = storage.ColStors;
                SelectedColumn = storage.SelectedCollumn;
                SelectedColumnSetting = storage.SelectedSetting;
                SelectedSetting = storage.SelectedDeskSet;
            });

            delSetting = new RelayCommand(c =>
            {
                storage.delSet(SelectedSetting);
                collection_setting = storage.DeskSets;
                collection_column = storage.ColStors;
                SelectedColumn = storage.SelectedCollumn;
                SelectedColumnSetting = storage.SelectedSetting;
                SelectedSetting = storage.SelectedDeskSet;
            }, e => collection_setting.Count() > 1);

            selectedSettingChanged = new RelayCommand(c =>
            {
                storage.changeSetVisible(SelectedSetting);
                collection_setting = storage.DeskSets;
                collection_column = storage.ColStors;
                SelectedColumn = storage.SelectedCollumn;
                SelectedColumnSetting = storage.SelectedSetting;
                SelectedSetting = storage.SelectedDeskSet;
            });

            saveChanges = new RelayCommand(c =>
            {
                storage.saveChanges(selected_column, selected_column_setting, selected_setting);
                collection_setting = storage.DeskSets;
                collection_column = storage.ColStors;
                SelectedColumn = storage.SelectedCollumn;
                SelectedColumnSetting = storage.SelectedSetting;
                SelectedSetting = storage.SelectedDeskSet;
               
            });
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

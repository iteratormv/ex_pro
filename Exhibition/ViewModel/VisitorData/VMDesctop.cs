using Exhibition.Model.DisplaySettingModel;
using Exhibition.Model.Repository;
using Exhibition.Model.VisitorDataModel;
using Exhibition.ViewModel.Infrostructure;
using Exhibition.ViewModel.SettingData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.ViewModel.VisitorData
{
    public class VMDesctop : INotifyPropertyChanged
    {

        DeskSettSor storage;
        DeskSet selected_setting;
        ColStor selected_column;
        ColSet selected_column_setting;
        ObservableCollection<DeskSet> collection_setting { get; set; }
        ObservableCollection<ColStor> collection_column { get; set; }



        VisitorStorage vs;
        DeskSettSor dss;
        ObservableCollection<ExhibitionVisitor> collection;
 //       ObservableCollection<ColStor> settingCollection;
        bool[] columnChecked;
        string[] alias;
        int[] width;



        public DeskSet SelectedSetting { get { return selected_setting; } set { selected_setting = value; OnPropertyChanged(nameof(SelectedSetting)); } }
        public ColStor SelectedColumn { get {  SelectedColumnSetting = storage.ColSets.Where(s => s.ColStorId == selected_column.Id).FirstOrDefault(); return selected_column; } set { selected_column = value; OnPropertyChanged(nameof(SelectedColumn)); } }
        public ColSet SelectedColumnSetting { get { return selected_column_setting; } set { selected_column_setting = value; OnPropertyChanged(nameof(SelectedColumnSetting)); } }

        public ObservableCollection<DeskSet> CollectionSetting { get { return collection_setting; } set { collection_setting = value; OnPropertyChanged(nameof(CollectionSetting)); } }
        public ObservableCollection<ColStor> CollectionColumn { get { return collection_column; } set { collection_column = value; OnPropertyChanged(nameof(CollectionColumn)); } }



        public ObservableCollection<ExhibitionVisitor> Collection { get { return collection; } set { collection = value; OnPropertyChanged(nameof(Collection)); } }
  //      public ObservableCollection<ColStor> SettingCollection { get { return SettingCollection; } set { SettingCollection = value; OnPropertyChanged(nameof(SettingCollection)); } }
        public DeskSettSor DSS { get { return dss; } set { dss = value; OnPropertyChanged(nameof(DSS)); } }
        public bool[] ColumnChecked { get { return columnChecked; } set { columnChecked = value; OnPropertyChanged(nameof(ColumnChecked)); } } 
        public string[] Alias { get { return alias; } set { alias = value; OnPropertyChanged(nameof(Alias)); } }
        public int[] Width { get { return width; } set { width = value; OnPropertyChanged(nameof(Width)); } }



        RelayCommand addCollumn;
        public RelayCommand AddCollumn { get { return addCollumn; } }

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





        public VMDesctop()
        {
            dss = new DeskSettSor();
            vs = new VisitorStorage();
            collection_column = new ObservableCollection<ColStor>();
            columnChecked = new bool[10];
            alias = new string[10];
            width = new int[10];
            collection = vs.getVisitors();
            //          settingCollection = dss.ColStors;

//            collection_column = dss.ColStors;
            var sc = dss.ColStors.ToArray();
            //коллекция visible
            bool[] _columnChecked = new bool[sc.Count()];
            for (int i=0; i < sc.Count(); i++) { _columnChecked[i] = dss.ColSets.Where(s => s.ColStorId == sc[i].Id).Select(s => s.Visible).FirstOrDefault(); }      
            for(int i = 0; i < 10; i++){ try { columnChecked[i] = _columnChecked[i]; } catch { columnChecked[i] = false; } }
            //коллекция алиасов
            string[] _alias = new string[sc.Count()];
            for (int i = 0; i < sc.Count(); i++) { _alias[i] = dss.ColSets.Where(s => s.ColStorId == sc[i].Id).Select(s => s.Alias).FirstOrDefault(); }
            for (int i = 0; i < 10; i++){ try { alias[i] = _alias[i]; } catch { alias[i] = "none"; } }
            int[] _width = new int[sc.Count()];
            for (int i = 0; i < sc.Count(); i++) { _width[i] = dss.ColSets.Where(s => s.ColStorId == sc[i].Id).Select(s => s.Width).FirstOrDefault(); }
            for(int i = 0; i < 10; i++) { try { width[i] = _width[i]; } catch { width[i] = 100; } }


            storage = new DeskSettSor();
            collection_setting = storage.DeskSets;
            selected_setting = collection_setting.Where(s => s.isSelected == true).FirstOrDefault();
            var _collection_column = storage.ColStors.Where(s => s.DeskSetId == selected_setting.Id).ToList();
            foreach(var c in _collection_column) { collection_column.Add(c); }
            selected_column = collection_column.FirstOrDefault();
            
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

                //             SelectedColumn = storage.SelectedCollumn;
        //        var _selected_column = storage.ColStors.Where(s => s.DeskSetId == selected_setting.Id).FirstOrDefault();
                _collection_column = storage.ColStors.Where(s => s.DeskSetId == selected_setting.Id).Select(s=>s).ToList();
                collection_column.Clear();
                foreach (var ci in _collection_column) { collection_column.Add(ci); }
                SelectedColumn = collection_column.FirstOrDefault();
                SelectedColumnSetting = storage.ColSets.Where(s => s.ColStorId == selected_column.Id).FirstOrDefault();
          //      collection_column = storage.ColStors;
         //       SelectedSetting = storage.SelectedDeskSet;
                storage.changeSetVisible(SelectedSetting);
          //      collection_setting = storage.DeskSets;
          //      collection_column = storage.ColStors;
          //      collection = new ObservableCollection<ExhibitionVisitor>();
          //      Collection = vs.getVisitors();
               
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

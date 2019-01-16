using Exhibition.Model.DisplaySettingModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.ViewModel.SettingData
{
	public class DeskSettSor:INotifyPropertyChanged
	{
		ObservableCollection<DeskSet> deskSets;
        DeskSetContext context;
        ObservableCollection<ColStor> colStors;
        ObservableCollection<ColSet> colSets;


        DeskSet selectedDeskSet;
        ColSet selectedSetting;
        ColStor selectedCollumn;
	
		public ObservableCollection<DeskSet> DeskSets { get { return deskSets; } set { deskSets = value; OnPropertyChanged(nameof(DeskSets)); } }
		public ObservableCollection<ColStor> ColStors { get { return colStors; } set { colStors = value; OnPropertyChanged(nameof(ColStors)); } }
		public ObservableCollection<ColSet> ColSets { get { return colSets; } set { colSets = value; OnPropertyChanged(nameof(ColSets)); } }

        public ColSet SelectedSetting { get { return selectedSetting; } set { selectedSetting = value; OnPropertyChanged(nameof(SelectedSetting)); } }
        public ColStor SelectedCollumn { get { return selectedCollumn; } set { selectedCollumn = value; OnPropertyChanged(nameof(SelectedCollumn)); } }
        public DeskSet SelectedDeskSet { get { return selectedDeskSet; } set { selectedDeskSet = value; OnPropertyChanged(nameof(SelectedDeskSet)); } }

		public DeskSettSor()
		{
            context = new DeskSetContext();
			if (context.DeskSets.Select(s => s).Count() == 0)
			{
				DeskSet dispset = new DeskSet() { Name = "default", isSelected = true };
				context.DeskSets.Add(dispset);
				context.SaveChanges();

				var defid = context.DeskSets.Where(s => s.Name == "default").Select(s => s.Id).FirstOrDefault();
                ColStor Id = new ColStor() { Name = "Id", DeskSetId = defid };
                ColStor firstName = new ColStor() { Name = "FirstName", DeskSetId = defid };
				ColStor lastName = new ColStor() { Name = "LastName", DeskSetId = defid };
				ColStor Company = new ColStor() { Name = "Company", DeskSetId = defid };
                context.ColStors.Add(Id);
				context.ColStors.Add(firstName);
				context.ColStors.Add(lastName);
				context.ColStors.Add(Company);
				context.SaveChanges();

                int idid = context.ColStors.Where(s => s.Name == "Id").Select(s => s.Id).FirstOrDefault();
                int fnid = context.ColStors.Where(s => s.Name == "Firstname").Select(s => s.Id).FirstOrDefault();
				int lnid = context.ColStors.Where(s => s.Name == "LastName").Select(s => s.Id).FirstOrDefault();
				int coid = context.ColStors.Where(s => s.Name == "Company").Select(s => s.Id).FirstOrDefault();

                ColSet id = new ColSet() { Alias = "№", Visible = true, Width = 100, ColStorId = idid };
                ColSet firstname = new ColSet() { Alias = "Имя", Visible = true, Width = 100, ColStorId = fnid };
				ColSet lastname = new ColSet { Alias = "Фамилия", Visible = true, Width = 100, ColStorId = lnid };
				ColSet company = new ColSet { Alias = "Компания", Visible = true, Width = 100, ColStorId = coid };
                context.ColSets.Add(id);
				context.ColSets.Add(firstname);
				context.ColSets.Add(lastname);
				context.ColSets.Add(company);
				context.SaveChanges();
			}
			var _deskSets = context.DeskSets;
            deskSets = new ObservableCollection<DeskSet>();
            foreach (var c in _deskSets) { deskSets.Add(c); }
			var sel_set_id = context.DeskSets.Where(s => s.isSelected == true).Select(s=>s.Id).FirstOrDefault();
//			var _colStors = context.ColStors.Where(s => s.DeskSetId == sel_set_id).Select(s => s).ToList();
            var _colStors = context.ColStors.ToList();

            colStors = new ObservableCollection<ColStor>();
            foreach(var c in _colStors) { colStors.Add(c); }
            colSets = new ObservableCollection<ColSet>();
			var _colSets = context.ColSets.ToList();
            foreach(var c in _colSets) { colSets.Add(c); }
		}

        public bool addColStor()
        {
            bool result = false;
            try
            {
                var dsid = context.DeskSets.Where(s => s.isSelected == true).Select(s => s.Id).FirstOrDefault();
                string _name = "NewCollumn1";
                while (context.ColStors.Where(s => s.Name == _name).Select(s => s).Count() > 0)
                {
                    string d_name = _name.Trim(new char[] { 'N', 'e', 'w', 'C', 'o', 'l', 'u', 'm', 'n' });
                    int d = int.Parse(d_name)+1;
                    _name = "NewCollumn" + d.ToString();
                }
                SelectedDeskSet = DeskSets.Where(s => s.isSelected == true).FirstOrDefault();
                selectedCollumn = new ColStor() { DeskSetId = dsid, Name = _name };
                context.ColStors.Add(selectedCollumn);
                context.SaveChanges();
                var _colStors = context.ColStors.Where(s=>s.DeskSetId == dsid).Select(s=>s).ToList();
                var _colStor = context.ColStors.Where(s => s.Name == _name).Select(s => s).FirstOrDefault();
                colStors.Clear();
                foreach(var c in _colStors) { colStors.Add(c); }

                string _alias = "NewAlias1";
                while (context.ColSets.Where(s => s.Alias == _alias).Select(s => s).Count() > 0)
                {
                    string d_alias = _alias.Trim(new char[] { 'N', 'e', 'w', 'A', 'l', 'i', 'a', 's' });
                    int d = int.Parse(d_alias)+1;
                    _alias = "NewAlias" + d.ToString();
                }
                selectedSetting = new ColSet() { ColStorId = _colStor.Id, Alias = _alias, Visible = true, Width = 100 };
                context.ColSets.Add(selectedSetting);
                context.SaveChanges();
                var _colsets = context.ColSets.ToList();
                colSets.Clear();
                foreach (var c in _colsets) { colSets.Add(c); }
                result = true;

            }

            catch (Exception e) { Console.WriteLine(e.ToString()); }

            return result;
        }

        public bool delStor(ColStor d_stor)
        {
            bool result = false;
            try
            {
                var d_se = context.ColSets.Where(s => s.ColStorId == d_stor.Id).Select(s => s).FirstOrDefault();
                context.ColSets.Remove(d_se);
                context.ColStors.Remove(d_stor);
                context.SaveChanges();
                ColStors.Remove(d_stor);
                ColSets.Remove(d_se);
                SelectedDeskSet = DeskSets.Where(s => s.isSelected == true).FirstOrDefault();
                SelectedCollumn = ColStors.FirstOrDefault();
                SelectedSetting = colSets.Where(s => s.ColStorId == SelectedCollumn.Id).Select(s => s).FirstOrDefault();
                result = true;
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
            return result;
        }

        public bool addSet()
        {
            bool result = false;
            try
            {
                var cur_set = context.DeskSets.Where(s => s.isSelected == true).Select(s => s).FirstOrDefault();
                string new_set_name = "NewSetting1";
                while (context.DeskSets.Where(s => s.Name == new_set_name).Count() > 0)
                {
                    string d_name = new_set_name.Trim(new char[] { 'N', 'e', 'w', 'S', 't', 'i', 'n', 'g' });
                    int d = int.Parse(d_name) + 1;
                    new_set_name = "NewSetting" + d.ToString();
                }
                if(cur_set != null) cur_set.isSelected = false;

                var n_set = new DeskSet() { Name = new_set_name, isSelected = true };
                context.DeskSets.Add(n_set);
                context.SaveChanges();
                var _desksets = context.DeskSets;
                SelectedDeskSet = context.DeskSets.Where(s => s.isSelected == true).Select(s => s).FirstOrDefault();
                deskSets.Clear();
                foreach(var c in _desksets) { deskSets.Add(c); }
                result = true;
                addColStor();
                result = true;
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }

            return result;
        }

        public bool delSet(DeskSet d_set)
        {
            bool result = false;
            try
            {
                DeskSet s_ds = context.DeskSets.Where(s => s.isSelected == true).FirstOrDefault();
                context.DeskSets.Remove(d_set);
                context.SaveChanges();
                if (d_set.isSelected == true)
                {
                    s_ds = context.DeskSets.FirstOrDefault();
                    s_ds.isSelected = true;
                    context.SaveChanges();
                }
                DeskSets.Remove(d_set);
                var _colstors = context.ColStors.Where(s => s.DeskSetId == s_ds.Id).Select(s=>s).ToList();
                ColStors.Clear();
                foreach(var c in _colstors) { ColStors.Add(c); }
                SelectedCollumn = ColStors.FirstOrDefault();
                var c_set = context.ColSets.Where(s => s.ColStorId == SelectedCollumn.Id).Select(s => s).FirstOrDefault();
                SelectedSetting = c_set;
                SelectedDeskSet = s_ds;
                result = true;
                //             var d_stors = context.ColStors.Where(s => s.DeskSetId == d_set.Id);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
            return result;
        }

        public bool changeSetVisible(DeskSet set)
        {
            bool result = false;
            try
            {
                var cur_sete = context.DeskSets.Where(s => s.isSelected == true).FirstOrDefault();
                var cur_setv = DeskSets.Where(s => s.isSelected == true).FirstOrDefault();
                cur_sete.isSelected = false;
                cur_setv.isSelected = false;
                context.SaveChanges();
                cur_sete = context.DeskSets.Where(s => s.Id == set.Id).FirstOrDefault();
                cur_setv = DeskSets.Where(s => s.Id == set.Id).FirstOrDefault();
                cur_sete.isSelected = true;
                context.SaveChanges();
                SelectedDeskSet = cur_sete;
 //               var _colstors = context.ColStors.Where(s => s.DeskSetId == SelectedDeskSet.Id);
 //               ColStors.Clear();
 //               foreach(var c in _colstors) { ColStors.Add(c); }
                SelectedCollumn = ColStors.FirstOrDefault();
                SelectedSetting = context.ColSets.Where(s => s.ColStorId == SelectedCollumn.Id).FirstOrDefault();
                result = true;
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }

            return result;
        }

        
        public bool saveChanges(ColStor cst, ColSet cse, DeskSet d)
        {
            bool result = false;
            try
            {
                selectedCollumn = cst;
                selectedDeskSet = d;
                selectedSetting = cse;

                context.SaveChanges();
                result = true;
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
            return result;
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

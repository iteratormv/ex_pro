using Exhibition.Model.DisplaySettingModel;
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
	public class DeskSettSor:INotifyPropertyChanged
	{
		List<DeskSet> deskSets;
		DeskSetContext context;
        List<ColStor> colStors;
        List<ColSet> colSets;
	

		public List<DeskSet> DeskSets { get { return deskSets; } set { deskSets = value; OnPropertyChanged(nameof(DeskSets)); } }
		public List<ColStor> ColStors { get { return colStors; } set { colStors = value; OnPropertyChanged(nameof(ColStors)); } }
		public List<ColSet> ColSets { get { return colSets; } set { colSets = value; OnPropertyChanged(nameof(ColSets)); } }

		public DeskSettSor()
		{
			context = new DeskSetContext();
			if (context.DeskSets.Select(s => s).Count() == 0)
			{
				DeskSet dispset = new DeskSet() { Name = "default", isSelected = true };
				context.DeskSets.Add(dispset);
				context.SaveChanges();

				var defid = context.DeskSets.Where(s => s.Name == "default").Select(s => s.Id).FirstOrDefault();

				ColStor firstName = new ColStor() { Name = "FirstName", DeskSetId = defid };
				ColStor lastName = new ColStor() { Name = "LastName", DeskSetId = defid };
				ColStor Company = new ColStor() { Name = "Company", DeskSetId = defid };
				context.ColStors.Add(firstName);
				context.ColStors.Add(lastName);
				context.ColStors.Add(Company);
				context.SaveChanges();

				int fnid = context.ColStors.Where(s => s.Name == "Firstname").Select(s => s.Id).FirstOrDefault();
				int lnid = context.ColStors.Where(s => s.Name == "LastName").Select(s => s.Id).FirstOrDefault();
				int coid = context.ColStors.Where(s => s.Name == "Company").Select(s => s.Id).FirstOrDefault();


				ColSet firstname = new ColSet() { Alias = "Имя", Visible = true, Width = 100, ColStorId = fnid };
				ColSet lastname = new ColSet { Alias = "Фамилия", Visible = true, Width = 100, ColStorId = lnid };
				ColSet company = new ColSet { Alias = "Компания", Visible = true, Width = 100, ColStorId = coid };
				context.ColSets.Add(firstname);
				context.ColSets.Add(lastname);
				context.ColSets.Add(company);
				context.SaveChanges();
			}
			deskSets = context.DeskSets.Select(s => s).ToList();
			var sel_set_id = context.DeskSets.Where(s => s.isSelected == true).Select(s=>s.Id).FirstOrDefault();
			colStors = context.ColStors.Where(s => s.DeskSetId == sel_set_id).Select(s => s).ToList();
			colSets = context.ColSets.ToList();
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

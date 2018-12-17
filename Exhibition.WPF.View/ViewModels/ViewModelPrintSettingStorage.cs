using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.ViewModel.ViewModels
{
	class ViewModelPrintSettingStorage : INotifyPropertyChanged
	{

		int psid;
		string psname;
		List<PrintSetting> psparameters;
		bool psisCanDelete;

		public int PSId { get { return psid; } set { psid = value; Notify("Id"); } }
		public string PSName { get { return psname; } set { psname = value; Notify("PSName"); } }
		public List<PrintSetting> PSParameters { get { return psparameters; } set { psparameters = value; Notify("PSParameters"); } }
		public bool PSIsCanDelete { get { return psisCanDelete; } set { psisCanDelete = value; Notify("PSIsCanDelete"); } }

		public ViewModelPrintSettingStorage()
		{
			psid = 1;
			psname = "default";
			psparameters = new List<PrintSetting>()
			{
				new PrintSetting() { Id = 1, ParameterName = "FirstName", FontName = "Arial", FontSize = 9, FontStyle = "Italic" },
				new PrintSetting() { Id = 2, ParameterName = "LastName", FontName = "Arial", FontSize = 9, FontStyle = "Italic" },
				new PrintSetting() { Id = 3, ParameterName = "Company", FontName = "Arial", FontSize = 9, FontStyle = "Italic" }
			};
		}

		public void addPSParameter(PrintSetting parameter)
		{
			PSParameters.Add(parameter);
		}

		public void delPSParameter(string name)
		{
			var delParameter = PSParameters.Where(p => p.ParameterName == name).Select(s => s).FirstOrDefault();
			if (delParameter != null)
			{
				PSParameters.Remove(delParameter);
			}
		}

		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}

	public class PrintSetting : INotifyPropertyChanged
	{
		int id;
		string parameterName;
		string fontName;
		int fontSize;
		string fontStyle;

		public int Id { get { return id; } set { id = value; Notify("Id"); } }
		public string ParameterName { get { return parameterName; } set { parameterName = value; Notify("ParameterName"); } }
		public string FontName { get { return fontName; } set { fontName = value; Notify("FontName"); } }
		public int FontSize { get { return fontSize; } set { fontSize = value; Notify("FontSize"); } }
		public string FontStyle { get { return fontStyle; } set { FontStyle = value; Notify("FontStyle"); } }

		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}

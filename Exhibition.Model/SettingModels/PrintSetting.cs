using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.SettingModels
{
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
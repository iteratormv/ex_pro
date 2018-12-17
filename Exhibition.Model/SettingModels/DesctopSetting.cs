using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.SettingModels
{
	class DesctopSetting : INotifyPropertyChanged
	{
		int id;
		string name;

		string col1;
		string col2;
		string col3;
		string col4;
		string col5;
		string col6;
		string col7;
		string col8;
		string col9;
		string col10;
		string col11;
		string col12;
		string col13;
		string col14;
		string col15;
		string col16;
		string col17;
		string col18;
		string col19;
		string col20;
		string col21;
		string col22;
		string col23;
		string col24;

		public int Id { get { return id; } set { id = value; Notify("Id"); } }
		public string Name {get { return name; } set { name = value; Notify("Name"); } }

		public string Col1 { get { return col1; } set { col1 = value; Notify("Col1"); } }
		public string Col2 { get { return col2; } set { col2 = value; Notify("Col2"); } }
		public string Col3 { get { return col3; } set { col3 = value; Notify("Col3"); } }
		public string Col4 { get { return col4; } set { col4 = value; Notify("Col4"); } }
		public string Col5 { get { return col5; } set { col5 = value; Notify("Col5"); } }
		public string Col6 { get { return col6; } set { col6 = value; Notify("Col6"); } }
		public string Col7 { get { return col7; } set { col7 = value; Notify("Col7"); } }
		public string Col8 { get { return col8; } set { col8 = value; Notify("Col8"); } }
		public string Col9 { get { return col9; } set { col9 = value; Notify("Col9"); } }
		public string Col10 { get { return col10; } set { col10 = value; Notify("Col10"); } }
		public string Col11 { get { return col11; } set { col11 = value; Notify("Col11"); } }
		public string Col12 { get { return col12; } set { col12 = value; Notify("Col12"); } }
		public string Col13 { get { return col13; } set { col13 = value; Notify("Col13"); } }
		public string Col14 { get { return col14; } set { col14 = value; Notify("Col14"); } }
		public string Col15 { get { return col15; } set { col15 = value; Notify("Col15"); } }
		public string Col16 { get { return col16; } set { col16 = value; Notify("Col16"); } }
		public string Col17 { get { return col17; } set { col17 = value; Notify("Col17"); } }
		public string Col18 { get { return col18; } set { col18 = value; Notify("Col18"); } }
		public string Col19 { get { return col19; } set { col19 = value; Notify("Col19"); } }
		public string Col20 { get { return col20; } set { col20 = value; Notify("Col20"); } }
		public string Col21 { get { return col21; } set { col21 = value; Notify("Col21"); } }
		public string Col22 { get { return col22; } set { col22 = value; Notify("Col22"); } }
		public string Col23 { get { return col23; } set { col23 = value; Notify("Col23"); } }
		public string Col24 { get { return col24; } set { col24 = value; Notify("Col24"); } }

		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}

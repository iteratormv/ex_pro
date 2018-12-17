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
	class PrintTemplateSetting : INotifyPropertyChanged
	{
		int id;
		string name;

		int col1id;
		int col2id;
		int col3id;
		int col4id;
		int col5id;
		int col6id;
		int col7id;
		int col8id;
		int col9id;
		int col10id;
		int col11id;
		int col12id;
		int col13id;
		int col14id;
		int col15id;
		int col16id;
		int col17id;
		int col18id;
		int col19id;
		int col20id;
		int col21id;
		int col22id;
		int col23id;
		int col24id;

		public int Id { get { return id; } set { id = value; Notify("Id"); } }
		public string Name { get { return name; } set { name = value; Notify("Name"); } }
		[Key]
		[ForeignKey("PrintSetting")]
		public int Col1id { get { return col1id; } set { col1id = value; Notify("Col1id"); } }
		public int Col2id { get { return col2id; } set { col2id = value; Notify("Col2id"); } }
		public int Col3id { get { return col3id; } set { col3id = value; Notify("Col3id"); } }
		public int Col4id { get { return col4id; } set { col4id = value; Notify("Col4id"); } }
		public int Col5id { get { return col5id; } set { col5id = value; Notify("Col5id"); } }
		public int Col6id { get { return col6id; } set { col6id = value; Notify("Col6id"); } }
		public int Col7id { get { return col7id; } set { col7id = value; Notify("Col7id"); } }
		public int Col8id { get { return col8id; } set { col8id = value; Notify("Col8id"); } }
		public int Col9id { get { return col9id; } set { col9id = value; Notify("Col9id"); } }
		public int Col10id { get { return col10id; } set { col10id = value; Notify("Col10id"); } }
		public int Col11id { get { return col11id; } set { col11id = value; Notify("Col11id"); } }
		public int Col12id { get { return col12id; } set { col12id = value; Notify("Col12id"); } }
		public int Col13id { get { return col13id; } set { col13id = value; Notify("Col13id"); } }
		public int Col14id { get { return col14id; } set { col14id = value; Notify("Col14id"); } }
		public int Col15id { get { return col15id; } set { col15id = value; Notify("Col15id"); } }
		public int Col16id { get { return col16id; } set { col16id = value; Notify("Col16id"); } }
		public int Col17id { get { return col17id; } set { col17id = value; Notify("Col17id"); } }
		public int Col18id { get { return col18id; } set { col18id = value; Notify("Col18id"); } }
		public int Col19id { get { return col19id; } set { col19id = value; Notify("Col19id"); } }
		public int Col20id { get { return col20id; } set { col20id = value; Notify("Col20id"); } }
		public int Col21id { get { return col21id; } set { col21id = value; Notify("Col21id"); } }
		public int Col22id { get { return col22id; } set { col22id = value; Notify("Co221id"); } }
		public int Col23id { get { return col23id; } set { col23id = value; Notify("Col23id"); } }
		public int Col24id { get { return col24id; } set { col24id = value; Notify("Col24id"); } }

		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
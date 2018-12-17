using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exhibition.Model
{
	public class DesctopSetting : INotifyPropertyChanged
	{
		public int Id;
		public string Name;

	//	public int Сol1id;
		public List<Col1> DisplaySettings { get; set; }
		//	int col2id;
		//	int col3id;
		//	int col4id;
		//	int col5id;
		//	int col6id;
		//	int col7id;
		//	int col8id;
		//	int col9id;
		//	int col10id;
		//	int col11id;
		//	int col12id;
		//	int col13id;
		//	int col14id;
		//	int col15id;
		//	int col16id;
		//	int col17id;
		//	int col18id;
		//	int col19id;
		//	int col20id;
		//	int col21id;
		//	int col22id;
		//	int col23id;
		//	int col24id;

		//		public int Id { get { return id; } set { id = value; Notify("Id"); } }
		//		public string Name { get { return name; } set { name = value; Notify("Name"); } }

		//		public int Col1Id { get { return col1id; } set { col1id = value; Notify("Col1Id"); } }
		//	public int Col2Id { get { return col2id; } set { col2id = value; Notify("Col2Id"); } }
		//	public int Col3Id { get { return col3id; } set { col3id = value; Notify("Col3Id"); } }
		//	public int Col4Id { get { return col4id; } set { col4id = value; Notify("Col4Id"); } }
		//	public int Col5Id { get { return col5id; } set { col5id = value; Notify("Col5Id"); } }
		//	public int Col6Id { get { return col6id; } set { col6id = value; Notify("Col6Id"); } }
		//	public int Col7Id { get { return col7id; } set { col7id = value; Notify("Col7Id"); } }
		//	public int Col8Id { get { return col8id; } set { col8id = value; Notify("Col8Id"); } }
		//	public int Col9Id { get { return col9id; } set { col9id = value; Notify("Col9Id"); } }
		//	public int Col10Id { get { return col10id; } set { col10id = value; Notify("Col10Id"); } }
		//	public int Col11Id { get { return col11id; } set { col11id = value; Notify("Col11Id"); } }
		//	public int Col12Id { get { return col12id; } set { col12id = value; Notify("Col12Id"); } }
		//	public int Col13Id { get { return col13id; } set { col13id = value; Notify("Col13Id"); } }
		//	public int Col14Id { get { return col14id; } set { col14id = value; Notify("Col14Id"); } }
		//	public int Col15Id { get { return col15id; } set { col15id = value; Notify("Col15Id"); } }
		//	public int Col16Id { get { return col16id; } set { col16id = value; Notify("Col16Id"); } }
		//	public int Col17Id { get { return col17id; } set { col17id = value; Notify("Col17Id"); } }
		//	public int Col18Id { get { return col18id; } set { col18id = value; Notify("Col18Id"); } }
		//	public int Col19Id { get { return col19id; } set { col19id = value; Notify("Col19Id"); } }
		//	public int Col20Id { get { return col20id; } set { col20id = value; Notify("Col20Id"); } }
		//	public int Col21Id { get { return col21id; } set { col21id = value; Notify("Col21Id"); } }
		//	public int Col22Id { get { return col22id; } set { col22id = value; Notify("Col22Id"); } }
		//	public int Col23Id { get { return col23id; } set { col23id = value; Notify("Col23Id"); } }
		//	public int Col24Id { get { return col24id; } set { col24id = value; Notify("Col24Id"); } }

		//	public virtual Col1 Col1 { get; set; }

		//	public virtual List<Col1> DisplaySettings { get; set; }
		//	public virtual DisplaySetting Col2 { get; set; }
		//	public virtual DisplaySetting Col3 { get; set; }
		//	public virtual DisplaySetting Col4 { get; set; }
		//	public virtual DisplaySetting Col5 { get; set; }
		//	public virtual DisplaySetting Col6 { get; set; }
		//	public virtual DisplaySetting Col7 { get; set; }
		//	public virtual DisplaySetting Col8 { get; set; }
		//	public virtual DisplaySetting Col9 { get; set; }
		//	public virtual DisplaySetting Col10 { get; set; }
		//	public virtual DisplaySetting Col11 { get; set; }
		//	public virtual DisplaySetting Col12 { get; set; }
		//	public virtual DisplaySetting Col13 { get; set; }
		//	public virtual DisplaySetting Col14 { get; set; }
		//	public virtual DisplaySetting Col15 { get; set; }
		//	public virtual DisplaySetting Col16 { get; set; }
		//	public virtual DisplaySetting Col17 { get; set; }
		//	public virtual DisplaySetting Col18 { get; set; }
		//	public virtual DisplaySetting Col19 { get; set; }
		//	public virtual DisplaySetting Col20 { get; set; }
		//	public virtual DisplaySetting Col21 { get; set; }
		//	public virtual DisplaySetting Col22 { get; set; }
		//	public virtual DisplaySetting Col23 { get; set; }
		//	public virtual DisplaySetting Col24 { get; set; }

		public void Notify([CallerMemberName]string s = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(s));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
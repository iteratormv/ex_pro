using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Exhibition.Model
{
	public class Col1 : INotifyPropertyChanged
	{
		
		int id;
		string parameter;
		string alias;
		bool visible;
		int width;

		[Key]
		public int Id { get { return id; } set{ id = value; OnPropertyChanged(nameof(Id));}}
		public string Parameter { get { return parameter; } set { parameter = value; OnPropertyChanged(nameof(Parameter)); } }
		public string Alias { get { return alias; } set { alias = value; OnPropertyChanged(nameof(Alias)); } }
		public bool Visible { get { return visible; } set { visible = value; OnPropertyChanged(nameof(Visible)); } }
		public int Width { get { return width; } set { width = value; OnPropertyChanged(nameof(Width)); } }


	//	public virtual List<Col1> DisplaySettings { get; set; }


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
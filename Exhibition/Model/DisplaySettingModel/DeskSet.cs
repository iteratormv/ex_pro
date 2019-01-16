﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.DisplaySettingModel
{
	public class DeskSet:INotifyPropertyChanged
	{
		int id { get; set; }
		string name { get; set; }
		bool isselected { get; set; }


        public int Id { get { return id; } set { id = value; OnPropertyChanged(nameof(Id)); } }
        public string Name { get { return name; } set { name = value; OnPropertyChanged(nameof(Name)); } }
        public bool isSelected { get { return isselected; } set { isselected = value; OnPropertyChanged(nameof(isSelected)); } }


        public virtual List<ColStor> ColStors { get; set; }


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

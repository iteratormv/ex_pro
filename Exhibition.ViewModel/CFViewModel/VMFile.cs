//using Exhibition.CFModel;
using Exhibition.ViewModel.Exel;
using Exhibition.ViewModel.Infrastructure;
using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using Exhibition.CFModel;

namespace Exhibition.ViewModel.CFViewModel
{
    public class VMFile: INotifyPropertyChanged
    {
   //     CFExRepository cFExRepository;
        
        ExelData exelData;

        RelayCommand addDataFromFileToDatabase;
        public RelayCommand AddDataFromFileToDatabase { get { return addDataFromFileToDatabase; } }

        public VMFile()
        {

            addDataFromFileToDatabase = new RelayCommand(c =>
           {
               OpenFileDialog openFileDialog = new OpenFileDialog();
               if (openFileDialog.ShowDialog() == true)
               {
                   exelData = new ExelData(openFileDialog.FileName);
                   exelData.setDataToReposytory();
               }
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

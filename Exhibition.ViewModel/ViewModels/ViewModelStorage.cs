using Exhibition.Model;
using Exhibition.Model.VisitorModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Exhibition.ViewModel.ViewModels
{
	public class ViewModelStorage
	{
		ObservableCollection<ExhibitionVisitorPro> m_collection;
		public ObservableCollection<ExhibitionVisitorPro> collection { get { return m_collection; } set { m_collection = value; } }

		public ViewModelStorage()
		{
			//context = new exhb_mod();
			stor a = new stor();
			m_collection = new ObservableCollection<ExhibitionVisitorPro>();
			List<ExhibitionVisitors> d = a.s;
			foreach (var i in d)
			{
				m_collection.Add(new ExhibitionVisitorPro
				{
					FirstName = i.FirstName,
					LastName = i.LastName,
					Company = i.CompanyId.ToString()
				});
			}
			//m_collection = new ObservableCollection<ExhibitionVisitorPro>()
			//{
			//	new ExhibitionVisitorPro("Mark"),
			//	new ExhibitionVisitorPro("Piter"),
			//	new ExhibitionVisitorPro("Grisha"),
			//};
		}
	}
}
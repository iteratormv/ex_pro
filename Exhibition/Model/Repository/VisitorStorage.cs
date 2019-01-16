using Exhibition.Model.VisitorDataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Model.Repository
{
    public class VisitorStorage
    {
        ObservableCollection<ExhibitionVisitor> vs { get; set; }

        public VisitorStorage()
        {
            ExVizContext con = new ExVizContext();
            vs = new ObservableCollection<ExhibitionVisitor>();
            List<ExhibitionVisitor> _vs = con.ExhibitionVisitors.ToList();
            foreach(var c in _vs) { vs.Add(c); }
        }

        public ObservableCollection<ExhibitionVisitor> getVisitors()
        {         
            return vs;
        }
    }
}

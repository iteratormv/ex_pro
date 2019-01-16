using Exhibition.CFModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhibition.Repository
{
    class CFExRepository
    {
        CFExhibitionContext context;
        ExelData exelData;

        ObservableCollection<Visitor> visitorRepository { get; set; }
        ObservableCollection<DisplaySetting> displaySettingsRepository { get; set; }
        ObservableCollection<DSCollumnSetting> dsColumnSettingRepository { get; set; }


        public CFExRepository()
        {
            context = new CFExhibitionContext();
            visitorRepository = new ObservableCollection<Visitor>();
            displaySettingsRepository = new ObservableCollection<DisplaySetting>();
            dsColumnSettingRepository = new ObservableCollection<DSCollumnSetting>();
        }

        public bool addDSCollumnSetting(DSCollumnSetting dscs)
        {
            try
            {
                context.DSCollumnSettings.Add(dscs);
                context.SaveChanges();
                var _dsColumnSettingRepository = context.DSCollumnSettings; dsColumnSettingRepository.Clear();
                foreach (var c in _dsColumnSettingRepository) { dsColumnSettingRepository.Add(c); }
            }
            catch { return false; }
            return true;
        }

        public bool delDSCollumnSetting(DSCollumnSetting dscs)
        {
            try
            {
                context.DSCollumnSettings.Remove(dscs);
                context.SaveChanges();
                dsColumnSettingRepository.Remove(dscs);
            }
            catch { return false; }
            return true;
        }

        public bool addDisplaySetting(DisplaySetting ds)
        {
            try
            {
                context.DisplaySettings.Add(ds);
                context.SaveChanges();
                var _displaySettingsRepository = context.DisplaySettings; displaySettingsRepository.Clear();
                foreach (var d in _displaySettingsRepository) displaySettingsRepository.Add(d);
            }
            catch { return false; }
            return true;
        }

        public bool delDisplaySetting(DisplaySetting ds)
        {
            try
            {
                context.DisplaySettings.Remove(ds);
                context.SaveChanges();
                displaySettingsRepository.Remove(ds);
            }
            catch { return false; }
            return true;
        }

        public bool addVisitor(Visitor visitor)
        {
            try
            {
                context.Visitors.Add(visitor);
                context.SaveChanges();
                var _visitorRepository = context.Visitors; visitorRepository.Clear();
                foreach (var v in _visitorRepository) visitorRepository.Add(v);
            }
            catch { return false; }
            return true;
        }

        public bool delVisitor(Visitor visitor)
        {
            try
            {
                context.Visitors.Remove(visitor);
                context.SaveChanges();
                visitorRepository.Remove(visitor);
            }
            catch { return false; }
            return true;
        }

    }
}


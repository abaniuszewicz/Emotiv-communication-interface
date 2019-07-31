using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Caliburn.Micro;
using HeadsetController.Headset;
using HeadsetController.Services.API.Responses.DataSubscriptions;
using HeadsetController.Services.API.Utils;
using Microsoft.Win32;
using VirtualKeyboard.Properties;

namespace VirtualKeyboard.ViewModels
{
    public class HeadsetInformationViewModel : PropertyChangedBase
    {
        private int _totalQuality;

        public Insight Insight { get; }
        public DPadViewModel DPadViewModel { get; }

        public int TotalQuality
        {
            get => _totalQuality;
            set
            {
                _totalQuality = value;
                NotifyOfPropertyChange(() => TotalQuality);
            }
        }

        public HeadsetInformationViewModel(Insight insight, Models.Settings settings)
        {
            Insight = insight;
            Insight.PropertyChanged += Insight_PropertyChanged;
            DPadViewModel = new DPadViewModel(settings, Insight);
        }

        private void Insight_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var prop = e.PropertyName;
            if (prop == "Af3Quality" || prop == "Af4Quality" || prop == "T7Quality" || prop == "T8Quality" || prop == "PzQuality")
                TotalQuality = (Insight.Af3Quality + Insight.T7Quality + Insight.PzQuality + Insight.T8Quality + Insight.Af4Quality) / 5;
        }
    }
}

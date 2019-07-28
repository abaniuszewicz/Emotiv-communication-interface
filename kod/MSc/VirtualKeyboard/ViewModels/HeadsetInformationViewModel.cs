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

namespace VirtualKeyboard.ViewModels
{
    public class HeadsetInformationViewModel : PropertyChangedBase
    {
        private int _batteryLevel;
        private int _wirelessSignalLevel;
        private int _af3Quality, af4Quality, t7Quality, t8Quality, pzQuality;
        private int _totalQuality;

        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                _batteryLevel = value;
                NotifyOfPropertyChange(() => BatteryLevel);
            }
        }

        public int WirelessSignalLevel
        {
            get => _wirelessSignalLevel;
            set
            {
                _wirelessSignalLevel = value;
                NotifyOfPropertyChange(() => WirelessSignalLevel);
            }
        }

        public Dictionary<string, int> Sensors { get; set; } = new Dictionary<string, int>();

        public int Af3Quality
        {
            get => _af3Quality;
            set
            {
                _af3Quality = value;
                NotifyOfPropertyChange(() => Af3Quality);
            }
        }

        public int Af4Quality
        {
            get => af4Quality;
            set
            {
                af4Quality = value;
                NotifyOfPropertyChange(() => Af4Quality);
            }
        }

        public int T7Quality
        {
            get => t7Quality;
            set
            {
                t7Quality = value;
                NotifyOfPropertyChange(() => T7Quality);
            }
        }

        public int T8Quality
        {
            get => t8Quality;
            set
            {
                t8Quality = value;
                NotifyOfPropertyChange(() => T8Quality);
            }
        }

        public int PzQuality
        {
            get => pzQuality;
            set
            {
                pzQuality = value;
                NotifyOfPropertyChange(() => PzQuality);
            }
        }

        public int TotalQuality
        {
            get => _totalQuality;
            set
            {
                _totalQuality = value;
                NotifyOfPropertyChange(() => TotalQuality);
            }
        }

        public HeadsetInformationViewModel()
        {
            BindingOperations.EnableCollectionSynchronization(Sensors, new object());
        }

        public void Initialize()
        {
            SettingsViewModel.Insight.OnMentalCommandUpdate += Insight_OnMentalCommandUpdate;
            SettingsViewModel.Insight.OnDeviceInformationUpdate += Insight_OnDeviceInformationUpdate;

            SettingsViewModel.Insight.Subscribe(new List<Enums.StreamsEnum>() { Enums.StreamsEnum.com, Enums.StreamsEnum.dev });
        }

        private void Insight_OnDeviceInformationUpdate(DevDataSampleObject dev)
        {
            var list = dev.dev.ToList();
            BatteryLevel = Convert.ToInt32(list[0]) * 25; //to get percentage result
            WirelessSignalLevel = Convert.ToInt32(list[1]);

            if (!(list[2] is List<int> contactQuality) || contactQuality.Count < 5)
                return; //corrupted data

            //possible values: 0-4, multiply *25 to get 0-100 (percentage)
            Af3Quality = contactQuality[0] * 25;
            t7Quality = contactQuality[1] * 25;
            pzQuality = contactQuality[2] * 25;
            t8Quality = contactQuality[3] * 25;
            af4Quality = contactQuality[4] * 25;
            TotalQuality = (Af3Quality + T7Quality + PzQuality + T8Quality + Af4Quality) / 5;
        }

        private void Insight_OnMentalCommandUpdate(ComDataSampleObject com)
        {
            var list = com.com.ToList();
        }
    }
}

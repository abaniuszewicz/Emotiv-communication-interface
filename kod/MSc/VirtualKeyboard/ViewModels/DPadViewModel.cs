using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HeadsetController.Headset;

namespace VirtualKeyboard.ViewModels
{
    public class DPadViewModel : PropertyChangedBase
    {
        public Insight Insight { get; }
        public Models.Settings Settings { get; }

        public DPadViewModel(Models.Settings settings, Insight insight)
        {
            Insight = insight;
            Settings = settings;
        }
    }
}

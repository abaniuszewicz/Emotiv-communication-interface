using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Caliburn.Micro;
using HeadsetController.Headset;
using VirtualKeyboard.Models;
using Action = System.Action;

namespace VirtualKeyboard.ViewModels
{
    public class DPadViewModel : PropertyChangedBase
    {
        public Insight Insight { get; }
        public Settings Settings { get; }
        public KeyboardNavigator KeyboardNavigator { get; }

        public DPadViewModel(Settings settings, Insight insight)
        {
            Insight = insight;
            Settings = settings;
            KeyboardNavigator = new KeyboardNavigator(Insight, Settings);
        }
    }
}

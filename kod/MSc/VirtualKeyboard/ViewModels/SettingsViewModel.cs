using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using VirtualKeyboard.Properties;

namespace VirtualKeyboard.ViewModels
{
    public class SettingsViewModel : PropertyChangedBase
    {
        public Models.Settings Settings { get; set; }
    }
}

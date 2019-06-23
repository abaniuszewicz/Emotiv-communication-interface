using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;

namespace VirtualKeyboard.ViewModels
{
    public class KeyViewModel : PropertyChangedBase
    {
        public string Key { get; } = "A";

        public KeyViewModel(Key key)
        {
            //Key = key;
        }

        public KeyViewModel()
        {
            //TODO - only temporary as bootstrapper requires parameterless constructor
        }
    }
}

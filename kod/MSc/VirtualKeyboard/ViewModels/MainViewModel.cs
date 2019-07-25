using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace VirtualKeyboard.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        public KeyboardViewModel Keyboard { get; } = new KeyboardViewModel();
        public DPadViewModel DPad { get; } = new DPadViewModel();
    }
}

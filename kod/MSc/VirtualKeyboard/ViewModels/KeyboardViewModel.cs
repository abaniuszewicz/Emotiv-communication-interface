using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using VirtualKeyboard.Views.Controls;

namespace VirtualKeyboard.ViewModels
{
    public class KeyboardViewModel : PropertyChangedBase
    {
        private string _message;

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public KeyboardViewModel()
        {
        }

        public void Pressed(string key)
        {
            Message += key;
        }
    }
}

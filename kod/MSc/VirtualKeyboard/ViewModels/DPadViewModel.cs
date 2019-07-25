using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace VirtualKeyboard.ViewModels
{
    public class DPadViewModel : PropertyChangedBase
    {
        private double _powerUp, _powerRight, _powerDown, _powerLeft;

        public double PowerUp
        {
            get => _powerUp;
            set
            {
                _powerUp = value;
                NotifyOfPropertyChange(() => PowerUp);
            }
        }
        public double PowerRight
        {
            get => _powerRight;
            set
            {
                _powerRight = value;
                NotifyOfPropertyChange(() => PowerRight);
            }
        }
        public double PowerDown
        {
            get => _powerDown;
            set
            {
                _powerDown = value;
                NotifyOfPropertyChange(() => PowerDown);
            }
        }
        public double PowerLeft
        {
            get => _powerLeft;
            set
            {
                _powerLeft = value;
                NotifyOfPropertyChange(() => PowerLeft);
            }
        }

    }
}

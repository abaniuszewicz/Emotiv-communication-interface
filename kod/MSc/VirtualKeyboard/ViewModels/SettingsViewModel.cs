using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace VirtualKeyboard.ViewModels
{
    public class SettingsViewModel : PropertyChangedBase
    {
        private double _upThreshold;
        private double _rightThreshold;
        private double _downThreshold;
        private double _leftThreshold;
        private double _focusTime;

        public double UpThreshold
        {
            get => _upThreshold;
            set
            {
                _upThreshold = value; 
                NotifyOfPropertyChange(() => UpThreshold);
            }
        }

        public double RightThreshold
        {
            get => _rightThreshold;
            set
            {
                _rightThreshold = value; 
                NotifyOfPropertyChange(() => RightThreshold);
            }
        }

        public double DownThreshold
        {
            get => _downThreshold;
            set
            {
                _downThreshold = value; 
                NotifyOfPropertyChange(() => DownThreshold);
            }
        }

        public double LeftThreshold
        {
            get => _leftThreshold;
            set
            {
                _leftThreshold = value; 
                NotifyOfPropertyChange(() => LeftThreshold);
            }
        }

        public double FocusTime
        {
            get => _focusTime;
            set
            {
                _focusTime = value;
                NotifyOfPropertyChange(() => FocusTime);
            }
        }
    }
}

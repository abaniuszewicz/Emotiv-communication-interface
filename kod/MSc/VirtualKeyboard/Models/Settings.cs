using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Newtonsoft.Json;

namespace VirtualKeyboard.Models
{
    [DataContract]
    public class Settings : PropertyChangedBase
    {
        private double _upThreshold;
        private double _rightThreshold;
        private double _downThreshold;
        private double _leftThreshold;
        private double _selectThreshold;
        private int _focusTime;
        private bool _isOfflineModeEnabled;

        [DataMember]
        public double UpThreshold
        {
            get => _upThreshold;
            set
            {
                _upThreshold = value; 
                NotifyOfPropertyChange(() => UpThreshold);
            }
        }

        [DataMember]
        public double RightThreshold
        {
            get => _rightThreshold;
            set
            {
                _rightThreshold = value; 
                NotifyOfPropertyChange(() => RightThreshold);
            }
        }

        [DataMember]
        public double DownThreshold
        {
            get => _downThreshold;
            set
            {
                _downThreshold = value; 
                NotifyOfPropertyChange(() => DownThreshold);
            }
        }

        [DataMember]
        public double LeftThreshold
        {
            get => _leftThreshold;
            set
            {
                _leftThreshold = value; 
                NotifyOfPropertyChange(() => LeftThreshold);
            }
        }

        [DataMember]
        public double SelectThreshold
        {
            get => _selectThreshold;
            set
            {
                _selectThreshold = value;
                NotifyOfPropertyChange(() => SelectThreshold);
            }
        }

        [DataMember]
        public int FocusTime
        {
            get => _focusTime;
            set
            {
                _focusTime = value; 
                NotifyOfPropertyChange(() => FocusTime);
            }
        }

        [DataMember]
        public bool IsOfflineModeEnabled
        {
            get => _isOfflineModeEnabled;
            set
            {
                _isOfflineModeEnabled = value; 
                NotifyOfPropertyChange(() => IsOfflineModeEnabled);
            }
        }
    }
}

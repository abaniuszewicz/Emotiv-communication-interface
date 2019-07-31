using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;
using VirtualKeyboard.Views.Controls;

namespace VirtualKeyboard.ViewModels
{
    public class KeyboardViewModel : PropertyChangedBase
    {
        private string _message;

        public string Name => "Virtual Keyboard";
        public SpeechSynthesizer Synthesizer { get; set; }
        public SettingsViewModel SettingsViewModel { get; }
        public ConnectionViewModel ConnectionViewModel { get; }
        public HeadsetInformationViewModel HeadsetInformationViewModel { get; }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public KeyboardViewModel(SettingsViewModel settingsViewModel, ConnectionViewModel connectionViewModel)
        {
            SettingsViewModel = settingsViewModel;
            ConnectionViewModel = connectionViewModel;
            HeadsetInformationViewModel = new HeadsetInformationViewModel(ConnectionViewModel.Insight, SettingsViewModel.Settings);

            Synthesizer = new SpeechSynthesizer();
            Synthesizer.SelectVoiceByHints(VoiceGender.NotSet,
                VoiceAge.NotSet, 0,
                CultureInfo.GetCultureInfo("en-US"));
        }


        public void Pressed(IKey key)
        {
            if (key == null)
                return;

            switch (key.Key)
            {
                case "←":
                    if (Message.Length > 0)
                        Message = Message.Remove(Message.Length - 1);
                    break;
                case "↵":
                    Enter();
                    break;

                default:
                    Message += key.Key;
                    break;
            }
        }

        public void Enter()
        {
            Synthesizer.SpeakAsync(Message.ToLower());
            Message = string.Empty;
        }
    }
}

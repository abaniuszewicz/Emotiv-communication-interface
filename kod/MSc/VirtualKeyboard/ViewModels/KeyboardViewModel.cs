using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using VirtualKeyboard.Views.Controls;

namespace VirtualKeyboard.ViewModels
{
    public class KeyboardViewModel : PropertyChangedBase
    {
        private string _message;

        public string Name => "Virtual Keyboard";
        public SpeechSynthesizer Synthesizer { get; set; }
        public ObservableCollection<string> MessageHistory { get; } = new ObservableCollection<string>();

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
            Synthesizer = new SpeechSynthesizer();
            Synthesizer.SelectVoiceByHints(VoiceGender.NotSet,
                VoiceAge.NotSet,
                0,
                CultureInfo.GetCultureInfo("en-US"));
        }

        public void Pressed(string key)
        {
            Message += key;
        }

        public void Enter()
        {
            Synthesizer.SpeakAsync(Message.ToLower());
            MessageHistory.Insert(0, $"{DateTime.Now}: {Message}");
            NotifyOfPropertyChange(() => MessageHistory);
            Message = string.Empty;
        }
    }
}

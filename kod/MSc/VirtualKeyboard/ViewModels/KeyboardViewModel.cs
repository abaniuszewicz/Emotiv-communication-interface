using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Caliburn.Micro;
using VirtualKeyboard.Views.Controls;

namespace VirtualKeyboard.ViewModels
{
    public class KeyboardViewModel : PropertyChangedBase
    {
        private string _message = string.Empty;

        public string Name => "Virtual Keyboard";
        public SpeechSynthesizer Synthesizer { get; set; }
        public SettingsViewModel SettingsViewModel { get; }
        public ConnectionViewModel ConnectionViewModel { get; }
        public HeadsetInformationViewModel HeadsetInformationViewModel { get; }
        public List<KeyView> Keys { get; } = new List<KeyView>();

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

            HeadsetInformationViewModel.DPadViewModel.KeyboardNavigator.OnUpCommand += () => Navigate(FocusNavigationDirection.Up);
            HeadsetInformationViewModel.DPadViewModel.KeyboardNavigator.OnDownCommand += () => Navigate(FocusNavigationDirection.Down);
            HeadsetInformationViewModel.DPadViewModel.KeyboardNavigator.OnLeftCommand += () => Navigate(FocusNavigationDirection.Left);
            HeadsetInformationViewModel.DPadViewModel.KeyboardNavigator.OnRightCommand += () => Navigate(FocusNavigationDirection.Right);
            HeadsetInformationViewModel.DPadViewModel.KeyboardNavigator.OnSelectCommand += () => Keys.First(k => k.IsSelected).InvokePressed();

            var keys = new[] { "Z", "←", "M", "3", ".", "X", "O", "G", "4", ",", "J", "C", "T", "D", "P", "5", "2", "Y", "R", "N", "E", "A", "S", "F", "0", "↵", "Q", "U", "I", "L", "B", "6", "␣", "K", "H", "V", "7", "9", "W", "8", "1"};
            foreach (var k in keys)
            {
                var key = new KeyView() { Key = k };
                key.Pressed += Key_Pressed;
                Keys.Add(key);
            }
            var sendKey = new KeyView() { Key = "SEND" };
            sendKey.Pressed += (s, e) => Send();
            Keys.Add(sendKey);
            SelectCenterKey();
        }

        private void Key_Pressed(object sender, EventArgs e)
        {
            if (!(sender is IKey key))
                return;

            switch (key.Key)
            {
                case "←":
                    if (Message.Length > 0)
                        Message = Message.Remove(Message.Length - 1);
                    break;

                case "↵":
                    Message += Environment.NewLine;
                    break;

                case "␣":
                    Message += " ";
                    break;

                default:
                    Message += key.Key;
                    break;
            }

            ClearSelectedKeys();
            SelectCenterKey();
        }

        private void Navigate(FocusNavigationDirection direction)
        {
            var selectedKey = Keys.FirstOrDefault(k => k.IsSelected);
            if (selectedKey == null)
                return;

            ClearSelectedKeys();
            selectedKey.Focus();

            if (direction == FocusNavigationDirection.Down &&  (selectedKey.Key == "0" || selectedKey.Key == "6" || selectedKey.Key == "7"))
                Keys.First(k => k.Key == "SEND").IsSelected = true;
            else if (direction == FocusNavigationDirection.Right && (selectedKey.Key == "1" || selectedKey.Key == "8" || selectedKey.Key == "7"))
                Keys.First(k => k.Key == "SEND").IsSelected = true;
            else
                selectedKey.MoveFocus(direction);

            selectedKey.IsSelected = false; //clear previous selection
        }

        public void Send()
        {
            Synthesizer.SpeakAsync(Message.ToLower());
            Message = string.Empty;
            ClearSelectedKeys();
            SelectCenterKey();
        }

        private void SelectCenterKey() => Keys.First(k => k.Key == "E").IsSelected = true;
        private void ClearSelectedKeys() => Keys.FindAll(k => k.IsSelected).ForEach(k => k.IsSelected = false);
    }
}

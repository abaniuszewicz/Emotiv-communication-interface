using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using Caliburn.Micro;
using HeadsetController.Headset;

namespace VirtualKeyboard.ViewModels
{
    public class MessengerViewModel : PropertyChangedBase
    {
        private readonly Insight _insight;
        private string _request;

        public string Name => "Messenger";
        public ObservableCollection<string> MessageHistory { get; } = new ObservableCollection<string>();

        public string Request
        {
            get => _request;
            set
            {
                _request = value; 
                NotifyOfPropertyChange(() => Request);
            }
        }

        public MessengerViewModel(Insight insight)
        {
            _insight = insight;
            BindingOperations.EnableCollectionSynchronization(MessageHistory, new object());
            _insight.OnResponse += Received;
            _insight.OnRequest += Sent;
        }

        public void Send()
        {
            _insight.SendRequest(Request);
            Request = string.Empty;
        }

        private void Received(string message)
        {
            MessageHistory.Add($"{DateTime.Now:dd-MM-yyyy hh:mm:ss.ffff} received:{Environment.NewLine}{message}");
            NotifyOfPropertyChange(() => MessageHistory);
        }

        public void Sent(string message)
        {
            MessageHistory.Add($"{DateTime.Now:dd-MM-yyyy hh:mm:ss.ffff} sent:{Environment.NewLine}{message}");
            NotifyOfPropertyChange(() => MessageHistory);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HeadsetController.Headset;
using HeadsetController.Services;
using HeadsetController.Services.Communication.Requests;
using HeadsetController.Services.Communication.Requests.Authentication;
using HeadsetController.Services.Communication.Requests.DataSubscription;
using HeadsetController.Services.Communication.Requests.Parameters;
using HeadsetController.Services.Communication.Requests.Sessions;
using Newtonsoft.Json.Linq;

namespace PoC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged 
    {
        public Insight Insight { get; } = new Insight();
        private string session = string.Empty;
        private string _sendText;
        private string _receiveText;


        public string SendText
        {
            get => _sendText;
            set
            {
                _sendText = value;
                OnPropertyChanged();
            }
        }

        public string ReceiveText
        {
            get => _receiveText;
            set
            {
                _receiveText = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Insight.OnRequest += msg => SendText += Environment.NewLine + msg;
            Insight.OnResponse += msg =>
            {
                if (string.IsNullOrEmpty(session))
                {
                    var jObj = JObject.Parse(msg);
                    var token = jObj.SelectToken("result.id");
                    session = token == null ? string.Empty : token.ToObject<string>();
                }

                ReceiveText += Environment.NewLine + msg;
            };

            SendMessage();
        }

        private async void SendMessage()
        {
            var id = 1;
            var clientId = "BQhJjFmrJVcWqLmyU9XCIKmNdUOMrTG1eo9RNYwu";
            var clientSecret = "fCp33VZDrAj8zduFjJJvYWBaePAupZyBqzszdQfG9DlVPiVX87xPRkQDuPXNc7QAef2d1sJi6rMbO5SeoM14RYoP6uJRMxigk2dirdIduDg98EIKifOcmDqA6RfX5pNs";
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhcHBJZCI6ImNvbS5hYmFuaXVzemV3aWN6LmljdF9tYXN0ZXIiLCJhcHBWZXJzaW9uIjoiMS4wIiwiZXhwIjoxNTYwNzIwNDQzLCJsaWNlbnNlSWQiOiJjZjg3MjEyOS02NmQ5LTRlMzItODk3MC1lNDc1YWJmZjg2YTUiLCJuYmYiOjE1NjA0NjEyNDMsInVzZXJJZCI6ImIxZDM5MTVkLTdhODQtNDljNi04NDIzLTY3Mzc1MTYzYTU0MiIsInVzZXJuYW1lIjoiYWJhbml1c3pld2ljeiIsInZlcnNpb24iOiIyLjAifQ==.BTl8SxEwlKuBEYpjaKMf7bvAJjosIK2aMCxT/hMM9CI=";

            await Send(new GetUserLoginRequest(id++));
            await Send(new RequestAccessRequest(id++, new RequestAccessParameter(clientId, clientSecret)));
            await Send(new QuerySessionRequest(id++, new QuerySessionsParameter(token)));
            await Send(new CreateSessionRequest(id++, new CreateSessionParameter(token, "open")));
            await Send(new SubscribeRequest(id++, new SubscribeParameter(token, session, new[] {"mot"})));
            await Send(new UnsubscribeRequest(id++, new UnsubscribeParameter(token, session, new[] {"mot"})));
        }

        private async Task Send(IRequest request)
        {
            await Task.Run(() =>
            {
                Insight.SendRequest(request);
                Thread.Sleep(5000);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using HeadsetController.Headset;
using HeadsetController.Services.API.Requests;
using HeadsetController.Services.API.Requests.Information;
using HeadsetController.Services.API.Responses.Information;
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
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhcHBJZCI6ImNvbS5hYmFuaXVzemV3aWN6LmljdF9tYXN0ZXIiLCJhcHBWZXJzaW9uIjoiMS4wIiwiZXhwIjoxNTYxMjEwODc4LCJsaWNlbnNlSWQiOiJjZjg3MjEyOS02NmQ5LTRlMzItODk3MC1lNDc1YWJmZjg2YTUiLCJuYmYiOjE1NjA5NTE2NzgsInVzZXJJZCI6ImIxZDM5MTVkLTdhODQtNDljNi04NDIzLTY3Mzc1MTYzYTU0MiIsInVzZXJuYW1lIjoiYWJhbml1c3pld2ljeiIsInZlcnNpb24iOiIyLjAifQ==.85c9orcJnjBhN4t0KzUOuWA7LwnCLRn6A5uReVTJejI=";

            //await Send(new GetCortexInfoRequest(id++));

            var co =  Insight.SendRequest<GetCortexInfoResponse>(new GetCortexInfoRequest(id++));
            var co1 = Insight.SendRequest<GetCortexInfoResponse>(new GetCortexInfoRequest(id++));
            var co2 = Insight.SendRequest<GetCortexInfoResponse>(new GetCortexInfoRequest(id++));
            var co3 = Insight.SendRequest<GetCortexInfoResponse>(new GetCortexInfoRequest(id++));
            var co4 = await Insight.SendRequest<GetCortexInfoResponse>(new GetCortexInfoRequest(id++));
            var co5 = await Insight.SendRequest<GetCortexInfoResponse>(new GetCortexInfoRequest(id++));



            //await Send(new GetUserLoginRequest(id++));
            //await Send(new RequestAccessRequest(id++, new RequestAccessParameter(clientId, clientSecret)));
            //await Send(new QueryHeadsetsRequest(id++, new QueryHeadsetsParameter()));
            //await Send(new CreateSessionRequest(id++, new CreateSessionParameter(token, Enums.StatusCreateEnum.open)));
            //await Send(new SubscribeRequest(id++, new SubscribeParameter(token, session, new List<Enums.StreamsEnum>() {Enums.StreamsEnum.mot})));
            //await Send(new UnsubscribeRequest(id++, new UnsubscribeParameter(token, session, new List<Enums.StreamsEnum>() {Enums.StreamsEnum.mot})));
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

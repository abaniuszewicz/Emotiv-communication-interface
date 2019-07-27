using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using HeadsetController.Headset;
using HeadsetController.Services.API.Requests;
using HeadsetController.Services.API.Requests.Authentication;
using HeadsetController.Services.API.Requests.BCI;
using HeadsetController.Services.API.Requests.DataSubscription;
using HeadsetController.Services.API.Requests.Headsets;
using HeadsetController.Services.API.Requests.Information;
using HeadsetController.Services.API.Requests.Sessions;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.Authentication;
using HeadsetController.Services.API.Responses.BCI;
using HeadsetController.Services.API.Responses.DataSubscriptions;
using HeadsetController.Services.API.Responses.Headsets;
using HeadsetController.Services.API.Responses.Information;
using HeadsetController.Services.API.Responses.Sessions;
using HeadsetController.Services.API.Utils;
using Newtonsoft.Json.Linq;

namespace PoC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged 
    {
        #region Fields

        private string session = string.Empty;
        private string _sendText;
        private string _receiveText;

        #endregion

        #region Properties

        public Insight Insight { get; } = new Insight();

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

        #endregion

        #region Constructor

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
            Insight.OnMentalCommandUpdate += o =>
            {

            };

            SendMessage();
        }

        #endregion

        private async void SendMessage()
        {
            await Insight.Authorize();
            await Insight.CreateSession();
            await Insight.LoadProfile("Adam");
            await SubscribeMentalCommandStream();
        }

        private async Task SubscribeMentalCommandStream()
        {
            var response = await Insight.SendRequest<SubscribeResponse>(new SubscribeRequest(new SubscribeParameter(Insight.CortexToken, Insight.SessionObject?.id, new List<Enums.StreamsEnum>() {Enums.StreamsEnum.com})));
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

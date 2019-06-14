using HeadsetController.Services;
using HeadsetController.Services.Communication.Requests;
using System;

namespace HeadsetController.Headset
{
    public abstract class Headset
    {
        private readonly string _cortexServiceUrl = "wss://localhost:6868";

        public event Action<string> OnResponse;
        public event Action<string> OnRequest;

        internal WebSocket WebSocket { get; private set; }
        internal JsonParser Parser { get; } = new JsonParser();

        protected Headset()
        {
            SetupWebSocket();
        }

        private void SetupWebSocket()
        {
            WebSocket = new WebSocket(_cortexServiceUrl);
            WebSocket.OnMessage += msg => OnResponse?.Invoke(msg);
            WebSocket.Connect();
        }

        public void SendRequest(IRequest request)
        {
            var message = Parser.Serialize(request);
            OnRequest?.Invoke(message);
            WebSocket.Send(message);
        }

        public void SendRequest(string request)
        {
            OnRequest?.Invoke(request);
            WebSocket.Send(request);
        }

        private string Serialize(object obj) => Parser.Serialize(obj);
        private T Deserialize<T>(string str) => Parser.Deserialize<T>(str);
    }
}

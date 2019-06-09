using System;

namespace HeadsetController.Services
{
    internal class WebSocket
    {
        private readonly string _cortexServiceUrl = "wss://localhost:6868";
        private readonly WebSocketSharp.WebSocket _webSocket;

        internal event Action OnOpen;
        internal event Action OnClose;
        internal event Action<string> OnMessage;
        internal event Action<string> OnError;

        internal WebSocket()
        {
            _webSocket = new WebSocketSharp.WebSocket(_cortexServiceUrl);

            _webSocket.OnOpen += (s, e) => OnOpen?.Invoke();
            _webSocket.OnClose += (s, e) => OnClose?.Invoke();
            _webSocket.OnMessage += (s, e) => OnMessage?.Invoke(e.Data);
            _webSocket.OnError += (s, e) => OnError?.Invoke(e.Message);
        }

        internal void Connect() => _webSocket.Connect();
        internal void Disconnect() => _webSocket.Close();
        internal void Send(string message) => _webSocket.Send(message);
    }
}

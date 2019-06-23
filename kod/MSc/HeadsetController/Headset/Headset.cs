using HeadsetController.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Threading.Tasks;
using HeadsetController.Services.API.Requests;
using HeadsetController.Services.API.Requests.Headsets;
using HeadsetController.Services.API.Requests.Information;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.Information;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadsetController.Headset
{
    public abstract class Headset
    {
        private const string _cortexServiceUrl = "wss://localhost:6868";

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
            WebSocket.OnMessage += msg => OnResponse?.Invoke(JToken.Parse(msg).ToString(Formatting.Indented));
            WebSocket.Connect();
        }

        public void SendRequest(IRequest request)
        {
            var msg = Parser.Serialize(request);
            OnRequest?.Invoke(msg);
            WebSocket.Send(msg);
        }

        public async Task<Response<T>> SendRequest<T>(IRequest request) where T : IResult
        {
            var tcs = new TaskCompletionSource<Response<T>>();

            void WaitResponseMatch(string msg)
            {
                if (Parser.GetTokenAsString(msg, "id") != request.id.ToString())
                    return;

                OnResponse -= WaitResponseMatch; //self-unsubscribe after match
                tcs.SetResult(Parser.Deserialize<Response<T>>(msg));
            }
            OnResponse += WaitResponseMatch;
            SendRequest(request);

            return await tcs.Task;
        }

        public void SendRequest(string request)
        {
            OnRequest?.Invoke(request);
            WebSocket.Send(request);
        }
    }
}

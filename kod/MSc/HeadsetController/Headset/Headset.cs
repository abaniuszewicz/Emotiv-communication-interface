using HeadsetController.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly string _cortexServiceUrl = "wss://localhost:6868";

        public event Action<string> OnResponse;
        public event Action<string> OnRequest;

        private readonly List<IRequest> _list = new List<IRequest>();

        internal WebSocket WebSocket { get; private set; }
        internal JsonParser Parser { get; } = new JsonParser();

        protected Headset()
        {
            SetupWebSocket();
        }

        private void SetupWebSocket()
        {
            WebSocket = new WebSocket(_cortexServiceUrl);
            WebSocket.OnMessage += msg =>
            {
                OnResponse?.Invoke(JToken.Parse(msg).ToString(Formatting.Indented));

                var id = (int)JObject.Parse(msg).GetValue("id");
                var request = (GetCortexInfoRequest)_list.FirstOrDefault(r => r.id == id);

                //var response = JsonConvert.DeserializeObject(msg, request.responseType);

                var co = Parser.Deserialize<Response<GetCortexInfoResponse>>(msg);
            };
            WebSocket.Connect();
        }

        public void SendRequest(IRequest request)
        {
            _list.Add(request);
            var message = Parser.Serialize(request);
            OnRequest?.Invoke(message);
            WebSocket.Send(message);
        }

        public void SendRequest(string request)
        {
            OnRequest?.Invoke(request);
            WebSocket.Send(request);
        }
    }
}

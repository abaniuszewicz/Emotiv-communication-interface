﻿using HeadsetController.Services;
using System;
using System.Threading.Tasks;
using HeadsetController.Services.API.Requests;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.DataSubscriptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadsetController.Headset
{
    public abstract class Headset
    {
        #region Fields

        private const string _cortexServiceUrl = "wss://localhost:6868";

        #endregion

        #region Events

        public event Action<string> OnResponse;
        public event Action<string> OnRequest;
        public event Action<DataSampleObject> OnMentalCommandUpdate;

        #endregion

        #region Properties

        internal WebSocket WebSocket { get; } = new WebSocket(_cortexServiceUrl);
        internal JsonParser Parser { get; } = new JsonParser();

        #endregion

        #region Constructor

        protected Headset()
        {
            WebSocket.OnMessage += ReadResponse;
            WebSocket.Connect();
        }

        #endregion

        #region Requests

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

        #endregion

        #region Responses

        private void ReadResponse(string message)
        {
            var jObject = JObject.Parse(message);
            if (!jObject.ContainsKey("id") && jObject.ContainsKey("com"))
            {
                OnMentalCommandUpdate?.Invoke(Parser.Deserialize<DataSampleObject>(message));
                return;
            }

            OnResponse?.Invoke(jObject.ToString(Formatting.Indented));
        }

        #endregion
    }
}

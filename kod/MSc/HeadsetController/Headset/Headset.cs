using HeadsetController.Services;
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
        public event Action<ComDataSampleObject> OnMentalCommandUpdate;
        public event Action<DevDataSampleObject> OnDeviceInformationUpdate;
        public event Action<FacDataSampleObject> OnFacialExpressionUpdate;

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

        private void SendRequest(IRequest request)
        {
            var msg = Parser.Serialize(request);
            OnRequest?.Invoke(msg);
            WebSocket.Send(msg);
        }

        public async Task<Response<T>> SendRequest<T>(IRequest request) where T : IResult
        {
            var tcs = new TaskCompletionSource<Response<T>>();

            void WaitResponseMatch(string response)
            {
                if (Parser.GetTokenAsString(response, "id") != request.id.ToString())
                    return;

                OnResponse -= WaitResponseMatch; //unsubscribe after match
                tcs.SetResult(Parser.Deserialize<Response<T>>(response));
            }
            OnResponse += WaitResponseMatch;
            SendRequest(request);

            return await tcs.Task;
        }

        public async Task<string> SendRequestRaw(IRequest request)
        {
            var tcs = new TaskCompletionSource<string>();

            void WaitResponseMatch(string response)
            {
                if (Parser.GetTokenAsString(response, "id") != request.id.ToString())
                    return;

                OnResponse -= WaitResponseMatch; //unsubscribe after match
                tcs.SetResult(response);
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
            if (!jObject.ContainsKey("id"))
            {
                //subscribe data sample arrived
                if (jObject.ContainsKey("com")) //mental command update
                    OnMentalCommandUpdate?.Invoke(Parser.Deserialize<ComDataSampleObject>(message));
                else if (jObject.ContainsKey("dev")) //device information update
                    OnDeviceInformationUpdate?.Invoke(Parser.Deserialize<DevDataSampleObject>(message));
                else if (jObject.ContainsKey("fac")) //facial expression update
                    OnFacialExpressionUpdate?.Invoke(Parser.Deserialize<FacDataSampleObject>(message));
                return;
            }

            OnResponse?.Invoke(jObject.ToString(Formatting.Indented));
        }

        #endregion
    }
}

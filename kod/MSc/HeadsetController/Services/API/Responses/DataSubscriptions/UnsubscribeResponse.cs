using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.DataSubscriptions
{
    public class UnsubscribeResponse : IResult
    {
        public IEnumerable<object> success { get; }
        public IEnumerable<object> failure { get; }
        public string streamName { get; }
        public int code { get; }
        public string message { get; }

        [JsonConstructor]
        private UnsubscribeResponse(IEnumerable<object> success, IEnumerable<object> failure, string streamName, int code, string message)
        {
            this.success = success;
            this.failure = failure;
            this.streamName = streamName;
            this.code = code;
            this.message = message;
        }
    }
}
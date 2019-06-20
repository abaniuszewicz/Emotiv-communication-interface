using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.DataSubscriptions
{
    public class SubscribeResponse : IResult
    {
        public IEnumerable<object> success { get; }
        public IEnumerable<object> failure { get; }
        public string streamName { get; }
        public IEnumerable<string> cols { get; }
        public string sid { get; }
        public int code { get; }
        public string message { get; }

        [JsonConstructor]
        private SubscribeResponse(IEnumerable<object> success, IEnumerable<object> failure, string streamName, IEnumerable<string> cols, string sid, int code, string message)
        {
            this.success = success;
            this.failure = failure;
            this.streamName = streamName;
            this.cols = cols;
            this.sid = sid;
            this.code = code;
            this.message = message;
        }
    }
}

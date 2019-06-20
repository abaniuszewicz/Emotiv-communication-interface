using System.Collections.Generic;
using System.Linq;
using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.DataSubscription
{
    public class UnsubscribeParameter
    {
        public string cortexToken { get; }
        public string session { get; }
        public IEnumerable<string> streams { get; }

        public UnsubscribeParameter(string cortexToken, string session, IEnumerable<Enums.StreamsEnum> streams)
        {
            this.cortexToken = cortexToken;
            this.session = session;
            this.streams = streams.Select(s => s.ToString());
        }
    }
}

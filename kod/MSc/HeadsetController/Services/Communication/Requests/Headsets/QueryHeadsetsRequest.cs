using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Headsets
{
    public class QueryHeadsetsRequest : Request
    {
        public override string Method { get; } = "queryHeadsets";
        [JsonProperty("params")]
        public QueryHeadsetParameter Parameter { get; }

        public QueryHeadsetsRequest(int id, QueryHeadsetParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class QuerySessionRequest : Request
    {
        public override string Method { get; } = "querySessions";
        [JsonProperty("params")]
        public QuerySessionsParameter Parameter { get; }

        public QuerySessionRequest(int id, QuerySessionsParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

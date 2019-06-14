
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class QuerySessionsParameter
    {
        [JsonProperty("cortexToken")]
        public string CortexToken { get; }

        public QuerySessionsParameter(string cortexToken)
        {
            CortexToken = cortexToken;
        }
    }
}

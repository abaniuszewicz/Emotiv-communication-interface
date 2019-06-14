using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class InjectMarkerRequest : Request
    {
        public override string Method { get; } = "injectMarker";
        [JsonProperty("params")]
        public InjectMarkerParameter Parameter { get; }

        public InjectMarkerRequest(int id, InjectMarkerParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

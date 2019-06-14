using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class GetCurrentProfileRequest : Request
    {
        public override string Method { get; } = "getCurrentProfile";
        [JsonProperty("params")]
        public GetCurrentProfileParameter Parameter { get; }

        public GetCurrentProfileRequest(int id, GetCurrentProfileParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class SetupProfileRequest : Request
    {
        public override string Method { get; } = "setupProfile";
        [JsonProperty("params")]
        public SetupProfileParameter Parameter { get; }

        public SetupProfileRequest(int id, SetupProfileParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

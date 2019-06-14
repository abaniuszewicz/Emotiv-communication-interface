using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class MentalCommandActionLevelRequest : Request
    {
        public override string Method { get; } = "mentalCommandActionLevel";
        [JsonProperty("params")]
        public MentalCommandActionLevelParameter Parameter { get; }

        public MentalCommandActionLevelRequest(int id, MentalCommandActionLevelParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

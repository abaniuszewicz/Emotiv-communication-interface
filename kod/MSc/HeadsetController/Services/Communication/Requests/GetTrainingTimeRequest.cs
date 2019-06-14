using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class GetTrainingTimeRequest : Request
    {
        public override string Method { get; } = "getTrainingTime";
        [JsonProperty("params")]
        public GetTrainingTimeParameter Parameter { get; }

        public GetTrainingTimeRequest(int id, GetTrainingTimeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

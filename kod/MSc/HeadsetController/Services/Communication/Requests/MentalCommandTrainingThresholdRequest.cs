using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class MentalCommandTrainingThresholdRequest : Request
    {
        public override string Method { get; } = "mentalCommandTrainingThreshold";
        [JsonProperty("params")]
        public MentalCommandTrainingThresholdParameter Parameter { get; }

        public MentalCommandTrainingThresholdRequest(int id, MentalCommandTrainingThresholdParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

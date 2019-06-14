using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class MentalCommandActionSensitivityRequest : Request
    {
        public override string Method { get; } = "mentalCommandActionSensitivity";
        [JsonProperty("params")]
        public MentalCommandActionSensitivityParameter Parameter { get; }

        public MentalCommandActionSensitivityRequest(int id, MentalCommandActionSensitivityParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

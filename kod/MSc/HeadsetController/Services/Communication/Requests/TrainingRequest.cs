using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class TrainingRequest : Request
    {
        public override string Method { get; } = "training";
        [JsonProperty("params")]
        public TrainingParameter Parameter { get; }

        public TrainingRequest(int id, TrainingParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

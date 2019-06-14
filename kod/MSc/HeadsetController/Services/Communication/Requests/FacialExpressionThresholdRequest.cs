using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class FacialExpressionThresholdRequest : Request
    {
        public override string Method { get; } = "facialExpressionThreshold";
        [JsonProperty("params")]
        public FacialExpressionThresholdParameter Parameter { get; }

        public FacialExpressionThresholdRequest(int id, FacialExpressionThresholdParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

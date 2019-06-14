using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class ConfigMappingRequest : Request
    {
        public override string Method { get; } = "configMapping";
        [JsonProperty("params")]
        public ConfigMappingParameter Parameter { get; }

        public ConfigMappingRequest(int id, ConfigMappingParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

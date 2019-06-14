using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class DecryptDataRequest : Request
    {
        public override string Method { get; } = "decryptData";
        [JsonProperty("params")]
        public DecryptDataParameter Parameter { get; }

        public DecryptDataRequest(int id, DecryptDataParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

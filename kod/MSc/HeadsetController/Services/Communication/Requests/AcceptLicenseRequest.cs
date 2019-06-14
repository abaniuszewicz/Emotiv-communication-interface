using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class AcceptLicenseRequest : Request
    {
        public override string Method { get; } = "acceptLicense";
        [JsonProperty("params")]
        public AcceptLicenseParameter Parameter { get; }

        public AcceptLicenseRequest(int id, AcceptLicenseParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class GetLicenseInfoRequest : Request
    {
        public override string Method { get; } = "getLicenseInfo";
        [JsonProperty("params")]
        public GetLicenseInfoParameter Parameter { get; }

        public GetLicenseInfoRequest(int id, GetLicenseInfoParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Information
{
    public class GetCortexInfoResponse : IResult
    {
        public string buildDate { get; }
        public string buildNumber { get; }
        public string version { get; }

        [JsonConstructor]
        private GetCortexInfoResponse(string buildDate, string buildNumber, string version)
        {
            this.buildDate = buildDate;
            this.buildNumber = buildNumber;
            this.version = version;
        }
    }
}

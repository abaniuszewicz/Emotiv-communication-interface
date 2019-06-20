using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Markers
{
    public class InjectMarkerResponse : IResult
    {
        public string recordId { get; }
        public string sessionId { get; }
        public MarkerObject marker { get; }

        [JsonConstructor]
        private InjectMarkerResponse(string recordId, string sessionId, MarkerObject marker)
        {
            this.recordId = recordId;
            this.sessionId = sessionId;
            this.marker = marker;
        }
    }
}

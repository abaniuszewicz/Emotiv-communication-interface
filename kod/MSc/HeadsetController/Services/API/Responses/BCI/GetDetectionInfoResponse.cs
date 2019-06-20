using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.BCI
{
    public class GetDetectionInfoResponse : IResult
    {
        public IEnumerable<string> actions { get; }
        public IEnumerable<string> controls { get; }
        public IEnumerable<string> events { get; }
        public IEnumerable<string> signature { get; }

        [JsonConstructor]
        private GetDetectionInfoResponse(IEnumerable<string> actions, IEnumerable<string> controls, IEnumerable<string> events)
        {
            this.actions = actions;
            this.controls = controls;
            this.events = events;
            this.events = events;
        }
    }
}
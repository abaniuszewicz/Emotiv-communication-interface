using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.AdvancedBCI
{
    public class MentalCommandActiveActionResponse : IResult
    {
        public IEnumerable<string> actions { get; }
        public string message { get; }

        [JsonConstructor]
        private MentalCommandActiveActionResponse(IEnumerable<string> actions, string message)
        {
            this.actions = actions;
            this.message = message;
        }
    }
}
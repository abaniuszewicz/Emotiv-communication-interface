using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.AdvancedBCI
{
    public class MentalCommandBrainMapResponse : IResult
    {
        public string action { get; }
        public IEnumerable<double> coordinates { get; }

        [JsonConstructor]
        private MentalCommandBrainMapResponse(string action, IEnumerable<double> coordinates)
        {
            this.action = action;
            this.coordinates = coordinates;
        }
    }
}
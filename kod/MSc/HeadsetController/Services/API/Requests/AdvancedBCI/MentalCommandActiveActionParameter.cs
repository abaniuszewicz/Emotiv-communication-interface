using System.Collections.Generic;
using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActiveActionParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string profile { get; set; }
        public string session { get; set; }
        public IEnumerable<string> actions { get; set; }

        public MentalCommandActiveActionParameter(string cortexToken, Enums.StatusGetSetEnum status)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
        }
    }
}

using System.Collections.Generic;
using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActionSensitivityParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string profile { get; set; }
        public string session { get; set; }
        public IEnumerable<string> values { get; set; }

        public MentalCommandActionSensitivityParameter(string cortexToken, Enums.StatusGetSetEnum status)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
        }
    }
}

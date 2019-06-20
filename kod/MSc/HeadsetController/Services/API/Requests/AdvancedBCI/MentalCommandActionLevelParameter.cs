using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActionLevelParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string profile { get; set; }
        public string session { get; set; }
        public int? level { get; set; }

        public MentalCommandActionLevelParameter(string cortexToken, Enums.StatusGetSetEnum status)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
        }
    }
}

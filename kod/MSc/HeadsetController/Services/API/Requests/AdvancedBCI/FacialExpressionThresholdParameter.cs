using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class FacialExpressionThresholdParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string action { get; }
        public string profile { get; set; }
        public string session { get; set; }
        public int value { get; set; }

        public FacialExpressionThresholdParameter(string cortexToken, Enums.StatusGetSetEnum status, string action)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
            this.action = action;
        }
    }
}

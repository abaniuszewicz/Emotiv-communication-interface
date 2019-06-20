using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class GetTrainedSignatureActionsParameter
    {
        public string cortexToken { get; }
        public string detection { get; }
        public string profile { get; set; }
        public string session { get; set; }

        public GetTrainedSignatureActionsParameter(string cortexToken, Enums.DetectionEnum detection)
        {
            this.cortexToken = cortexToken;
            this.detection = detection.ToString();
        }
    }
}

using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class GetTrainingTimeParameter
    {
        public string cortexToken { get; }
        public string detection { get; }
        public string session { get; }

        public GetTrainingTimeParameter(string cortexToken, Enums.DetectionEnum detection, string session)
        {
            this.cortexToken = cortexToken;
            this.detection = detection.ToString();
            this.session = session;
        }
    }
}

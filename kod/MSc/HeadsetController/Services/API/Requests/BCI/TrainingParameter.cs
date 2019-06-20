using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.BCI
{
    public class TrainingParameter
    {
        public string cortexToken { get; }
        public string session { get; }
        public string detection { get; }
        public string status { get; }
        public string action { get; }

        public TrainingParameter(string cortexToken, string session, Enums.DetectionEnum detection, string status, string action)
        {
            this.cortexToken = cortexToken;
            this.session = session;
            this.detection = detection.ToString();
            this.status = status;
            this.action = action;
        }
    }
}

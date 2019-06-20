using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.BCI
{
    public class GetDetectionInfoParameter
    {
        public string detection { get; }

        public GetDetectionInfoParameter(Enums.DetectionEnum detection)
        {
            this.detection = detection.ToString();
        }
    }
}

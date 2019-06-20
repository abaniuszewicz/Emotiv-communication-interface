using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.BCI
{
    public class SetupProfileParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string profile { get; }
        public string headset { get; set; }
        public string newProfileName { get; set; }

        public SetupProfileParameter(string cortexToken, Enums.StatusSetupEnum status, string profile)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
            this.profile = profile;
        }
    }
}

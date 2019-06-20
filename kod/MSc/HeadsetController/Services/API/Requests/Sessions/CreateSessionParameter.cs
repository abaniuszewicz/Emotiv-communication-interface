using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.Sessions
{
    public class CreateSessionParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string headset { get; set; }

        public CreateSessionParameter(string cortexToken, Enums.StatusCreateEnum status)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
        }
    }
}

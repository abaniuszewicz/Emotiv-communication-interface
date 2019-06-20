using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.Sessions
{
    public class UpdateSessionParameter
    {
        public string cortexToken { get; }
        public string session { get; }
        public string status { get; }

        public UpdateSessionParameter(string cortexToken, string session, Enums.StatusUpdateEnum status)
        {
            this.cortexToken = cortexToken;
            this.session = session;
            this.status = status.ToString();
        }
    }
}

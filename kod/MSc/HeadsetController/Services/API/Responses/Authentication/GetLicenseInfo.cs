using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class GetLicenseInfo : IResult
    {
        public object license { get; }
        public bool isOnline { get; }

        [JsonConstructor]
        private GetLicenseInfo(object license, bool isOnline)
        {
            this.license = license;
            this.isOnline = isOnline;
        }
    }
}
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class GetLicenseInfoRequest : Request
    {
        public override string Method { get; } = "getLicenseInfo";
        public GetLicenseInfoParameter @params { get; }

        public GetLicenseInfoRequest(int id, GetLicenseInfoParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GetLicenseInfoRequest : Request
    {
        public override string method { get; } = "getLicenseInfo";
        public GetLicenseInfoParameter @params { get; }

        public GetLicenseInfoRequest(GetLicenseInfoParameter parameter)
        {
            @params = parameter;
        }
    }
}

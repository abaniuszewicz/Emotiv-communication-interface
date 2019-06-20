namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GetLicenseInfoParameter
    {
        public string cortexToken { get; }

        public GetLicenseInfoParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}
namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GetUserInformationParameter
    {
        public string cortexToken { get; }

        public GetUserInformationParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}
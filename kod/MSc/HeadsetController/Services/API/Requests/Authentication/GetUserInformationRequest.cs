namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GetUserInformationRequest : Request
    {
        public override string method { get; } = "generateUserInformation";
        public GetUserInformationParameter @params { get; }

        public GetUserInformationRequest(GetUserInformationParameter parameter)
        {
            @params = parameter;
        }
    }
}

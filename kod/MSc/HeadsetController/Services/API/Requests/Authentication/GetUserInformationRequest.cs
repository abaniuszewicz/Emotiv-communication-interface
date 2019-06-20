namespace HeadsetController.Services.API.Requests.Authentication
{
    public class GetUserInformationRequest : Request
    {
        public override string method { get; } = "generateUserInformation";
        public GetUserInformationParameter @params { get; }

        public GetUserInformationRequest(int id, GetUserInformationParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

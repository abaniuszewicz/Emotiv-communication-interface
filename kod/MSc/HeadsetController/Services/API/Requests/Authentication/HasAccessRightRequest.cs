namespace HeadsetController.Services.API.Requests.Authentication
{
    public class HasAccessRightRequest : Request
    {
        public override string method { get; } = "hasAccessRight";
        public HasAccessRightParameter @params { get; }

        public HasAccessRightRequest(HasAccessRightParameter parameter)
        {
            @params = parameter;
        }
    }
}

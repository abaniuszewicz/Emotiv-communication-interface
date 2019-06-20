namespace HeadsetController.Services.API.Requests.Headsets
{
    public class UpdateHeadsetRequest : Request
    {
        public override string method { get; } = "updateHeadset";
        public UpdateHeadsetParameter @params { get; }

        public UpdateHeadsetRequest(int id, UpdateHeadsetParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

namespace HeadsetController.Services.API.Requests.BCI
{
    public class GetDetectionInfoRequest : Request
    {
        public override string method { get; } = "getDetectionInfo";
        public GetDetectionInfoParameter @params { get; }

        public GetDetectionInfoRequest(int id, GetDetectionInfoParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

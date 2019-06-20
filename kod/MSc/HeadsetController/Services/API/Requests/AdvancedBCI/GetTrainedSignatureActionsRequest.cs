namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class GetTrainedSignatureActionsRequest : Request
    {
        public override string method { get; } = "getTrainedSignatureActions";
        public GetTrainedSignatureActionsParameter @params { get; }

        public GetTrainedSignatureActionsRequest(int id, GetTrainedSignatureActionsParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

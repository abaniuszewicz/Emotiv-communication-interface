namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class GetTrainedSignatureActionsRequest : Request
    {
        public override string method { get; } = "getTrainedSignatureActions";
        public GetTrainedSignatureActionsParameter @params { get; }

        public GetTrainedSignatureActionsRequest(GetTrainedSignatureActionsParameter parameter)
        {
            @params = parameter;
        }
    }
}

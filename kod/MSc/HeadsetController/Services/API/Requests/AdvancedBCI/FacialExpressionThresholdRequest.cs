namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class FacialExpressionThresholdRequest : Request
    {
        public override string method { get; } = "facialExpressionThreshold";
        public FacialExpressionThresholdParameter @params { get; }

        public FacialExpressionThresholdRequest(int id, FacialExpressionThresholdParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

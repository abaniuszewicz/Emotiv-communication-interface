namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class FacialExpressionSignatureTypeRequest : Request
    {
        public override string method { get; } = "facialExpressionSignatureType";
        public FacialExpressionSignatureTypeParameter @params { get; }

        public FacialExpressionSignatureTypeRequest(FacialExpressionSignatureTypeParameter parameter)
        {
            @params = parameter;
        }
    }
}

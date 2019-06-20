namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class FacialExpressionSignatureTypeRequest : Request
    {
        public override string method { get; } = "facialExpressionSignatureType";
        public FacialExpressionSignatureTypeParameter @params { get; }

        public FacialExpressionSignatureTypeRequest(int id, FacialExpressionSignatureTypeParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

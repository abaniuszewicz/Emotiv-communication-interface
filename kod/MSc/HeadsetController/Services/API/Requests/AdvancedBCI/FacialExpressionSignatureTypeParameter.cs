using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class FacialExpressionSignatureTypeParameter
    {
        public string cortexToken { get; }
        public string status { get; }
        public string profile { get; set; }
        public string session { get; set; }
        public string signature { get; set; }

        public FacialExpressionSignatureTypeParameter(string cortexToken, Enums.StatusGetSetEnum status)
        {
            this.cortexToken = cortexToken;
            this.status = status.ToString();
        }
    }
}

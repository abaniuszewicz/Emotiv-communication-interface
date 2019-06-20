using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.AdvancedBCI
{
    public class FacialExpressionSignatureTypeResponse : IResult
    {
        public string currentSig { get; }
        public IEnumerable<string> availableSig { get; }

        [JsonConstructor]
        private FacialExpressionSignatureTypeResponse(IEnumerable<string> availableSig, string currentSig)
        {
            this.availableSig = availableSig;
            this.currentSig = currentSig;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class FacialExpressionSignatureType : Request
    {
        public override string Method { get; } = "facialExpressionSignatureType";
        [JsonProperty("params")]
        public FacialExpressionSignatureTypeParameter Parameter { get; }

        public FacialExpressionSignatureType(int id, FacialExpressionSignatureTypeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

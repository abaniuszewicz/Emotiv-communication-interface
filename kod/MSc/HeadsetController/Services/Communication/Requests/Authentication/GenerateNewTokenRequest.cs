using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class GenerateNewTokenRequest : Request
    {
        public override string Method { get; } = "generateNewToken";
        public GenerateNewTokenParameter @params { get; }

        public GenerateNewTokenRequest(int id, GenerateNewTokenParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

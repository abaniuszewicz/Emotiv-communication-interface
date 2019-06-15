using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class GetUserInformationRequest : Request
    {
        public override string Method { get; } = "generateUserInformation";
        public GenerateUserInformationParameter @params { get; }

        public GetUserInformationRequest(int id, GenerateUserInformationParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

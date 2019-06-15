using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Authentication
{
    public class HasAccessRightRequest : Request
    {
        public override string Method { get; } = "hasAccessRight";
        public HasAccessRightParameter @params { get; }

        public HasAccessRightRequest(int id, HasAccessRightParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests
{
    public class GetUserLoginRequest : Request
    {
        public override string Method { get; } = "getUserLogin";

        public GetUserLoginRequest(int id) : base(id)
        {
        }
    }
}

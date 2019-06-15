using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Information
{
    public class GetCortexInfoRequest : Request
    {
        public override string Method { get; } = "getCortexInfo";

        public GetCortexInfoRequest(int id) : base(id)
        {
        }
    }
}

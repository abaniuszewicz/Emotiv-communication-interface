using System;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.Information;

namespace HeadsetController.Services.API.Requests.Information
{
    public class GetCortexInfoRequest : Request
    {
        public override string method { get; } = "getCortexInfo";

        public GetCortexInfoRequest(int id) : base(id)
        {
        }
    }
}

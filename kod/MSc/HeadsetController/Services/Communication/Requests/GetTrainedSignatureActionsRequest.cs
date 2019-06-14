﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class GetTrainedSignatureActionsRequest : Request
    {
        public override string Method { get; } = "getTrainedSignatureActions";
        [JsonProperty("params")]
        public GetTrainedSignatureActionsParameter Parameter { get; }

        public GetTrainedSignatureActionsRequest(int id, GetTrainedSignatureActionsParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

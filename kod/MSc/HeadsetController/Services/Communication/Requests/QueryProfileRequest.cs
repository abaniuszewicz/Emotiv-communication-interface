﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class QueryProfileRequest : Request
    {
        public override string Method { get; } = "queryProfile";
        [JsonProperty("params")]
        public QueryProfileParameter Parameter { get; }

        public QueryProfileRequest(int id, QueryProfileParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
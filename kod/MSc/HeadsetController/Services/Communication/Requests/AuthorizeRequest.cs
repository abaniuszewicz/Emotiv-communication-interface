﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class AuthorizeRequest : Request
    {
        public override string Method { get; } = "authorize";
        [JsonProperty("params")]
        public AuthorizeParameter Parameter { get; }

        public AuthorizeRequest(int id, AuthorizeParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class MentalCommandActiveActionRequest : Request
    {
        public override string Method { get; } = "mentalCommandActiveAction";
        [JsonProperty("params")]
        public MentalCommandActiveActionParameter Parameter { get; }

        public MentalCommandActiveActionRequest(int id, MentalCommandActiveActionParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class GetTrainedSignatureActionsParameter
    {
        public string Authentication { get; set; }
        public string Detection { get; set; }
        public string Session { get; set; }
        public string Profile { get; set; }

        public GetTrainedSignatureActionsParameter(string authentication, string detection, string profile)
        {
            Authentication = authentication;
            Detection = detection;
            Profile = profile;
        }
    }
}
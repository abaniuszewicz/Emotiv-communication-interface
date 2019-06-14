using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class FacialExpressionThresholdParameter
    {
        public string Authentication { get; }
        public string Session { get; }
        public string Profile { get; }
        public string Status { get; }
        public string Action { get; }
        public int Number { get; }

        public FacialExpressionThresholdParameter(string authentication, string profile, string status, string action)
        {
            Authentication = authentication;
            Profile = profile;
            Status = status;
            Action = action;
        }
    }
}

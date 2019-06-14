using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class SetupProfileParameter
    {
        public string Authentication { get; set; }
        public string Headset { get; set; }
        public string Profile { get; set; }
        public string NewProfileName { get; set; }
        public string Status { get; set; }

        public SetupProfileParameter(string authentication, string profile, string status)
        {
            Authentication = authentication;
            Profile = profile;
            Status = status;
        }
    }
}

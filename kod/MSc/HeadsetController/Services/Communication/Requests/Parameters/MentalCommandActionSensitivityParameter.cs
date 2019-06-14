using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class MentalCommandActionSensitivityParameter
    {
        public string Authentication { get; set; }
        public string Session { get; set; }
        public string Profile { get; set; }
        public string Status { get; set; }
        public IEnumerable<string> Values { get; set; }

        public MentalCommandActionSensitivityParameter(string authentication, string profile, string status)
        {
            Authentication = authentication;
            Profile = profile;
            Status = status;
        }
    }
}

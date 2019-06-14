using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class MentalCommandBrainMapParameter
    {
        public string Authentication { get; set; }
        public string Session { get; set; }
        public string Profile { get; set; }

        public MentalCommandBrainMapParameter(string authentication, string profile)
        {
            Authentication = authentication;
            Profile = profile;
        }
    }
}

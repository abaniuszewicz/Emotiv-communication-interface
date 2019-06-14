using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class GetCurrentProfileParameter
    {
        public string Authentication { get; set; }
        public string Headset { get; set; }

        public GetCurrentProfileParameter(string authentication, string headset)
        {
            Authentication = authentication;
            Headset = headset;
        }
    }
}

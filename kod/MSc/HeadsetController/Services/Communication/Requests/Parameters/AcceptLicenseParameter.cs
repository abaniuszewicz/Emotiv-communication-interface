using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class AcceptLicenseParameter
    {
        public string Authentication { get; set; }

        public AcceptLicenseParameter(string authentication)
        {
            Authentication = authentication;
        }
    }
}

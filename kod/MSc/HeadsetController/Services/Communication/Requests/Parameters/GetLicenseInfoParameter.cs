using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class GetLicenseInfoParameter
    {
        public string cortexToken { get; set; }

        public GetLicenseInfoParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}

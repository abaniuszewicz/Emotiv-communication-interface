using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class GetTrainingTimeParameter
    {
        public string Authentication { get; set; }
        public string Detection { get; set; }
        public string Session { get; set; }

        public GetTrainingTimeParameter(string authentication, string detection, string session)
        {
            Authentication = authentication;
            Detection = detection;
            Session = session;
        }
    }
}

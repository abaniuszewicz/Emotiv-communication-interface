
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class TrainingParameter
    {
        public string Authentication { get; set; }
        public string Detection { get; set; }
        public string Session { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }

        public TrainingParameter(string authentication, string detection, string action, string status)
        {
            Authentication = authentication;
            Detection = detection;
            Action = action;
            Status = status;
        }
    }
}

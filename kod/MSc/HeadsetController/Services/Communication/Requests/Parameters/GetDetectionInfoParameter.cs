using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class GetDetectionInfoParameter
    {
        public string Detection { get; set; }

        public GetDetectionInfoParameter(string detection)
        {
            Detection = detection;
        }
    }
}

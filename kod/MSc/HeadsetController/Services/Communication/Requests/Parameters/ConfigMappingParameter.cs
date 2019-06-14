using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class ConfigMappingParameter
    {
        public string Authentication { get; set; }
        public string Status { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Mapping { get; set; }

        public ConfigMappingParameter(string authentication, string status)
        {
            Authentication = authentication;
            Status = status;
        }
    }
}

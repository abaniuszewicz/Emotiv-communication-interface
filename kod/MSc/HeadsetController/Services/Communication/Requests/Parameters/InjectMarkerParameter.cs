using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class InjectMarkerParameter
    {
        public string Authentication { get; set; }
        public string Session { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public string Stop { get; set; }
        public string Port { get; set; }
        public int Time { get; set; }

        public InjectMarkerParameter(string authentication, string label, int time)
        {
            Authentication = authentication;
            Label = label;
            Time = time;
        }
    }
}

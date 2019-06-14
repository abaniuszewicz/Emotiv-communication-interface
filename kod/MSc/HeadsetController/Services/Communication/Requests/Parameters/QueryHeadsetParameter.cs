using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class QueryHeadsetParameter
    {
        public string HeadsetId { get; set; }

        public QueryHeadsetParameter()
        {
        }
    }
}

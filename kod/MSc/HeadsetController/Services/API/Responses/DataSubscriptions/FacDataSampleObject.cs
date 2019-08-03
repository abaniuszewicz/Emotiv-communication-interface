using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadsetController.Services.API.Responses.DataSubscriptions
{
    public class FacDataSampleObject
    {
        public IEnumerable<object> fac { get; }
        public string sid { get; }
        public double time { get; }

        [JsonConstructor]
        private FacDataSampleObject(IEnumerable<object> fac, string sid, double time)
        {
            this.fac = fac;
            this.sid = sid;
            this.time = time;
        }
    }
}

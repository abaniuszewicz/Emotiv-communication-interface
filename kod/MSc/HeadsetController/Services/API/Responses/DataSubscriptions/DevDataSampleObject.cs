using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadsetController.Services.API.Responses.DataSubscriptions
{
    public class DevDataSampleObject
    {
        public IEnumerable<object> dev { get; }
        public string sid { get; }
        public double time { get; }

        [JsonConstructor]
        private DevDataSampleObject(IEnumerable<object> dev, string sid, double time)
        {
            var list = dev.ToList();
            var co = ((JArray) list[2]).ToObject<List<int>>();
            this.dev = new List<object>()
            {
                list[0],
                list[1],
                ((JArray)list[2]).ToObject<List<int>>()
            };
            this.sid = sid;
            this.time = time;
        }
    }
}

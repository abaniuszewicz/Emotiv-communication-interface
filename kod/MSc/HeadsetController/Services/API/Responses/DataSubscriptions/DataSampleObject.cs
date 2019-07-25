﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.DataSubscriptions
{
    public class DataSampleObject
    {
        public IEnumerable<object> com { get; }
        public string sid { get; }
        public double time { get; }

        [JsonConstructor]
        private DataSampleObject(IEnumerable<object> com, string sid, double time)
        {
            this.com = com;
            this.sid = sid;
            this.time = time;
        }
    }
}

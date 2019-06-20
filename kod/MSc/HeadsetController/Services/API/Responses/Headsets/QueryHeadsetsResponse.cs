using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Headsets
{
    public class QueryHeadsetsResponse : IResult
    {
        public IEnumerable<HeadsetObject> TODO { get; }

        [JsonConstructor]
        private QueryHeadsetsResponse(IEnumerable<HeadsetObject> todo)
        {
            TODO = todo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public abstract class Request : IRequest
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; } = "2.0";
        [JsonProperty("method")]
        public abstract string Method { get; }
        [JsonProperty("id")]
        public int Id { get; }

        protected Request(int id)
        {
            this.Id = id;
        }
    }
}

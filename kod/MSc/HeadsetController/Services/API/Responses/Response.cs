using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.API.Responses.Sessions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeadsetController.Services.API.Responses
{
    public class Response<T> where T : IResult
    {
        public int id { get; }
        public string jsonrpc { get; }
        public T result { get; }

        [JsonConstructor]
        private Response(int id, string jsonrpc, T result)
        {
            this.id = id;
            this.jsonrpc = jsonrpc;
            this.result = result;
        }
    }
}

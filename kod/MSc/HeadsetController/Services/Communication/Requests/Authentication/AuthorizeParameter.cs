using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class AuthorizeParameter
    {
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        public string license { get; set; }
        public int? debit { get; set; }

        public AuthorizeParameter(string clientId, string clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }
    }
}

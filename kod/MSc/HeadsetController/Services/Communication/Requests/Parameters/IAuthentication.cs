using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public interface IAuthentication
    {
        [JsonProperty("_auth")]
        string Authentication { get; set; }
    }
}

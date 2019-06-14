using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class LoginParameter
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        public LoginParameter(string username, string password, string clientId, string clientSecret)
        {
            Username = username;
            Password = password;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}

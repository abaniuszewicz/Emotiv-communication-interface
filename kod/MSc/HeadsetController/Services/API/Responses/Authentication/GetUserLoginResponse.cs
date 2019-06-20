using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Authentication
{
    public class GetUserLoginResponse : IResult
    {
        public string username { get; }
        public string currentOSUId { get; }
        public string currentOSUsername { get; }
        public string loggedInOSUId { get; }
        public string loggedInOSUsername { get; }

        [JsonConstructor]
        private GetUserLoginResponse(string username, string currentOsuId, string currentOsUsername, string loggedInOsuId, string loggedInOsUsername)
        {
            this.username = username;
            currentOSUId = currentOsuId;
            currentOSUsername = currentOsUsername;
            loggedInOSUId = loggedInOsuId;
            loggedInOSUsername = loggedInOsUsername;
        }
    }
}

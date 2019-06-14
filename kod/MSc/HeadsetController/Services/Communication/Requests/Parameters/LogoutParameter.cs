using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class LogoutParameter
    {
        public string Username { get; set; }

        public LogoutParameter(string username)
        {
            Username = username;
        }
    }
}

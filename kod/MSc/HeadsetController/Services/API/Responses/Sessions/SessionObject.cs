using System.Collections.Generic;
using HeadsetController.Services.API.Requests.Headsets;
using HeadsetController.Services.API.Responses.Headsets;
using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.Sessions
{
    public class SessionObject
    {
        public string id { get; }
        public Enums.StatusSessionEnum status { get; }
        public string owner { get; }
        public string license { get; }
        public string appId { get; }
        public string started { get; }
        public string stopped { get; }
        public IEnumerable<Enums.StreamsEnum> streams { get; }
        public IEnumerable<string> recordIds { get; }
        public bool recording { get; }
        public HeadsetObject headset { get; }
    }
}

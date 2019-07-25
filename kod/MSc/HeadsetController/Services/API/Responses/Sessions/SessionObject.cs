using System.Collections.Generic;
using HeadsetController.Services.API.Responses.Headsets;
using HeadsetController.Services.API.Utils;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Sessions
{
    public class SessionObject : IResult
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

        [JsonConstructor]
        private SessionObject(string id, Enums.StatusSessionEnum status, string owner, string license, string appId, string started, string stopped, IEnumerable<Enums.StreamsEnum> streams, IEnumerable<string> recordIds, bool recording, HeadsetObject headset)
        {
            this.id = id;
            this.status = status;
            this.owner = owner;
            this.license = license;
            this.appId = appId;
            this.started = started;
            this.stopped = stopped;
            this.streams = streams;
            this.recordIds = recordIds;
            this.recording = recording;
            this.headset = headset;
        }
    }
}

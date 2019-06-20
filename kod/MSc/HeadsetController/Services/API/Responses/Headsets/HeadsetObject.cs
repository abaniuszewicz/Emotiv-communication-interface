using System.Collections.Generic;
using HeadsetController.Services.API.Utils;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Headsets
{
    public class HeadsetObject
    {
        public string id { get; }
        public Enums.StatusHeadsetEnum status { get; }
        public string connectedBy { get; }
        public string dongle { get; }
        public string firmware { get; }
        public IEnumerable<string> motionSensors { get; }
        public IEnumerable<string> sensors { get; }
        public HeadsetObjectSettings settings { get; }

        [JsonConstructor]
        private HeadsetObject(string id, Enums.StatusHeadsetEnum status, string connectedBy, string dongle, string firmware, IEnumerable<string> motionSensors, IEnumerable<string> sensors, HeadsetObjectSettings settings)
        {
            this.id = id;
            this.status = status;
            this.connectedBy = connectedBy;
            this.dongle = dongle;
            this.firmware = firmware;
            this.motionSensors = motionSensors;
            this.sensors = sensors;
            this.settings = settings;
        }
    }
}

using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Headsets
{
    public class HeadsetObjectSettings
    {
        public string mode { get; }
        public int eegRate { get; }
        public int eegRes { get; }
        public int memsRate { get; }
        public int memsRes { get; }

        [JsonConstructor]
        private HeadsetObjectSettings(string mode, int eegRate, int eegRes, int memsRate, int memsRes)
        {
            this.mode = mode;
            this.eegRate = eegRate;
            this.eegRes = eegRes;
            this.memsRate = memsRate;
            this.memsRes = memsRes;
        }
    }
}
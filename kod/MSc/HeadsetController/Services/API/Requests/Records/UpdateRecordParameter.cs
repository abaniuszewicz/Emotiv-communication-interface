using System.Collections.Generic;

namespace HeadsetController.Services.API.Requests.Records
{
    public class UpdateRecordParameter
    {
        public string cortexToken { get; }
        public string record { get; }
        public string description { get; set; }
        public IEnumerable<string> tags { get; set; }

        public UpdateRecordParameter(string cortexToken, string record)
        {
            this.cortexToken = cortexToken;
            this.record = record;
        }
    }
}
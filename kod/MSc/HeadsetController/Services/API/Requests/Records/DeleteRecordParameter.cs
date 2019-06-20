using System.Collections.Generic;

namespace HeadsetController.Services.API.Requests.Records
{
    public class DeleteRecordParameter
    {
        public string cortexToken { get; }
        public IEnumerable<string> records { get; }

        public DeleteRecordParameter(string cortexToken, IEnumerable<string> records)
        {
            this.cortexToken = cortexToken;
            this.records = records;
        }
    }
}
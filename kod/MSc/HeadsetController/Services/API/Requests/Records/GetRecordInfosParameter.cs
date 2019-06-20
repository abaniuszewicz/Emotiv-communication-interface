using System.Collections.Generic;

namespace HeadsetController.Services.API.Requests.Records
{
    public class GetRecordInfosParameter
    {
        public string cortexToken { get; }
        public IEnumerable<string> recordIds { get; }

        public GetRecordInfosParameter(string cortexToken, IEnumerable<string> recordIds)
        {
            this.cortexToken = cortexToken;
            this.recordIds = recordIds;
        }
    }
}
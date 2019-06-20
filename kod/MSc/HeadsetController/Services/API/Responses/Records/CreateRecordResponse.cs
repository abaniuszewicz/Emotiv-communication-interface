using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.API.Requests.Records;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Records
{
    public class CreateRecordResponse : IResult
    {
        public RecordObject record { get; }
        public string sessionId { get; }

        [JsonConstructor]
        private CreateRecordResponse(RecordObject record, string sessionId)
        {
            this.record = record;
            this.sessionId = sessionId;
        }
    }
}

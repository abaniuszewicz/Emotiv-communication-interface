using System.Collections.Generic;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.Records
{
    public class DeleteRecordResponse : IResult
    {
        public IEnumerable<object> success { get; }
        public IEnumerable<object> failure { get; }
        public string recordId { get; }
        public int? code { get; }
        public string message { get; }

        [JsonConstructor]
        private DeleteRecordResponse(IEnumerable<object> success, IEnumerable<object> failure, string recordId, int? code, string message)
        {
            this.success = success;
            this.failure = failure;
            this.recordId = recordId;
            this.code = code;
            this.message = message;
        }
    }
}
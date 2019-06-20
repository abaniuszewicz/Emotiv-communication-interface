using System.Collections.Generic;
using HeadsetController.Services.API.Utils;

namespace HeadsetController.Services.API.Requests.Records
{
    public class ExportRecordParameter
    {
        public string cortexToken { get; }
        public IEnumerable<string> recordIds { get; }
        public string folder { get; }
        public string format { get; }
        public IEnumerable<string> streamTypes { get; }
        public string version { get; set; }

        public ExportRecordParameter(string cortexToken, IEnumerable<string> recordIds, string folder, Enums.RecordFormatEnum format, IEnumerable<string> streamTypes)
        {
            this.cortexToken = cortexToken;
            this.recordIds = recordIds;
            this.folder = folder;
            this.format = format.ToString();
            this.streamTypes = streamTypes;
        }
    }
}
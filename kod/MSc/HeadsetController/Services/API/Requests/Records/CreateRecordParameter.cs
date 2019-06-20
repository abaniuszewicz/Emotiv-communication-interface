using System.Collections.Generic;

namespace HeadsetController.Services.API.Requests.Records
{
    public class CreateRecordParameter
    {
        public string cortexToken { get; }
        public string session { get; }
        public string title { get; }
        public string description { get; set; }
        public string subjectName { get; set; }
        public IEnumerable<string> tags { get; set; }

        public CreateRecordParameter(string cortexToken, string session, string title)
        {
            this.cortexToken = cortexToken;
            this.session = session;
            this.title = title;
        }
    }
}
using System.Collections.Generic;

namespace HeadsetController.Services.API.Requests.Records
{
    public class QueryRecordsParameter
    {
        public string cortexToken { get; }
        public string query { get; }
        public IEnumerable<object> orderBy { get; }
        public int limit { get; set; }
        public int offset { get; set; }
        public bool includeMarkers { get; set; }

        public QueryRecordsParameter(string cortexToken, string query, IEnumerable<object> orderBy)
        {
            this.cortexToken = cortexToken;
            this.query = query;
            this.orderBy = orderBy;
        }
    }
}
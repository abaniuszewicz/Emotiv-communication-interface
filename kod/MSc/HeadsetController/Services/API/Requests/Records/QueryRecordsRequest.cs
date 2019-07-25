namespace HeadsetController.Services.API.Requests.Records
{
    public class QueryRecordsRequest : Request
    {
        public override string method { get; } = "queryRecords";
        public QueryRecordsParameter @params { get; }

        public QueryRecordsRequest(QueryRecordsParameter parameter)
        {
            @params = parameter;
        }
    }
}

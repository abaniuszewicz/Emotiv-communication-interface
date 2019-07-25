namespace HeadsetController.Services.API.Requests.Sessions
{
    public class QuerySessionsRequest : Request
    {
        public override string method { get; } = "querySessions";
        public QuerySessionsParameter @params { get; }

        public QuerySessionsRequest(QuerySessionsParameter parameter)
        {
            @params = parameter;
        }
    }
}

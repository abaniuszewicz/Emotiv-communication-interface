namespace HeadsetController.Services.API.Requests.Sessions
{
    public class QuerySessionsRequest : Request
    {
        public override string method { get; } = "querySessions";
        public QuerySessionsParameter @params { get; }

        public QuerySessionsRequest(int id, QuerySessionsParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

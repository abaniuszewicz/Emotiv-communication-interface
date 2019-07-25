namespace HeadsetController.Services.API.Requests.BCI
{
    public class QueryProfileRequest : Request
    {
        public override string method { get; } = "queryProfile";
        public QueryProfileParameter @params { get; }

        public QueryProfileRequest(QueryProfileParameter parameter)
        {
            @params = parameter;
        }
    }
}

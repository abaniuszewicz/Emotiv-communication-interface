namespace HeadsetController.Services.API.Requests.BCI
{
    public class QueryProfileRequest : Request
    {
        public override string method { get; } = "queryProfile";
        public QueryProfileParameter @params { get; }

        public QueryProfileRequest(int id, QueryProfileParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

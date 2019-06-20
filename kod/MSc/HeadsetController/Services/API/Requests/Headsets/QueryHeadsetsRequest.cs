namespace HeadsetController.Services.API.Requests.Headsets
{
    public class QueryHeadsetsRequest : Request
    {
        public override string method { get; } = "queryHeadsets";
        public QueryHeadsetsParameter @params { get; }

        public QueryHeadsetsRequest(int id, QueryHeadsetsParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

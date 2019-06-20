namespace HeadsetController.Services.API.Requests.Sessions
{
    public class QuerySessionsParameter
    {
        public string cortexToken { get; }

        public QuerySessionsParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}
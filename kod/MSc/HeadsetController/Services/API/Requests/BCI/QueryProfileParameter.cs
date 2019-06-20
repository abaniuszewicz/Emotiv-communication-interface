namespace HeadsetController.Services.API.Requests.BCI
{
    public class QueryProfileParameter
    {
        public string cortexToken { get; }

        public QueryProfileParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}

namespace HeadsetController.Services.API.Requests.Records
{
    public class StopRecordParameter
    {
        public string cortexToken { get; }
        public string session { get; }

        public StopRecordParameter(string cortexToken, string session)
        {
            this.cortexToken = cortexToken;
            this.session = session;
        }
    }
}
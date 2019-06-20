namespace HeadsetController.Services.API.Requests.Markers
{
    public class UpdateMarkerParameter
    {
        public string cortexToken { get; }
        public string session { get; }
        public string markerId { get; }
        public int time { get; }
        public object extras { get; set; }

        public UpdateMarkerParameter(string cortexToken, string session, string markerId, int time)
        {
            this.cortexToken = cortexToken;
            this.session = session;
            this.markerId = markerId;
            this.time = time;
        }
    }
}
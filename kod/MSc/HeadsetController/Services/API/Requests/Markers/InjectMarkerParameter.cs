namespace HeadsetController.Services.API.Requests.Markers
{
    public class InjectMarkerParameter
    {
        public string cortexToken { get; }
        public string session { get; }
        public int time { get; }
        public string value { get; }
        public string label { get; }
        public string port { get; set; }
        public object extras { get; set; }

        public InjectMarkerParameter(string cortexToken, string session, int time, string value, string label)
        {
            this.cortexToken = cortexToken;
            this.value = value;
            this.label = label;
            this.session = session;
            this.time = time;
        }
    }
}

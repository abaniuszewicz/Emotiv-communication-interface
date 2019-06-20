namespace HeadsetController.Services.API.Requests.Headsets
{
    public class UpdateHeadsetParameter
    {
        public string cortexToken { get; }
        public string headset { get; }
        public object setting { get; }

        public UpdateHeadsetParameter(string cortexToken, string headset, string mode, string eegRate, string memsRate)
        {
            this.cortexToken = cortexToken;
            this.headset = headset;
            setting = new {mode, eegRate, memsRate};
        }
    }
}
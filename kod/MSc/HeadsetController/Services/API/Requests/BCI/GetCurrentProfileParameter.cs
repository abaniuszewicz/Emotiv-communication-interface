namespace HeadsetController.Services.API.Requests.BCI
{
    public class GetCurrentProfileParameter
    {
        public string cortexToken { get; }
        public string headset { get; }

        public GetCurrentProfileParameter(string cortexToken, string headset)
        {
            this.cortexToken = cortexToken;
            this.headset = headset;
        }
    }
}

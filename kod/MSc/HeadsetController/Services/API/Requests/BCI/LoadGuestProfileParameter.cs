namespace HeadsetController.Services.API.Requests.BCI
{
    public class LoadGuestProfileParameter
    {
        public string cortexToken { get; }
        public string headset { get; }

        public LoadGuestProfileParameter(string cortexToken, string headset)
        {
            this.cortexToken = cortexToken;
            this.headset = headset;
        }
    }
}
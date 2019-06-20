namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandBrainMapParameter
    {
        public string cortexToken { get; }
        public string profile { get; set; }
        public string session { get; set; }

        public MentalCommandBrainMapParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandTrainingThresholdParameter
    {
        public string cortexToken { get; }
        public string profile { get; set; }
        public string session { get; set; }

        public MentalCommandTrainingThresholdParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}

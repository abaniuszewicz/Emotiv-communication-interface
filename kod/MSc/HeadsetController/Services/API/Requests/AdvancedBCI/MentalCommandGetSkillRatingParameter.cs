namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandGetSkillRatingParameter
    {
        public string cortexToken { get; }
        public string profile { get; set; }
        public string session { get; set; }
        public string action { get; set; }

        public MentalCommandGetSkillRatingParameter(string cortexToken)
        {
            this.cortexToken = cortexToken;
        }
    }
}

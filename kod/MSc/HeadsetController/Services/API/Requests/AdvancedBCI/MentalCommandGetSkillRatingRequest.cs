namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandGetSkillRatingRequest : Request
    {
        public override string method { get; } = "mentalCommandGetSkillRating";
        public MentalCommandGetSkillRatingParameter @params { get; }

        public MentalCommandGetSkillRatingRequest(MentalCommandGetSkillRatingParameter parameter)
        {
            @params = parameter;
        }
    }
}

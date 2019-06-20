namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandGetSkillRatingRequest : Request
    {
        public override string method { get; } = "mentalCommandGetSkillRating";
        public MentalCommandGetSkillRatingParameter @params { get; }

        public MentalCommandGetSkillRatingRequest(int id, MentalCommandGetSkillRatingParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

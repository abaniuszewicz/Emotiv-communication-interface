namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActionLevelRequest : Request
    {
        public override string method { get; } = "mentalCommandActionLevel";
        public MentalCommandActionLevelParameter @params { get; }

        public MentalCommandActionLevelRequest(int id, MentalCommandActionLevelParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandBrainMapRequest : Request
    {
        public override string method { get; } = "mentalCommandBrainMap";
        public MentalCommandBrainMapParameter @params { get; }

        public MentalCommandBrainMapRequest(int id, MentalCommandBrainMapParameter parameter) : base(id)
        {
            @params = parameter;
        }
    }
}

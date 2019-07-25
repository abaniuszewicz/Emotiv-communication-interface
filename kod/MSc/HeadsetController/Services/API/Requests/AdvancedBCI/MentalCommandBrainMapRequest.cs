namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandBrainMapRequest : Request
    {
        public override string method { get; } = "mentalCommandBrainMap";
        public MentalCommandBrainMapParameter @params { get; }

        public MentalCommandBrainMapRequest(MentalCommandBrainMapParameter parameter)
        {
            @params = parameter;
        }
    }
}

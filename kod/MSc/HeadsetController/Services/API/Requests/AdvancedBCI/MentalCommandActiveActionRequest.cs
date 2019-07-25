namespace HeadsetController.Services.API.Requests.AdvancedBCI
{
    public class MentalCommandActiveActionRequest : Request
    {
        public override string method { get; } = "mentalCommandActiveAction";
        public MentalCommandActiveActionParameter @params { get; }

        public MentalCommandActiveActionRequest(MentalCommandActiveActionParameter parameter)
        {
            @params = parameter;
        }
    }
}
